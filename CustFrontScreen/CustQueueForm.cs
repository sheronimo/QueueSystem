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
        int queueCount = 1;
        Timer timer = new Timer { Interval = 100 };
        string connectionString = "Data Source=192.168.0.32,61945;Initial Catalog=SHERBASE;Persist Security Info=True;User ID=sher;Password=sher";

        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
        public CustQueueForm()
		{
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();
		}

        /// <summary>
        /// Initialises queue number and timer when program loads.
        /// </summary>
        private void CustQueueFormLoad(object sender, EventArgs e)
        {
            queueNumTextBox.Text = queueCount.ToString();
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
                }
            }
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
                    insertCommand.Parameters.Add(new SqlParameter("QueueNum", queueCount));
                    insertCommand.ExecuteNonQuery();
                }
            }

            PrintQueueNumber();

            // increments for next customer
            queueCount++;

            if (queueCount > 1)
            {
                queueNumTextBox.Text = queueCount.ToString();
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
        /// Prevents the application from exiting through Alt-F4.
        /// </summary>
        private void CustQueueFormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Prints out the queue number ticket.
        /// </summary>
        private void PrintQueueNumber()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = "Epson TM-U220 Receipt";
            printDoc.PrintPage += PrintDoco;

            printDoc.Print();
        }

        /// <summary>
        /// Draws the queue number graphic for printing.
        /// </summary>
        void PrintDoco(object sender, PrintPageEventArgs e)
        {
            using (System.Drawing.Font custFont1 = new System.Drawing.Font("Arial", 12.0f, System.Drawing.FontStyle.Regular))
            { 
                e.Graphics.DrawString("Trisensa Diagnostic Centre", custFont1, System.Drawing.Brushes.Black, 0, 0);
            }
       
            using (System.Drawing.Font custFont2 = new System.Drawing.Font("Microsoft Sans Serif", 60.0f, System.Drawing.FontStyle.Bold))
            {
                e.Graphics.DrawString(queueNumTextBox.Text, custFont2, System.Drawing.Brushes.Black, 90, 40);
            }

            using (System.Drawing.Font custFont3 = new System.Drawing.Font("Arial", 10.0f, System.Drawing.FontStyle.Regular))
            {
                e.Graphics.DrawString(DateTime.Now.ToString(), custFont3, System.Drawing.Brushes.Black, 120, 150);
            }
        }
    }
}
