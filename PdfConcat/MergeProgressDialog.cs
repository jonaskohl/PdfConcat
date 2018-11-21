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
    public partial class MergeProgressDialog : Form
    {
        public MergeProgressDialog()
        {
            InitializeComponent();

            Load += MergeProgressDialog_Load;
        }

        private void MergeProgressDialog_Load(object sender, EventArgs e)
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
            Font = SystemFonts.CaptionFont;
        }

        public void SetMaximum(int m)
        {
            mergeProgressBar.Maximum = m;
            UpdateText();
        }

        public void SetProgress(int v)
        {
            mergeProgressBar.Value = v;
            UpdateText();
        }

        void UpdateText()
        {
            messageLabel.Text = $"Merging {mergeProgressBar.Value} of {mergeProgressBar.Maximum}...";
        }
    }
}
