using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePracticeWayne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HockeyButton_Click(object sender, EventArgs e)
        {
            string name = "Wayne Gretzky";
            int jersey = 99;

            textLabel.Text = $"{name} is number {jersey}";
            costLabel.Text = "";
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;

            textLabel.Text = $"The area of a circle with a radius of {radius}cm is {area}cm^2";
            costLabel.Text = "";
        }

        private void CarpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = costPerMeter * area;

            textLabel.Text = $"The area of a room with dimensions {length}m * {width}m is {area}m^2";
            textLabel.Text += $"\n\nThe cost to carpet this area at {costPerMeter} per square meter is ${totalCost}";
            costLabel.Text = "";
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            double shirtCost = 12.49;
            double amountPaid = 20;
            double tax = 0.13;
            double taxAmount = shirtCost * tax;
            double changeDue = amountPaid - shirtCost - taxAmount;
            double totalCharge = shirtCost + taxAmount;

            textLabel.Text = "Bill of Sale";
            textLabel.Text += $"\n\nShirt:";
            textLabel.Text += $"\n\nTax:";
            textLabel.Text += $"\nTotal:";
            textLabel.Text += $"\n\nTendered:";
            textLabel.Text += $"\nChange";

            costLabel.Text = $"\n\n{shirtCost.ToString("C")}";
            costLabel.Text += $"\n\n{taxAmount.ToString("C")}";
            costLabel.Text += $"\n{totalCharge.ToString("C")}";
            costLabel.Text += $"\n\n{amountPaid.ToString("C")}";
            costLabel.Text += $"\n{changeDue.ToString("C")}";
        }
    }
}
