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

namespace WeatherApp
{
    public partial class FavoriteCities : Form
    {
        public FavoriteCities()
        {
            InitializeComponent();
        }

        private void FavoriteCities_Load(object sender, EventArgs e)
        {
            loadCities();
            refreshList();
            fileReader();

        }
        // This method populates city objects to the listbox 
        private void loadCities()
        {
            foreach (Weather item in WeatherWorker.weathersList)
            {

                if (!lstCities.Items.Contains(item.City))
                {
                    lstCities.Items.Add(item.City);
                }

            }
        }
        // This method refreshes the favorite list of objects
        public void refreshList()
        {
            WeatherWorker.favoriteList.Sort();
            lstFavCities.Items.Clear();
            foreach (Weather item in WeatherWorker.favoriteList)
            {
                if (!lstFavCities.Items.Contains(item.City))
                {
                    lstFavCities.Items.Add(item.City);
                }
            }

        }
        // This method adds selected weather objects to the favorites textfile
        private void Addfavorite()
        {
            if (lstCities.SelectedItem != null)
            {
                WeatherWorker.filtered = WeatherWorker.weathersList.Where(w => w.City.Equals(lstCities.SelectedItem.ToString())).ToList();
                try
                {
                    StreamWriter file = new StreamWriter("Favorites.txt", true);
                    foreach (Weather weather in WeatherWorker.filtered)
                    {
                        file.WriteLine(weather.City + "," + weather.Date + "," + weather.MinTemp +
                                   "," + weather.MaxTemp + "," + weather.Prec + "," + weather.Hum + "," + weather.Wind);
                    }
                    file.Close();
                    MessageBox.Show("Weather Added Favorites");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a city you wish to add to favorites");
            }
        }
        // This method reads from the favorites textfile
        public void fileReader()
        {
            WeatherWorker.favoriteList.Clear();
            string line;
            try
            {
                StreamReader file = new StreamReader("Favorites.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] lineParts = line.Split(',');
                    Weather temp = new Weather(lineParts[0], Convert.ToDateTime(lineParts[1]), Convert.ToInt32(lineParts[2]), Convert.ToInt32(lineParts[3]), Convert.ToInt32(lineParts[4]), Convert.ToInt32(lineParts[5]), Convert.ToInt32(lineParts[6]));
                    WeatherWorker.favoriteList.Add(temp);
                }
                file.Close();

            }
            catch (FileNotFoundException)
            {
                StreamReader sr = new StreamReader("Favorites.txt");
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lstFavCities.Items.Clear();
            foreach (Weather item in WeatherWorker.favoriteList)
            {
                if (!lstFavCities.Items.Contains(item.City))
                {
                    lstFavCities.Items.Add(item.City);
                }
            }

        }
        // This button adds weather items to the favorite list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Addfavorite();
            refreshList();
        }
        // This button removes a weather that the user no longer wants in the favorites
        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeFavorite();
        }
        // This Method takes the user back to the weather report form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeatherReport form = new WeatherReport();
            form.disableButton();
            form.ShowDialog();
        }

        // This method removes the selected weather item from the favorite textfile
        public void removeFavorite()
        {
            string selectedCity = lstFavCities.SelectedItem.ToString();
            if (selectedCity != null)
            {
                try
                {
                    var oldLines = System.IO.File.ReadAllLines("Favorites.txt").ToList();
                    var newLines = oldLines.Where(line => !line.Contains(selectedCity));
                    System.IO.File.WriteAllLines("Favorites.txt", newLines);
                    lstFavCities.Items.Remove(selectedCity);
                    MessageBox.Show("Weather Successfully removed from your favorites");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select the Weather you Wish to remove from the your favorites");
            }
        }
    }
}
