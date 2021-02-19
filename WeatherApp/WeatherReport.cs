using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherReport : Form
    {

        public WeatherReport()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fileReader();
            readFavorites();
        }
        // This button takes the user to the weather capture form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeatherCapture form = new WeatherCapture();
            form.ShowDialog();
            this.Close();
        }

        private void radOne_CheckedChanged(object sender, EventArgs e)
        {
            lblCity2.Visible = false;
            cmbCity2.Visible = false;
            cmbCity2.Text = "";
        }

        private void radMultiple_CheckedChanged(object sender, EventArgs e)
        {
            lblCity2.Visible = true;
            cmbCity2.Visible = true;
        }
        // This button takes the user to the favorites form
        private void btnFavorites_Click(object sender, EventArgs e)
        {
            this.Hide();
            FavoriteCities form = new FavoriteCities();
            form.ShowDialog();
            this.Close();
        }
        // This button clears the user interface for new selection
        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.ResetText();
            dtpTo.ResetText();
            radOne.Checked = false;
            radMultiple.Checked = false;
            cmbCity.ResetText();
            cmbCity2.ResetText();
            dataGridView1.Rows.Clear();

        }

        // This Method is used to display the weather forcast within a specific range to the user
        private void btnDisplay_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            if ((dtpFrom.Value == null || dtpTo.Value == null || cmbCity.SelectedItem == null && cmbCity2.SelectedItem == null && cmbFavorite1.SelectedItem == null && cmbFavorite2.SelectedItem == null))
            {
                MessageBox.Show("Please Select a date range and City");
            }
            else if ((dtpFrom.Value > dtpTo.Value))
            {
                MessageBox.Show("Please Select a Valid date Range");
            }
            else if ((dtpFrom.Value != null && dtpTo.Value != null && cmbCity.SelectedItem != null && cmbCity2.SelectedItem == null))
            {

                WeatherWorker.filtered = WeatherWorker.weathersList.Where(w => w.City.Equals(cmbCity.SelectedItem.ToString()) &&
                w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value).OrderBy(wn => wn.Date).ToList();

                foreach (Weather item in WeatherWorker.filtered)
                {
                    dataGridView1.Rows.Add(item.City, item.Date, item.MinTemp, item.MaxTemp, item.Prec, item.Hum, item.Wind);
                }
            }
            else if (dtpFrom.Value != null && dtpTo.Value != null && cmbCity2.SelectedItem != null && cmbCity.SelectedItem != null)
            {
                WeatherWorker.filtered = WeatherWorker.weathersList.Where(w => w.City.Equals(cmbCity.SelectedItem.ToString()) &&
                w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value || w.City.Equals(cmbCity2.SelectedItem.ToString()) &&
                w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value).OrderBy(wn => wn.Date).ToList();

                foreach (Weather item in WeatherWorker.filtered)
                {
                    dataGridView1.Rows.Add(item.City, item.Date, item.MinTemp, item.MaxTemp, item.Prec, item.Hum, item.Wind);

                }

            }
            else if (dtpFrom.Value != null && dtpTo.Value != null && cmbFavorite1.SelectedItem != null && cmbFavorite2.SelectedItem == null)
            {
                WeatherWorker.filtered = WeatherWorker.favoriteList.Where(w => w.City.Equals(cmbFavorite1.SelectedItem.ToString()) &&
                w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value).OrderBy(wn => wn.Date).ToList();

                foreach (Weather item in WeatherWorker.filtered)
                {
                    dataGridView1.Rows.Add(item.City, item.Date, item.MinTemp, item.MaxTemp, item.Prec, item.Hum, item.Wind);

                }

            }
            else if (dtpFrom.Value != null && dtpTo.Value != null && cmbFavorite2.SelectedItem != null && cmbFavorite1.SelectedItem != null)
            {
                WeatherWorker.filtered = WeatherWorker.favoriteList.Where(w => w.City.Equals(cmbFavorite1.SelectedItem.ToString()) &&
                w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value || w.City.Equals(cmbFavorite2.SelectedItem.ToString()) &&
                w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value).OrderBy(wn => wn.Date).ToList();

                foreach (Weather item in WeatherWorker.filtered)
                {
                    dataGridView1.Rows.Add(item.City, item.Date, item.MinTemp, item.MaxTemp, item.Prec, item.Hum, item.Wind);

                }
            }
            getHighest();
            getLowest();

        }

        // This Method filters and returns the highest Minimum temperature value
        private int highestMinTemp()
        {
            int max = int.MinValue;
            ArrayList theMax = new ArrayList();

            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMax.Add(item.MinTemp);

                }
            }
            foreach (var item in theMax)
            {
                if (Convert.ToInt32(item) > max)
                {
                    max = Convert.ToInt32(item);
                }
            }
            return max;
        }
        // This Method filters and returns the highest Maximum temperature value
        private int highestMaxTemp()
        {
            int max = int.MinValue;
            ArrayList theMax = new ArrayList();

            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMax.Add(item.MaxTemp);

                }
            }
            foreach (var item in theMax)
            {
                if (Convert.ToInt32(item) > max)
                {
                    max = Convert.ToInt32(item);
                }
            }
            return max;
        }
        // This Method filters and returns the highest Precipitation value
        private int highestPrec()
        {
            int max = int.MinValue;
            ArrayList theMax = new ArrayList();
            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMax.Add(item.Prec);

                }
            }
            foreach (var item in theMax)
            {
                if (Convert.ToInt32(item) > max)
                {
                    max = Convert.ToInt32(item);
                }
            }
            return max;
        }
        // This Method filters and returns the highest Humidity value
        private int highestHum()
        {
            int max = int.MinValue;
            ArrayList theMax = new ArrayList();
            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMax.Add(item.Hum);

                }
            }
            foreach (var item in theMax)
            {
                if (Convert.ToInt32(item) > max)
                {
                    max = Convert.ToInt32(item);
                }
            }
            return max;
        }
        // This Method filters and returns the highest Wind value
        private int highestWind()
        {
            int max = int.MinValue;
            ArrayList theMax = new ArrayList();
            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMax.Add(item.Wind);

                }
            }
            foreach (var item in theMax)
            {
                if (Convert.ToInt32(item) > max)
                {
                    max = Convert.ToInt32(item);
                }
            }
            return max;
        }
        // This Method retrieves the highest weather values
        private void getHighest()
        {
            int start = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                start = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                if (highestMinTemp() == int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[2].Value.ToString();
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                start = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                if (highestMaxTemp() == int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[3].Value.ToString();
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
                start = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                if (highestPrec() == int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[4].Value.ToString();
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                start = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                if (highestHum() == int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[5].Value.ToString();
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
                start = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                if (highestWind() == int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[6].Value.ToString();
                    dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Red;
                }

            }
        }
        // This Method filters and returns the lowest Minimum temperature value
        private int lowestMinTemp()
        {
            int min = int.MaxValue;
            ArrayList theMin = new ArrayList();

            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMin.Add(item.MinTemp);

                }
            }
            foreach (var item in theMin)
            {
                if (Convert.ToInt32(item) < min)
                {
                    min = Convert.ToInt32(item);
                }
            }
            return min;

        }
        // This Method filters and returns the lowest Maximum temperature value
        private int lowestMaxTemp()
        {
            int min = int.MaxValue;
            ArrayList theMin = new ArrayList();

            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMin.Add(item.MaxTemp);

                }
            }
            foreach (var item in theMin)
            {
                if (Convert.ToInt32(item) < min)
                {
                    min = Convert.ToInt32(item);
                }
            }
            return min;
        }
        // This Method filters and returns the lowest Precipitation value
        private int lowestPrec()
        {
            int min = int.MaxValue;
            ArrayList theMin = new ArrayList();

            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMin.Add(item.Prec);

                }
            }
            foreach (var item in theMin)
            {
                if (Convert.ToInt32(item) < min)
                {
                    min = Convert.ToInt32(item);
                }
            }
            return min;
        }
        // This Method filters and returns the lowest humidity value
        private int lowestHum()
        {
            int min = int.MaxValue;
            ArrayList theMin = new ArrayList();

            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMin.Add(item.Hum);

                }
            }
            foreach (var item in theMin)
            {
                if (Convert.ToInt32(item) < min)
                {
                    min = Convert.ToInt32(item);
                }
            }
            return min;
        }
        // This Method filters and returns the lowest wind value
        private int lowestWind()
        {
            int min = int.MaxValue;
            ArrayList theMin = new ArrayList();

            foreach (var item in WeatherWorker.filtered)
            {
                if (item.City.Equals(cmbCity.SelectedItem + "") || item.City.Equals(cmbFavorite1.SelectedItem + ""))
                {
                    theMin.Add(item.Wind);

                }
            }
            foreach (var item in theMin)
            {
                if (Convert.ToInt32(item) < min)
                {
                    min = Convert.ToInt32(item);
                }
            }
            return min;
        }
        // This Method retrieves the lowest weather values
        private void getLowest()
        {
            int start = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                start = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                if (lowestMinTemp() == int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[2].Value.ToString();
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Green;
                }
                start = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                if (lowestMaxTemp() == int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[3].Value.ToString();
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Green;
                }
                start = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                if (lowestPrec() == int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[4].Value.ToString();
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                start = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                if (lowestHum() == int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[5].Value.ToString();
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                }
                start = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                if (lowestWind() == int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[6].Value.ToString();
                    dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Green;
                }

            }
        }

        // This Method reads from the weather textfile
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
            dataGridView1.Rows.Clear();

            foreach (Weather item in WeatherWorker.weathersList)
            {

                if (!cmbCity.Items.Contains(item.City))
                {
                    cmbCity.Items.Add(item.City);
                }
                if (!cmbCity2.Items.Contains(item.City))
                {
                    cmbCity2.Items.Add(item.City);
                }
            }

        }

        // This Method reads from the favorite textfile
        public void readFavorites()
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
            dataGridView1.Rows.Clear();

            foreach (Weather item in WeatherWorker.favoriteList)
            {

                if (!cmbFavorite1.Items.Contains(item.City))
                {
                    cmbFavorite1.Items.Add(item.City);
                }
                if (!cmbFavorite2.Items.Contains(item.City))
                {
                    cmbFavorite2.Items.Add(item.City);
                }
            }

        }

        // This method saves the weather report specified by the user onto the report textfile
        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            if (dataGridView1 == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Please Display forcast before saving a report");
            }
            else
            {
                DateTime today = DateTime.Today;
                try
                {
                    StreamWriter file = new StreamWriter("Report.txt", true);
                    file.WriteLine("Date Captured: " + today.ToString("d"));
                    file.WriteLine("");
                    file.WriteLine("\t" + "City" + "\t" + "|" + "\t\t" + "Date" + "\t\t" + "|" + "  Min Temp " + "\t" + "|" + "  Max Temp" + "\t" + "|" + " Precipitation" + "\t" + "|" + "  Humidity" + "\t" + "|" + "  Wind Speed" + "\t" + "|");
                    file.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------");
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            file.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        file.WriteLine("");
                        file.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                    file.Close();
                    MessageBox.Show("Report Successfully Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
        // This method restricts the General user from capturing the weather
        public void disableButton()
        {
            btnAdd.Visible = false;
            btnExit.Visible = true;
        }
        // This button is used to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            string msg = "Are you sure you want to Exit the Application ?";
            string title = "Weather Display";
            d = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
