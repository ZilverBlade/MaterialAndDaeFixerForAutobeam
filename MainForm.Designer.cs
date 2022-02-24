
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fixBtn
            // 
            this.fixBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fixBtn.Enabled = false;
            this.fixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fixBtn.Location = new System.Drawing.Point(38, 249);
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
            this.carNameTxtBox.Location = new System.Drawing.Point(44, 139);
            this.carNameTxtBox.Name = "carNameTxtBox";
            this.carNameTxtBox.Size = new System.Drawing.Size(354, 20);
            this.carNameTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(52, 123);
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
            this.shortMatCharBtn.Location = new System.Drawing.Point(38, 289);
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
            this.button1.Location = new System.Drawing.Point(38, 211);
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
            this.label1.Location = new System.Drawing.Point(41, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "random seed:";
            // 
            // buildCleanupBtn
            // 
            this.buildCleanupBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buildCleanupBtn.Enabled = false;
            this.buildCleanupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildCleanupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildCleanupBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buildCleanupBtn.Location = new System.Drawing.Point(38, 338);
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
            this.followMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(444, 398);
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
    }
}

