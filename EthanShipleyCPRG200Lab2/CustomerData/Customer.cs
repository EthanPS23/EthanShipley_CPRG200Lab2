using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        /* Creates a class containing customer to perform calculations
         * Author: Ethan Shipley
         * Date: December 2018
         */

        //private data
        private int accountNo; // store customer account number private
        private string customerName; // store customer name private
        private char customerType; // store customer type private
        private decimal chargeAmount; // store customer charge amount private

        //public account number, get and sets account number. Verifies positive int
        public int AccountNo
        {
            get { return accountNo; }
            set
            {
                if (value>=0)
                {
                    accountNo = value;
                }
            }
        }

        // public customer name, get and sets customer name
        public string CustomerName { get; set; }
        // public customer type, get and sets customer type, verifies that it is char of R, C or I
        public char CustomerType
        {
            get { return customerType; }
            set
            {
                if (value=='R' || value=='C' || value =='I')
                {
                    customerType = value;
                }
            }
        }

        // checks that the charge amount is greater than zero, gets and sets chargeamount
        public decimal ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
                if (value >= 0)
                {
                    chargeAmount = value;
                }
            }
        }

        //constructor of customer
        public Customer(char ct = 'R',string cn="Unknown", int an = 0, decimal ca = 0)
        {
            accountNo = an; // an is account number
            customerName = cn; // cn is customer name
            customerType = ct; // ct is customer type
            chargeAmount = ca; // ca is charge amount for customer
        }

        //create a method that calculates the the customer charge amount
        // according toi the rules
        public decimal CalculateCharge(int kwh, decimal kwh_Off_Pk=0)
        {
            const decimal RES_COST = 6.00m;  //residential initial cost
            const decimal RES_MULT = 0.052m; //residential cost multiplier
            const decimal CON_COST = 60.00m; //commercial initial cost
            const decimal COMMULT = 0.045m; //commercial cost multiplier
            const decimal IND_COST = 76.00m; //industrial peak hour initial cost
            const decimal IND_MULT = 0.065m; //industrial peak hour cost multiplier
            const decimal IND_OFF_PK_COST = 40.00m;    //industrial off-peak hour initial cost
            const decimal IND_OFF_PK_MULT = 0.028m;    //industrial off-peak hour cost multiplier
            const decimal CAP = 1000; // for the first 1000 kWh
            
            // Checks the customer type in order to determine which calculation to perform for the
            // chargeamount
            if (customerType == 'R')
            {
                chargeAmount = RES_COST + RES_MULT * kwh;
            }
            else if (customerType == 'C')
            {
                if (kwh > CAP)
                {
                    chargeAmount = CON_COST + COMMULT * (kwh - CAP);
                }
                else
                {
                    chargeAmount = CON_COST;
                }
            }
            else if (customerType == 'I')
            {
                if (kwh > CAP)
                {
                    chargeAmount = (IND_COST + IND_MULT * (kwh - CAP))+(IND_OFF_PK_COST + IND_OFF_PK_MULT * (kwh - CAP));
                }
                else
                {
                    chargeAmount = IND_COST+ IND_OFF_PK_COST;
                }
            }
            return chargeAmount;
        }

        // modify the ToString() to display the needed data
        public override string ToString()
        {
            return "Account No.: " + accountNo.ToString() + ", " + customerName.ToString() +
                ", Customer Type: " + customerType.ToString() + ", Charge Amount " +
                chargeAmount.ToString("c");
        }

        // ToFileString() outputs the customer information into a comma separated line for a text file 
        public string ToFileString()
        {
            return accountNo.ToString() + "," + customerName.ToString() +
                "," + customerType.ToString() + "," +
                chargeAmount.ToString();
        }
    }
}
