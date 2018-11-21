using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PdfConcat
{
    public partial class PDFSettingsWindow : Form
    {
        private readonly int[] versions = new int[6] { 12, 13, 14, 15, 16, 17 };
        
        public int PDFVersion
        {
            get
            {
                return versions[pdfVersionComboBox.SelectedIndex];
            }
        }

        public PdfPageLayout PageLayout
        {
            get
            {
                return (PdfPageLayout)Enum.Parse(typeof(PdfPageLayout), pageLayoutComboBox.SelectedValue.ToString());
            }
        }

        public PDFSettingsWindow()
        {
            InitializeComponent();
            Load += PDFSettingsWindow_Load;
            SystemColorsChanged += PDFSettingsWindow_SystemColorsChanged;
            
            pdfVersionComboBox.SelectedIndex = SettingsProvider.GetAsOrDefault<int>("pdfVersionIndex", 2);
            pdfVersionComboBox.SelectedIndexChanged += PdfVersionComboBox_SelectedIndexChanged;

            pageLayoutComboBox.DataSource = Enum.GetValues(typeof(PdfPageLayout));
            pageLayoutComboBox.SelectedIndex = SettingsProvider.GetAs<int>("pageLayoutIndex");
            pageLayoutComboBox.SelectedIndexChanged += PageLayoutComboBox_SelectedIndexChanged;
        }

        private void PDFSettingsWindow_SystemColorsChanged(object sender, EventArgs e)
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
            Font = SystemFonts.MessageBoxFont;
        }

        private void PageLayoutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsProvider.Set("pageLayoutIndex", pageLayoutComboBox.SelectedIndex);
            SettingsProvider.SaveSettings();
        }

        private void PdfVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsProvider.Set("pdfVersionIndex", pdfVersionComboBox.SelectedIndex);
            SettingsProvider.SaveSettings();
        }

        private void PDFSettingsWindow_Load(object sender, EventArgs e)
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
            Font = SystemFonts.MessageBoxFont;
        }
    }
}
