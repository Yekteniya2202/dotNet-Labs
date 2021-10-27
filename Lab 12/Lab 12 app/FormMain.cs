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

namespace Lab_12_app
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            pictureBoxFlag.ContextMenu = new ContextMenu(new MenuItem[]
            {
                new MenuItem("Upload", new EventHandler(LoadImg)),
                new MenuItem("Save", new EventHandler(SaveImg)),
                new MenuItem("Info", new EventHandler(InfoImg))

            });
        }

        private void LoadImg(object obj, EventArgs args)
        {
            var current = (DataRowView)countriesBindingSource.Current;
            DataRow row = current.Row;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFlag.Image = Image.FromFile(ofd.FileName);
                toolStripStatusLabelImg.Text = "Фотография успешно загружена";
            }
        }

        private void SaveImg(object obj, EventArgs args)
        {
            DataRowView drw = (DataRowView)countriesBindingSource.Current;
            CountriesDBDataSet.CountriesRow ur = (CountriesDBDataSet.CountriesRow)(drw.Row);
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (pictureBoxFlag.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    pictureBoxFlag.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                    toolStripStatusLabelImg.Text = "Фотография успешно сохранена";
                }
            }
        }

        private void InfoImg(object obj, EventArgs args)
        {
            //Вызов второй формы
            ImgInfo imginf = new ImgInfo(pictureBoxFlag.Image);
            imginf.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void dataGridViewCities_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewCities.Columns["cityIdDataGridViewTextBoxColumn"].Visible = false;
        }

        private void uploadCountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "countriesDBDataSet.Countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter.Fill(this.countriesDBDataSet.Countries);
        }

        private void uploadCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "countriesDBDataSet.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.countriesDBDataSet.Cities);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countriesBindingSource.EndEdit();
            this.countriesTableAdapter.Update(this.countriesDBDataSet.Countries);
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citiesBindingSource.EndEdit();
            this.citiesTableAdapter.Update(this.countriesDBDataSet.Cities);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);

            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float yPos = 0;
            int i = 0;

            var row = (DataRowView)countriesBindingSource.Current;

            var strArr = new string[5];
            var itemArr = row.Row.ItemArray;
            strArr[0] = "Country ID = " + ((int)itemArr[0]).ToString();
            strArr[1] = "Country Name = " + itemArr[1];
            strArr[2] = "Country Polity = " + itemArr[2];
            strArr[3] = "Country Flag = " + (DBNull.Value.Equals(itemArr[3]) ? "none" : "");
            foreach (var str in strArr)
            {
                yPos = topMargin + i * font.GetHeight(e.Graphics);
                e.Graphics.DrawString(str, font, Brushes.Black, leftMargin, yPos, new StringFormat());

                i++;
            }
            e.HasMorePages = false;

            if (pictureBoxFlag.Image != null)
                e.Graphics.DrawImage(pictureBoxFlag.Image, leftMargin, topMargin + i * font.GetHeight(e.Graphics));
        }
    }
}
