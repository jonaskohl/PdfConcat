using System;
using System.Windows.Forms;

namespace PdfConcat
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SettingsProvider.LoadSettings();

            Application.Run(new MainForm());
        }
    }
}
