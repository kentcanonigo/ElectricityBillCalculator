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
    public partial class SignUp : Form
    {

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
        }

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

        }

        private void singupBtn_Click(object sender, EventArgs e)
        {

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

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login main = new login();
            main.Show();
            this.Close();
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
    }
}
