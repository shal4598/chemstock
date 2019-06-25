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
    public partial class adminlogin : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sdb"].ConnectionString);
        public adminlogin()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void adminloginb1_Click(object sender, EventArgs e)
        {
            t1adminlogin.Text = "";
            t2adminlogin.Text = "";
            t1adminlogin.Focus();
        }
        private void adminloginb2_Click(object sender, EventArgs e)
        {
            string us=t1adminlogin.Text;
            string pass=t2adminlogin.Text;
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
  FROM [dbo].[registration] where username='" + us + "' and password='" + pass + "'", con);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            if (us == "" && pass == "")
            {
                MessageBox.Show("Enter username and Password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (dt.Rows.Count == 1)
            {
                if (us == "admin")
                {
                    MessageBox.Show("Successfully Login!!!");
                    this.Hide();
                    chemstock c = new chemstock();
                    c.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                MessageBox.Show("Invalid Username and Password..!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                adminloginb1_Click(sender,e);
            }
        }
        private void adminlogin_Load(object sender, EventArgs e)
        {
            t1adminlogin.Focus();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword fp = new forgetpassword();
            this.Hide();
            fp.Show();
        }
        private void t1adminlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                t2adminlogin.Focus();
            }
        }
        private void t2adminlogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void t2adminlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adminloginb2.Focus();
            }
        }

        private void adminlogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
    }
}
