using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ElectricityBillCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Init();
        }

        private void Init() //Testing purposes (Two test appliances on startup)
        {
            applianceList.Items.Add(new Appliance("Test Appliance", 50, 24)); //Create a test appliance to start
            applianceList.Items.Add(new Appliance("Test Appliance 2", 25, 16)); //Create a test appliance to start
        }

        private bool alreadyExist(string _text, ref char KeyChar) //Checks if a period already exists in a textbox.
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            Form2 addNewAppForm = new Form2(applianceList);
            addNewAppForm.ShowDialog();
        }

        private void customRateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!customRateCheckbox.Checked)
            {
                kwhRateTextbox.Text = "14.28";
            }
            kwhRateTextbox.Enabled = !kwhRateTextbox.Enabled;
        }

        private void kwhRateTextbox_KeyPress(object sender, KeyPressEventArgs e) //Only allows 1 period and 2 decimals in textbox
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (kwhRateTextbox.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (kwhRateTextbox.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(kwhRateTextbox.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (kwhRateTextbox.SelectionStart != kwhRateTextbox.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = kwhRateTextbox.Text.Substring(kwhRateTextbox.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(kwhRateTextbox.Text, ref sepratorChar))
                {
                    int sepratorPosition = kwhRateTextbox.Text.IndexOf(sepratorChar);
                    string afterSepratorString = kwhRateTextbox.Text.Substring(sepratorPosition + 1);
                    if (kwhRateTextbox.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private void wattageTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wattageTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void hrsPerDayTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void applianceList_SelectedValueChanged(object sender, EventArgs e) //Event handling for appliance list. (Update properties)
        {
            Appliance currentAppliance = (Appliance)applianceList.SelectedItem;
            if (currentAppliance == null) //Return if there is no current appliance
            {
                return;
            }
            UpdateInfo(currentAppliance);
        }

        private void UpdateInfo(Appliance currentAppliance)
        {
            float appCost = ((currentAppliance.Wattage * currentAppliance.HrsPerDay) / 1000.0f) * float.Parse(kwhRateTextbox.Text);
            currentAppliance.AppCost = appCost;
            editButton.Enabled = true;
            appNameTextbox.Text = currentAppliance.Name;
            wattageTextbox.Text = currentAppliance.Wattage.ToString();
            hrsPerDayTextbox.Text = currentAppliance.HrsPerDay.ToString();
            appCostTextbox.Text = "₱" + appCost.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (applianceList.Items.Count <= 0)
            {
                return;
            }
            saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Appliance currentAppliance = (Appliance)applianceList.SelectedItem;
            if (currentAppliance == null)
            {
                return;
            }
            currentAppliance.Name = appNameTextbox.Text;
            currentAppliance.Wattage = float.Parse(wattageTextbox.Text);
            currentAppliance.HrsPerDay = float.Parse(hrsPerDayTextbox.Text);
            saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = false;
            UpdateInfo(currentAppliance);
            applianceList.DrawMode = DrawMode.OwnerDrawFixed;
            applianceList.DrawMode = DrawMode.Normal;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            while (applianceList.SelectedItems.Count > 0)
            {
                applianceList.Items.RemoveAt(applianceList.SelectedIndex);
            }
            ResetButtons();
        }

        private void applianceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (applianceList.Items.Count <= 0)
            {
                ResetButtons();
            }
        }

        private void ResetButtons()
        {
            appNameTextbox.Text = string.Empty;
            appCostTextbox.Text = string.Empty;
            wattageTextbox.Text = string.Empty;
            hrsPerDayTextbox.Text = string.Empty;
            editButton.Enabled = saveButton.Enabled = appNameTextbox.Enabled = wattageTextbox.Enabled = hrsPerDayTextbox.Enabled = false;
        }

        private void kwhRateTextbox_TextChanged(object sender, EventArgs e)
        {
            Appliance currentAppliance = (Appliance)applianceList.SelectedItem;
            if (currentAppliance == null) //Return if there is no current appliance
            {
                return;
            }
            UpdateInfo(currentAppliance);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            float monthlyCost = 0f;
            float yearlyCost = 0f;

            for (int i = 0; i < applianceList.Items.Count; i++)
            {
                Appliance currentAppliance = (Appliance)applianceList.Items[i];
                currentAppliance.AppCost = ((currentAppliance.Wattage * currentAppliance.HrsPerDay) / 1000.0f) * float.Parse(kwhRateTextbox.Text);
                //MessageBox.Show(currentAppliance.AppCost.ToString());
                monthlyCost += currentAppliance.AppCost;
            }

            monthlyCost *= 30f;
            yearlyCost = monthlyCost * 12f;

            monthlyBillTextbox.Text = "₱" + monthlyCost.ToString();
            yearlyBillTextbox.Text = "₱" + yearlyCost.ToString();
        }


    }
}