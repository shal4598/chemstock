using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pro1
{
    public partial class userlogin : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sdb"].ConnectionString);
        public userlogin()
        {
            InitializeComponent();
        }

        private void adminloginb1_Click(object sender, EventArgs e)
        {
            t1ul.Text = "";
            t2ul.Text = "";
            t1ul.Focus();
        }

        private void loginb2ul_Click(object sender, EventArgs e)
        {
            string us = t1ul.Text;
            string pass = t2ul.Text;
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
  FROM [dbo].[registration] where username='" + us + "' and password='" + pass + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (us == "" && pass == "")
            {
                MessageBox.Show("Enter username and Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Successfully Login!!!");
                this.Hide();
                chemstockuser c = new chemstockuser();
                c.Show();
            }
            else if (us == "")
            {
                MessageBox.Show("Enter username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pass == "")
            {
                MessageBox.Show("Enter Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Usename and Password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminloginb1_Click(sender, e);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword fp = new forgetpassword();
            this.Hide();
            fp.Show();
        }

        private void userlogin_Load(object sender, EventArgs e)
        {
            t1ul.Focus();
        }

        private void t1ul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                t2ul.Focus();
            }
        }

        private void t2ul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginb2ul.Focus();
            }
        }

        private void userlogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void labeladminloginl2_Click(object sender, EventArgs e)
        {

        }

        private void adminloginl1_Click(object sender, EventArgs e)
        {

        }

        private void t2ul_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1ul_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
