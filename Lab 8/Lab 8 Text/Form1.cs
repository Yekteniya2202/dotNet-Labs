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

namespace Lab_8_Text
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }




        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogMain = new OpenFileDialog();
            openFileDialogMain.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы|*.*";
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                string[] pathlines = openFileDialogMain.FileName.Split("\\");
                string path = "";
                for (int i = 0; i < pathlines.Length - 1; i++)
                {

                    if (i == pathlines.Length - 2)
                    {

                        path += pathlines[i];
                        break;
                    }
                    path += pathlines[i] + "\\";
                }
                fileSystemWatcher1.Path = path;
                using (FileStream fs = new FileStream(openFileDialogMain.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                using (TextReader reader = new StreamReader(fs))
                {
                    textBox.Text = reader.ReadToEnd();
                }
            }


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogMain = new SaveFileDialog();
            saveFileDialogMain.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы|*.*";
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialogMain.FileName, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite))
                using (TextWriter writer = new StreamWriter(fs))
                {
                    writer.Write(textBox.Text);
                }
            }


        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                using (FileStream fs = new FileStream(@"D:\repos_d\dotNet Labs\Lab 8\Lab 8 Text\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                using (TextReader reader = new StreamReader(fs))
                {

                    textBox.Text = reader.ReadToEnd();
                }
            }));
        }
    }

}
