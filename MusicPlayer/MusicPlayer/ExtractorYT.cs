using Jurassic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MusicPlayer
{
	public static class ExtratorYT
    {
        public static string Decipher(string id)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Proxy = null;

					// Using a WebClient, we download the Youtube page (the HTML content itself) as a string
					string PaginaWebYoutube = wc.DownloadString(string.Concat("https://www.youtube.com/watch?v=", id));

					// On the previously downloaded page, we located a Javascript variable called "ytInitialPlayerResponse"
					// To do this, we simply find the starting position of the string "ytInitialPlayerResponse" and the position of the first occurrence of the string "};"
					int InitialPlayerResponse = PaginaWebYoutube.IndexOf("ytInitialPlayerResponse") + "ytInitialPlayerResponse".Length + 3;
                    int FinalPlayerResponse = PaginaWebYoutube.IndexOf("};", InitialPlayerResponse) + 1;

                    string ytInitialPlayerResponse = "";
                    if (InitialPlayerResponse > -1 && FinalPlayerResponse > -1)
                    {
                        int len = FinalPlayerResponse - InitialPlayerResponse;
                        ytInitialPlayerResponse = PaginaWebYoutube.Substring(InitialPlayerResponse, len);

                    }

					
                    //The function below, written in Javascript, is responsible for getting the first audio format present in the ytInitialPlayerResponse that we extracted in the previous step
                    //Before it was done via regex, it was kind of messy and hard to understand 
                    string FuncaoJavascriptPegarAudio =
                    @"function getFirstAudio()
                    {
	                    var ytInitialPlayerResponse = @RESPONSE_HERE;
	                    var adaptiveFormats = ytInitialPlayerResponse.streamingData.adaptiveFormats;
	                    for(var i = 0; i < adaptiveFormats.length; i++)
	                    {
		                    var mimeType = adaptiveFormats[i].mimeType;
		                    if(mimeType.indexOf('audio/') > -1)
		                    {
			                    if(adaptiveFormats[i].signatureCipher != undefined)
			                    {
				                    return adaptiveFormats[i].signatureCipher;
			                    }
			                    else
			                    {
				                    if(adaptiveFormats[i].url != undefined)
				                    {
					                    return adaptiveFormats[i].url;
				                    }				
			                    }
			
		                    }
	                    }
                    }";

					// Inserts the ytInitialPlayerResponse we extracted earlier into our Javascript function
					FuncaoJavascriptPegarAudio = FuncaoJavascriptPegarAudio.Replace("@RESPONSE_HERE", ytInitialPlayerResponse);

					// Instantiate a new Jurassic ScriptEngine and run an eval in our JS code
					ScriptEngine Engine = new ScriptEngine();
                    Engine.Evaluate(FuncaoJavascriptPegarAudio);

					// Use the Call Global Function<To Jurassic function with string return to get the audio format information
					string PrimaryAudioFormat = (Engine.CallGlobalFunction<string>("getFirstAudio"));

					// Convert string from audio format to dictionary
					Dictionary<string, string> CipherDict = Utils.cifraToDict(PrimaryAudioFormat);

					// Checks if the dictionary has been split into 3 (if not = the audio information string does not need to be unscrambled)
					if (CipherDict.Count == 3)
                    {

						// Here we get the URL of player.js (Same capture process of ytInitialPlayerResponse)
						int InicioJSURL = PaginaWebYoutube.IndexOf("jsUrl") + "jsUrl".Length + 3;
                        int FimJSURL = PaginaWebYoutube.IndexOf("\"", InicioJSURL);
                        string BasePlayerURL = "";


                        if (InicioJSURL > -1 && FimJSURL > -1)
                        {
                            int len = FimJSURL - InicioJSURL;
                            BasePlayerURL = PaginaWebYoutube.Substring(InicioJSURL, len);
                        }
                        string BasePlayerJS = wc.DownloadString(string.Concat("https://youtube.com", BasePlayerURL));

						// Unfortunately we still rely on regular expressions to fetch the JS function that performs string unscrambling
						Regex JsFunction = new Regex(Patterns.JsFunctionPattern1);
                        Match RegexFuncaoJavascript = JsFunction.Match(BasePlayerJS);
                        string FuncaoJavascriptDecipher = RegexFuncaoJavascript.Groups[1].Value;

                        JsFunction = new Regex(string.Concat(Regex.Escape(FuncaoJavascriptDecipher), Patterns.JsFunctionPattern2));
                        RegexFuncaoJavascript = JsFunction.Match(BasePlayerJS);

						// We separate the arguments and the "function body" (which I called the algorithm)
						string ArgumentosFuncaoJavascript = RegexFuncaoJavascript.Groups[1].Value;

                        string AlgoritmoFuncaoJavascript = RegexFuncaoJavascript.Groups[2].Value;

						// We assemble the complete function with the information captured earlier and then separate the instructions by line
						string FuncaoJavascriptMontada = string.Concat("var unscramble = function(", ArgumentosFuncaoJavascript, ") { ", AlgoritmoFuncaoJavascript, " };");
                        string[] LinhasAlgoritmoJavascript = AlgoritmoFuncaoJavascript.Split(';');

                        HashSet<string> VariaveisFuncaoJavascript = new HashSet<string>();

						// We capture all variable names (which may or may not be part of a function hidden within 1.5MB of obfuscated Javascript)
						foreach (string LinhaAlgoritmoJavascript in LinhasAlgoritmoJavascript)
                            if (!LinhaAlgoritmoJavascript.StartsWith(string.Concat(ArgumentosFuncaoJavascript, "=")) && !LinhaAlgoritmoJavascript.StartsWith("return "))
                                VariaveisFuncaoJavascript.Add(LinhaAlgoritmoJavascript.Split('.')[0]);

                        JsFunction = new Regex(string.Concat("var ", VariaveisFuncaoJavascript.Where(c => !c.Contains(")")).FirstOrDefault(), Patterns.JsFunctionPattern3), RegexOptions.Singleline);
                        RegexFuncaoJavascript = JsFunction.Match(BasePlayerJS);

                        AlgoritmoFuncaoJavascript = RegexFuncaoJavascript.Groups[0].Value;

						// Finally we unite functions and function call in the same string
						FuncaoJavascriptMontada = string.Concat(AlgoritmoFuncaoJavascript, "\n", FuncaoJavascriptMontada);

						// As we did with ytInitialPlayerResponse, we give an eval and call CallGlobalFunction<T> returning string
						Engine.Evaluate(FuncaoJavascriptMontada);
                        string UnscambledCipher = (Engine.CallGlobalFunction<string>("unscramble", CipherDict["s"]));

						// If everything went well, it returns the "url" parameter + the previously unscrambled cipher
						if (!string.IsNullOrEmpty(UnscambledCipher))
                        {
                            return Uri.UnescapeDataString($"{CipherDict["url"]}&{CipherDict["sp"]}={UnscambledCipher}");
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
					// If the dictionary does not contain 3 entries, it probably means that ytInitialPlayerResponse returned the audio URL in an unobfuscated state, so the descrambling process is not necessary. 
					else
					{
                        return Uri.UnescapeDataString(PrimaryAudioFormat);
                    }
                }
            }
            catch(Exception ex)
            {
                string a = ex.Message;
                return "";
            }
        }
	}
}
