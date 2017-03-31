/*
 * Author: sd
 * Date: 23/3/2017
 * Version: 2.5
 * Time: 9:07 AM
 * Brief: Class for CS to serve customers waiting in queue.
 */

using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustServCounter
{
	/// <summary>
	/// This form will be used by the Customer Service employees at their
    /// respective counters in order to serve the customers waiting in queue.
    /// Customer Service employees are able to call and re-call customers, as
    /// well as view the queue number they are currently serving (or will serve)
    /// and the total number of people waiting to be served.
    /// There is also functionality to select the CS Counter # instead of
    /// hardcoding the numbers and creating 5 identical applications.
	/// </summary>
	public partial class CustServForm : Form
	{
		Timer timer = new Timer { Interval = 500 };
        string connectionString = "Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True";

        public CustServForm()
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
		}
		
		/// <summary>
        /// Initialises and starts timer upon form load.
        /// Displays dialog warning, as selecting CS counter #
        /// will enable call and re-call buttons (disabled by default).
		/// </summary>
		void CustServFormLoad(object sender, EventArgs e)
		{
			timer.Tick += new EventHandler(TimerTick);
			timer.Start();
            MessageBox.Show("Please select your CS counter # before starting the queue.");
		}
		
		/// <summary>
        /// Fully closes program when tool strip button is clicked.
		/// </summary>
		void ExitMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

        /// <summary>
        /// Updates (per tick) display of total number of people waiting to be served.
        /// </summary>
        void TimerTick(object sender, EventArgs e)
		{	
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand countCommand = new SqlCommand("SELECT COUNT(QueueNum) FROM QUEUE", connection))
                {
                    int queueTotal = Convert.ToInt32(countCommand.ExecuteScalar());
                    queueTotalTextBox.Text = queueTotal.ToString();
                }//end countCommand
            }// end connection
		}// end TimerTick
		
		
		/// <summary>
		/// Detects the "CS Select..." submenu item that has been clicked.
		/// </summary>
		private void CSIDOptionClick(object sender, EventArgs e)
		{
            // enables buttons so CS can start serving customers
            callButton.Enabled = true;
            recallButton.Enabled = true;

			ToolStripMenuItem selectedMenuItem = sender as ToolStripMenuItem;
			CheckMenuItem(csSelector, selectedMenuItem);
			
            // matches text in top right of form to the CS # that has been selected
			if(selectedMenuItem.Text != null)
			{
				csIDTextBox.Text = selectedMenuItem.Text.Substring(3);
			}
		}
		
		/// <summary>
		/// Unchecks all items in submenu except for the clicked item.
		/// </summary>
		/// <param name="parentMenuItem">The parent menu which points to
		/// the submenu containing the list of options.</param>
		/// <param name="checkedMenuItem">The submenu item which has been clicked and checked.</param>
		private void CheckMenuItem(ToolStripMenuItem parentMenuItem, ToolStripMenuItem checkedMenuItem)
		{
			foreach(ToolStripItem childItem in parentMenuItem.DropDownItems)
			{
				if(childItem is ToolStripMenuItem)
				{
					ToolStripMenuItem childMenuItem = childItem as ToolStripMenuItem;
					childMenuItem.Checked = (childMenuItem == checkedMenuItem);
				}// end if
			}// end foreach
		}// end CheckMenuItem
		
		/// <summary>
		/// Prevents form from closing by accident.
		/// </summary>
		void CustServFormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("This will exit the program. Continue?", "Close Program", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// Gets the next queue number from the top row of the QUEUE database table.
        /// Also clears that number from the top of the table to prevent clash.
        /// Writes user-selected CS # and queue number being served to the CURRENTQUEUE
        /// table, for usage by the TVScreenDisplay application.
		/// </summary>
		void CallButtonClick(object sender, EventArgs e)
		{
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT TOP(1) QueueNum FROM QUEUE", connection))
                {
                    int currServ = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (currServ > 0)
                    {
                        currServTextBox.Text = currServ.ToString();

                        using (SqlCommand deleteCommand = new SqlCommand("DELETE TOP(1) FROM QUEUE", connection))
                        {
                            deleteCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No one waiting!");
                    }

                    using (SqlCommand insertCommand = new SqlCommand("UPDATE CURRENTQUEUE SET QUEUENUMBER = @QueueNumber WHERE CSNum = @CSNum", connection))
                    {
                        // parameterised for protection against SQL injection
                        insertCommand.Parameters.Add(new SqlParameter("QueueNumber", currServ));
                        insertCommand.Parameters.Add(new SqlParameter("CSNum", Convert.ToInt32(csIDTextBox.Text.Substring(1))));
                        insertCommand.ExecuteNonQuery();
                    }// end insertCommand
                }// end selectCommand                
            }// end connection   
		}// end CallButtonClick
	}
}