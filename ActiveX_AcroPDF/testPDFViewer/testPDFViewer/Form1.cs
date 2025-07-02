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

namespace testPDFViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pdfFileName = "big_size_4.68MB.pdf";
            string runDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string pdfFileDirectory = System.IO.Path.Combine(runDirectory, "SamplePDF");
            string pdfFilePath = System.IO.Path.Combine(pdfFileDirectory, pdfFileName);

            axAcroPDF1.src = string.Empty; // Clear any previous source
            if (!File.Exists(pdfFilePath))
            {
                MessageBox.Show($"PDF file not found: {pdfFilePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else

            {
                axAcroPDF1.src = pdfFilePath;
            }

            //string testEngName1 = "ABCDEFG";
            //string testEngName2 = " ";
            //String[] splitEngGivenName1 = testEngName1.Split();
            //String[] splitEngGivenName2 = testEngName2.Split();
            //String[] maskedSplitEngGivenName = new String[splitEngGivenName1.Length];
            //for (int i = 0; i < splitEngGivenName1.Length; i++)
            //{
            //    String maskedWord = splitEngGivenName1[i].Substring(0, 1);
            //}

            //String[] maskedSplitEngGivenName2 = new String[splitEngGivenName2.Length];
            //for (int i = 0; i < splitEngGivenName2.Length; i++)
            //{
            //    String maskedWord = splitEngGivenName2[i].Substring(0, 1);
            //}
        }
    }
}
