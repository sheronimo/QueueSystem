/*
 * Author: sd
 * Date: 29/3/2017
 * Version: 3.0
 * Time: 9:23 AM
 * Brief: Class for customer queueing.
 */

using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustFrontScreen
{
	/// <summary>
	/// This form will be displayed on the front screen in the reception area.
    /// Its purpose is for customers to take a queue number and wait
    /// to be served by one of the Customer Service counters.
    /// They can also view the total number of people waiting at that given
    /// time, and then decide if they would like to join the queue.
	/// </summary>
	public partial class MainForm : Form
	{
        int counter = 1;
        Timer myTimer = new Timer { Interval = 500 };
        
        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Called when customer clicks TakeNumButton.
        /// Method adds queue number to DB table to be used by other programs.
        /// Queue number is also displayed for customers' convenience.
        /// </summary>
        /// <param name="sender">Parameter containing a reference
        /// to the control/object that contains event data.</param>
        /// <param name="e">Parameter containing event data.</param>
        private void TakeNumButtonClick(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                connect.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO QUEUE VALUES(@QueueNum)", connect))
                {
                    // parameterised to prevent SQL injection
                    command.Parameters.Add(new SqlParameter("QueueNum", counter));
                    command.ExecuteNonQuery();
                }
            }

            // increments for next customer
            counter = counter + 1;

            if (counter > 1)
            {
                queueNumTextBox.Text = counter.ToString();
            }       
        }

        /// <summary>
        /// Calls and displays password verification form when Exit button is clicked.
        /// </summary>
        /// <param name="sender">Parameter containing a reference
        /// to the control/object that contains event data.</param>
        /// <param name="e">Parameter containing event data.</param>
        private void ExitButtonClick(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        /// <summary>
        /// Initialises queue number and timer when program loads.
        /// </summary>
        /// <param name="sender">Parameter containing a reference
        /// to the control/object that contains event data.</param>
        /// <param name="e">Parameter containing event data.</param>
        private void MainFormLoad(object sender, EventArgs e)
        {
            queueNumTextBox.Text = counter.ToString();
            myTimer.Tick += new EventHandler(myTimerTick);
            myTimer.Start();
        }

        /// <summary>
        /// Refreshes display of total number of people waiting to be served.
        /// </summary>
        /// <param name="sender">Parameter containing a reference
        /// to the control/object that contains event data.</param>
        /// <param name="e">Parameter containing event data.</param>
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

        /// <summary>
        /// Prevents the application from exiting through Alt-F4.
        /// </summary>
        /// <param name="sender">Parameter containing a reference
        /// to the control/object that contains event data.</param>
        /// <param name="e">Parameter containing event data.</param>
        private void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
