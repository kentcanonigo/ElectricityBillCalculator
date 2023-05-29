using MySql.Data.MySqlClient;
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
    public partial class history : Form
    {
        string username;
        string connectionString = "server=localhost;user=root;password=;database=testBC";

        public history(string username)
        {
            InitializeComponent();
            this.username = username;
            UpdateHistory();
        }

        // Variables to store the column values
        List<float> monthlyCost = new List<float>();
        List<float> yearlyCost = new List<float>();

        private bool UpdateHistory()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand($"SELECT monthly_cost, yearly_cost FROM {username}", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            float currMonthlyCost = reader.GetFloat(0);  // Index 0 corresponds to the 2nd column
                            float currYearlyCost = reader.GetFloat(1);  // Index 1 corresponds to the 3rd column

                            monthlyCost.Add(currMonthlyCost);
                            yearlyCost.Add(currYearlyCost);
                        }
                    }
                }
            }

            // Use the column values as needed
            for (int i = 0; i < monthlyCost.Count; i++)
            {
                float currentMonthlyCost = monthlyCost[i];
                float currentYearlyCost = yearlyCost[i];

                historyListbox.Items.Add(new Calculation(i, currentMonthlyCost, currentYearlyCost));
            }
            return true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historyListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (historyListbox.Items.Count <= 0)
            {
                ResetFields();
            }
        }

        private void ResetFields()
        {
            monthlyTbx.Text = String.Empty;
            yearlyTbx.Text = String.Empty;
        }

        private void historyListbox_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculation currentCalc = (Calculation)historyListbox.SelectedItem;
            if (currentCalc == null) //Return if there is no current appliance
            {
                return;
            }
            UpdateInfo(currentCalc);
        }

        private void UpdateInfo(Calculation calculation)
        {
            monthlyTbx.Text = calculation.monthlyCost.ToString();
            yearlyTbx.Text = calculation.yearlyCost.ToString();
        }
    }
}
