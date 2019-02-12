using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EthanShipleyCPRG200Lab2
{
    
    public partial class Form1 : Form
    {
        /* Calculates a customers cost for their power consumption
         * Author: Ethan Shipley
         * Date: December 2018
         */

        // Cost and multiplication constants for types of customers
        const decimal RES_COST = 6.00m;  //residential initial cost
        const decimal RES_MULT = 0.052m; //residential cost multiplier
        const decimal CON_COST = 60.00m; //commercial initial cost
        const decimal COMMULT = 0.045m; //commercial cost multiplier
        const decimal IND_COST = 76.00m; //industrial peak hour initial cost
        const decimal IND_MULT = 0.065m; //industrial peak hour cost multiplier
        const decimal IND_OFF_PK_COST = 40.00m;    //industrial off-peak hour initial cost
        const decimal IND_OFF_PK_MULT = 0.028m;    //industrial off-peak hour cost multiplier
        const decimal CAP = 1000; // for the first 1000 kWh
        List<CustomerData.Customer> customers = new List<CustomerData.Customer>(); // empty list of customers
        char cust = 'R'; // sets the default customer id to 1

        public Form1()
        {
            InitializeComponent();
            lblPkPwr.Visible = false; //hides the Peak power label
            lblOffPk.Visible = false; //hides the off peak power label
            txtOffPk.Visible = false; //hides the off peak power text

        }

        // Clears the texts fields in the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalcChrg.Text = "";
            txtPwrConsump.Text = "";
            txtAcctNo.Text = "";
            txtCustName.Text = "";
            txtOffPk.Text = "";
            txtAcctNo.Focus();
            lblPkPwr.Visible = false;
            lblOffPk.Visible = false;
            txtOffPk.Visible = false;
            radRes.Checked = true;

        }

        // Closes the form if button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // function
        // Calculates the cost of power based on the radial button selected
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // initializes the variables
            decimal chrg=0; // charge amount
            
            //validates that user entered a positive integer for account number, peak power consumption, and off peak power
            if(validator.IsProvided(txtPwrConsump) && validator.IsNonNegativeInt(txtPwrConsump) && validator.IsAcctNo(txtAcctNo))
            {
                // Creates customer c with the customer name and account number
                CustomerData.Customer c = new CustomerData.Customer(cust,txtCustName.Text.Trim(), Convert.ToInt32(txtAcctNo.Text.Trim()));
                if (cust=='R' || cust=='C')
                {
                    c.CalculateCharge(Convert.ToInt32(txtPwrConsump.Text));
                }
                else if (cust == 'I' && (validator.IsProvided(txtOffPk) && validator.IsNonNegativeInt(txtOffPk))) //Is Industrial
                {
                    c.CalculateCharge(Convert.ToInt32(txtPwrConsump.Text),Convert.ToInt32(txtOffPk.Text));
                }
                                
                chrg = c.ChargeAmount;
                
                // checks that chrg is greater than zero else clears the CalcChrg.Text
                if (chrg > 0)
                {
                    customers.Add(c); // adds c customer to the list of customers

                    CustCharge(customers); // performs the customer charge calculation based on customer type
                    
                    txtCalcChrg.Text = chrg.ToString("c");
                    
                    DisplayCustomers();
                    FileIO.WriteData(customers);
                }
                else
                {
                    txtCalcChrg.Text = "";
                }

            }
        }

        // calculates the sum of all the charges
        private void CustCharge(List<CustomerData.Customer> customers)
        {
            int sum = customers.Count; // sum of the number of customers
            txtTotNoCust.Text = sum.ToString(); // displays number of customers

            // calculates the sum of customer charges
            decimal sumChrg = 0; // for the sum off all charges
            foreach (CustomerData.Customer custy in customers)
            {
                sumChrg += custy.ChargeAmount; // sums charges
            }
            txtChrgSum.Text = sumChrg.ToString("c"); // display charges

            //calc the sum of residential customer charges
            decimal sumRes = 0; // for the sum off all resident charges
            foreach (CustomerData.Customer custy in customers)
            {
                //checks if custy is is customer type resident
                if (custy.CustomerType == 'R')
                {
                    sumRes += custy.ChargeAmount; // sums charges
                }
            }
            txtSumRes.Text = sumRes.ToString("c"); // display charges

            //calc the sum of commercial customer charges
            decimal sumCom = 0; // for the sum off all commercial charges
            foreach (CustomerData.Customer custy in customers)
            {
                //checks if custy is is customer type commercial
                if (custy.CustomerType == 'C')
                {
                    sumCom += custy.ChargeAmount; // sums charges
                }
            }
            txtSumCom.Text = sumCom.ToString("c"); // display charges

            //calc the sum of industrial customer charges
            decimal sumInd = 0; // for the sum off all industrial charges
            foreach (CustomerData.Customer custy in customers)
            {
                //checks if custy is is customer type industrial
                if (custy.CustomerType == 'I')
                {
                    sumInd += custy.ChargeAmount; // sums charges
                }
            }
            txtSumInd.Text = sumInd.ToString("c"); // display charges

        }

        // Displays the customer information
        private void DisplayCustomers()
        {
            lstCustomer.Items.Clear(); // start with empty list box
            // go through the list and add each product to the lst box
            foreach (CustomerData.Customer c in customers)
            {
                lstCustomer.Items.Add(c);
            }
        }

        //if user uses the esCAPe key then it esCAPes the form
        protected override bool ProcessDialogKey(Keys keyData)
        {
            //checks if user pressed escape button, closes the form
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        //sets customer id to one if resident
        private void radRes_CheckedChanged(object sender, EventArgs e)
        {
            cust = 'R';
            lblPwrConsump.Visible = true;// makes the power consumption text appear
            lblPkPwr.Visible = false; //hides the Peak power label
            lblOffPk.Visible = false; //hides the off peak power label
            txtOffPk.Visible = false; //hides the off peak power text
        }

        //sets customer id to two if commercial
        private void radCom_CheckedChanged(object sender, EventArgs e)
        {
            cust = 'C';
            lblPwrConsump.Visible = true;// makes the power consumption text appear
            lblPkPwr.Visible = false; //hides the Peak power label
            lblOffPk.Visible = false; //hides the off peak power label
            txtOffPk.Visible = false; //hides the off peak power text
        }

        //sets customer id to three if industrial off-peak hours
        private void radInd_CheckedChanged(object sender, EventArgs e)
        {
            cust = 'I';
            lblPkPwr.Visible = true;      //shows the peak power text
            lblPwrConsump.Visible = false;// makes the power consumption text dissappear
            lblOffPk.Visible = true; //shows the off peak power label
            txtOffPk.Visible = true; //shows the off peak power text
        }

        // read products data from file and display
        private void Form1_Load(object sender, EventArgs e)
        {
            customers = FileIO.ReadData();
            CustCharge(customers);
            DisplayCustomers();
        }
    
    }
}
