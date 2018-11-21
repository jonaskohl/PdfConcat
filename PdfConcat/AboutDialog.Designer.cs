namespace PdfConcat
{
    partial class AboutDialog
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
            this.okButton = new System.Windows.Forms.Button();
            this.projectLinkLabel = new System.Windows.Forms.LinkLabelEx();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabelEx();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(132, 74);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // projectLinkLabel
            // 
            this.projectLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.projectLinkLabel.AutoSize = true;
            this.projectLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 16);
            this.projectLinkLabel.Location = new System.Drawing.Point(24, 79);
            this.projectLinkLabel.Name = "projectLinkLabel";
            this.projectLinkLabel.Size = new System.Drawing.Size(93, 13);
            this.projectLinkLabel.TabIndex = 2;
            this.projectLinkLabel.TabStop = true;
            this.projectLinkLabel.Text = "Project homepage";
            this.projectLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.projectLinkLabel_LinkClicked);
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(46, 10);
            this.aboutLinkLabel.Location = new System.Drawing.Point(27, 24);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(162, 42);
            this.aboutLinkLabel.TabIndex = 1;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "PdfConcat - Version $VerNum\r\nCopyright © 2018 Jonas Kohl\r\nAll rights reserved.";
            this.aboutLinkLabel.UseCompatibleTextRendering = true;
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // AboutDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(234, 124);
            this.Controls.Add(this.projectLinkLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.aboutLinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About PdfConcat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabelEx aboutLinkLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.LinkLabelEx projectLinkLabel;
    }
}