
namespace MaterialAndDaeFixerForAutobeam
{
    partial class MainForm
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
            this.fixBtn = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shortMatCharBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buildCleanupBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beamNGPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beamNGPostToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.randomMatGenCheck = new System.Windows.Forms.CheckBox();
            this.nameModificCheck = new System.Windows.Forms.CheckBox();
            this.matNameShortnedCheck = new System.Windows.Forms.CheckBox();
            this.gitHubReleasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fixBtn
            // 
            this.fixBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fixBtn.Enabled = false;
            this.fixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fixBtn.Location = new System.Drawing.Point(38, 225);
            this.fixBtn.Name = "fixBtn";
            this.fixBtn.Size = new System.Drawing.Size(368, 34);
            this.fixBtn.TabIndex = 0;
            this.fixBtn.Text = "fix names";
            this.fixBtn.UseVisualStyleBackColor = false;
            this.fixBtn.Click += new System.EventHandler(this.fixBtn_Click1);
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.logTextBox.Location = new System.Drawing.Point(456, 44);
            this.logTextBox.MaxLength = 2147483647;
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(206, 380);
            this.logTextBox.TabIndex = 1;
            this.logTextBox.Visible = false;
            this.logTextBox.WordWrap = false;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogLabel.Location = new System.Drawing.Point(453, 9);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(198, 13);
            this.LogLabel.TabIndex = 2;
            this.LogLabel.Text = "Log (disabled because crashes program)";
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.locationTxtBox.ForeColor = System.Drawing.SystemColors.Info;
            this.locationTxtBox.Location = new System.Drawing.Point(44, 64);
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.Size = new System.Drawing.Size(354, 20);
            this.locationTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(52, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Car Folder (unpacked\\modname\\vehicles\\car)";
            // 
            // carNameTxtBox
            // 
            this.carNameTxtBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.carNameTxtBox.ForeColor = System.Drawing.SystemColors.Info;
            this.carNameTxtBox.Location = new System.Drawing.Point(44, 115);
            this.carNameTxtBox.Name = "carNameTxtBox";
            this.carNameTxtBox.Size = new System.Drawing.Size(354, 20);
            this.carNameTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(52, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Car Name (in Jbeam)";
            // 
            // shortMatCharBtn
            // 
            this.shortMatCharBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shortMatCharBtn.Enabled = false;
            this.shortMatCharBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortMatCharBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.shortMatCharBtn.Location = new System.Drawing.Point(38, 265);
            this.shortMatCharBtn.Name = "shortMatCharBtn";
            this.shortMatCharBtn.Size = new System.Drawing.Size(368, 34);
            this.shortMatCharBtn.TabIndex = 0;
            this.shortMatCharBtn.Text = "Cut material names to 64";
            this.shortMatCharBtn.UseVisualStyleBackColor = false;
            this.shortMatCharBtn.Click += new System.EventHandler(this.fixBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(38, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate random mat seed (cuz i dont trust beam)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "random seed:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buildCleanupBtn
            // 
            this.buildCleanupBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buildCleanupBtn.Enabled = false;
            this.buildCleanupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildCleanupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildCleanupBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buildCleanupBtn.Location = new System.Drawing.Point(38, 316);
            this.buildCleanupBtn.Name = "buildCleanupBtn";
            this.buildCleanupBtn.Size = new System.Drawing.Size(368, 34);
            this.buildCleanupBtn.TabIndex = 0;
            this.buildCleanupBtn.Text = "Build & Cleanup";
            this.buildCleanupBtn.UseMnemonic = false;
            this.buildCleanupBtn.UseVisualStyleBackColor = false;
            this.buildCleanupBtn.Click += new System.EventHandler(this.cleanup_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.youtubeChannelToolStripMenuItem,
            this.followMeToolStripMenuItem,
            this.beamNGPostToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // youtubeChannelToolStripMenuItem
            // 
            this.youtubeChannelToolStripMenuItem.Name = "youtubeChannelToolStripMenuItem";
            this.youtubeChannelToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // followMeToolStripMenuItem
            // 
            this.followMeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youtubeToolStripMenuItem,
            this.twitchToolStripMenuItem});
            this.followMeToolStripMenuItem.Name = "followMeToolStripMenuItem";
            this.followMeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.followMeToolStripMenuItem.Text = "Follow me!";
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.youtubeToolStripMenuItem_Click);
            // 
            // twitchToolStripMenuItem
            // 
            this.twitchToolStripMenuItem.Name = "twitchToolStripMenuItem";
            this.twitchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.twitchToolStripMenuItem.Text = "Twitch";
            this.twitchToolStripMenuItem.Click += new System.EventHandler(this.twitchToolStripMenuItem_Click);
            // 
            // beamNGPostToolStripMenuItem
            // 
            this.beamNGPostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubReleasesToolStripMenuItem,
            this.beamNGPostToolStripMenuItem1,
            this.youtubeVideoToolStripMenuItem});
            this.beamNGPostToolStripMenuItem.Name = "beamNGPostToolStripMenuItem";
            this.beamNGPostToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.beamNGPostToolStripMenuItem.Text = "Posts";
            this.beamNGPostToolStripMenuItem.Click += new System.EventHandler(this.beamNGPostToolStripMenuItem_Click);
            // 
            // beamNGPostToolStripMenuItem1
            // 
            this.beamNGPostToolStripMenuItem1.Name = "beamNGPostToolStripMenuItem1";
            this.beamNGPostToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.beamNGPostToolStripMenuItem1.Text = "BeamNG Forum Post";
            this.beamNGPostToolStripMenuItem1.Click += new System.EventHandler(this.beamNGPostToolStripMenuItem1_Click);
            // 
            // youtubeVideoToolStripMenuItem
            // 
            this.youtubeVideoToolStripMenuItem.Name = "youtubeVideoToolStripMenuItem";
            this.youtubeVideoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.youtubeVideoToolStripMenuItem.Text = "Youtube Video";
            this.youtubeVideoToolStripMenuItem.Click += new System.EventHandler(this.youtubeVideoToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(200, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // randomMatGenCheck
            // 
            this.randomMatGenCheck.AutoCheck = false;
            this.randomMatGenCheck.AutoSize = true;
            this.randomMatGenCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.randomMatGenCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.randomMatGenCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.randomMatGenCheck.Location = new System.Drawing.Point(39, 388);
            this.randomMatGenCheck.Name = "randomMatGenCheck";
            this.randomMatGenCheck.Size = new System.Drawing.Size(103, 17);
            this.randomMatGenCheck.TabIndex = 10;
            this.randomMatGenCheck.Text = "Generated name";
            this.randomMatGenCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.randomMatGenCheck.UseVisualStyleBackColor = false;
            // 
            // nameModificCheck
            // 
            this.nameModificCheck.AutoCheck = false;
            this.nameModificCheck.AutoSize = true;
            this.nameModificCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nameModificCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nameModificCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameModificCheck.Location = new System.Drawing.Point(149, 388);
            this.nameModificCheck.Name = "nameModificCheck";
            this.nameModificCheck.Size = new System.Drawing.Size(99, 17);
            this.nameModificCheck.TabIndex = 10;
            this.nameModificCheck.Text = "Names modified";
            this.nameModificCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nameModificCheck.UseVisualStyleBackColor = false;
            // 
            // matNameShortnedCheck
            // 
            this.matNameShortnedCheck.AutoCheck = false;
            this.matNameShortnedCheck.AutoSize = true;
            this.matNameShortnedCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.matNameShortnedCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matNameShortnedCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.matNameShortnedCheck.Location = new System.Drawing.Point(257, 388);
            this.matNameShortnedCheck.Name = "matNameShortnedCheck";
            this.matNameShortnedCheck.Size = new System.Drawing.Size(144, 17);
            this.matNameShortnedCheck.TabIndex = 10;
            this.matNameShortnedCheck.Text = "Shortened material length";
            this.matNameShortnedCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.matNameShortnedCheck.UseVisualStyleBackColor = false;
            // 
            // gitHubReleasesToolStripMenuItem
            // 
            this.gitHubReleasesToolStripMenuItem.Name = "gitHubReleasesToolStripMenuItem";
            this.gitHubReleasesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gitHubReleasesToolStripMenuItem.Text = "GitHub Releases";
            this.gitHubReleasesToolStripMenuItem.Click += new System.EventHandler(this.gitHubReleasesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(441, 427);
            this.Controls.Add(this.matNameShortnedCheck);
            this.Controls.Add(this.nameModificCheck);
            this.Controls.Add(this.randomMatGenCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationTxtBox);
            this.Controls.Add(this.carNameTxtBox);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.buildCleanupBtn);
            this.Controls.Add(this.shortMatCharBtn);
            this.Controls.Add(this.fixBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fixBtn;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button shortMatCharBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buildCleanupBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beamNGPostToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox randomMatGenCheck;
        private System.Windows.Forms.CheckBox nameModificCheck;
        private System.Windows.Forms.CheckBox matNameShortnedCheck;
        private System.Windows.Forms.ToolStripMenuItem beamNGPostToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem youtubeVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubReleasesToolStripMenuItem;
    }
}

