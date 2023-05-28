using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityBillCalculator
{
    public partial class rate : Form
    {
        public rate()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        private void rateBtn1_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = Color.Yellow;
        }

        private void rateBtn2_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = rateBtn2.BackColor = Color.Yellow;
        }

        private void rateBtn3_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = Color.Yellow;
        }

        private void rateBtn4_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = Color.Yellow;
        }

        private void rateBtn5_Click(object sender, EventArgs e)
        {
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.White;
            rateBtn1.BackColor = rateBtn2.BackColor = rateBtn3.BackColor = rateBtn4.BackColor = rateBtn5.BackColor = Color.Yellow;
        }

        private void starBtn1_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            Graphics graphics = e.Graphics;
            Rectangle buttonBounds = button.ClientRectangle;

            // Clear the button background
            graphics.Clear(button.BackColor);

            // Set the color and thickness for drawing the star
            Pen starPen = new Pen(Color.Yellow, 2);

            // Define the points of the star
            Point[] starPoints =
            {
                new Point(buttonBounds.Width / 2, 0),
                new Point((int)(buttonBounds.Width * 0.65), (int)(buttonBounds.Height * 0.35)),
                new Point(buttonBounds.Width, (int)(buttonBounds.Height * 0.4)),
                new Point((int)(buttonBounds.Width * 0.75), (int)(buttonBounds.Height * 0.65)),
                new Point((int)(buttonBounds.Width * 0.8), buttonBounds.Height),
                new Point(buttonBounds.Width / 2, (int)(buttonBounds.Height * 0.8)),
                new Point((int)(buttonBounds.Width * 0.2), buttonBounds.Height),
                new Point((int)(buttonBounds.Width * 0.25), (int)(buttonBounds.Height * 0.65)),
                new Point(0, (int)(buttonBounds.Height * 0.4)),
                new Point((int)(buttonBounds.Width * 0.35), (int)(buttonBounds.Height * 0.35))
            };

            // Draw the star
            graphics.DrawPolygon(starPen, starPoints);
        }
    }
}
