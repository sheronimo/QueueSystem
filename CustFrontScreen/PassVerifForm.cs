/*
 * Author: sd
 * Name: Password Verification Form
 * Creation Date: 29/03/2017
 * Creation Time: 9:51 AM (GMT+7)
 */

using System;
using System.Windows.Forms;

namespace CustReceptionArea
{
    /// <summary>
    /// The Password Verification Form class prevents unauthorised individuals
    /// from exiting the main application.
    /// </summary>
    public partial class PassVerifForm : Form
    {
        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
        public PassVerifForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();
        }

        /// <summary>
        /// Validates password input.
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
                passTextBox.Text.Equals("");
            }
        }

        /// <summary>
        /// Prevents form from closing if Alt-F4 is pressed.
        /// </summary>
        private void PassVerifFormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
