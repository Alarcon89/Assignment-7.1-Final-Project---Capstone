using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelCoffee
{
    public partial class Form3 : Form
    {
        // Here I had to create a constructor from the money being passed over from the total amout
        // from form2. 
        public Form3(string totalAmount)
        {
            InitializeComponent();
            TotalMoneyAmount.Text = totalAmount;

        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            // Here im checking to see if the user has entered a payment amount.
            // by using the double try parse method. 
            // if the user is able to have the sufficient amount for the total 
            // amount it will calculate the change. 
            // here the double parse method is to convert the string to a double also. 
            double total = 0.0;
            double.TryParse(TotalMoneyAmount.Text.Replace("$", ""), out total);

           
            // Here it will check if the payment is good to go and see if the user has entered an amount. 
            // It will also calculate the change if the user gives the right amount. 
            double payment = 0.0;
            if (double.TryParse(Payment.Text, out payment))
            {
                if (payment >= total)
                {

                    // Here will be the calculation of the change by subtracting the total amount from the datagrid view. 
                    // The tostring will be used to format the change to two decimal places. 
                    double change = payment - total;
                    Change.Text = change.ToString("0.00");
                }
                
                // Here I am using the else statement if the user doesn't have the right amount of funds it will send a message. 
                else
                {
                    
                    // Here if the user doesn't put the right amount into the box it will give an error message
                    MessageBox.Show("Insufficient payment!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for payment.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // here the user can exit the application
            // It will say thank you for your purchase
            MessageBox.Show("Thank you for your purchase!", "Goodbye",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
