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
    public partial class Form2 : Form
    {
        public Form2(string myName)
        {
            // Here i am creating a constructor for the form2
            // I am also passing the user from form 1 to form 2
            // The user can see their name when the open to the next windows form. 
            InitializeComponent();
            txtName.Text = myName;


            // Here I am putting 3 columns for the dataGridView so that the user can
            // see what they ordered, quantitiy, and price.
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Coffee", "Coffee");
            dataGridView1.Columns.Add("Qty", "Qty");
            dataGridView1.Columns.Add("Price", "Price");


        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void AddOrUpdateItem(string coffeeName, double price)
        {

            // In here I added a method that will add a new coffee or pastry to the dataGridView. 
            // If it already in the data GridView the user could click the button again and it will update the price and quantity.  
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                // Here it is checking to see if the coffee exists in the DataGridView. 
                // By doing so it will update the price and quantity. 
                // This "if" will check if the coffee is null and match the coffee name parameter. 
                if (row.Cells["Coffee"].Value != null && row.Cells["Coffee"].Value.ToString() == coffeeName)
                {
                    // Here I am updating the qty and the price of the coffee/pastry
                    // By putting ++ it will increase the qty by 1. 
                    // The "parse" is used to convert the string to a double. 
                    int qty = int.Parse(row.Cells["Qty"].Value.ToString());
                    qty++;
                    row.Cells["Qty"].Value = qty;

                    // Here I am adding to update the price of the coffee and pastry. 
                    // It will multiply the qty and price, then display them in the datagrid. 
                    row.Cells["Price"].Value = "$" + (qty * price).ToString("0.00");
                    return;
                }
            }

            //Here I am adding a new row to the datagrid view if the coffee and pastry doens't exist.
            dataGridView1.Rows.Add(coffeeName, 1, "$" + price.ToString("0.00"));
        }


        private void ItalianBtn_Click(object sender, EventArgs e)
        {
            // Here whenever the user click the italian coffee button
            // it will add the price and coffee name to the DataGridView
            // and whenever they want more Italian coffe they could keep on clicking. 
            // This will add a new line under the Italian coffee options
          
            AddOrUpdateItem("Italian Coffee", 2.00);


        }

        private void RomanBtn_Click(object sender, EventArgs e)
        {
            // Here  when the user clicks the Roman button, we can add Roman coffee options to the DataGridView
            // it will also add new line under the Italian coffee options
            // Or they could click this one first. 

            AddOrUpdateItem("Roman Coffee", 2.50);


        }

        public void TotalAmountbtn_Click(object sender, EventArgs e)
        {
            // Here when the user clicks the Total Amount button, we can calculate the total
            // and move the total amount into the TotalMoneyAmount textbox
            // Whenever I click the TotalAmountBtn it will calculate the total amount of the options in
            // the DataGridView and display it in the TotalMoneyAmount textbox
            double total = 0.0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Here i am using the if statement and check to see if it is null. 

                if (row.Cells["Price"].Value != null)
                {

                    // Here what I ended up doing was replacing the method to remove the dollar sign from the price and
                    // then being able to parse it to a double to calculate the total. 
                    // Then the total amount will be calcuated by adding the price of each item into the datagridview. 
                    // There are four methods here, one is the replace method that is used to remove the dollar sign, 
                    // The second is the tryparse method to convert the string into a double, the third is the 
                    // "out" that would indicate the method will be able to have a return, and lastly would be the
                    // toString method to be able to format the total of the two decimals. 
                    string priceText = row.Cells["Price"].Value.ToString().Replace("$", "");
                    if (double.TryParse(priceText, out double price))
                    {
                        total += price;
                    }
                }
            }
            TotalMoneyAmount.Text = "$" + total.ToString("0.00");




        }

        private void ItalianPastryBtn_Click(object sender, EventArgs e)
        {
            // Here when the user click the event button it will move it onto the datagrid view. 
            // I got the addorupdateitem method from above
            AddOrUpdateItem("Cannoli Coffee", 2.50);
        }

        private void RussianBtn_Click(object sender, EventArgs e)
        {
            //Here when the user click the event button it will move it onto the datagrid view. 
            AddOrUpdateItem("Russia Coffee", 3.50);
        }

        private void RomanPastryBtn_Click(object sender, EventArgs e)
        {
            // Here the user can choose roman pastry with this button. 
            AddOrUpdateItem("Maritozzi Coffee", 3.50);
        }

        private void RussiaPastryBtn_Click(object sender, EventArgs e)
        {
            // Here the user can click the russia button. 
            AddOrUpdateItem("Pirozhki Coffee", 4.00);
        }

        private void VietnameseBtn_Click(object sender, EventArgs e)
        {
            // Here the user can click the vietnamese button if they choose to drink coffee. 
            AddOrUpdateItem("Vietnamese Coffee", 3.75);
        }

        private void VietnamesePastryBtn_Click(object sender, EventArgs e)
        {
            // Here the user can choose to get the vietnamese pastry. 
            AddOrUpdateItem("Banh Chuoi", 3.98);
        }

        private void ThaiBtn_Click(object sender, EventArgs e)
        {
            // here the user can have a choice for thai. 
            AddOrUpdateItem("Thai Coffee", 4.00);
        }

        private void ThaiPastryBtn_Click(object sender, EventArgs e)
        {
            // Here the user can have the option to choose the thai pastry. 
            AddOrUpdateItem("Thai Mango Cake", 4.23);
        }

        private void MexicanBtn_Click(object sender, EventArgs e)
        {
            // here the user can have the choice to drink the mexican coffee. 
            
            AddOrUpdateItem("Cafe de Olla", 3.75);
        }

        private void MexicanPastryBtn_Click(object sender, EventArgs e)
        {
            // here the user can have the choice of having the mexican sweet bread. 
            AddOrUpdateItem("Pan Dulce", 3.75);
        }

        private void OpenForm3_Click(object sender, EventArgs e)
        {
            // Here when the user clicks the OpenForm3 button, we can open Form3
            // and pass the total amount to it
            Form3 form3 = new Form3(TotalMoneyAmount.Text);
            form3.Show();
           


        }
    }
}
