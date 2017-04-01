/*
 * Author: sd
 * Name: Customer Queue Form
 * Creation Date: 27/3/2017
 * Creation Time: 8:10 AM (GMT+7)
 */

using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace CustReceptionArea
{
	/// <summary>
	/// The Customer Queue Form class is for customers to take a queue number
    /// and view the total number of people waiting in the queue.
	/// </summary>
	public partial class CustQueueForm : Form
	{
        int queueCounter = 1;
        Timer timer = new Timer { Interval = 500 };
        string connectionString = "Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True";

        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
        public CustQueueForm()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Adds queue number to database table "Queue" to be used by other programs.
        /// Queue number is also displayed for customers' convenience.
        /// </summary>
        private void TakeNumButtonClick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand("INSERT INTO QUEUE VALUES(@QueueNum)", connection))
                {
                    // parameterised to prevent SQL injection
                    insertCommand.Parameters.Add(new SqlParameter("QueueNum", queueCounter));
                    insertCommand.ExecuteNonQuery();
                }
            }

            //PrintQueueNumber();

            // increments for next customer
            queueCounter++;

            if (queueCounter > 1)
            {
                queueNumTextBox.Text = queueCounter.ToString();
            }       
        }

        private void PrintQueueNumber()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Queue Number";
            printDoc.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            printDoc.PrintPage += PrintDocPage;

            printDoc.Print();
        }

        void PrintDocPage(object sender, PrintPageEventArgs e)
        {
            using (System.Drawing.Font custFont = new System.Drawing.Font("Microsoft Sans Serif", 60.0f, System.Drawing.FontStyle.Bold))
            {   
                e.Graphics.DrawString(queueNumTextBox.Text, custFont, System.Drawing.Brushes.Black, 250, 150);
            }
        }

        /// <summary>
        /// Displays Password Verification Form when Exit button is clicked.
        /// </summary>
        private void ExitButtonClick(object sender, EventArgs e)
        {
            PassVerifForm passVerif = new PassVerifForm();
            passVerif.Show();
        }

        /// <summary>
        /// Initialises queue number and timer when program loads.
        /// </summary>
        private void CustQueueFormLoad(object sender, EventArgs e)
        {
            queueNumTextBox.Text = queueCounter.ToString();
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        /// <summary>
        /// Updates total number of people waiting to be served.
        /// </summary>
        void TimerTick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand countCommand = new SqlCommand("SELECT COUNT(QueueNum) FROM QUEUE", connection))
                {
                    int totalQueue = Convert.ToInt32(countCommand.ExecuteScalar());
                    totalQueueTextBox.Text = totalQueue.ToString();
                }// end command
            }// end connect
        }// end MyTimerTick

        /// <summary>
        /// Prevents the application from exiting through Alt-F4.
        /// </summary>
        private void CustQueueFormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }// end if
        }// end CustQueueFormKeyDown
    }
}
