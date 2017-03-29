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
        /// InitializeComponent() refers to the method in the designer class
        /// that draws the form itself, as well as its components.
        /// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

        /// <summary>
        /// This event handler method is called when the customer clicks the TakeNumButton.
        /// This method connects to the QUEUE table in the database using SQL, and adds
        /// the queue number value (contained in "counter") to the QueueNum column.
        /// The aforementioned queue number is also displayed on the screen
        /// next to the "Take Number" button, so the customer can view
        /// what their queue number will be.
        /// </summary>
        /// <param name="sender">Parameter containing a reference
        /// to the control/object that contains event data.</param>
        /// <param name="e">Parameter containing event data.</param>
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

            counter = counter + 1;

            if (counter > 1)
            {
                queueNumTextBox.Text = counter.ToString();
            }       
        }

        /// <summary>
        /// This event handler method is called when the Exit button on the
        /// bottom right of the form is clicked.
        /// It calls and displays the password verification form.
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// This event handler method is called when Alt-F4 is pressed anywhere in the form.
        /// It prevents the application from exiting through Alt-F4.
        /// Take that, kids.
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
