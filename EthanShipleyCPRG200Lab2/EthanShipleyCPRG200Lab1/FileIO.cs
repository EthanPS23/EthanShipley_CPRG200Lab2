using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthanShipleyCPRG200Lab2
{
    public static class FileIO
    {
        /* Inputs and outputs customer information to a file
         * Author: Ethan Shipley
         * Date: December 2018
         */
        const string path = "Customers.txt";

        //writes data from the array to the file
        public static void WriteData (List<CustomerData.Customer> customers)
        {
            FileStream fs = null; // sets the file stream
            StreamWriter sw = null; // sets the stream writer

            // tries to open a file and write a line to the the file
            // if it fails to write to the file an error message in displayed
            try
            {
                //open the file for writing; ,overwrite old content
                fs= new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                //write data
                foreach(CustomerData.Customer c in customers)
                {
                    sw.WriteLine(c.ToFileString());
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error While writing to file: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close(); // also closes the fs
                }
                if (fs != null) fs.Close();
            }
        }

        //reads data from the file and puts in an list
        //returns number of elements
        public static List<CustomerData.Customer> ReadData()
        {

            List<CustomerData.Customer> customers = new List<CustomerData.Customer> ();
            FileStream fs=null;
            StreamReader sr = null;
            string line; //for reading
            string[] fields; //result from splitting the line
            //open the file for reading and read numbers into data
            //displays errors if file contains non numeric data
            //or reading the file
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                while(!sr.EndOfStream) //while there is data in the file
                {
                    line = sr.ReadLine();//read the next line
                    fields = line.Split(','); // split the line into fields
                    CustomerData.Customer c = new CustomerData.Customer(Convert.ToChar(fields[2]),Convert.ToString(fields[1]), Convert.ToInt32(fields[0]),Convert.ToDecimal(fields[3]));
                    customers.Add(c);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("File contains non-numeric data. Aborting reading");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while reading file: " +ex.Message, ex.GetType().ToString());
            }
            finally
            {
                //close the file if open
                if(sr!=null) sr.Close();//file stream gets closed too
            }
            return customers;
        }
    }
}
