using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergePDF
{
    public partial class Form1 : Form
    {
        private List<Label> Labels { get; set; }
        private List<Button> Buttons { get; set; }
        private List<TextBox> Textboxes { get; set; }
        private List<OpenFileDialog> FileDialogs { get; set; }

        private PdfMerger _pdfMerger;

        private OpenFileDialog openFileDialog { get; set; }
        private SaveFileDialog saveFileDialog { get; set; }

        private int NumberOfFiles { get; set; }

        public Form1()
        {
            InitializeComponent();
            Labels = new List<Label>();
            Buttons = new List<Button>();
            Textboxes = new List<TextBox>();
            FileDialogs = new List<OpenFileDialog>();
            _pdfMerger = new PdfMerger();
            CreateOpenFileDialog();
            CreateSaveFileDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richConsole.AppendText("Initialized MergePDF, ready to merge!\n");
            btnMergePdf.Enabled = false;
        }

        private void richConsole_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void btnMergePdf_Click(object sender, EventArgs e)
        {
            try
            {
                _pdfMerger.Clear();
                foreach (var box in Textboxes)
                    _pdfMerger.AddFile(box.Text);

                _pdfMerger.MergeFiles(saveFileDialog.FileName);
                richConsole.AppendText(string.Format("Merged successfully!\n"));
            }catch(Exception ex)
            {
                MessageBox.Show("Uh-oh, something went wrong. Are you sure you have specified valid input and output paths?", "Merging error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richConsole.AppendText(string.Format("Error: {0}\n", ex.Message));
            }
        }

        private void richConsole_TextChanged(object sender, EventArgs e)
        {
            richConsole.SelectionStart = richConsole.Text.Length;
            richConsole.ScrollToCaret();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richConsole.Clear();
        }

        private void RemoveMergeRows()
        {
            foreach(var button in Buttons)
            {
                flpFiles.Controls.Remove(button);
            }

            foreach(var label in Labels)
            {
                flpFiles.Controls.Remove(label);
            }

            foreach(var txtBox in Textboxes)
            {
                flpFiles.Controls.Remove(txtBox);
            }

            Buttons.Clear();
            Labels.Clear();
            Textboxes.Clear();
            _pdfMerger.Clear();
        }

        private void CreateOpenFileDialog()
        {
            openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Title = "Open PDF file";
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
        }

        private void CreateSaveFileDialog()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Title = "Save merged PDF file at";
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
        }

        private TextBox CreateTextbox(int yOffset)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(126, yOffset + 1);
            textBox.Size = new Size(490, 20);
            textBox.Visible = true;
            textBox.ReadOnly = true;
            Textboxes.Add(textBox);

            return textBox;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lblFileCount.Text = (NumberOfFiles = 0).ToString();
            RemoveMergeRows();
            richConsole.Clear();
            txtSaveFile.Text = string.Empty;
            btnMergePdf.Enabled = false;
        }

        

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            var dialog = openFileDialog;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lblFileCount.Text = (++NumberOfFiles).ToString();
                    var box = CreateTextbox(45 * NumberOfFiles);
                    box.Text = dialog.FileName;
                    flpFiles.Controls.Add(box);
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Uh-oh, something went wrong. Please try closing all the PDF files you want to import", "Import error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richConsole.AppendText("Something went wrong, please try closing all the PDF files you want to import first.\n");
                }
            }
            btnMergePdf.Enabled = NumberOfFiles > 1;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                txtSaveFile.Text = saveFileDialog.FileName;
                richConsole.AppendText(string.Format("Output location set: {0}\n", saveFileDialog.FileName));
            }
        }
    }
}
