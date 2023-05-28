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

            if (rememberCheckBox.Checked == true)
            {
                Properties.Settings.Default.Username = usernameTxtBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Save();
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            SignUp regForm = new SignUp();
            regForm.Show();
            this.Close();
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.PasswordChar == '•')
            {
                // Show the password characters
                passwordTxtBox.PasswordChar = '\0';
                showPassBtn.Image = Properties.Resources.hidePass;
            }
            else
            {
                // Hide the password characters
                passwordTxtBox.PasswordChar = '•';
                showPassBtn.Image = Properties.Resources.showPass;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            // Adjust corner radius
            usernamePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, usernamePanel.Width, usernamePanel.Height, 40, 40));
            passwordPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, passwordPanel.Width, passwordPanel.Height, 40, 40));
            registerBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, registerBtn.Width, registerBtn.Height, 40, 40));
            loginBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginBtn.Width, loginBtn.Height, 40, 40));
            showPassBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, showPassBtn.Width, showPassBtn.Height, 40, 40));

            // Assuming you have a button named "myButton" on your form
            fbBtn.MouseEnter += Button_MouseEnter;
            fbBtn.MouseEnter += Button_MouseLeave;
            googBtn.MouseEnter += Button_MouseEnter;
            googBtn.MouseLeave += Button_MouseLeave;
            twtBtn.MouseEnter += Button_MouseEnter;
            twtBtn.MouseLeave += Button_MouseLeave;

            // Transparent background for labels
            signUp1Lbl.Parent = wpSignupPbx;
            signUp1Lbl.BackColor = Color.Transparent;
            signUp1Lbl.Location = new Point(57, 280);
            signUp2Lbl.Parent = wpSignupPbx;
            signUp2Lbl.BackColor = Color.Transparent;
            signUp2Lbl.Location = new Point(72, 350);
            loginClose.Parent = wpSignupPbx;
            loginClose.BackColor = Color.Transparent;
            loginClose.Location = new Point(445, 10);
            loginRestore.Parent = wpSignupPbx;
            loginRestore.BackColor = Color.Transparent;
            loginRestore.Location = new Point(410, 10);
            loginMinimize.Parent = wpSignupPbx;
            loginMinimize.BackColor = Color.Transparent;
            loginMinimize.Location = new Point(375, 10);

            usernameTxtBox.Text = Properties.Settings.Default.Username;
            if (usernameTxtBox.Text != "")
            {
                rememberCheckBox.Checked = true;
            }
            else
            {
                rememberCheckBox.Checked = false;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.WhiteSmoke;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = SystemColors.Control;
        }

        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginRestore_Click(object sender, EventArgs e)
        {
            /*if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                loginRestore.Image = Properties.Resources.loginRestore1;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                loginRestore.Image = Properties.Resources.loginMaximize;
            }*/
        }

        private void loginMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
