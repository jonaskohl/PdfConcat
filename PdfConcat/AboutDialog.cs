using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PdfConcat
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            aboutLinkLabel.Text = aboutLinkLabel.Text.Replace("$VerNum", version);

            Load += AboutDialog_Load;
            SystemColorsChanged += AboutDialog_SystemColorsChanged;
        }

        private void AboutDialog_SystemColorsChanged(object sender, EventArgs e)
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
            Font = SystemFonts.MessageBoxFont;
            aboutLinkLabel.LinkColor =
                projectLinkLabel.LinkColor =
                SystemColors.HotTrack;
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
            Font = SystemFonts.MessageBoxFont;
            aboutLinkLabel.LinkColor =
                projectLinkLabel.LinkColor =
                SystemColors.HotTrack;
        }

        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonaskohl.de/");
        }

        private void projectLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonaskohl.de/pdfconcat/");
        }
    }
}
