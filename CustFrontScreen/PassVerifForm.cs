/*
 * Author: sd
 * Date: 29/3/2017
 * Time: 12:48 PM
 * Version: 3.0
 * Brief: Class for password verification to exit Front Screen application. 
 */

using System;
using System.Windows.Forms;

namespace CustReceptionArea
{
    /// <summary>
    /// This form is to verify that the correct password has been entered
    /// in order to exit the main CustQueueForm application.
    /// This is to prevent unauthorised individuals (i.e.
    /// non-staff members) from exiting the program.
    /// </summary>
    public partial class PassVerifForm : Form
    {
        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
        public PassVerifForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates password entered to exit the application.
        /// </summary>
        private void PassVerifButtonClick(object sender, EventArgs e)
        {
            if(passTextBox.Text.Equals("0012"))
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Incorrect password!");
                passTextBox.Text = "";
            }// end if
        }

        /// <summary>
        /// Prevents application from exiting if Alt-F4 is pressed.
        /// </summary>
        private void PassVerifFormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }// end if
        }// end PassVerifFormKeyDown
    }// end partial class
}
