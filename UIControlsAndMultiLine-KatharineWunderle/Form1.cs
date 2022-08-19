using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIControlsAndMultiLine_KatharineWunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 03/29/2021
    //Goal: Calculate total cost of selected car and added options
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //Declare total and car cost variables
            decimal ttlCst = 0m;
            decimal carCost = 0m;
            //Establish constants for options
            const decimal opt1 = 500m;
            const decimal opt2 = 1000m;
            const decimal opt3 = 2000m;
            //Begin ordered list label with string
            string orderedStr = "YOU ORDERED:" + "\n";
            //INPUT
            //Cost of the car based on selected radio button
            if (car1Rad.Checked == true)
            { carCost = 10000m;
                orderedStr = orderedStr + car1Rad.Text + "\n";
            }
            else if (car2Rad.Checked == true)
            { carCost = 18000m; 
                orderedStr = orderedStr + car2Rad.Text + "\n";}
            //Verify a car has been selected via radio button
            else if (car1Rad.Checked ==false || car2Rad.Checked ==false)
            {
                MessageBox.Show("Error: Please Select a Car.");
                return;
            }
            //Total cost starts with cost of chosen car
            ttlCst = carCost;
            //Display no options if none are checked
            if (opt1Chk.Checked == false && opt2Chk.Checked == false && opt3Chk.Checked == false)
            {
                orderedStr = orderedStr + "Options: None";
            }
            //Add option 1 to total and ordered list
            if (opt1Chk.Checked == true)
            {
                ttlCst += opt1;
                orderedStr = orderedStr + opt1Chk.Text + "\n";
            }
            //Add option 2 to total and ordered list
            if (opt2Chk.Checked == true)
            {
                ttlCst += opt2;
                orderedStr = orderedStr + opt2Chk.Text + "\n";
            }
            //Add option 3 to total and ordered list
            if (opt3Chk.Checked == true)
            {   ttlCst += opt3;
                orderedStr = orderedStr + opt3Chk.Text + "\n";
            }
            //OUTPUT
            //Display Total cost and display list of total order
            ttlCstOtpt.Text = ttlCst.ToString("c");
            ordrOtpt.Text = orderedStr;
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear radio buttons
            car1Rad.Checked = false;
            car2Rad.Checked = false;
            //Clear checkboxes
            opt1Chk.Checked = false;
            opt2Chk.Checked = false;
            opt3Chk.Checked = false;
            //Clear cost and ordered list labels
            ttlCstOtpt.Text = "";
            ordrOtpt.Text = "";
        }
    }
}
