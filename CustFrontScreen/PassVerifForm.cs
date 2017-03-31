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
        /// Verifies password entered to exit the application.
        /// </summary>
        /// <param name="sender">Parameter that contains a reference
		/// to the control/object that sent the event.</param>
        /// <param name="e">Parameter that contains event data.</param>
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
        /// <param name="sender">Parameter that contains a reference
		/// to the control/object that sent the event.</param>
        /// <param name="e">Parameter that contains event data.</param>
        private void PassVerifFormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }// end if
        }// end PassVerifFormKeyDown
    }// end partial class
}
