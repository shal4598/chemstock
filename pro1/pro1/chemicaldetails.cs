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
    public partial class chemicaldetails : Form
    {
        int quant;
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sdb"].ConnectionString);
        public chemicaldetails()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (t1add.Text == "")
                {
                    MessageBox.Show("Please enter the Chemical name which you want to delete!");
                }

                else
                {
                    con.Open();
                    if (ispresent(con, t1add.Text))
                    {
                        DialogResult dg = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[stockdb]
      WHERE name='" + t1add.Text + "'", con);

                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Deleted Successfully!!");
                            displaydata();
                        }
                    }
                    else
                    {
                        MessageBox.Show("'" + t1add.Text + "' not present in the list!!");
                    }
                    clearadd_Click(sender, e);
                }


            }
            catch (Exception ex)
            { MessageBox.Show("Error!", ex.Message); }
            finally { con.Close(); }
        }
        private void chemicaldetails_Load(object sender, EventArgs e)
        {
            t1add.Focus();
            displaydata();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                cbadd.SelectedIndex = 0;
                // TODO: This line of code loads data into the 'stockDataSet.stockdb' table. You can move, or remove it, as needed.
                this.stockdbTableAdapter.Fill(this.stockDataSet.stockdb);
                Class1 c = new Class1();
                c.notify();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured ", ex.Message);
            }
        }
        private void gcd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displaydata()
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT TOP (1000) [name]
      ,[stock]
      ,[type]
      ,[date]
  FROM [stock].[dbo].[stockdb]", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                DataView dv = new DataView(dt);
                dv.Sort = "type desc";
                gcd.DataSource = dv;
                con.Close();
                if (gcd.Rows.Count > 0)
                {
                    l2.Text = gcd.Rows.Count.ToString();
                    int totalstock = 0;
                    for (int i = 0; i < gcd.Rows.Count; i++)
                    {
                        totalstock += int.Parse(gcd.Rows[i].Cells["stockDataGridViewTextBoxColumn"].Value.ToString());
                        l4.Text = totalstock.ToString();
                    }
                }
                else
                {
                    l2.Text = "0";
                    l4.Text = "0";
                }
            }
            catch (Exception) { }
        }
        /*  private void searchcd_Click(object sender, EventArgs e)
          {
              try
              {
                  if (t1add.Text == "")
                  {
                      MessageBox.Show("Please enter the name!");
                  }
                  else
                  {
                      con.Open();
                      if (ispresent(con, t1add.Text))
                      {

                          SqlCommand cmd = new SqlCommand(@"SELECT [name],[stock]
        ,[type]
        ,[date]
         FROM [dbo].[stockdb]
        WHERE name='" + t1add.Text + "'", con);
                          cmd.ExecuteNonQuery();
                          DataTable dt = new DataTable();
                          SqlDataAdapter sda = new SqlDataAdapter(cmd);
                          sda.Fill(dt);
                          gcd.DataSource = dt;
                          con.Close();
                      }
                      else
                      {
                          MessageBox.Show("'" + t1add.Text + "' is not present in the list!!");
                          clearadd_Click(sender, e);
                      }
                  }
              }
              catch (Exception exp)
              {
                  MessageBox.Show("Error!", exp.Message);
              }
              finally
              {
                  con.Close();
              }
          } */
        private void b1addadd_Click(object sender, EventArgs e)
        {

            try
            {
                if (t1add.Text == "" || t2add.Text == "")
                {
                    MessageBox.Show("Please enter the details!");
                }

                else
                {
                    con.Open();
                    var query = "";
                    if (ispresent(con, t1add.Text))
                    {

                        query = @"UPDATE [dbo].[stockdb]
   SET [stock] = stock +'" + t2add.Text + "' ,[date] = '" + dtpadd.Text + "' WHERE name='" + t1add.Text + "'";
                        MessageBox.Show("" + t2add.Text + " stocks added to " + t1add.Text + "..!!");
                    }
                    else
                    {
                        query = @"INSERT INTO [dbo].[stockdb] ([name],[stock],[type],[date])
       VALUES('" + t1add.Text + "','" + t2add.Text + "','" + cbadd.Text + "','" + dtpadd.Text + "')";
                        MessageBox.Show("Record Inserted Successfully!!");
                    }
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    clearadd_Click(sender, e);
                    displaydata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Activity", ex.Message);
            }
            finally { con.Close(); }
        }
        public bool ispresent(SqlConnection con, string a)
        {
            string b = t1add.Text;
            SqlCommand cmd = new SqlCommand(@"SELECT [name],[stock],[type] ,[date] FROM [dbo].[stockdb]
      WHERE name='" + b + "'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            { return true; }
            else
            { return false; }
        }
        private void clearadd_Click(object sender, EventArgs e)
        {
            t1add.Focus();
            t1add.Text = "";
            t2add.Text = "";
            cbadd.SelectedIndex = 0;
            searchtbcd.Text = "";
            dtpadd.Value = DateTime.Now;

        }
        private void t2add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void t2add_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(t2add.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only!");
                t2add.Text = t2add.Text.Remove(t2add.Text.Length - 1);
                t2add.Text = "";
            }
        }
        private void gcd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                t1add.Text = gcd.SelectedRows[0].Cells[0].Value.ToString();
                t2add.Text = gcd.SelectedRows[0].Cells[1].Value.ToString();
                cbadd.Text = gcd.SelectedRows[0].Cells[2].Value.ToString();
                dtpadd.Text = gcd.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }

        }
        private void searchtbcd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void searchtbcd_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT [name],[stock]
      ,[type]
      ,[date]
       FROM [dbo].[stockdb]
      WHERE name like '" + searchtbcd.Text + "%' OR stock like '" + searchtbcd.Text + "%' OR type like '" + searchtbcd.Text + "%'", con);
            //  cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            gcd.DataSource = dt;
            con.Close();
            if (gcd.Rows.Count > 0)
            {
                l2.Text = gcd.Rows.Count.ToString();
                int totalstock = 0;
                for (int i = 0; i < gcd.Rows.Count; i++)
                {
                    totalstock += int.Parse(gcd.Rows[i].Cells["stockDataGridViewTextBoxColumn"].Value.ToString());
                    l4.Text = totalstock.ToString();
                }
            }
            else
            {
                l2.Text = "0";
                l4.Text = "0";
            }

        }
        private void updatebtncd_Click(object sender, EventArgs e)
        {
            try
            {
                if (t1add.Text == "")
                {
                    MessageBox.Show("Please enter the chemical name which you want to update..!");
                }

                else
                {
                    con.Open();
                    var query = "";
                    if (ispresent(con, t1add.Text))
                    {
                        query = @"UPDATE [dbo].[stockdb]
   SET [name] = '" + t1add.Text + "',[stock] ='" + t2add.Text + "',[type] = '" + cbadd.Text + "',[date] = '" + dtpadd.Text + "' WHERE name='" + t1add.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully!!");
                    }
                    else
                    {
                        MessageBox.Show("'" + t1add.Text + "' is not present in the list!!");
                    }
                    con.Close();
                    clearadd_Click(sender, e);
                    displaydata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void t1add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                t2add.Focus();
            }
        }
        private void t2add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbadd.Focus();
            }
        }
        private void cbadd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpadd.Focus();
            }
        }
        private void l2_Click(object sender, EventArgs e)
        {
        }
        private void removeb1cd_Click(object sender, EventArgs e)
        {
            try
            {
                string a = t1add.Text;
                quant = qty(a);
                if (t1add.Text == "" || t2add.Text == "")
                {
                    MessageBox.Show("Please enter the details!");
                }
                else
                {
                    con.Open();
                    var query = "";
                    if (ispresent(con, t1add.Text))
                    {
                        int n = Convert.ToInt32(t2add.Text);
                        if (quant >= n)
                        {
                            query = @"UPDATE [dbo].[stockdb]
   SET [stock] = [stock] -'" + t2add.Text + "'  WHERE name='" + t1add.Text + "'";
                            MessageBox.Show("" + t2add.Text + " stocks removed by you ..!!");
                        }
                        else
                        {
                            MessageBox.Show("" + t2add.Text + " stocks cannot be removed only " + quant + " is their..!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("'" + t1add.Text + "' is not present in the list!!");
                    }
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    clearadd_Click(sender, e);
                    displaydata();
                }
            }
            catch (Exception)
            {
                // MessageBox.Show("Invalid Activity", ex.Message);
            }
            finally { con.Close(); }

        }
        private void t1add_TextChanged(object sender, EventArgs e)
        {
            // con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT [name],[stock]
      ,[type]
      ,[date]
       FROM [dbo].[stockdb]
      WHERE name like '" + t1add.Text + "%' ", con);
            //  cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            gcd.DataSource = dt;
            con.Close();
        }
        public int qty(string ne)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand(@"SELECT * FROM [dbo].[stockdb]
           WHERE name='" + t1add.Text + "'", con);
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                quant = Convert.ToInt32(dr["stock"].ToString());
            }
            con.Close();
            return quant;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void gcd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in gcd.Rows)
            {
                int s = Convert.ToInt32(row.Cells[1].Value);
                if (s < 3)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }

            }
        }
    }

}
