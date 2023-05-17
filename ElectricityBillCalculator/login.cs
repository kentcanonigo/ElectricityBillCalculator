using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;


namespace ElectricityBillCalculator
{
    public partial class login : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=testBC");
        MySqlCommand command;
        MySqlDataReader reader;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            string query = "SELECT * FROM userinfo WHERE user_name='" + username + "' AND user_pass ='" + password + "'";

            command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                    usernameTxtBox.Clear();
                    passwordTxtBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "" || passwordTxtBox.Text == "")
            {
                MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string query = "INSERT INTO userinfo (user_name, user_pass) VALUES(@username, @password)";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", usernameTxtBox.Text);
                command.Parameters.AddWithValue("@password", passwordTxtBox.Text);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("New account created!", "Success!", MessageBoxButtons.OK);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.PasswordChar == '•')
            {
                // Show the password characters
                passwordTxtBox.PasswordChar = '\0';
                showPassBtn.Image = Properties.Resources.showPass;
            }
            else
            {
                // Hide the password characters
                passwordTxtBox.PasswordChar = '•';
                showPassBtn.Image = Properties.Resources.hidePass;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            // Adjust corner radius
            usernameTxtBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, usernameTxtBox.Width, usernameTxtBox.Height, 40, 40));
            passwordTxtBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, passwordTxtBox.Width, passwordTxtBox.Height, 40, 40));
            registerBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, registerBtn.Width, registerBtn.Height, 40, 40));
            
            // Assuming you have a button named "myButton" on your form
            fbBtn.MouseEnter += Button_MouseEnter;
            fbBtn.MouseEnter += Button_MouseLeave;
            googBtn.MouseLeave += Button_MouseLeave;
            twtBtn.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.LightGray;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = SystemColors.Control;
        }
    }
}
