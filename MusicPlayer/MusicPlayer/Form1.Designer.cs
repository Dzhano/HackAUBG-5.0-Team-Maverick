namespace MusicPlayer
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.Songs = new System.Windows.Forms.ListBox();
			this.PlaySong = new System.Windows.Forms.Button();
			this.Greetings = new System.Windows.Forms.Label();
			this.TheHUB = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.AnswerFeedback = new System.Windows.Forms.Label();
			this.DownloadPlaylist = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Songs
			// 
			this.Songs.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Songs.FormattingEnabled = true;
			this.Songs.ItemHeight = 24;
			this.Songs.Location = new System.Drawing.Point(751, 15);
			this.Songs.Margin = new System.Windows.Forms.Padding(4);
			this.Songs.Name = "Songs";
			this.Songs.Size = new System.Drawing.Size(285, 364);
			this.Songs.TabIndex = 1;
			this.Songs.SelectedIndexChanged += new System.EventHandler(this.Songs_SelectedIndexChanged);
			this.Songs.MouseLeave += new System.EventHandler(this.Songs_MouseLeave);
			this.Songs.MouseHover += new System.EventHandler(this.Songs_MouseHover);
			// 
			// PlaySong
			// 
			this.PlaySong.BackColor = System.Drawing.Color.DarkOrange;
			this.PlaySong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PlaySong.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlaySong.Location = new System.Drawing.Point(751, 411);
			this.PlaySong.Margin = new System.Windows.Forms.Padding(4);
			this.PlaySong.Name = "PlaySong";
			this.PlaySong.Size = new System.Drawing.Size(287, 73);
			this.PlaySong.TabIndex = 2;
			this.PlaySong.Text = "Play a random song";
			this.PlaySong.UseVisualStyleBackColor = false;
			this.PlaySong.Click += new System.EventHandler(this.PlaySong_Click);
			this.PlaySong.MouseLeave += new System.EventHandler(this.PlaySong_MouseLeave);
			this.PlaySong.MouseHover += new System.EventHandler(this.PlaySong_MouseHover);
			// 
			// Greetings
			// 
			this.Greetings.AutoSize = true;
			this.Greetings.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Greetings.Location = new System.Drawing.Point(28, 428);
			this.Greetings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Greetings.Name = "Greetings";
			this.Greetings.Size = new System.Drawing.Size(125, 40);
			this.Greetings.TabIndex = 5;
			this.Greetings.Text = "Greetings to:";
			// 
			// TheHUB
			// 
			this.TheHUB.AutoSize = true;
			this.TheHUB.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TheHUB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.TheHUB.Location = new System.Drawing.Point(161, 437);
			this.TheHUB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TheHUB.Name = "TheHUB";
			this.TheHUB.Size = new System.Drawing.Size(86, 20);
			this.TheHUB.TabIndex = 6;
			this.TheHUB.Text = "The Hub";
			this.TheHUB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TheHUB_MouseClick);
			this.TheHUB.MouseLeave += new System.EventHandler(this.TheHUB_MouseLeave);
			this.TheHUB.MouseHover += new System.EventHandler(this.TheHUB_MouseHover);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.GreenYellow;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(35, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(270, 85);
			this.button1.TabIndex = 8;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.GreenYellow;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(393, 37);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(270, 85);
			this.button2.TabIndex = 9;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
			this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.GreenYellow;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(35, 207);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(270, 85);
			this.button3.TabIndex = 10;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
			this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.GreenYellow;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(393, 207);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(270, 85);
			this.button4.TabIndex = 11;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
			this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
			// 
			// AnswerFeedback
			// 
			this.AnswerFeedback.AutoSize = true;
			this.AnswerFeedback.BackColor = System.Drawing.Color.Transparent;
			this.AnswerFeedback.Font = new System.Drawing.Font("Bookman Old Style", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AnswerFeedback.Location = new System.Drawing.Point(72, 338);
			this.AnswerFeedback.Name = "AnswerFeedback";
			this.AnswerFeedback.Size = new System.Drawing.Size(15, 36);
			this.AnswerFeedback.TabIndex = 12;
			this.AnswerFeedback.Text = "\r\n";
			this.AnswerFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DownloadPlaylist
			// 
			this.DownloadPlaylist.BackColor = System.Drawing.Color.DarkTurquoise;
			this.DownloadPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DownloadPlaylist.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DownloadPlaylist.Location = new System.Drawing.Point(509, 411);
			this.DownloadPlaylist.Name = "DownloadPlaylist";
			this.DownloadPlaylist.Size = new System.Drawing.Size(192, 73);
			this.DownloadPlaylist.TabIndex = 13;
			this.DownloadPlaylist.Text = "Download song playlist";
			this.DownloadPlaylist.UseVisualStyleBackColor = false;
			this.DownloadPlaylist.Click += new System.EventHandler(this.DownloadPlaylist_Click);
			this.DownloadPlaylist.MouseLeave += new System.EventHandler(this.DownloadPlaylist_MouseLeave);
			this.DownloadPlaylist.MouseHover += new System.EventHandler(this.DownloadPlaylist_MouseHover);
			// 
			// MusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1067, 587);
			this.Controls.Add(this.DownloadPlaylist);
			this.Controls.Add(this.AnswerFeedback);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TheHUB);
			this.Controls.Add(this.Greetings);
			this.Controls.Add(this.PlaySong);
			this.Controls.Add(this.Songs);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MusicPlayer";
			this.Text = "Dzhano\'s Music Player";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Songs;
        private System.Windows.Forms.Button PlaySong;
        private System.Windows.Forms.Label Greetings;
        private System.Windows.Forms.Label TheHUB;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label AnswerFeedback;
		private System.Windows.Forms.Button DownloadPlaylist;
	}
}

