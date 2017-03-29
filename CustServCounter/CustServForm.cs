/*
 * Author: sd
 * Date: 23/3/2017
 * Version: 2.5
 * Time: 9:07 AM
 * Brief: Class for the Customer Service Form methods.
 * Description: This class contains the methods and event handlers for the Customer Service Counter's main form.
 */

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustServCounter
{
	/// <summary>
	/// CustServForm is the main form for the Customer Service Counter application.
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
		/// This function is an event handler for the loading of the form.
		/// This event handler initialises and starts the timer.
		/// </summary>
		/// <param name="sender">Parameter that contains a reference
		/// to the control/object that contains event data.</param>
		/// <param name="e">Parameter that contains event data.</param>
		void CustServFormLoad(object sender, EventArgs e)
		{
			timer.Tick += new EventHandler(TimerTick);
			timer.Start();
		}
		
		/// <summary>
		/// This function is an event handler for the Exit submenu item in the menu toolstrip.
		/// This event handler exits the entire application.
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
            using(SqlConnection conn = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(QueueNum) FROM QUEUE", conn))
                {
                    int totalQueue = Convert.ToInt32(command.ExecuteScalar());
                    queueTotalTextBox.Text = totalQueue.ToString();
                }
            }
		}
		
		
		/// <summary>
		/// This function is an event handler that detects the submenu item that has been clicked.
		/// This event handler will check the clicked menu item and then uncheck the others.
		/// </summary>
		/// <param name="sender">Parameter that contains a reference
		/// to the control/object that sent the event.</param>
		/// <param name="e">Parameter that contains event data.</param>
		private void CSIDOptionClick(object sender, EventArgs e)
		{
			ToolStripMenuItem selectedMenuItem = sender as ToolStripMenuItem;
			CheckMenuItem(csSelector, selectedMenuItem);
			
			if(selectedMenuItem.Text != null)
			{
				csIDTextBox.Text = selectedMenuItem.Text.Substring(3);
			}
		}
		
		/// <summary>
		/// This function will uncheck all items in the submenu except for the selected item.
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
				}
			}
		}
		
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
            using (SqlConnection conn = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand comm2 = new SqlCommand("SELECT TOP(1) QueueNum FROM QUEUE", conn))
                {
                    int currServ = Convert.ToInt32(comm2.ExecuteScalar());

                    if (currServ > 0)
                    {
                        currServTextBox.Text = currServ.ToString();
                        using (SqlCommand comm3 = new SqlCommand("DELETE TOP(1) FROM QUEUE", conn))
                        {
                            comm3.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No one waiting!");
                        currServTextBox.Text = "0";
                    }
                }
            }   
		}
		
	}
}
