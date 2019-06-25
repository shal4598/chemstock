using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace pro1
{
    public partial class forgetpassword : Form
    {
        Regex expr2;
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sdb"].ConnectionString);
        public forgetpassword()
        {
            InitializeComponent();
        }
        private void t2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void clearb1_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            l4.Text = "";
        }
        private void t4_TextChanged(object sender, EventArgs e)
        {
            if (t3.Text == t4.Text)
            {
                l4.ForeColor = Color.Green;
                l4.Text = "Password Matched";
            }
            else
            {
                l4.ForeColor = Color.Red;
                l4.Text = "Password not Matched";
            }
        }
        private void forgetpassword_Load(object sender, EventArgs e)
        {
            t1.Focus();
        }
        private void t1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                t2.Focus();
            }
        }
        private void t2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                t3.Focus();
            }
        }
        private void t3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                t4.Focus();
            }
        }
        private void t4_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void resetpassb2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [id]  ,[firstname],[lastname],[username],[password]
       ,[contact]
   FROM [dbo].[registration] where username='" + t1.Text + "' and contact='" + t2.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (t1.Text == "" || t2.Text == "" || t3.Text == "" || t4.Text == "")
                {
                    MessageBox.Show("Please fill all the details.");
                }
                else if (i == 0)
                {
                    MessageBox.Show("Username or contact does not match...!");
                }
                else
                {

                    if (t3.Text != t4.Text)
                    {
                        MessageBox.Show("Password does not matched");
                    }
                    else if (passwordexp(t3.Text) == false)
                    {
                        MessageBox.Show("Password must contain  8 to 15 characters,a-z,A-Z,0-9");
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[registration]
   SET [password] = '" + t3.Text + "' WHERE  username= '" + t1.Text + "' and contact='" + t2.Text + "' ", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated Successfully!!");
                        this.Hide();
                        welcome w = new welcome();
                        w.Show();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
        private void t4_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        public bool passwordexp(string p)
        {

            expr2 = new Regex(@"(^[A-z,a-z,0-9]{8,15})$");

            if (expr2.IsMatch(p))
            {
                return true;
            }
            else return false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void forgetpassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            welcome w = new welcome();
            w.Show();

        }
    }
}
