namespace TemtemTracker
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.trackerNameLabel = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAboutText = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.labelIconBy = new System.Windows.Forms.Label();
            this.linkAlice1 = new System.Windows.Forms.LinkLabel();
            this.linkAlice2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox.Image = global::TemtemTracker.Properties.Resources.Icon128;
            this.iconPictureBox.Location = new System.Drawing.Point(16, 15);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(179, 160);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            // 
            // trackerNameLabel
            // 
            this.trackerNameLabel.AutoSize = true;
            this.trackerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackerNameLabel.Location = new System.Drawing.Point(203, 15);
            this.trackerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trackerNameLabel.Name = "trackerNameLabel";
            this.trackerNameLabel.Size = new System.Drawing.Size(527, 79);
            this.trackerNameLabel.TabIndex = 1;
            this.trackerNameLabel.Text = "TemtemTracker";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(204, 89);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(300, 63);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Version 3.1";
            // 
            // labelAboutText
            // 
            this.labelAboutText.Location = new System.Drawing.Point(211, 146);
            this.labelAboutText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAboutText.Name = "labelAboutText";
            this.labelAboutText.Size = new System.Drawing.Size(515, 85);
            this.labelAboutText.TabIndex = 4;
            this.labelAboutText.Text = "TemtemTracker is a free, open source encounter tracking application for the popul" +
    "ar monster-catching MMORPG Temtem.";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(211, 231);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(296, 25);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Code by: Mislav (Silber) Culig";
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(211, 272);
            this.linkGithub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(250, 25);
            this.linkGithub.TabIndex = 7;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "https://github.com/mculig";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGithub_LinkClicked);
            // 
            // labelIconBy
            // 
            this.labelIconBy.AutoSize = true;
            this.labelIconBy.Location = new System.Drawing.Point(211, 314);
            this.labelIconBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIconBy.Name = "labelIconBy";
            this.labelIconBy.Size = new System.Drawing.Size(296, 25);
            this.labelIconBy.TabIndex = 8;
            this.labelIconBy.Text = "Icons by: Alice (Parou) Peters";
            // 
            // linkAlice1
            // 
            this.linkAlice1.AutoSize = true;
            this.linkAlice1.Location = new System.Drawing.Point(211, 352);
            this.linkAlice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAlice1.Name = "linkAlice1";
            this.linkAlice1.Size = new System.Drawing.Size(218, 25);
            this.linkAlice1.TabIndex = 9;
            this.linkAlice1.TabStop = true;
            this.linkAlice1.Text = "https://alicepeters.de/";
            this.linkAlice1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAlice1_LinkClicked);
            // 
            // linkAlice2
            // 
            this.linkAlice2.AutoSize = true;
            this.linkAlice2.Location = new System.Drawing.Point(211, 389);
            this.linkAlice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAlice2.Name = "linkAlice2";
            this.linkAlice2.Size = new System.Drawing.Size(185, 25);
            this.linkAlice2.TabIndex = 10;
            this.linkAlice2.TabStop = true;
            this.linkAlice2.Text = "https://parou.moe/";
            this.linkAlice2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAlice2_LinkClicked);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(739, 435);
            this.Controls.Add(this.linkAlice2);
            this.Controls.Add(this.linkAlice1);
            this.Controls.Add(this.labelIconBy);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelAboutText);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.trackerNameLabel);
            this.Controls.Add(this.iconPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AboutWindow";
            this.Text = "About";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label trackerNameLabel;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelAboutText;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Label labelIconBy;
        private System.Windows.Forms.LinkLabel linkAlice1;
        private System.Windows.Forms.LinkLabel linkAlice2;
    }
}