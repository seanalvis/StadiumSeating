using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Set up the variables
                int classACost = 15;
                int classBCost = 12;
                int classCCost = 9;

                int classASold = int.Parse(classATextBox.Text);
                int classBSold = int.Parse(classBTextBox.Text);
                int classCSold = int.Parse(classCTextBox.Text);


                // Calculate the total by multiplying cost by sold
                // Insert the totals into the labels
                int classATotal = classACost * classASold;
                classALabel.Text = classATotal.ToString("c");

                int classBTotal = classBCost * classBSold;
                classBLabel.Text = classBTotal.ToString("c");

                int classCTotal = classCCost * classCSold;
                classCLabel.Text = classCTotal.ToString("c");

                // Add all totals
                int total = classATotal + classBTotal + classCTotal;
                totalLabel.Text = total.ToString("c");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all of the text boxes by setting their contents
            // to empty.
            classALabel.Text = "";
            classATextBox.Text = "";
            classBLabel.Text = "";
            classBTextBox.Text = "";
            classCLabel.Text = "";
            classCTextBox.Text = "";
            totalLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close out the program.
            this.Close();
        }
    }
}
