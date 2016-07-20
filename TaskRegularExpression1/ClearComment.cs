using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskRegularExpression1
{
    public partial class frmRegularExpression : Form
    {
        public frmRegularExpression()
        {
            InitializeComponent();
        }


        static string path;
        static string pattern = @"/\*(?:(?!\*/)(?:.|[\r\n]+))*\*/";
        static string fileText = "";


        public class FayliOxu
        {


            public void fayliOxu()
            {
                StreamReader streamReader = new StreamReader(path);
                fileText = streamReader.ReadToEnd();
            }
        }



        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
            }

            textBoxFilePath.Text = path;
            FayliOxu faylOxu = new FayliOxu();
            faylOxu.fayliOxu();
            richTextBoxOriginalContent.Text = fileText; ;

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(pattern, RegexOptions.Multiline);

            richTextBoxConvertedContent.Text = regex.Replace(fileText, "");
        }
    }
}
