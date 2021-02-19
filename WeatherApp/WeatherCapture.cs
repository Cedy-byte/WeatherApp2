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
    public partial class WeatherCapture : Form
    {
        public WeatherCapture()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileReader();
        }

        // This button Saves a weather object and reads from the textfile
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveWeather();
            fileReader();
        }
        // This button takes the user to the weather report form
        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeatherReport form = new WeatherReport();
            form.ShowDialog();

        }
        // This button refreshes the user interface
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnView.Enabled = true;
            btnDelete.Enabled = true;
            refreshUI();
        }
        // This Method contains validation for the minimum temperature textbox
        private void txtMinTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter digits only");
            }
        }
        // This Method contains validation for the maximum temperature textbox
        private void txtMaxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter digits only");
            }
        }
        // This Method contains validation for the precipitation textbox
        private void txtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter digits only");
            }
        }

        // This Method populates the respective text fields with a weather object that has been selected from the listbox
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCities.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select the Weather you Wish to Edit from the List");
                }
                else
                {
                    string selectedName = lstCities.SelectedItem.ToString();
                    Weather selectedWeather = new Weather();

                    foreach (Weather item in WeatherWorker.weathersList)
                    {
                        if ((item.City + " " + item.Date).Equals(selectedName))
                        {
                            txtCity.Text = item.City;
                            dtpDate.Value = item.Date;
                            txtMinTemp.Text = item.MinTemp.ToString();
                            txtMaxTemp.Text = item.MaxTemp.ToString();
                            txtPrec.Text = item.Prec.ToString();
                            numUpDwnHum.Value = item.Hum;
                            numUpDwnWind.Value = item.Wind;
                            break;
                        }

                    }
                    btnView.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // This Method removes a weather object selected by a user from the textfile
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCities.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select the Weather you Wish to Delete from the List");
                }
                else
                {
                    // Deleting selected index from the Weather Text file
                    int count = -1;
                    List<string> linesList = File.ReadAllLines("Weather.txt").ToList();
                    for (int i = 0; i < linesList.Count; i++)
                    {
                        count++;
                        if (count == lstCities.SelectedIndex)
                        {
                            linesList.RemoveAt(i);
                            lstCities.Items.RemoveAt(lstCities.SelectedIndex);
                        }

                    }
                    File.WriteAllLines("Weather.txt", linesList.ToArray());
                    MessageBox.Show("Weather Successfully Deleted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This Method receives the weather input from a user and stores it in a textfile
        private void saveWeather()
        {
            if (txtCity.Text == null || dtpDate.Value == null || txtMinTemp.Text == null || txtMaxTemp.Text == null || txtPrec.Text == null || numUpDwnHum.Text == null || numUpDwnWind.Text == null)
            {
                MessageBox.Show("Please Populate Empty fields");
            }
            else
            {
                try
                {
                    string city = txtCity.Text;
                    DateTime date = Convert.ToDateTime(dtpDate.Value);
                    int min = Convert.ToInt32(txtMinTemp.Text);
                    int max = Convert.ToInt32(txtMaxTemp.Text);
                    int prec = Convert.ToInt32(txtPrec.Text);
                    int hum = Convert.ToInt32(numUpDwnHum.Text);
                    int wind = Convert.ToInt32(numUpDwnWind.Text);


                    Weather weather = new Weather(city, date, min, max, prec, hum, wind);
                    WeatherReport form = new WeatherReport();

                    if (lstCities.SelectedIndex == -1)
                    {
                        WeatherWorker.weathersList.Add(weather);
                        try
                        {
                            StreamWriter sw = new StreamWriter("Weather.txt", true);
                            sw.WriteLine(weather.City + "," + weather.Date + "," + weather.MinTemp +
                                "," + weather.MaxTemp + "," + weather.Prec + "," + weather.Hum + "," + weather.Wind);
                            sw.Close();
                            MessageBox.Show("Weather Saved Sucessfully");
                            refreshUI();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        WeatherWorker.weathersList.Remove(weather);
                        WeatherWorker.weathersList[lstCities.SelectedIndex] = weather;

                        try
                        {
                            StreamWriter sw = new StreamWriter("Weather.txt");
                            foreach (Weather item in WeatherWorker.weathersList)
                            {
                                sw.WriteLine(item.City + "," + item.Date + "," + item.MinTemp +
                               "," + item.MaxTemp + "," + item.Prec + "," + item.Hum + "," + item.Wind);
                            }
                            sw.Close();
                            MessageBox.Show("Weather Updated Sucessfully");
                            refreshUI();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Populate Empty fields");
                }

            }

        }

        // This Method reads data stored in the weather textfile
        public void fileReader()
        {
            WeatherWorker.weathersList.Clear();
            string line;
            try
            {
                StreamReader file = new StreamReader("Weather.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] lineParts = line.Split(',');
                    Weather temp = new Weather(lineParts[0], Convert.ToDateTime(lineParts[1]), Convert.ToInt32(lineParts[2]), Convert.ToInt32(lineParts[3]), Convert.ToInt32(lineParts[4]), Convert.ToInt32(lineParts[5]), Convert.ToInt32(lineParts[6]));
                    WeatherWorker.weathersList.Add(temp);
                }
                file.Close();

            }
            catch (FileNotFoundException)
            {
                StreamReader sr = new StreamReader("Weather.txt");
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            WeatherWorker.weathersList.Sort();
            lstCities.Items.Clear();
            foreach (Weather item in WeatherWorker.weathersList)
            {
                lstCities.Items.Add(item.City + " " + item.Date);
            }

        }

        // This method clears the textboxes and sorts the weather list
        public void refreshUI()
        {
            txtCity.Clear();
            dtpDate.ResetText();
            txtMinTemp.Clear();
            txtMaxTemp.Clear();
            numUpDwnHum.ResetText();
            txtPrec.Clear();
            numUpDwnWind.ResetText();

            WeatherWorker.weathersList.Sort();
            lstCities.Items.Clear();
            foreach (Weather item in WeatherWorker.weathersList)
            {
                lstCities.Items.Add(item.City + " " + item.Date);
            }
        }
    }
}
