using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ElectricityBillCalculator
{
    public partial class SignUp : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=testBC");
        MySqlCommand command;
        bool isUsernameGood = false;
        int res = 0;
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

        public SignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            connection.Open();
        }

        PasswordChecker pwchk = new PasswordChecker();

        private void SignUp_Load(object sender, EventArgs e)
        {
            regInfoPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, regInfoPanel.Width, regInfoPanel.Height, 20, 20));
            signupBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signupBtn.Width, signupBtn.Height, 20, 20));
            regUserPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, regUserPanel.Width, regUserPanel.Height, 20, 20));
            regMailPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, regMailPanel.Width, regMailPanel.Height, 20, 20));
            regPassPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, regPassPanel.Width, regPassPanel.Height, 20, 20));
            regConfPassPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, regConfPassPanel.Width, regConfPassPanel.Height, 20, 20));

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            regInfoPanel.BackColor = Color.PowderBlue;
            signupBtn.Enabled = false;
        }

        private void singupBtn_Click(object sender, EventArgs e)
        {
            if (regUserTbx.Text == "" || regPassTbx.Text == "" || regConfPassTbx.Text == "" || regMailTbx.Text == "")
            {
                MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string query = "INSERT INTO userinfo (user_name, user_email, user_pass) VALUES(@username, @email, @password)";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", regUserTbx.Text);
                command.Parameters.AddWithValue("email", regMailTbx.Text);
                if (regPassTbx.Text == regConfPassTbx.Text)
                {
                    command.Parameters.AddWithValue("@password", regConfPassTbx.Text);
                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        command.ExecuteNonQuery();
                        MessageBox.Show("New account created!", "Success!", MessageBoxButtons.OK);
                        login main = new login();
                        main.Show();
                        this.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Passwords should be the same", "Failed", MessageBoxButtons.OK);
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Transparent;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = SystemColors.Control;
        }

        private void regPassShowBtn_Click(object sender, EventArgs e)
        {
            if (regPassTbx.PasswordChar == '•')
            {
                // Show the password characters
                regPassTbx.PasswordChar = '\0';
                regPassShowBtn.Image = Properties.Resources.hidePass;
            }
            else
            {
                // Hide the password characters
                regPassTbx.PasswordChar = '•';
                regPassShowBtn.Image = Properties.Resources.showPass;
            }
        }

        private void regConfPassShowBtn_Click(object sender, EventArgs e)
        {
            if (regConfPassTbx.PasswordChar == '•')
            {
                // Show the password characters
                regConfPassTbx.PasswordChar = '\0';
                regConfPassShowBtn.Image = Properties.Resources.hidePass;
            }
            else
            {
                // Hide the password characters
                regConfPassTbx.PasswordChar = '•';
                regConfPassShowBtn.Image = Properties.Resources.showPass;
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            login main = new login();
            main.Show();
            this.Close();
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
            regPassTbx.Text = result.ToString();
        }

        string message = string.Empty;

        private void regPassTbx_TextChanged(object sender, EventArgs e)
        {
            res = pwchk.IsStrong(regPassTbx.Text, out message);
            if (res == 0)
            {
                CheckConditions(res, isUsernameGood);
                passwordCheckerBtn.BackColor = Color.Red;
            }
            else if (res == 1)
            {
                CheckConditions(res, isUsernameGood);
                passwordCheckerBtn.BackColor = Color.Yellow;
            }
            else if (res == 2)
            {
                CheckConditions(res, isUsernameGood);
                passwordCheckerBtn.BackColor = Color.DarkGreen;
            }
            pwCheckerTooltip.SetToolTip(passwordCheckerBtn, message);
        }

        private void CheckConditions(int passStrength, bool isUsernameGood)
        {
            if (passStrength > 0 && isUsernameGood) //Check if both password strength and username are good
            {
                signupBtn.Enabled = true;
            }
            else
                signupBtn.Enabled = false;
        }

        private void regUserTbx_TextChanged(object sender, EventArgs e)
        {
            using (connection)
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM userinfo WHERE user_name = @Username", connection);
                command.Parameters.AddWithValue("@Username", regUserTbx.Text);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0 || regUserTbx.Text == String.Empty)
                {
                    usernameCheckerPic.Image = Properties.Resources.rcLxML7Ri2;
                    usernameTooltip.ToolTipIcon = ToolTipIcon.Warning;
                    usernameTooltip.SetToolTip(usernameCheckerPic, "Username is already taken!");
                    isUsernameGood = false;
                }
                else
                {
                    isUsernameGood = true;
                    CheckConditions(res, isUsernameGood);
                    usernameTooltip.ToolTipIcon = ToolTipIcon.Info;
                    usernameTooltip.SetToolTip(usernameCheckerPic, "Username is available!");
                    usernameCheckerPic.Image = Properties.Resources.checkmark_xxl;
                }
            }
        }
    }
}
