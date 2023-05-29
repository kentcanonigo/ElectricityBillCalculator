using MySql.Data.MySqlClient;
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

namespace ElectricityBillCalculator
{
    public partial class forgotPass : Form
    {

        int res = 0;
        PasswordChecker pwchk = new PasswordChecker();

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

        public forgotPass()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
        }

        private void forgotPass_Load(object sender, EventArgs e)
        {
            regInfoPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, regInfoPanel.Width, regInfoPanel.Height, 20, 20));
            resetPassBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resetPassBtn.Width, resetPassBtn.Height, 20, 20));
            checkUsernamePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, checkUsernamePanel.Width, checkUsernamePanel.Height, 20, 20));
            checkEmailPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, checkEmailPanel.Width, checkEmailPanel.Height, 20, 20));
            newPassPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, newPassPanel.Width, newPassPanel.Height, 20, 20));
            newPassConfPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, newPassConfPanel.Width, newPassConfPanel.Height, 20, 20));

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            regInfoPanel.BackColor = Color.PowderBlue;
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            login main = new login();
            main.Show();
            this.Close();
        }

        private void CheckConditions(int passStrength)
        {
            if (passStrength > 0) //Check if both password strength and username are good
            {
                resetPassBtn.Enabled = true;
            }
            else
                resetPassBtn.Enabled = false;
        }

        string message = string.Empty;

        private void newPassTbx_TextChanged(object sender, EventArgs e)
        {
            res = pwchk.IsStrong(newPassTbx.Text, out message);
            if (res == 0)
            {
                CheckConditions(res);
                passwordCheckerBtn.BackColor = Color.Red;
            }
            else if (res == 1)
            {
                CheckConditions(res);
                passwordCheckerBtn.BackColor = Color.Yellow;
            }
            else if (res == 2)
            {
                CheckConditions(res);
                passwordCheckerBtn.BackColor = Color.DarkGreen;
            }
            resetPassToolTip.SetToolTip(passwordCheckerBtn, message);
        }

        private void generatePassBtn_Click(object sender, EventArgs e)
        {
            if (generateLengthCbx.Text == "8 Char")
            {
                PasswordGenerator(8);
            }
            else if (generateLengthCbx.Text == "10 Char")
            {
                PasswordGenerator(10);
            }
            else if (generateLengthCbx.Text == "12 Char")
            {
                PasswordGenerator(12);
            }
            else
            {
                MessageBox.Show("Select the Length for your password", "Password Length", MessageBoxButtons.OK);
            }
        }

        public void PasswordGenerator(int length)
        {
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();

            while (0 < length--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);
            }
            newPassTbx.Text = result.ToString();
        }

        private void newPassShowBtn_Click(object sender, EventArgs e)
        {
            if (newPassTbx.PasswordChar == '•')
            {
                // Show the password characters
                newPassTbx.PasswordChar = '\0';
                newPassShowBtn.Image = Properties.Resources.hidePass;
            }
            else
            {
                // Hide the password characters
                newPassTbx.PasswordChar = '•';
                newPassShowBtn.Image = Properties.Resources.showPass;
            }
        }

        private void newPassConfShowBtn_Click(object sender, EventArgs e)
        {
            if (newPassConfTbx.PasswordChar == '•')
            {
                // Show the password characters
                newPassConfTbx.PasswordChar = '\0';
                regConfPassShowBtn.Image = Properties.Resources.hidePass;
            }
            else
            {
                // Hide the password characters
                newPassConfTbx.PasswordChar = '•';
                regConfPassShowBtn.Image = Properties.Resources.showPass;
            }
        }

        MySqlCommand command;
        MySqlDataReader reader;
        string connectionString = "server=localhost;user=root;password=;database=testBC";
        string usernameToFind = String.Empty;
        string emailToFind = String.Empty;
        string foundUsername = String.Empty;
        string foundEmail = String.Empty;
        bool isUsernameExist = false;
        bool isEmailExist = false;

        private void checkUsernameTbx_TextChanged(object sender, EventArgs e)
        {
            usernameToFind = checkUsernameTbx.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_name FROM userinfo WHERE user_name = @username";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", usernameToFind);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundUsername = reader.GetString("user_name");
                            isUsernameExist = true;
                        }
                        else
                        {
                            isUsernameExist = false;
                        }
                    }
                }
            }
        }

        private void checkEmailTbx_TextChanged(object sender, EventArgs e)
        {
            emailToFind = checkEmailTbx.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_email FROM userinfo WHERE user_email = @usermail";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usermail", emailToFind);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundEmail = reader.GetString("user_email");
                            isEmailExist = true;
                        }
                        else
                        {
                            isEmailExist = false;
                        }
                    }
                }
            }
        }

        private void resetPassBtn_Click(object sender, EventArgs e)
        {
            if (isEmailExist && isUsernameExist && newPassTbx.Text == newPassConfTbx.Text && res > 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM userinfo WHERE user_name = @column1 AND user_email = @column2";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@column1", foundUsername);
                        command.Parameters.AddWithValue("@column2", foundEmail);

                        int matchingRowsCount = Convert.ToInt32(command.ExecuteScalar());

                        if (matchingRowsCount > 0)
                        {
                            using (MySqlCommand command2 = new MySqlCommand("UPDATE userinfo SET user_pass = @newPassword WHERE user_name = @username", connection))
                            {
                                command2.Parameters.AddWithValue("@newPassword", newPassTbx.Text);
                                command2.Parameters.AddWithValue("@username", checkUsernameTbx.Text);

                                int rowsAffected = command2.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Password updated successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("User not found or password update failed.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username or Email does not match");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Username or Email does not exist.");
            }
        }
    }
}
