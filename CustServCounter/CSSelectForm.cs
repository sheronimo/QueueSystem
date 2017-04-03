/*
 * Author: sd
 * Project Name: CS Selection Form
 * Creation Date: 03/04/2017
 * Creation Time: 7:51 AM (GMT+7)
 */

using System;
using System.Windows.Forms;

namespace CustServCounter
{
    /// <summary>
    /// The CS Selection Form class enables users to select
    /// their CS counter ID for the main application.
    /// </summary>
    public partial class CSSelectForm : Form
    {
        RadioButton selectedButton = new RadioButton();

        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
        public CSSelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates whether one of the CS counter ID options
        /// has been selected.
        /// </summary>
        private void CSAcceptButtonClick(object sender, EventArgs e)
        {
            bool selected = false;

            for (int i = 0; i < csOptionGroupBox.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)csOptionGroupBox.Controls[i];

                if (rb.Checked)
                {
                    selected = true;
                    selectedButton = rb;
                }
            }

            if(selected)
            {
                // passes an OK for the main application to detect
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a CS ID counter!");
            }
        }

        /// <summary>
        /// Get method to access number field of the checked CS counter ID option's text.
        /// </summary>
        public string CSIDText
        {
            get
            {
                return selectedButton.Text.Substring(3);
            }
        }
    }
}
