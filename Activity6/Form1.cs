using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity6
{
    public partial class activity6PoundsToOuncesConversion : Form
    {
        public activity6PoundsToOuncesConversion()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Create variables
            double pounds;
            double ounces = 16.000;
            double total;


            try //Begin of exception handling. 
            {
                // Gather data from user
                pounds = double.Parse(userInputPounds.Text);

                // Perform conversion, lbs(16)
                total = pounds * ounces;

                // Display Result in totalOunces control
                userOuncesTotal.Text = total.ToString("n3"); // The "n3" is a number format argument to the string method that creates a conversion of a max of 3 decimals to the right of the "DOT". 

            }
            catch (FormatException) // The end of exception handling "throws an exception". 
            {
                MessageBox.Show("Please enter a numeric value!!!");
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
