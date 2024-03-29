﻿/*
 Class:  Form1.cs
 Author: Sujan Rokad
 Date:   October 5, 2023

 Purpose: This class represents the main form of the Hair Salon Pricing Calculator application. It provides a graphical user interface (GUI) for users to select a hairdresser, one or more services, a client type, and the number of client visits. Based on these selections, the class calculates the total price for the salon services and displays it to the user.

 Authorship statement: I, Sujan Rokad, 000882948 certify that this material is my original work.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for Cut checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Event handler for Colour checkbox
        private void checkColour_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Event handler for Highlights checkbox
        private void checkHighlights_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Event handler for Extensions checkbox
        private void checkExtensions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Event handler for "Reset" button click
        private void button2_Click(object sender, EventArgs e)
        {
            radioJane.Checked = true;  // Default

            // Uncheck all other services 
            checkCut.Checked = false;
            checkColour.Checked = false;
            checkExtensions.Checked = false;
            checkHighlights.Checked = false;

            radioStandard.Checked = true; // Default

            // Reset number of visits
            textBoxClient.Text = "1";

            // Reset total price
            answerLabel.Text = "0.00";

            // Set focus to first radio button in hairdresser
            radioJane.Focus();
        }

        // Event handler for "Exit" button click
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for "Calculate" button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if at least one service is selected
            if (!checkCut.Checked && !checkColour.Checked && !checkExtensions.Checked && !checkHighlights.Checked)
            {
                // Display an error message if none service selected
                MessageBox.Show("Please select at least one service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkCut.Focus(); // Set focus to the first service checkbox
                return; // Exit the method to prevent further processing
            }

            // Parse and validate the number of client visits
            int numberOfVisits;
            if (!int.TryParse(textBoxClient.Text, out numberOfVisits) || numberOfVisits < 1)
            {
                // Display an error message for invalid input
                MessageBox.Show("Please enter a valid positive integer for Number of Visits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxClient.Focus(); // Set focus to the textBoxClient control
                return; // Exit the method to prevent further processing
            }

            // Initialize variables for pricing
            decimal baseRate = 0;
            decimal serviceRate = 0;
            decimal discountRate = 0;
            decimal visitsDiscountRate = 0;

            // Determine the selected hairdresser's base rate
            if (radioJane.Checked)
            {
                baseRate = 30;
            }
            else if (radioPat.Checked)
            {
                baseRate = 45;
            }
            else if (radioRon.Checked)
            {
                baseRate = 40;
            }
            else if (radioSue.Checked)
            {
                baseRate = 50;
            }
            else if (radioLaura.Checked)
            {
                baseRate = 55;
            }

            // Calculate service rate based on selected services
            if (checkCut.Checked)
                serviceRate += 30;
            if (checkColour.Checked)
                serviceRate += 40;
            if (checkHighlights.Checked)
                serviceRate += 50;
            if (checkExtensions.Checked)
                serviceRate += 200;

            // Determine discount rates based on client type
            if (radioChild.Checked)
                discountRate = 0.10m; // 10%
            else if (radioStudent.Checked)
                discountRate = 0.05m; // 5%
            else if (radioSenior.Checked)
                discountRate = 0.15m; // 15%

            // Calculate discount rate based on the number of visits
            if (int.TryParse(textBoxClient.Text, out numberOfVisits) && numberOfVisits >= 1)
            {
                if (numberOfVisits >= 1 && numberOfVisits <= 3)
                    visitsDiscountRate = 0;
                else if (numberOfVisits >= 4 && numberOfVisits <= 8)
                    visitsDiscountRate = 0.05m; // 5%
                else if (numberOfVisits >= 9 && numberOfVisits <= 13)
                    visitsDiscountRate = 0.10m; // 10%
                else if (numberOfVisits >= 14)
                    visitsDiscountRate = 0.15m; // 15%
            }

            // Calculate total price
            decimal totalPrice = (baseRate + serviceRate) * (1 - discountRate) * (1 - visitsDiscountRate);

            // Display the total price
            answerLabel.Text = "$" + totalPrice.ToString("F2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Hairdresser_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
