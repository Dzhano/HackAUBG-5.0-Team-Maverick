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
			this.PlaySong.BackColor = System.Drawing.Color.GreenYellow;
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
			// 
			// Greetings
			// 
			this.Greetings.AutoSize = true;
			this.Greetings.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Greetings.Location = new System.Drawing.Point(28, 455);
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
			this.TheHUB.Location = new System.Drawing.Point(168, 463);
			this.TheHUB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TheHUB.Name = "TheHUB";
			this.TheHUB.Size = new System.Drawing.Size(86, 20);
			this.TheHUB.TabIndex = 6;
			this.TheHUB.Text = "The Hub";
			this.TheHUB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TheHUB_MouseClick);
			this.TheHUB.MouseLeave += new System.EventHandler(this.TheHUB_MouseLeave);
			this.TheHUB.MouseHover += new System.EventHandler(this.TheHUB_MouseHover);
			// 
			// MusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1067, 587);
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
    }
}

