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

namespace EncodingForm
{
    public partial class Form1 : Form
    {
        public string fileName = string.Empty;
        public Encoding UTF7 = Encoding.UTF7;
        public Encoding Latin = Encoding.Latin1;
        public Encoding ASCII = Encoding.ASCII;
        public Encoding UTF8 = Encoding.UTF8;
        public Encoding UTF32 = Encoding.UTF32;
        public Encoding Unicode = Encoding.Unicode;

        public Encoding CurrentEncoding = Encoding.ASCII;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aSCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = ASCII;
            textBoxCurEnc.Text = CurrentEncoding.EncodingName;
        }

        private void uTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = UTF8;
            textBoxCurEnc.Text = CurrentEncoding.EncodingName;
        }

        private void uTF32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = UTF32;
            textBoxCurEnc.Text = CurrentEncoding.EncodingName;
        }

        private void uNICODEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Unicode;
            textBoxCurEnc.Text = CurrentEncoding.EncodingName;
        }

        private void uTF7ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CurrentEncoding = UTF7;
            textBoxCurEnc.Text = CurrentEncoding.EncodingName;
        }

        private void lATINToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CurrentEncoding = Latin;
            textBoxCurEnc.Text = CurrentEncoding.EncodingName;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fileName = fd.FileName;
                using (FileStream fs = new FileStream(fd.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                using (StreamReader reader = new StreamReader(fs))
                {
                    textBox.Text = reader.ReadToEnd();
                    CurrentEncoding = reader.CurrentEncoding;
                    textBoxCurEnc.Text = CurrentEncoding.EncodingName;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogMain = new SaveFileDialog();
            saveFileDialogMain.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы|*.*";
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {

                using (FileStream fs = new FileStream(saveFileDialogMain.FileName, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite))
                using (TextWriter writer = new StreamWriter(fs, CurrentEncoding))
                {
                    writer.Write(textBox.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] encByte = CurrentEncoding.GetBytes(File.ReadAllText(fileName));
            char[] encChar = new char[CurrentEncoding.GetCharCount(encByte, 0, encByte.Length)];
            CurrentEncoding.GetChars(encByte, 0, encByte.Length, encChar, 0);
            textBox.Text = CurrentEncoding.GetString(encByte);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
