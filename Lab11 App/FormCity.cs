using Lab11_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_App
{
    public partial class FormCity : Form
    {
        private City _city;
        public City City
        {
            get { return _city; }
            set
            {
                _city = value;
                numericUpDownCountryId.Value = _city.CountryId;
                textBoxName.Text = _city.CityName;
                numericUpDownPopulation.Value = _city.CityPopulation;
            }
        }
        public FormCity()
        {
            InitializeComponent();
        }

        private void FormCity_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            City.CountryId = (int)numericUpDownCountryId.Value;
            City.CityName = textBoxName.Text;
            City.CityPopulation = (int)numericUpDownPopulation.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
