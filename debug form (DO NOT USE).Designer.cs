
namespace MaterialAndDaeFixerForAutobeam
{
    partial class Form2
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
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTxtBox.Location = new System.Drawing.Point(0, 0);
            this.resultTxtBox.MaxLength = 2147483647;
            this.resultTxtBox.Multiline = true;
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTxtBox.Size = new System.Drawing.Size(800, 450);
            this.resultTxtBox.TabIndex = 0;
            this.resultTxtBox.WordWrap = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox resultTxtBox;
    }
}