/*
 * Author: sd
 * Name: Customer Service Form
 * Creation Date: 27/03/2017
 * Creation Time: 8:10 AM (GMT+7)
 */

using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace CustServCounter
{
	/// <summary>
    /// The Customer Service Form class is used by the Customer Service counters
    /// to serve customers waiting in queue.
	/// </summary>
	public partial class CustServForm : Form
	{
		Timer timer = new Timer { Interval = 500 };
        string connectionString = "Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True";

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
		/// </summary>
		void CustServFormLoad(object sender, EventArgs e)
		{
			timer.Tick += new EventHandler(TimerTick);
			timer.Start();
		}
		
		/// <summary>
        /// Fully closes program when tool strip button is clicked.
		/// </summary>
		void ExitMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

        /// <summary>
        /// Updates display of total number of people waiting to be served.
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
			
 
			if(selectedMenuItem.Text != null)
			{
				csIDTextBox.Text = selectedMenuItem.Text.Substring(3);
			}
		}
		
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
        /// Gets queue number of next customer to be served.
		/// </summary>
		void CallButtonClick(object sender, EventArgs e)
		{
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // next queue number is the topmost value in QUEUE table
                using (SqlCommand selectCommand = new SqlCommand("SELECT TOP(1) QueueNum FROM QUEUE", connection))
                {
                    int currServ = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (currServ > 0)
                    {
                        currServTextBox.Text = currServ.ToString();

                        // erase from table to prevent clash with other CS counters
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE TOP(1) FROM QUEUE", connection))
                        {
                            deleteCommand.ExecuteNonQuery();
                        }

                        // plays queue number call audio
                        PlayQueueTTS();
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
                    }
                }// end selectCommand             
            }// end connection   
		}// end CallButtonClick

        /// <summary>
        /// Calls out queue number through text-to-speech conversion.
        /// </summary>
        void PlayQueueTTS()
        {
            string substr = csIDTextBox.Text.Substring(1);

            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            speaker.Rate = -1;
            speaker.SpeakAsync("Queue number " + currServTextBox.Text + ", please make your way to counter number " + substr);
        }

        /// <summary>
        /// Replays queue number call audio
        /// </summary>
        private void RecallButtonClick(object sender, EventArgs e)
        {
            PlayQueueTTS();
        }
    }
}