using Lab11.Models;
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
    public partial class FormCountry : Form
    {
        private Country _country;
        public Country Country
        {
            get { return _country; }
            set
            {
                _country = value;
                textBoxName.Text = _country.CountryName;
                textBoxPolity.Text = _country.CountryPolity;
            }
        }
        public FormCountry()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Country.CountryName = textBoxName.Text;
            Country.CountryPolity = textBoxPolity.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
