/*
 * Author: sd
 * Date: 30/3/2017
 * Time: 9:28 AM
 * Version: 2.0
 * Brief: Class for displaying queue status on TV screen.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TVScreenDisplay
{
    public partial class TVScreenForm : Form
    {
        Timer timer = new Timer { Interval = 500 };
        string connectionString = "Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True";

        /// <summary>
        /// Default constructor for the form class.
        /// </summary>
        public TVScreenForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();
        }

        /// <summary>
        /// Sets the label's text to the current date and time.
        /// </summary>
        private void DateTimeTick(object sender, EventArgs e)
        {
            this.dateTimeLabel.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Initialises timer (for queue number display refresh) upon form load.
        /// </summary>
        private void TVScreenFormLoad(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        /// <summary>
        /// Gets the currently being served queue numbers for all CS counters
        /// and then updates them in the corresponding textboxes.
        /// </summary>
        void TimerTick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT QueueNumber FROM CURRENTQUEUE", connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        // move each row into a List data structure for easier access by textboxes
                        List<string> numList = new List<string>();  

                        while (reader.Read())
                        {
                            numList.Add(reader[0].ToString());
                        }

                        cs01TextBox.Text = numList[0];
                        cs02TextBox.Text = numList[1];
                        cs03TextBox.Text = numList[2];
                        cs04TextBox.Text = numList[3];
                        cs05TextBox.Text = numList[4];
                    }// end reader
                }// end command
            }// end connect
        }// end TimerTick
    }
}
