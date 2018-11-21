namespace PdfConcat
{
    partial class PDFSettingsWindow
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
            this.pdfVersionLabel = new System.Windows.Forms.Label();
            this.pdfVersionComboBox = new System.Windows.Forms.ComboBox();
            this.pageLayoutComboBox = new System.Windows.Forms.ComboBox();
            this.pageLayoutLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pdfVersionLabel
            // 
            this.pdfVersionLabel.AutoSize = true;
            this.pdfVersionLabel.Location = new System.Drawing.Point(12, 9);
            this.pdfVersionLabel.Name = "pdfVersionLabel";
            this.pdfVersionLabel.Size = new System.Drawing.Size(68, 13);
            this.pdfVersionLabel.TabIndex = 0;
            this.pdfVersionLabel.Text = "PDF &version:";
            // 
            // pdfVersionComboBox
            // 
            this.pdfVersionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pdfVersionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pdfVersionComboBox.FormattingEnabled = true;
            this.pdfVersionComboBox.Items.AddRange(new object[] {
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7"});
            this.pdfVersionComboBox.Location = new System.Drawing.Point(12, 25);
            this.pdfVersionComboBox.Name = "pdfVersionComboBox";
            this.pdfVersionComboBox.Size = new System.Drawing.Size(192, 21);
            this.pdfVersionComboBox.TabIndex = 1;
            // 
            // pageLayoutComboBox
            // 
            this.pageLayoutComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageLayoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageLayoutComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pageLayoutComboBox.FormattingEnabled = true;
            this.pageLayoutComboBox.Location = new System.Drawing.Point(12, 78);
            this.pageLayoutComboBox.Name = "pageLayoutComboBox";
            this.pageLayoutComboBox.Size = new System.Drawing.Size(192, 21);
            this.pageLayoutComboBox.TabIndex = 3;
            // 
            // pageLayoutLabel
            // 
            this.pageLayoutLabel.AutoSize = true;
            this.pageLayoutLabel.Location = new System.Drawing.Point(12, 62);
            this.pageLayoutLabel.Name = "pageLayoutLabel";
            this.pageLayoutLabel.Size = new System.Drawing.Size(66, 13);
            this.pageLayoutLabel.TabIndex = 2;
            this.pageLayoutLabel.Text = "&Page layout:";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Location = new System.Drawing.Point(129, 119);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // PDFSettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(216, 154);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pageLayoutComboBox);
            this.Controls.Add(this.pageLayoutLabel);
            this.Controls.Add(this.pdfVersionComboBox);
            this.Controls.Add(this.pdfVersionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDFSettingsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDF Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pdfVersionLabel;
        private System.Windows.Forms.ComboBox pdfVersionComboBox;
        private System.Windows.Forms.ComboBox pageLayoutComboBox;
        private System.Windows.Forms.Label pageLayoutLabel;
        private System.Windows.Forms.Button closeButton;
    }
}