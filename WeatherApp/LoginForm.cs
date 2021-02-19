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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            readFromFile();
        }

        // This button creates a new user
        private void btnCreate_Click(object sender, EventArgs e)
        {
            createNewUser();
        }

        // This button logs in a user
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnConfChar_Click(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
        }
        private void btnConfChar_Click(object sender, MouseEventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = false;
        }

        private void btnCrtChar_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnCrtChar_Click(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnLoginPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLoginPass_Click(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        // This Method reads the data stored in the textfile
        public void readFromFile()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("Login.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineParts = line.Split(',');
                    Login temp = new Login(lineParts[0], lineParts[1], lineParts[2]);
                    WeatherWorker.login.Add(temp);
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                StreamReader sr = new StreamReader("Login.txt");
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // A Method that encrypts the user's password
        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        // A Method that validates the user's credentials and logs in a user
        public void login()
        {

            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please populate the empty fields");
            }
            else
            {
                for (int i = 0; i < WeatherWorker.login.Count; i++)
                {
                    if (WeatherWorker.login[i].Username == txtUsername.Text && WeatherWorker.login[i].Password == EncodePasswordToBase64(txtPassword.Text))
                    {
                        if (WeatherWorker.login[i].UserType.Equals("Admin"))
                        {
                            WeatherCapture form = new WeatherCapture();
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else if (WeatherWorker.login[i].UserType.Equals("General User"))
                        {
                            WeatherReport form = new WeatherReport();
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            this.Hide();
                            form.disableButton();
                            form.ShowDialog();
                            this.Show();
                        }
                    }
                }
                MessageBox.Show("Please Enter a Valid Username and Password");
            }
        }

        // This Method clears the form for new entry
        private void refreshUI()
        {
            txtCreateUser.Clear();
            txtPass.Clear();
            txtConfirmPass.Clear();
            cmbUserType.ResetText();
        }

        // This Method creates a new user and stores the details in a Textfile
        private void createNewUser()
        {
            string username = txtCreateUser.Text;
            string pass = EncodePasswordToBase64(txtConfirmPass.Text);
            string userType = cmbUserType.Text;

            Login login = new Login(username, pass, userType);
            if (txtCreateUser.Text.Equals("") || txtPass.Text.Equals("") || txtConfirmPass.Text.Equals("") || cmbUserType.SelectedItem == null)
            {
                MessageBox.Show("Please Populate the empty fields");
            }
            else if (txtCreateUser != null && txtPass != null && txtConfirmPass != null || cmbUserType.SelectedItem != null)
            {
                if (txtConfirmPass.Text == txtPass.Text)
                {
                    WeatherWorker.login.Add(login);
                    try
                    {
                        StreamWriter sw = new StreamWriter("Login.txt", true);
                        sw.WriteLine(login.Username + "," + login.Password + "," + login.UserType);
                        sw.Close();
                        MessageBox.Show("User registration Sucessful");
                        refreshUI();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
        }
    }
}
