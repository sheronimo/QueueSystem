/*
 * Author: sd
 * Date: 23/3/2017
 * Version: 2.5
 * Time: 9:07 AM
 * Brief: Class for the Customer Service Form methods.
 * Description: This class contains the methods and event handlers for the Customer Service Counter's main form.
 */

using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustServCounter
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CustServForm : Form
	{
		Timer timer = new Timer {Interval = 500};

		public CustServForm()
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
		}
		
		/// <summary>
        /// Initialises and starts timer upon form load.
		/// </summary>
		/// <param name="sender">Parameter that contains a reference
		/// to the control/object that contains event data.</param>
		/// <param name="e">Parameter that contains event data.</param>
		void CustServFormLoad(object sender, EventArgs e)
		{
			timer.Tick += new EventHandler(TimerTick);
			timer.Start();
            MessageBox.Show("Please select your CS counter before starting the queue.");
		}
		
		/// <summary>
        /// Fully exits program when tool strip button is clicked.
		/// </summary>
		/// <param name="sender">Parameter that contains a reference 
		/// to the control/object that sent the event.</param>
		/// <param name="e">Parameter that contains event data.</param>
		void ExitMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">Parameter that contains a reference
		/// to the control/object that sent the event.</param>
		/// <param name="e">Parameter that contains event data.</param>
		void TimerTick(object sender, EventArgs e)
		{	
            using(SqlConnection connect = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                connect.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(QueueNum) FROM QUEUE", connect))
                {
                    int totalQueue = Convert.ToInt32(command.ExecuteScalar());
                    queueTotalTextBox.Text = totalQueue.ToString();
                }//end command
            }// end connect
		}// end TimerTick
		
		
		/// <summary>
		/// This function is an event handler that detects the submenu item that has been clicked.
		/// This event handler will check the clicked menu item and then uncheck the others.
		/// </summary>
		/// <param name="sender">Parameter that contains a reference
		/// to the control/object that sent the event.</param>
		/// <param name="e">Parameter that contains event data.</param>
		private void CSIDOptionClick(object sender, EventArgs e)
		{
            callButton.Enabled = true;
            recallButton.Enabled = true;
			ToolStripMenuItem selectedMenuItem = sender as ToolStripMenuItem;
			CheckMenuItem(csSelector, selectedMenuItem);
			
			if(selectedMenuItem.Text != null)
			{
				csIDTextBox.Text = selectedMenuItem.Text.Substring(3);
			}
		}
		
		/// <summary>
		/// Unchecks all items in submenu except for the selected item.
		/// </summary>
		/// <param name="parentMenuItem">The parent menu item which points to
		/// the submenu containing the list of items.</param>
		/// <param name="checkedMenuItem">The submenu item which has been selected and checked. </param>
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
		/// This function is an event handler that acts to prevent the application from closing 
		/// if the Exit menu item or the Close button has been clicked by accident.
		/// This event handler displays a dialog box, prompting the user to confirm closing the program
		/// or cancel the exit from taking place.
		/// </summary>
		/// <param name="sender">Parameter that contains a reference
		/// to the control/object that sent the event.</param>
		/// <param name="e">Parameter that contains event data.</param>
		void CustServFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("This will exit the program. Continue?", "Close Program", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">Parameter that contains a reference
		/// to the control/object that sent the event.</param>
		/// <param name="e">Parameter that contains event data.</param>
		void CallButtonClick(object sender, EventArgs e)
		{

            using (SqlConnection connect = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                connect.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT TOP(1) QueueNum FROM QUEUE", connect))
                {
                    int currServ = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (currServ > 0)
                    {
                        currServTextBox.Text = currServ.ToString();

                        using (SqlCommand deleteCommand = new SqlCommand("DELETE TOP(1) FROM QUEUE", connect))
                        {
                            deleteCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No one waiting!");
                    }

                    using (SqlCommand insertCommand = new SqlCommand("UPDATE CURRENTQUEUE SET QUEUENUMBER = @QueueNumber WHERE CSNum = @CSNum", connect))
                    {
                        insertCommand.Parameters.Add(new SqlParameter("QueueNumber", currServ));

                        if(csIDTextBox.Text.Equals("01"))
                        {
                            insertCommand.Parameters.Add(new SqlParameter("CSNum", 1));
                        }
                        else if (csIDTextBox.Text.Equals("02"))
                        {
                            insertCommand.Parameters.Add(new SqlParameter("CSNum", 2));
                        }
                        else if (csIDTextBox.Text.Equals("03"))
                        {
                            insertCommand.Parameters.Add(new SqlParameter("CSNum", 3));
                        }
                        else if (csIDTextBox.Text.Equals("04"))
                        {
                            insertCommand.Parameters.Add(new SqlParameter("CSNum", 4));
                        }
                        else if (csIDTextBox.Text.Equals("05"))
                        {
                            insertCommand.Parameters.Add(new SqlParameter("CSNum", 5));
                        }

                        insertCommand.ExecuteNonQuery();
                    }
                }// end selectCommand                
            }// end sql connect   
		}// end CallButtonClick
	}//end CustServForm : Form
}
