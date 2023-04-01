using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
	{
		private WindowsMediaPlayer Player;

		public MusicPlayer()
        {
            InitializeComponent();

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

		private void PlayFile(string url)
		{
			if (Player.playState == WMPPlayState.wmppsPlaying)
			{
				Player.controls.pause();
			}
			Player.URL = url;
			Player.controls.play();
		}

		private void MusicPlayer_Load(object sender, EventArgs e)
        {
            
        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[Songs.SelectedIndex];
        }

        private void Songs_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Songs_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void NextSong_Button_Click(object sender, EventArgs e)
        {
            if (Songs.SelectedIndex < Songs.Items.Count - 1) Songs.SelectedIndex += 1;
            else Songs.SelectedIndex = 0;
        }

        private void PreviousSong_Button_Click(object sender, EventArgs e)
        {
            if (Songs.SelectedIndex > 0) Songs.SelectedIndex -= 1;
            else Songs.SelectedIndex = Songs.Items.Count - 1;
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

        private void RJC_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/rjcaubg");
        }

        private void RJC_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void RJC_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void AURA_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://radio-aura.org/");
        }

        private void AURA_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void AURA_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Dzhano/");
        }

        private void label_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void PlaySong_Click(object sender, EventArgs e)
        {
            // Code to select song
            //OpenFileDialog ofd = new OpenFileDialog();
            // Code to select multiple files
            //ofd.Multiselect = true;

            /*if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < ofd.SafeFileNames.Count(); i++)
                {
                    if (!files.Contains(ofd.SafeFileNames[i]))
                    {
                        files.Add(ofd.SafeFileNames[i]); // Save the names of the track in file array.
                        paths.Add(ofd.FileNames[i]); // Save the paths of the tracks in path array.
                        Songs.Items.Add(ofd.SafeFileNames[i]); // Display Songs in ListBox
                    }
                }
            } */
            Random random = new Random();
            List<string> searchOnline = new List<string>() { "Andalusian classical music", "Indian classical music", "Korean court music", "Persian classical music", "Western classical music",
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
                                                            "Mick Jagger", "Keith Richards", "Paul Simon", "Joni Mitchell", "Elton John", "Bernie Taupin"};

            using (WebClient wc = new WebClient())
            {
                wc.Proxy = null;
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36");
                string dpage = Encoding.UTF8.GetString(wc.DownloadData($"http://youtube.com/results?search_query={searchOnline[random.Next(searchOnline.Count)]}"));

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
                foreach (Match v in objVideos)
                {
                    string video = v.Value;
                    Regex rgId = new Regex(Patterns.VideoName);
                    string sNome = rgId.Match(video).Value;
                    rgId = new Regex(Patterns.VideoID);
                    string sID = rgId.Match(video).Value;
                    rgId = new Regex(Patterns.VideoViewCount);
                    sNome += $"({rgId.Match(video).Value})";

					/*lblPlaylist ll = new lblPlaylist(sID, 0, Regex.Unescape(sNome));
                    ll.Width = alt;
                    pnlResults.Controls.Add(ll);
                    */
					files.Add(sNome); // Save the names of the track in file array.
					paths.Add(sID); // Save the paths of the tracks in path array.
					Songs.Items.Add(sNome); // Display Songs in ListBox
                    ReproduceMusic(sID);
				}
            }
        }
    }
}
