/*
 * Author: sd
 * Name: Customer Service Form
 * Creation Date: 27/03/2017
 * Creation Time: 8:10 AM (GMT+7)
 */

using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustServCounter
{
	/// <summary>
    /// The Customer Service Form class is used by the Customer Service counters
    /// to serve customers waiting in queue.
	/// </summary>
	public partial class CustServForm : Form
	{
		Timer timer = new Timer { Interval = 100 };
        string connectionString = "Data Source=192.168.0.122,61945;Network Library = DBMSSOCN;Initial Catalog=QUEUEBASE;User ID=potato;Password=potato";

        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
        public CustServForm()
		{
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();
		}
		
		/// <summary>
        /// Initialises and starts timer upon form load.
        /// Also displays CS counter ID selection form.
		/// </summary>
		void CustServFormLoad(object sender, EventArgs e)
		{
			timer.Tick += new EventHandler(TimerTick);
			timer.Start();
            ShowSelectorForm();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand initialiseCommand = new SqlCommand("SELECT QueueNumber FROM CURRENTQUEUE WHERE CSNum = @csnum", connection))
                {
                    initialiseCommand.Parameters.Add("csnum", Convert.ToInt32(csIDTextBox.Text.Substring(1)));
                    int initialServ = Convert.ToInt32(initialiseCommand.ExecuteScalar());
                    currServTextBox.Text = initialServ.ToString();
                }
            }

            keyShortsMenuItem.Checked = true;
		}

        /// <summary>
        /// Updates display of total number of people waiting to be served.
        /// </summary>
        void TimerTick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand countCommand = new SqlCommand("SELECT COUNT(QueueNum) FROM QUEUE", connection))
                {
                    int queueTotal = Convert.ToInt32(countCommand.ExecuteScalar());
                    queueTotalTextBox.Text = queueTotal.ToString();
                }
            }
        }

        /// <summary>
        /// Fully closes program when Exit menu item is clicked.
        /// </summary>
        void ExitMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
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
        /// Gets queue number of next customer to be served.
		/// </summary>
		void CallButtonClick(object sender, EventArgs e)
		{
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // next queue number is the topmost value in QUEUE table
                using (SqlCommand selectCommand = new SqlCommand("SELECT TOP(1) QueueNum FROM QUEUE ORDER BY QueueNum ASC", connection))
                {
                    int currServ = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (currServ > 0)
                    {
                        currServTextBox.Text = currServ.ToString();

                        // erase from table to prevent clash with other CS counters
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM QUEUE WHERE QueueNum IN(SELECT TOP(1) QueueNum FROM QUEUE ORDER BY QueueNum ASC)", connection))
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
                        insertCommand.Parameters.Add(new SqlParameter("QueueNumber", currServ.ToString()));
                        insertCommand.Parameters.Add(new SqlParameter("CSNum", Convert.ToInt32(csIDTextBox.Text.Substring(1))));
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
		}

        /// <summary>
        /// Replays queue number call audio
        /// </summary>
        private void RecallButtonClick(object sender, EventArgs e)
        {
            if (!currServTextBox.Text.Equals("0"))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // a little fiddly, but a placeholder flag
                    using (SqlCommand updateCommand1 = new SqlCommand("UPDATE CURRENTQUEUE SET QUEUENUMBER = @queuenum WHERE CSNUM = @CSNum", connection))
                    {
                        updateCommand1.Parameters.Add(new SqlParameter("queuenum", "0" + currServTextBox.Text));
                        updateCommand1.Parameters.Add(new SqlParameter("CSNum", Convert.ToInt32(csIDTextBox.Text.Substring(1))));
                        updateCommand1.ExecuteNonQuery();
                    }

                    using (SqlCommand waitCommand = new SqlCommand("WAITFOR DELAY \'00:00:01\'", connection))
                    {
                        waitCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand updateCommand2 = new SqlCommand("UPDATE CURRENTQUEUE SET QUEUENUMBER = @QueueNum WHERE CSNUM = @CSNum", connection))
                    {
                        updateCommand2.Parameters.Add(new SqlParameter("QueueNum", currServTextBox.Text));
                        updateCommand2.Parameters.Add(new SqlParameter("CSNum", Convert.ToInt32(csIDTextBox.Text.Substring(1))));
                        updateCommand2.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("No one to recall!");
            }
        }

        /// <summary>
        /// Allows user to change the CS counter ID instead 
        /// of closing and reopening the application.
        /// </summary>
        private void CSSelectMenuItemClick(object sender, EventArgs e)
        {
            ShowSelectorForm();
        }

        /// <summary>
        /// Displays CS counter ID selection form as a dialog
        /// and handles data passed from the form.
        /// </summary>
        void ShowSelectorForm()
        {
            CSSelectForm csSelForm = new CSSelectForm();
            DialogResult result = csSelForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                csIDTextBox.Text = csSelForm.CSIDText;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand initialiseCommand = new SqlCommand("SELECT QueueNumber FROM CURRENTQUEUE WHERE CSNum = @csnum", connection))
                    {
                        initialiseCommand.Parameters.Add("csnum", Convert.ToInt32(csIDTextBox.Text.Substring(1)));
                        int initialServ = Convert.ToInt32(initialiseCommand.ExecuteScalar());
                        currServTextBox.Text = initialServ.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// Shows the About window. 
        /// </summary>
        private void AboutMenuItemClick(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Fun keyboard shortcuts for the form controls.
        /// </summary>
        private void CustServForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Shift)
            {
                if(e.KeyCode == Keys.R)
                {
                    RecallButtonClick(null, null);
                }
                else if(e.KeyCode == Keys.C)
                {
                    CallButtonClick(null, null);
                }
                else if(e.KeyCode == Keys.S)
                {
                    CSSelectMenuItemClick(null, null);
                }
            }
            else if(e.KeyCode == Keys.F2)
            {
                if(groupBox1.Visible == true)
                {
                    groupBox1.Visible = false;
                    keyShortsMenuItem.Checked = false;
                }
                else
                {
                    groupBox1.Visible = true;
                    keyShortsMenuItem.Checked = true;
                }
            }
        }

        /// <summary>
        /// Functionality to show/hide the keyboard shortcut box.
        /// </summary>
        private void KeyShortsMenuItemClick(object sender, EventArgs e)
        {
            if(groupBox1.Visible)
            {
                groupBox1.Visible = false;
                keyShortsMenuItem.Checked = false;
            }
            else
            {
                groupBox1.Visible = true;
                keyShortsMenuItem.Checked = true;
            }
        }

        /*
         * 3/4/17: Commented out because of change to the CS counter ID selection method.
         * Keeping code here because it might be useful for future add-on,
         * maybe switching interface language between English and Bahasa Indonesia.
         * 
		/// <summary>
		/// Unchecks all items in submenu except for the clicked item.
		/// </summary>
		/// <param name="parentMenuItem">Parent menu which points to
		/// submenu containing the list of options.</param>
		/// <param name="checkedMenuItem">The submenu item which has been clicked and checked.</param>
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
        */
    }
}