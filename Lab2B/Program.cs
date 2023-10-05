/*
 Class:  Program.cs
 Author: Sujan Rokad
 Date:   October 5, 2023

 Purpose: This class serves as the entry point for the Hair Salon Pricing Calculator application, running its graphical user interface (GUI).
          Users select a hairdresser, services, client type, and visits to calculate the total salon price.

 Authorship statement: I, Sujan Rokad, 000882948 certify that this material is my origianl work. No other person's work has been used                      without due acknowledgement.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2B
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
