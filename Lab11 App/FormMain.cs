﻿using Lab11.Models;
using Lab11_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_App
{
    public partial class FormMain : Form
    {
        private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
            _connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CountriesDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }

        private void toolStripCountriesButtonSelect_Click(object sender, EventArgs e)
        {
            var countries = Country.List(_connection);
            listViewCountries.Items.Clear();
            for (int i = 0; i < countries.Count; i++)
            {
                var country = countries[i];
                var listListViewItem = listViewCountries.Items.Add(country.CountryId.ToString());
                listListViewItem.Tag = country;
                listListViewItem.SubItems.Add(country.CountryName);
                listListViewItem.SubItems.Add(country.CountryPolity);
            }
        }

        private void toolStripCountriesButtonInsert_Click(object sender, EventArgs e)
        {
            FormCountry formCountry = new FormCountry
            {
                Country = new Country()
            };
            if (formCountry.ShowDialog() == DialogResult.OK)
            {
                Country.Insert(_connection, formCountry.Country);
            }
        }

        private void toolStripCountriesButtonUpdate_Click(object sender, EventArgs e)
        {
            FormCountry formCountry = new FormCountry
            {
                Country = (Country)listViewCountries.SelectedItems[0].Tag
            };
            if (formCountry.ShowDialog() == DialogResult.OK)
            {
                Country.Update(_connection, formCountry.Country);
            }
        }


        private void toolStripCountriesButtonDelete_Click(object sender, EventArgs e)
        {
            Country.Delete(_connection, ((Country)listViewCountries.SelectedItems[0].Tag).CountryId);
        }

        private void toolStripCitiesButtonSelect_Click(object sender, EventArgs e)
        {
            var cities = City.List(_connection);
            listViewCities.Items.Clear();
            for (int i = 0; i < cities.Count; i++)
            {
                var city = cities[i];
                var listListViewItem = listViewCities.Items.Add(city.CityId.ToString());
                listListViewItem.Tag = city;
                listListViewItem.SubItems.Add(city.CountryId.ToString());
                listListViewItem.SubItems.Add(city.CityName);
                listListViewItem.SubItems.Add(city.CityPopulation.ToString());
            }
        }

        private void toolStripCitiesButtonInsert_Click(object sender, EventArgs e)
        {
            FormCity formCity = new FormCity
            {
                City = new City()
            };
            if (formCity.ShowDialog() == DialogResult.OK)
            {
                City.Insert(_connection, formCity.City);
            }
        }

        private void toolStripCitiesButtonUpdate_Click(object sender, EventArgs e)
        {
            FormCity formCity = new FormCity
            {
                City = (City)listViewCities.SelectedItems[0].Tag
            };
            if (formCity.ShowDialog() == DialogResult.OK)
            {
                City.Update(_connection, formCity.City);
            }
        }

        private void toolStripCitiesButtonDelete_Click(object sender, EventArgs e)
        {
            City.Delete(_connection, ((City)listViewCities.SelectedItems[0].Tag).CityId);
        }
    }
}
