using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustFrontScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void Form1KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
