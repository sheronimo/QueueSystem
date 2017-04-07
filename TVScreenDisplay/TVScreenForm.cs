/*
 * Author: sd
 * Project Name: TV Screen Display
 * Creation Date: 30/03/2017
 * Creation Time: 7:53 AM
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using CustServCounter;

namespace TVScreenDisplay
{
    /// <summary>
    /// The TV Screen Form class displays the CS counter IDs and
    /// the queue numbers of customers they are currently serving.
    /// There is no user interactivity.
    /// </summary>
    public partial class TVScreenForm : Form
    {
        Timer timer = new Timer { Interval = 50 };
        string connectionString = "Data Source=192.168.0.32,61945;Initial Catalog=SHERBASE;Persist Security Info=True;User ID=sher;Password=sher";
        CallClass callClass = new CallClass();

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
        /// Gets currently serving queue numbers for all CS counters
        /// and updates them in the corresponding textboxes.
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
                    }
                }
            }
        }

        private void CS01TextBoxTextChanged(object sender, EventArgs e)
        {
            if(!cs01TextBox.Text.StartsWith("0"))
            {
                string newStr = callClass.StringConvert(Convert.ToInt32(cs01TextBox.Text));
                callClass.CallIntro();
                callClass.CallQueue(newStr);
                callClass.CallToCounter();
                callClass.CallCounterNumber(Convert.ToInt32(cs01Label.Text.Substring(4)));
            }         
        }

        private void CS02TextBoxTextChanged(object sender, EventArgs e)
        {
            if (!cs02TextBox.Text.StartsWith("0"))
            {
                string newStr = callClass.StringConvert(Convert.ToInt32(cs02TextBox.Text));
                callClass.CallIntro();
                callClass.CallQueue(newStr);
                callClass.CallToCounter();
                callClass.CallCounterNumber(Convert.ToInt32(cs02Label.Text.Substring(4)));
            }
        }

        private void CS03TextBoxTextChanged(object sender, EventArgs e)
        {
            if (!cs03TextBox.Text.StartsWith("0"))
            {
                string newStr = callClass.StringConvert(Convert.ToInt32(cs03TextBox.Text));
                callClass.CallIntro();
                callClass.CallQueue(newStr);
                callClass.CallToCounter();
                callClass.CallCounterNumber(Convert.ToInt32(cs03Label.Text.Substring(4)));
            }
        }

        private void CS04TextBoxTextChanged(object sender, EventArgs e)
        {
            if (!cs04TextBox.Text.StartsWith("0"))
            {
                string newStr = callClass.StringConvert(Convert.ToInt32(cs04TextBox.Text));
                callClass.CallIntro();
                callClass.CallQueue(newStr);
                callClass.CallToCounter();
                callClass.CallCounterNumber(Convert.ToInt32(cs04Label.Text.Substring(4)));
            }
        }

        private void CS05TextBoxTextChanged(object sender, EventArgs e)
        {
            if (!cs05TextBox.Text.StartsWith("0"))
            {
                string newStr = callClass.StringConvert(Convert.ToInt32(cs05TextBox.Text));
                callClass.CallIntro();
                callClass.CallQueue(newStr);
                callClass.CallToCounter();
                callClass.CallCounterNumber(Convert.ToInt32(cs05Label.Text.Substring(4)));
            }
        }
    }
}