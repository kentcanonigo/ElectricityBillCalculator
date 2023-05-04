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
    public partial class Form2 : Form
    {
        ListBox _appList;
        public Form2(ListBox appList)
        {
            InitializeComponent();
            _appList = appList;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(addName.Text == "" || addWattage.Text == "" || addHrs.Text == "")
            {
                MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK);
            }

            try
            {
                _appList.Items.Add(new Appliance(addName.Text, Int32.Parse(addWattage.Text), Int32.Parse(addHrs.Text)));
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addWattage_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void addHrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
