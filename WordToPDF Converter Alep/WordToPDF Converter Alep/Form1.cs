using Microsoft.Office.Interop.Word;
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

namespace WordToPDF_Converter_Alep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void B_SOURCE_Click(object sender, EventArgs e)
        {
            DialogResult result = OFD_SOURCE.ShowDialog();

            if (result == DialogResult.OK)
            {
                string sourcePath = OFD_SOURCE.FileName;

                try
                {
                    D_SOURCE.Text = sourcePath.ToString();
                    D_SOURCE.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void B_TARGET_Click(object sender, EventArgs e)
        {
            DialogResult result = BFD_TARGET.ShowDialog();

            if (result == DialogResult.OK)
            {
                string targetPath = BFD_TARGET.SelectedPath;

                try
                {
                    D_TARGET.Text = targetPath.ToString();
                    D_TARGET.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void B_CONVERT_Click(object sender, EventArgs e)
        {
            string sourcePath = D_SOURCE.Text.Trim();
            string targetPath = D_TARGET.Text.Trim();
            string fileName = I_NAME.Text.Trim();
            ConvertToPDF(sourcePath, targetPath, fileName);
        }

        private void clear()
        {
            D_SOURCE.Text = "";
            D_TARGET.Text = "";
            I_NAME.Text = "";
            B_SOURCE.Focus();
        }

        private void ConvertToPDF(string SourcePath, string TargetPath, string NewName)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                Document doc = word.Documents.Open(SourcePath);
                doc.Activate();
                string NewFilePath = TargetPath + "\\" + NewName + ".pdf";
                doc.SaveAs(NewFilePath, WdSaveFormat.wdFormatPDF);
                doc.Close();

                MessageBox.Show("Document converted to pdf");
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
