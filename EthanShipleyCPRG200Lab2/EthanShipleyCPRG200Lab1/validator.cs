using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthanShipleyCPRG200Lab2
{
    public static class validator
    {
        // tests if a text box is not empty (required fields)
        public static bool IsProvided(TextBox tb)//, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if (tb.Text.Trim() == "") //empty txt box
            {
                result = false;
                MessageBox.Show("Power is required.", "Data entry error");
                tb.Focus();
            }
            return result;
        }
        //tests if input is a non-negative integer
        public static bool IsNonNegativeInt(TextBox tb)
        {
            bool result = true;
            int num; // parsed number
            if(!Int32.TryParse(tb.Text.Trim(), out num))//if not integer
            {
                result = false;
                MessageBox.Show("Power has to be an integar", " Data Entry Error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative
            {
                if (num < 0)
                {   
                    result = false;
                    MessageBox.Show("Power has to be a non-negative integar", " Data Entry Error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }
        //tests if input is a non-negative double
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double num; // parsed number
            if (!Double.TryParse(tb.Text.Trim(), out num))//if not integer
            {
                result = false;
                MessageBox.Show(name + " has to be a decimal number", " Data Entry Error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " has to be a non-negative integar", " Data Entry Error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }
        //tests if input is a non-negative int for the account number
        public static bool IsAcctNo(TextBox tb)
        {
            bool result = true;
            int num; // parsed number
            if (!Int32.TryParse(tb.Text.Trim(), out num))//if not integer
            {
                result = false;
                MessageBox.Show("Account number has to be an integar", " Data Entry Error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show("Account number has to be a non-negative integar", " Data Entry Error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }
    }
}
