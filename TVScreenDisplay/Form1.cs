using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dateTimeLabel.Text = DateTime.Now.ToString();
        }

        private void TVScreenForm_Load(object sender, EventArgs e)
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
                    }
                }
            }
        }
    }
}
