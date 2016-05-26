namespace MusicRecognizingTrainer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playingLbl = new System.Windows.Forms.Label();
            this.playControlGrp = new System.Windows.Forms.GroupBox();
            this.resetPlaylistBtn = new System.Windows.Forms.Button();
            this.playNextBtn = new System.Windows.Forms.Button();
            this.playlistLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playClipBtn = new System.Windows.Forms.Button();
            this.sourceLink = new System.Windows.Forms.LinkLabel();
            this.stopBtn = new System.Windows.Forms.Button();
            this.playPrevBtn = new System.Windows.Forms.Button();
            this.autoPlayChk = new System.Windows.Forms.CheckBox();
            this.rndBeginBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playControlGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(63, 10);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(381, 20);
            this.pathBox.TabIndex = 1;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(450, 8);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Now playing:";
            // 
            // playingLbl
            // 
            this.playingLbl.AutoSize = true;
            this.playingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingLbl.ForeColor = System.Drawing.Color.Green;
            this.playingLbl.Location = new System.Drawing.Point(87, 58);
            this.playingLbl.Name = "playingLbl";
            this.playingLbl.Size = new System.Drawing.Size(168, 25);
            this.playingLbl.TabIndex = 4;
            this.playingLbl.Text = "[Click to Reveal]";
            this.playingLbl.Click += new System.EventHandler(this.playingLbl_Click);
            // 
            // playControlGrp
            // 
            this.playControlGrp.Controls.Add(this.rndBeginBox);
            this.playControlGrp.Controls.Add(this.autoPlayChk);
            this.playControlGrp.Controls.Add(this.playPrevBtn);
            this.playControlGrp.Controls.Add(this.stopBtn);
            this.playControlGrp.Controls.Add(this.resetPlaylistBtn);
            this.playControlGrp.Controls.Add(this.playNextBtn);
            this.playControlGrp.Controls.Add(this.playlistLbl);
            this.playControlGrp.Controls.Add(this.label3);
            this.playControlGrp.Controls.Add(this.playClipBtn);
            this.playControlGrp.Location = new System.Drawing.Point(16, 116);
            this.playControlGrp.Name = "playControlGrp";
            this.playControlGrp.Size = new System.Drawing.Size(418, 108);
            this.playControlGrp.TabIndex = 5;
            this.playControlGrp.TabStop = false;
            this.playControlGrp.Text = "Play Control";
            // 
            // resetPlaylistBtn
            // 
            this.resetPlaylistBtn.Location = new System.Drawing.Point(212, 48);
            this.resetPlaylistBtn.Name = "resetPlaylistBtn";
            this.resetPlaylistBtn.Size = new System.Drawing.Size(97, 23);
            this.resetPlaylistBtn.TabIndex = 6;
            this.resetPlaylistBtn.Text = "Reset Playlist";
            this.resetPlaylistBtn.UseVisualStyleBackColor = true;
            this.resetPlaylistBtn.Click += new System.EventHandler(this.resetPlaylistBtn_Click);
            // 
            // playNextBtn
            // 
            this.playNextBtn.Location = new System.Drawing.Point(109, 77);
            this.playNextBtn.Name = "playNextBtn";
            this.playNextBtn.Size = new System.Drawing.Size(97, 23);
            this.playNextBtn.TabIndex = 5;
            this.playNextBtn.Text = "Next";
            this.playNextBtn.UseVisualStyleBackColor = true;
            this.playNextBtn.Click += new System.EventHandler(this.playNextBtn_Click);
            // 
            // playlistLbl
            // 
            this.playlistLbl.AutoSize = true;
            this.playlistLbl.Location = new System.Drawing.Point(55, 24);
            this.playlistLbl.Name = "playlistLbl";
            this.playlistLbl.Size = new System.Drawing.Size(24, 13);
            this.playlistLbl.TabIndex = 4;
            this.playlistLbl.Text = "0/0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Playlist:";
            // 
            // playClipBtn
            // 
            this.playClipBtn.Location = new System.Drawing.Point(6, 48);
            this.playClipBtn.Name = "playClipBtn";
            this.playClipBtn.Size = new System.Drawing.Size(97, 23);
            this.playClipBtn.TabIndex = 2;
            this.playClipBtn.Text = "Play Clip";
            this.playClipBtn.UseVisualStyleBackColor = true;
            this.playClipBtn.Click += new System.EventHandler(this.playClipBtn_Click);
            // 
            // sourceLink
            // 
            this.sourceLink.AutoSize = true;
            this.sourceLink.Location = new System.Drawing.Point(16, 231);
            this.sourceLink.Name = "sourceLink";
            this.sourceLink.Size = new System.Drawing.Size(122, 13);
            this.sourceLink.TabIndex = 6;
            this.sourceLink.TabStop = true;
            this.sourceLink.Text = "OpenSource by logchan";
            this.sourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceLink_LinkClicked);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(109, 48);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(97, 23);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // playPrevBtn
            // 
            this.playPrevBtn.Location = new System.Drawing.Point(6, 77);
            this.playPrevBtn.Name = "playPrevBtn";
            this.playPrevBtn.Size = new System.Drawing.Size(97, 23);
            this.playPrevBtn.TabIndex = 8;
            this.playPrevBtn.Text = "Prev";
            this.playPrevBtn.UseVisualStyleBackColor = true;
            this.playPrevBtn.Click += new System.EventHandler(this.playPrevBtn_Click);
            // 
            // autoPlayChk
            // 
            this.autoPlayChk.AutoSize = true;
            this.autoPlayChk.Checked = true;
            this.autoPlayChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoPlayChk.Location = new System.Drawing.Point(213, 82);
            this.autoPlayChk.Name = "autoPlayChk";
            this.autoPlayChk.Size = new System.Drawing.Size(71, 17);
            this.autoPlayChk.TabIndex = 9;
            this.autoPlayChk.Text = "Auto Play";
            this.autoPlayChk.UseVisualStyleBackColor = true;
            // 
            // rndBeginBox
            // 
            this.rndBeginBox.AutoSize = true;
            this.rndBeginBox.Location = new System.Drawing.Point(315, 82);
            this.rndBeginBox.Name = "rndBeginBox";
            this.rndBeginBox.Size = new System.Drawing.Size(96, 17);
            this.rndBeginBox.TabIndex = 10;
            this.rndBeginBox.Text = "Random Begin";
            this.rndBeginBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "v 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 251);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sourceLink);
            this.Controls.Add(this.playControlGrp);
            this.Controls.Add(this.playingLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Music Recognizing Trainer";
            this.playControlGrp.ResumeLayout(false);
            this.playControlGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playingLbl;
        private System.Windows.Forms.GroupBox playControlGrp;
        private System.Windows.Forms.Button resetPlaylistBtn;
        private System.Windows.Forms.Button playNextBtn;
        private System.Windows.Forms.Label playlistLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button playClipBtn;
        private System.Windows.Forms.LinkLabel sourceLink;
        private System.Windows.Forms.CheckBox autoPlayChk;
        private System.Windows.Forms.Button playPrevBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.CheckBox rndBeginBox;
        private System.Windows.Forms.Label label4;
    }
}

