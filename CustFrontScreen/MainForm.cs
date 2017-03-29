/*
 * Author: sd
 * Date: 23/3/2017
 * Version: 2.5
 * Time: 3:52 PM
 * Brief: 
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustFrontScreen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        int counter = 1;
        Timer myTimer = new Timer { Interval = 500 };

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void TakeNumButtonClick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO QUEUE VALUES(@QueueNum)", conn))
                {
                    command.Parameters.Add(new SqlParameter("QueueNum", counter));
                    command.ExecuteNonQuery();
                }
            }

            queueNumTextBox.Text = counter.ToString();

            counter = counter + 1;
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(myTimerTick);
            myTimer.Start();
        }

        void myTimerTick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(QueueNum) FROM QUEUE", conn))
                {
                    int totalQueue = Convert.ToInt32(command.ExecuteScalar());
                    totalQueueTextBox.Text = totalQueue.ToString();
                }
            }
        }

        private void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
