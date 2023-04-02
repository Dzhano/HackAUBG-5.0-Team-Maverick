using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
	public partial class MusicPlayer : Form
	{
		private WindowsMediaPlayer Player;
		private static System.Timers.Timer t;
		private int index;
		private Random random;
		private bool clickedAgain;

		private bool button1True;
		private bool button2True;
		private bool button3True;
		private bool button4True;
		private bool missed;
		private bool gotItRight;

		public MusicPlayer()
		{
			InitializeComponent();
			random = new Random();
			index = 0;

			Player = new WindowsMediaPlayer();
			Player.PlayStateChange += Player_PlayStateChange;
		}

		private void Player_PlayStateChange(int NewState)
		{
			switch ((WMPPlayState)NewState)
			{
				case WMPPlayState.wmppsMediaEnded:
					break;
				case WMPPlayState.wmppsStopped:
					break;
			}
		}

		// Create Global Variables of String Type Array to save the titles or name of the Tracks and path of the track.
		List<String> paths = new List<String>();
		List<String> files = new List<String>();

		public void ReproduceMusic(string id) // (string)GradePlaylist.SelectedRows[0].Cells[1].Value
		{
			string VideoToPlay = ExtratorYT.Decipher(id);//yt.Extract(id);
			if (VideoToPlay.Length > 0)
			{
				PlayFile(VideoToPlay);
			}
		}

		private async void PlayFile(string url)
		{
			if (Player.playState == WMPPlayState.wmppsPlaying)
			{
				Player.controls.pause();
			}
			Player.URL = url;


			clickedAgain = false;
			button1True = false;
			button2True = false;
			button3True = false;
			button4True = false;
			missed = false;
			gotItRight = false;
			this.AnswerFeedback.Text = string.Empty;

			Task task1 = Task.Run(() => Player.controls.play());

			await Task.WhenAll(task1, Task.Delay(30000));
			Player.controls.stop();

			switch (random.Next(0, 4))
			{
				case 0:
					this.button1.Text = files[index];
					button1True = true;
					this.button2.Text = buttonTextChange(button3.Text, button4.Text);
					this.button3.Text = buttonTextChange(button2.Text, button4.Text);
					this.button4.Text = buttonTextChange(button3.Text, button2.Text);
					break;
				case 1:
					this.button1.Text = buttonTextChange(button3.Text, button4.Text);
					this.button2.Text = files[index];
					button2True = true;
					this.button3.Text = buttonTextChange(button1.Text, button4.Text);
					this.button4.Text = buttonTextChange(button1.Text, button3.Text);
					break;
				case 2:
					this.button1.Text = buttonTextChange(button2.Text, button4.Text);
					this.button2.Text = buttonTextChange(button1.Text, button4.Text);
					this.button3.Text = files[index];
					button3True = true;
					this.button4.Text = buttonTextChange(button1.Text, button2.Text);
					break;
				case 3:
					this.button1.Text = buttonTextChange(button2.Text, button3.Text);
					this.button2.Text = buttonTextChange(button1.Text, button3.Text);
					this.button3.Text = buttonTextChange(button1.Text, button4.Text);
					this.button4.Text = files[index];
					button4True = true;
					break;
			}

			await Task.Delay(20000);
			Songs.Items.Add(files[index]);

			index += 4;
		}

		private string buttonTextChange(string b1, string b2)
		{
			string button = files[random.Next(files.Count)];
			while (button == b1 || button == b2 || button == files[index])
				button = files[random.Next(files.Count)];
			return button;
		}

		private void button1_Click(object sender, EventArgs e) => CheckAnswer(button1True);

		private void button2_Click(object sender, EventArgs e) => CheckAnswer(button2True);

		private void button3_Click(object sender, EventArgs e) => CheckAnswer(button3True);

		private void button4_Click(object sender, EventArgs e) => CheckAnswer(button4True);

		private void CheckAnswer(bool buttonTrue)
		{
			if (buttonTrue)
			{
				if (clickedAgain)
				{
					if (gotItRight) this.AnswerFeedback.Text = "Nope. Just one point per correct answer ;)";
					else if (missed) this.AnswerFeedback.Text = "Sorry. You missed your shot :(";
				}
				else
				{
					this.AnswerFeedback.Text = "Correct";
					gotItRight = true;
				}
			}
			else
			{
				this.AnswerFeedback.Text = "Wrong";
				missed = true;
			}
			clickedAgain = true;
		}

		private void Songs_SelectedIndexChanged(object sender, EventArgs e) { }

		private void Songs_MouseHover(object sender, EventArgs e)
		{
			Cursor = Cursors.Hand;
		}

		private void Songs_MouseLeave(object sender, EventArgs e)
		{
			Cursor = Cursors.Default;
		}

		private void TheHUB_MouseClick(object sender, MouseEventArgs e)
		{
			System.Diagnostics.Process.Start("https://thehub-aubg.com/");
		}

		private void TheHUB_MouseHover(object sender, EventArgs e)
		{
			Cursor = Cursors.Hand;
		}

		private void TheHUB_MouseLeave(object sender, EventArgs e)
		{
			Cursor = Cursors.Default;
		}

		private void PlaySong_Click(object sender, EventArgs e)
	{
		List<string> songDatabase = new List<string>() { "Andalusian classical music", "Indian classical music", "Korean court music", "Persian classical music", "Western classical music",
															"Early music", "Medieval music", "Ars antiqu", "Ars nova",
															"Ars subtilior", "Renaissance music ", "Baroque music ", "Galant music",
															"Romantic music", "Modernism", "Impressionism ", "Neoclassicism ",
															"High modernism", "Postmodern music", "Experimental music",
															"Contemporary classical music", "Minimal music", "Crossover music",
															"Danger music", "Drone music", "Electroacoustic", "Instrumental", "Lo-fi",
															"Musical improvisation", "Musique concrète",
															"Outsider music", "PC Music", "Industrial music",
															"Progressive music", "Psychedelic music", "Underground music",
															"1940s", "1950s", "1960s", "1970s", "1980s", "1990s", "2000s", "2010s", "2020s",
															"The Rock", "Face off", "Wellerman", "John Lennon", "Bruce Springsteen", "Paul McCartney", "Neil Young",
															"Mick Jagger", "Keith Richards", "Paul Simon", "Joni Mitchell", "Elton John", "Bernie Taupin",
															"Smells Like Teen Spirit - Nirvana", "Imagine - John Lennon", "One - U2", "Billie Jean - Michael Jackson", "Bohemian Rhapsody - Queen",
															"Hey Jude - The Beatles", "Like A Rolling Stone - Bob Dylan", "I Can't Get No Satisfaction - Rolling Stones", "God Save The Queen - Sex Pistols", "Sweet Child O'Mine - Guns N' Roses",
															"London Calling - The Clash", "Waterloo Sunset - The Kinks", "Hotel California - The Eagles", "Your Song - Elton John", "Stairway To Heaven - Led Zeppelin",
															"The Twist - Chubby Checker", "Live Forever - Oasis", "I Will Always Love You - Whitney Houston", "Life On Mars? - David Bowie", "Heartbreak Hotel - Elvis Presley",
															"Over The Rainbow - Judy Garland", "What's Goin' On - Marvin Gaye", "Born To Run - Bruce Springsteen", "Be My Baby - The Ronettes", "Creep - Radiohead",
															"Bridge Over Troubled Water - Simon & Garfunkel", "Respect - Aretha Franklin", "Family Affair - Sly And The Family Stone", "Dancing Queen - ABBA", "Good Vibrations - The Beach Boys",
															"Purple Haze - Jimi Hendrix", "Yesterday - The Beatles", "Jonny B Good - Chuck Berry", "No Woman No Cry - Bob Marley", "Hallelujah - Jeff Buckley",
															"Every Breath You Take - The Police", "A Day In The Life - The Beatles", "Stand By Me - Ben E King", "Papa's Got A Brand New Bag - James Brown", "Gimme Shelter - The Rolling Stones", "What'd I Say - Ray Charles",
															"Sultans Of Swing - Dire Straits", "God Only Knows - The Beach Boys", "You've Lost That Lovin' Feeling - The Righteous Brothers",
															"My Generation - The Who", "Dancing In The Street - Martha Reeves and the Vandellas",
															"When Doves Cry - Prince", "A Change Is Gonna Come - Sam Cooke", "River Deep Mountain High - Ike and Tina Turner", "Best Of My Love - The Emotions"};
		string ID1 = "";
		for (int j = 0; j < 4; j++)
		{
			using (WebClient wc = new WebClient())
			{
				wc.Proxy = null;
				wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36");
				string dpage = Encoding.UTF8.GetString(wc.DownloadData($"http://youtube.com/results?search_query={songDatabase[random.Next(songDatabase.Count)]}"));

				int start = dpage.IndexOf("ytInitialData") + "ytInitialData".Length + 3;
				int end = dpage.IndexOf("};", start) + 1;
				string _raw = "";
				if (start > -1 && end > -1)
				{
					int len = end - start;
					_raw = dpage.Substring(start, len);

				}
				var rgVideos = new Regex(Patterns.VideoRendererBlock);
				var objVideos = rgVideos.Matches(_raw);

				for (int i = 0; i < 10; i++) // only 10 out of objVideos.Count. Not to overwork the program.
				{
					string video = objVideos[i].Value;
					Regex rgId = new Regex(Patterns.VideoName);
					string songName = rgId.Match(video).Value;
					rgId = new Regex(Patterns.VideoID);
					string sID = rgId.Match(video).Value;
					if (i == 0) ID1 = sID;
					rgId = new Regex(Patterns.VideoViewCount);
					songName += $"({rgId.Match(video).Value})";


					files.Add(songName); // Save the names of the track in file array.
					paths.Add(sID); // Save the paths of the tracks in path array.
				}
			}
		}

		ReproduceMusic(ID1);
	}
	}
}
