using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PdfConcat
{
    public partial class MainForm : Form
    {
        #region interop
        const int GWL_STYLE = -16;
        const int WS_DISABLED = 0x08000000;

        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        void SetNativeEnabled(bool enabled)
        {
            SetWindowLong(Handle, GWL_STYLE, GetWindowLong(Handle, GWL_STYLE) &
                ~WS_DISABLED | (enabled ? 0 : WS_DISABLED));
        }
        #endregion

        ObservableCollection<string> pdfFiles;

        private MergeProgressDialog progressDialog;
        private AboutDialog aboutDialog;
        private PDFSettingsWindow pdfSettingsWindow;
        private VistaFolderBrowserDialog folderBrowserDialog;

        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            SystemColorsChanged += MainForm_SystemColorsChanged;

            KeyPreview = true;
            
            pdfFiles = new ObservableCollection<string>();
            filesListBox.DataSource = pdfFiles;
            filesListBox.KeyDown += FilesListBox_KeyDown;

            progressDialog = new MergeProgressDialog();
            aboutDialog = new AboutDialog();
            pdfSettingsWindow = new PDFSettingsWindow();
            folderBrowserDialog = new VistaFolderBrowserDialog();
        }

        private void MainForm_SystemColorsChanged(object sender, EventArgs e)
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
            Font = SystemFonts.MessageBoxFont;

            mergeButton.Font = new Font(mergeButton.Font, FontStyle.Bold);
        }

        bool shiftHeld = false;

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shiftHeld = false;
                addFilesButton.Text = "&Add file(s)";
                removeSelectedFilesButton.Text = "&Remove selected file(s)";
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shiftHeld = true;
                addFilesButton.Text = "&Add files from folder";
                removeSelectedFilesButton.Text = "&Remove all files";
            }
        }

        private void FilesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (
                e.Control &&
                !e.Alt &&
                !e.Shift
            )
            {
                if (e.KeyCode == Keys.Up)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    MoveUp();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    MoveDown();
                }
            } else if (
                !e.Control &&
                !e.Alt &&
                !e.Shift
            )
            {
                if (e.KeyCode == Keys.Delete)
                {
                    RemoveSelected();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
            Font = SystemFonts.MessageBoxFont;

            mergeButton.Font = new Font(mergeButton.Font, FontStyle.Bold);
        }

        #region event handlers
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (shiftHeld)
            {
                removeSelectedFilesButton.Enabled = pdfFiles.Count > 0;
            } 
            else
            {
                removeSelectedFilesButton.Enabled = filesListBox.SelectedItems.Count > 0;
            }

            moveSelectedFileUpButton.Enabled =
                filesListBox.SelectedItems.Count == 1 &&
                GetSmallestIndex() > 0;

            moveSelectedFileDownButton.Enabled =
                filesListBox.SelectedItems.Count == 1 &&
                GetBiggestIndex() < filesListBox.Items.Count - 1;

            mergeButton.Enabled = pdfFiles.Count > 0;
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {
            if (shiftHeld)
            {
                if (folderBrowserDialog.ShowDialog())
                {
                    string folder = folderBrowserDialog.SelectedPath;
                    string[] files = System.IO.Directory.GetFiles(folder, "*.pdf", System.IO.SearchOption.TopDirectoryOnly);
                    foreach (string file in files)
                    {
                        pdfFiles.Add(file);
                        UpdateList();
                    }
                }
            }
            else
            {
                if (openPdfFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openPdfFileDialog.FileNames)
                    {
                        pdfFiles.Add(file);
                        UpdateList();
                    }
                }
            }
            shiftHeld = false;
            addFilesButton.Text = "&Add file(s)";
        }

        private void removeSelectedFilesButton_Click(object sender, EventArgs e)
        {
            if (shiftHeld)
                RemoveAll();
            else
                RemoveSelected();
        }

        private void moveSelectedFileUpButton_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void moveSelectedFileDownButton_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            if (savePdfFileDialog.ShowDialog() == DialogResult.OK)
                DoMerge(savePdfFileDialog.FileName);
        }
        
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog.ShowDialog(this);
        }
        
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region methods
        void RemoveAll()
        {
            pdfFiles.Clear();
            UpdateList();
        }

        void RemoveSelected()
        {
            foreach (string item in filesListBox.SelectedItems)
            {
                pdfFiles.Remove(item);
            }
            UpdateList();
        }

        void MoveUp()
        {
            if (!(filesListBox.SelectedItems.Count == 1 && GetSmallestIndex() > 0))
                return;

            int i = filesListBox.SelectedIndex;
            pdfFiles.Move(i, --i);
            filesListBox.ClearSelected();
            UpdateList();
            filesListBox.SelectedIndex = i;
        }
        
        void MoveDown()
        {
            if (!(filesListBox.SelectedItems.Count == 1 && GetBiggestIndex() < filesListBox.Items.Count - 1))
                return;

            int i = filesListBox.SelectedIndex;
            pdfFiles.Move(i, ++i);
            filesListBox.ClearSelected();
            UpdateList();
            filesListBox.SelectedIndex = i;
        }

        int GetSmallestIndex()
        {
            if (filesListBox.SelectedIndices == null && filesListBox.SelectedIndices.Count < 1)
                return -1;
            int[] lst = filesListBox.SelectedIndices.Cast<int>().ToArray();
            if (lst.Length < 1)
                return -1;
            int min = lst.Min(entry => entry);
            var lowestValues = lst.Where(entry => entry == min);
            return lowestValues.ElementAt(0);
        }

        int GetBiggestIndex()
        {
            if (filesListBox.SelectedIndices == null && filesListBox.SelectedIndices.Count < 1)
                return -1;
            int[] lst = filesListBox.SelectedIndices.Cast<int>().ToArray();
            if (lst.Length < 1)
                return -1;
            int max = lst.Max(entry => entry);
            var highestValues = lst.Where(entry => entry == max);
            return highestValues.ElementAt(0);
        }

        void UpdateList()
        {
            filesListBox.BeginUpdate();
            filesListBox.DataSource = null;
            filesListBox.Update();
            filesListBox.DataSource = pdfFiles;
            filesListBox.EndUpdate();
        }

        void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
                to.AddPage(from.Pages[i]);
        }

        void DoMerge(string outputFileName)
        {
            try
            {
                progressDialog.SetProgress(0);
            }
            catch (ObjectDisposedException)
            {
                progressDialog = new MergeProgressDialog();
                progressDialog.SetProgress(0);
            }
            progressDialog.SetMaximum(pdfFiles.Count);
            SetNativeEnabled(false);
            progressDialog.Show(this);

            var docs = new List<PdfDocument>();
            var outputDoc = new PdfDocument()
            {
                Version = pdfSettingsWindow.PDFVersion,
                PageLayout = pdfSettingsWindow.PageLayout
            };

            foreach (string file in pdfFiles)
                docs.Add(PdfReader.Open(file, PdfDocumentOpenMode.Import));

            int progress = 1;

            foreach (var doc in docs)
            {
                CopyPages(doc, outputDoc);
                doc.Dispose();
                progressDialog.SetProgress(progress);
                progress++;
                Application.DoEvents();
            }

            outputDoc.Save(outputFileName);
            outputDoc.Dispose();

            docs.Clear();
            docs = null;
            GC.Collect();

            progressDialog.Hide();
            SetNativeEnabled(true);
            Focus();

            MessageBox.Show($"Successfully merged {pdfFiles.Count} PDF files!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void pdfSettingsMenuItem_Click(object sender, EventArgs e)
        {
            pdfSettingsWindow.ShowDialog(this);
        }
    }
}
