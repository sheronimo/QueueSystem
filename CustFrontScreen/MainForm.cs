/*
 * Created by SharpDevelop.
 * User: waluigi
 * Date: 23-Mar-17
 * Time: 3:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustFrontScreen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        int counter = 1;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void TakeNumButtonClick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=WALUIGI-PC\\SQLEXPRESS;Initial Catalog=SHERBASE;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO QUEUE VALUES(@QueueNum)", conn))
                {
                    command.Parameters.Add(new SqlParameter("QueueNum", counter));
                    command.ExecuteNonQuery();
                }
            }

            counter = counter + 1;
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
