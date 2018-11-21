namespace PdfConcat
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addFilesButton = new System.Windows.Forms.Button();
            this.removeSelectedFilesButton = new System.Windows.Forms.Button();
            this.moveSelectedFileUpButton = new System.Windows.Forms.Button();
            this.moveSelectedFileDownButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.openPdfFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePdfFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.pdfSettingsMenuItem = new System.Windows.Forms.MenuItem();
            this.fileMenuSeparator = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.filesListBox = new System.Windows.Forms.DoubleBufferedListBox();
            this.SuspendLayout();
            // 
            // addFilesButton
            // 
            this.addFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addFilesButton.Location = new System.Drawing.Point(333, 12);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(147, 23);
            this.addFilesButton.TabIndex = 1;
            this.addFilesButton.Text = "&Add file(s)";
            this.addFilesButton.UseVisualStyleBackColor = true;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // removeSelectedFilesButton
            // 
            this.removeSelectedFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSelectedFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeSelectedFilesButton.Location = new System.Drawing.Point(333, 41);
            this.removeSelectedFilesButton.Name = "removeSelectedFilesButton";
            this.removeSelectedFilesButton.Size = new System.Drawing.Size(147, 23);
            this.removeSelectedFilesButton.TabIndex = 2;
            this.removeSelectedFilesButton.Text = "&Remove selected file(s)";
            this.removeSelectedFilesButton.UseVisualStyleBackColor = true;
            this.removeSelectedFilesButton.Click += new System.EventHandler(this.removeSelectedFilesButton_Click);
            // 
            // moveSelectedFileUpButton
            // 
            this.moveSelectedFileUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveSelectedFileUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.moveSelectedFileUpButton.Location = new System.Drawing.Point(333, 70);
            this.moveSelectedFileUpButton.Name = "moveSelectedFileUpButton";
            this.moveSelectedFileUpButton.Size = new System.Drawing.Size(147, 23);
            this.moveSelectedFileUpButton.TabIndex = 3;
            this.moveSelectedFileUpButton.Text = "Move selected file &up";
            this.moveSelectedFileUpButton.UseVisualStyleBackColor = true;
            this.moveSelectedFileUpButton.Click += new System.EventHandler(this.moveSelectedFileUpButton_Click);
            // 
            // moveSelectedFileDownButton
            // 
            this.moveSelectedFileDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveSelectedFileDownButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.moveSelectedFileDownButton.Location = new System.Drawing.Point(333, 99);
            this.moveSelectedFileDownButton.Name = "moveSelectedFileDownButton";
            this.moveSelectedFileDownButton.Size = new System.Drawing.Size(147, 23);
            this.moveSelectedFileDownButton.TabIndex = 4;
            this.moveSelectedFileDownButton.Text = "Move selected file &down";
            this.moveSelectedFileDownButton.UseVisualStyleBackColor = true;
            this.moveSelectedFileDownButton.Click += new System.EventHandler(this.moveSelectedFileDownButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mergeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mergeButton.Location = new System.Drawing.Point(333, 232);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(147, 23);
            this.mergeButton.TabIndex = 5;
            this.mergeButton.Text = "&Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // openPdfFileDialog
            // 
            this.openPdfFileDialog.DefaultExt = "pdf";
            this.openPdfFileDialog.Filter = "PDF file|*.pdf";
            this.openPdfFileDialog.Multiselect = true;
            this.openPdfFileDialog.Title = "Add PDF file";
            // 
            // savePdfFileDialog
            // 
            this.savePdfFileDialog.DefaultExt = "pdf";
            this.savePdfFileDialog.Filter = "PDF file|*.pdf";
            this.savePdfFileDialog.Title = "Save merged PDF";
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.helpMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.pdfSettingsMenuItem,
            this.fileMenuSeparator,
            this.exitMenuItem});
            this.fileMenuItem.Text = "&File";
            // 
            // pdfSettingsMenuItem
            // 
            this.pdfSettingsMenuItem.Index = 0;
            this.pdfSettingsMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlK;
            this.pdfSettingsMenuItem.Text = "&PDF Settings...";
            this.pdfSettingsMenuItem.Click += new System.EventHandler(this.pdfSettingsMenuItem_Click);
            // 
            // fileMenuSeparator
            // 
            this.fileMenuSeparator.Index = 1;
            this.fileMenuSeparator.Text = "-";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 2;
            this.exitMenuItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.exitMenuItem.Text = "&Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 1;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 0;
            this.aboutMenuItem.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.aboutMenuItem.Text = "&About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.HorizontalScrollbar = true;
            this.filesListBox.IntegralHeight = false;
            this.filesListBox.Location = new System.Drawing.Point(12, 12);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesListBox.Size = new System.Drawing.Size(315, 243);
            this.filesListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 267);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.moveSelectedFileDownButton);
            this.Controls.Add(this.moveSelectedFileUpButton);
            this.Controls.Add(this.removeSelectedFilesButton);
            this.Controls.Add(this.addFilesButton);
            this.Controls.Add(this.filesListBox);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(294, 203);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "PdfConcat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DoubleBufferedListBox filesListBox;
        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.Button removeSelectedFilesButton;
        private System.Windows.Forms.Button moveSelectedFileUpButton;
        private System.Windows.Forms.Button moveSelectedFileDownButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.OpenFileDialog openPdfFileDialog;
        private System.Windows.Forms.SaveFileDialog savePdfFileDialog;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem helpMenuItem;
        private System.Windows.Forms.MenuItem aboutMenuItem;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem pdfSettingsMenuItem;
        private System.Windows.Forms.MenuItem fileMenuSeparator;
    }
}

