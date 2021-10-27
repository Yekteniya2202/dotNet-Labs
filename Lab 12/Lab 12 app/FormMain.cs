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
    }
}
