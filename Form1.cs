﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VRANDER_01
{
    public partial class Form1 : Form
    {

        private static string conString = "Server=DESKTOP-43E8RCF\\SQLEXPRESS; Database=VR; User=SG; Password=12345";
        private SqlConnection connection = new SqlConnection(conString);

        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        
       // SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();

            connection.ConnectionString = conString;


          //  cmd = new SqlCommand("INSERT INTO History (Feedback, RiderID, RequestID, StartDate, EndDate, FromDest, ToDest) VALUES ('Not Satisfied', 4, 4, '2017-04-01', '2017-04-10','Mississauga','Toronto');", conn);
           // cmd = new SqlCommand("INSERT INTO OrderTable (Payment, UserID, DriverID) VALUES (454.48, 42, 52);", conn);
            //cmd.Connection.Open();
          //  cmd.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //login button clicked
        {
            LoginInfo.username = tbUsername.Text;
            LoginInfo.password = tbPassword.Text;

            if (LoginInfo.authenticate())
            {

                Options options = new Options();
                options.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
           
            /*
            adapter = new SqlDataAdapter("SELECT COUNT(*) FROM UserInfo WHERE Username='" + tbUsername.Text +
          "' AND password='" + tbPassword.Text + "'", connection);
            adapter.Fill(table);

            if (table.Rows[0][0].ToString() == "1")
            {
                Options options = new Options();
                options.Show();
            }
            else
                MessageBox.Show("Invalid username or password");  
  */
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
}

        private void btnTest_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();

        }

        private void loginGroup_Enter(object sender, EventArgs e)
        {

        }  
        }
       
    }

