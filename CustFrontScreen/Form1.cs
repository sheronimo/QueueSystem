/*
 * Author: sd
 * Date: 29/3/2017
 * Time: 12:48 PM
 * Version: 3.0
 * Brief: 
 */

using System;
using System.Windows.Forms;

namespace CustFrontScreen
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Verifies password entered to exit the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passVerifButtonClick(object sender, EventArgs e)
        {
            if(passTextBox.Text.Equals("0012"))
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Incorrect password!");
            }
        }

        /// <summary>
        /// Prevents application from exiting if Alt-F4 is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
