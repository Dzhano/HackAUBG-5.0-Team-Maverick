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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.Songs = new System.Windows.Forms.ListBox();
            this.PlaySong = new System.Windows.Forms.Button();
            this.PreviousSong_Button = new System.Windows.Forms.Button();
            this.NextSong_Button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.Greetings = new System.Windows.Forms.Label();
            this.TheHUB = new System.Windows.Forms.Label();
            this.RJC = new System.Windows.Forms.Label();
            this.AURA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // Songs
            // 
            this.Songs.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Songs.FormattingEnabled = true;
            this.Songs.ItemHeight = 18;
            this.Songs.Location = new System.Drawing.Point(563, 12);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(215, 310);
            this.Songs.TabIndex = 1;
            this.Songs.SelectedIndexChanged += new System.EventHandler(this.Songs_SelectedIndexChanged);
            this.Songs.MouseLeave += new System.EventHandler(this.Songs_MouseLeave);
            this.Songs.MouseHover += new System.EventHandler(this.Songs_MouseHover);
            // 
            // PlaySong
            // 
            this.PlaySong.BackColor = System.Drawing.Color.GreenYellow;
            this.PlaySong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaySong.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySong.Location = new System.Drawing.Point(563, 334);
            this.PlaySong.Name = "PlaySong";
            this.PlaySong.Size = new System.Drawing.Size(215, 59);
            this.PlaySong.TabIndex = 2;
            this.PlaySong.Text = "Select song";
            this.PlaySong.UseVisualStyleBackColor = false;
            this.PlaySong.Click += new System.EventHandler(this.PlaySong_Click);
            // 
            // PreviousSong_Button
            // 
            this.PreviousSong_Button.BackColor = System.Drawing.Color.OrangeRed;
            this.PreviousSong_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousSong_Button.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousSong_Button.Location = new System.Drawing.Point(563, 399);
            this.PreviousSong_Button.Name = "PreviousSong_Button";
            this.PreviousSong_Button.Size = new System.Drawing.Size(97, 48);
            this.PreviousSong_Button.TabIndex = 3;
            this.PreviousSong_Button.Text = "Previous";
            this.PreviousSong_Button.UseVisualStyleBackColor = false;
            this.PreviousSong_Button.Click += new System.EventHandler(this.PreviousSong_Button_Click);
            // 
            // NextSong_Button
            // 
            this.NextSong_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NextSong_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextSong_Button.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextSong_Button.Location = new System.Drawing.Point(679, 399);
            this.NextSong_Button.Name = "NextSong_Button";
            this.NextSong_Button.Size = new System.Drawing.Size(99, 48);
            this.NextSong_Button.TabIndex = 4;
            this.NextSong_Button.Text = "Next";
            this.NextSong_Button.UseVisualStyleBackColor = false;
            this.NextSong_Button.Click += new System.EventHandler(this.NextSong_Button_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(25, 410);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(177, 53);
            this.label.TabIndex = 0;
            this.label.Text = "Made by Dzhano Mihaylov Class of 2026";
            this.label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            this.label.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label.MouseHover += new System.EventHandler(this.label_MouseHover);
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(21, 12);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(519, 381);
            this.axWindowsMediaPlayerMusic.TabIndex = 0;
            // 
            // Greetings
            // 
            this.Greetings.AutoSize = true;
            this.Greetings.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greetings.Location = new System.Drawing.Point(300, 400);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(99, 32);
            this.Greetings.TabIndex = 5;
            this.Greetings.Text = "Greetings to:";
            // 
            // TheHUB
            // 
            this.TheHUB.AutoSize = true;
            this.TheHUB.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheHUB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TheHUB.Location = new System.Drawing.Point(405, 406);
            this.TheHUB.Name = "TheHUB";
            this.TheHUB.Size = new System.Drawing.Size(70, 16);
            this.TheHUB.TabIndex = 6;
            this.TheHUB.Text = "The Hub";
            this.TheHUB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TheHUB_MouseClick);
            this.TheHUB.MouseLeave += new System.EventHandler(this.TheHUB_MouseLeave);
            this.TheHUB.MouseHover += new System.EventHandler(this.TheHUB_MouseHover);
            // 
            // RJC
            // 
            this.RJC.AutoSize = true;
            this.RJC.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJC.Location = new System.Drawing.Point(404, 427);
            this.RJC.Name = "RJC";
            this.RJC.Size = new System.Drawing.Size(139, 20);
            this.RJC.TabIndex = 7;
            this.RJC.Text = "Rock Jamming Club";
            this.RJC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RJC_MouseClick);
            this.RJC.MouseLeave += new System.EventHandler(this.RJC_MouseLeave);
            this.RJC.MouseHover += new System.EventHandler(this.RJC_MouseHover);
            // 
            // AURA
            // 
            this.AURA.AutoSize = true;
            this.AURA.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AURA.ForeColor = System.Drawing.Color.MediumBlue;
            this.AURA.Location = new System.Drawing.Point(404, 448);
            this.AURA.Name = "AURA";
            this.AURA.Size = new System.Drawing.Size(115, 20);
            this.AURA.TabIndex = 8;
            this.AURA.Text = "Radion AURA";
            this.AURA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AURA_MouseClick);
            this.AURA.MouseLeave += new System.EventHandler(this.AURA_MouseLeave);
            this.AURA.MouseHover += new System.EventHandler(this.AURA_MouseHover);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.AURA);
            this.Controls.Add(this.RJC);
            this.Controls.Add(this.TheHUB);
            this.Controls.Add(this.Greetings);
            this.Controls.Add(this.label);
            this.Controls.Add(this.NextSong_Button);
            this.Controls.Add(this.PreviousSong_Button);
            this.Controls.Add(this.PlaySong);
            this.Controls.Add(this.Songs);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Name = "MusicPlayer";
            this.Text = "Dzhano\'s Music Player";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.ListBox Songs;
        private System.Windows.Forms.Button PlaySong;
        private System.Windows.Forms.Button PreviousSong_Button;
        private System.Windows.Forms.Button NextSong_Button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Greetings;
        private System.Windows.Forms.Label TheHUB;
        private System.Windows.Forms.Label RJC;
        private System.Windows.Forms.Label AURA;
    }
}

