using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;

            outputLabel.Text = $"{playerName} is number {playerNumber}";
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double hours = 25;
            double pay = 18.75;
            double earned = hours * pay;

            outputLabel.Text = $"Hours: {hours}";
            outputLabel.Text += $"\nPay: ${pay}";
            outputLabel.Text += $"\nEarned: ${earned}";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = radius * radius * pi;

            outputLabel.Text = $"Radius: {radius}cm";
            outputLabel.Text += $"\nArea: {area}cm^2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = costPerMeter * area;

            outputLabel.Text = $"The area of a room with dimensions {length}m X {width}m is {area}m^2";
            outputLabel.Text += $"\n\nThe cost to carpet this area at {costPerMeter} per square meter is ${totalCost}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            string title = "Bill of Sale";
            double costofshirt = 12.49;
            double tax = 1.62;
            double total = costofshirt + tax;
            double tendered = 20.00;
            double change = tendered - total;

            outputLabel.Text = title ;
            outputLabel.Text += $"\n\nShirt:      {costofshirt}";
            outputLabel.Text += $"\n\n\nTax:         {tax}";
            outputLabel.Text += $"\nTotal:      {total}";
            outputLabel.Text += $"\n\nTendered:   {tendered}";
            outputLabel.Text += $"\nChange:      {change}";
        }
    }
}
