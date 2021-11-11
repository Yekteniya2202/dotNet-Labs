using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_13_App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CountriesDBDataSet _countiresDataGrid;
        private CountriesDBDataSetTableAdapters.CountriesTableAdapter _countiresDataGridCountriesTableAdapter;
        private CountriesDBDataSetTableAdapters.CitiesTableAdapter _countiresDataGridCitiesTableAdapter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _countiresDataGrid = (CountriesDBDataSet)FindResource("CountriesDBDataSet");
            // Загрузить данные в таблицу Countries. Можно изменить этот код как требуется.
            _countiresDataGridCountriesTableAdapter = new CountriesDBDataSetTableAdapters.CountriesTableAdapter();
            _countiresDataGridCountriesTableAdapter.Fill(_countiresDataGrid.Countries);
            var usersViewSource = (CollectionViewSource)FindResource("countriesViewSource");
            usersViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Cities. Можно изменить этот код как требуется.
            _countiresDataGridCitiesTableAdapter = new CountriesDBDataSetTableAdapters.CitiesTableAdapter();
            _countiresDataGridCitiesTableAdapter.Fill(_countiresDataGrid.Cities);
            var usersCitiesViewSource = (CollectionViewSource)FindResource("citiesViewSource");
            usersCitiesViewSource.View.MoveCurrentToFirst();
        }

        private void DeleteCountry_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < countriesDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = countriesDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            _countiresDataGridCountriesTableAdapter.Update(_countiresDataGrid.Countries);
        }

        private void SaveCountry_Click(object sender, RoutedEventArgs e)
        {
            _countiresDataGridCountriesTableAdapter.Update(_countiresDataGrid.Countries);
        }

        private void SaveCity_Click(object sender, RoutedEventArgs e)
        {
            _countiresDataGridCitiesTableAdapter.Update(_countiresDataGrid.Cities);
        }

        private void DeleteCity_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < citiesDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = citiesDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            _countiresDataGridCitiesTableAdapter.Update(_countiresDataGrid.Cities);
        }

        private void LoadImage_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".jpg",
                Filter = "Image files (*.jpg)|*.jpg|All files|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                if (countriesDataGrid.SelectedItems.Count > 0)
                {
                    var dataRowView = countriesDataGrid.SelectedItems[0] as DataRowView;
                    if (dataRowView != null)
                    {
                        var dataRow = dataRowView.Row as CountriesDBDataSet.CountriesRow;
                        if (dataRow != null)
                        {
                            dataRow.Flag = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }
    }
}
