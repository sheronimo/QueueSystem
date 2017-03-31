/*
 * Author: sd
 * Date: 30/3/2017
 * Time: 9:28 AM
 * Version: 2.0
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

        public TVScreenForm()
        {
            InitializeComponent();
        }

        private void DateTimeTick(object sender, EventArgs e)
        {
            this.dateTimeLabel.Text = DateTime.Now.ToString();
        }

        private void TVScreenFormLoad(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        void TimerTick(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                connect.Open();

                using (SqlCommand command = new SqlCommand("SELECT QueueNumber FROM CURRENTQUEUE", connect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
