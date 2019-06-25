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
    public partial class adduser : Form
    {
        Regex expr,expr2,expr3;
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sdb"].ConnectionString);
        public adduser()
        {
            InitializeComponent();
        }
        private void adduser_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
         
            fnt1au.Focus();
            displaydata();
        }
        private void addus_Click(object sender, EventArgs e)
        {
            try
            {                
                int i = 0;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [id]  ,[firstname],[lastname],[username],[password]
      ,[contact]
  FROM [dbo].[registration] where username='" + unt3au.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    if (fnt1au.Text == "" || lnt2au.Text == "" || unt3au.Text == "" || unt3au.Text == "" || ct6au.Text == "" || passt4au.Text == "" || rpasst5au.Text == "")
                    {
                        MessageBox.Show("Please enter the details...!");
                    }
                    else if (nameexp(fnt1au.Text) == false || nameexp(lnt2au.Text) == false)
                    {                        
                        MessageBox.Show("name should contain only characters...!");
                    }
                    else if (passwordexp(passt4au.Text) == false)
                    {
                        MessageBox.Show("Password must contain  8 to 15 characters,a-z,A-Z,0-9");
                    }
                    else if(phone(ct6au.Text)==false)
                    {                       
                        MessageBox.Show("Please enter valid contact...!");
                    }                   
                    else
                    {
                        if (passt4au.Text == rpasst5au.Text)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[registration]
           ([firstname]
           ,[lastname]
           ,[username]
           ,[password]
           ,[contact])
     VALUES
           ('" + fnt1au.Text + "', '" + lnt2au.Text + "'  , '" + unt3au.Text + "' , '" + passt4au.Text + "' , '" + ct6au.Text + "' )", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            resetus_Click(sender, e);
                            displaydata();
                            MessageBox.Show("User record inserted successfully...!");                            
                        }
                        else
                        {
                            label7.ForeColor = Color.Red;
                            label7.Text = "Password not Matched";   
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This username is already registred please choose another...!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
        private void resetus_Click(object sender, EventArgs e)
        {
            fnt1au.Text = ""; lnt2au.Text = ""; unt3au.Text = ""; unt3au.Text = ""; ct6au.Text = ""; passt4au.Text = "";
            rpasst5au.Text = ""; label7.Text = "";
        }
        public void displaydata()
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * from registration", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvad.DataSource = dt;

        }
        private void fnt1au_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lnt2au.Focus();
            }
        }
        private void lnt2au_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                unt3au.Focus();
            }
        }
        private void unt3au_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passt4au.Focus();
            }
        }
        private void passt4au_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rpasst5au.Focus();
            }
        }
        private void rpasst5au_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ct6au.Focus();
            }

        }
        private void ct6au_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addus.Focus();
            }
        }
        private void deleteus_Click(object sender, EventArgs e)
        {
            try
            {

                int id;
                id = Convert.ToInt32(dgvad.SelectedCells[0].Value.ToString());
                if (unt3au.Text == "" || unt3au.Text == "admin")
                {
                    MessageBox.Show("Please enter the username name which you want to delete!");
                }
                else
                {
                   
                        DialogResult dg = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(@"Delete 
  FROM [dbo].[registration] where id='" + id + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show(" Deleted Successfully!!");
                            displaydata();
                            resetus_Click(sender, e);
                        }

                    }                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
       
        }
        private void dgvad_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                fnt1au.Text = dgvad.SelectedRows[0].Cells[1].Value.ToString();
                lnt2au.Text = dgvad.SelectedRows[0].Cells[2].Value.ToString();
                unt3au.Text = dgvad.SelectedRows[0].Cells[3].Value.ToString();
                passt4au.Text = dgvad.SelectedRows[0].Cells[4].Value.ToString();
                rpasst5au.Text = dgvad.SelectedRows[0].Cells[4].Value.ToString();
                ct6au.Text = dgvad.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
        public bool ispresent(SqlConnection con, string a)
        {
            string b = unt3au.Text;
          //  con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM registration
      WHERE username='" + b + "'", con);
            cmd.ExecuteNonQuery();
        //    con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            { return true; }
            else
            { return false; }

        }
        private void ct6au_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }
        private void fnt1au_Validating(object sender, CancelEventArgs e)
        {          
        }
        private void fnt1au_TextChanged(object sender, EventArgs e)
        {

        }
        private void updateus_Click(object sender, EventArgs e)
        {
            try
            {
                int id1;
                id1 = Convert.ToInt32(dgvad.SelectedCells[0].Value.ToString());
                if (unt3au.Text == "")
                {
                    MessageBox.Show("Please enter the username name which you want to update..!");
                }

                else
                {
                    
                    con.Open();                   
                    if (ispresent(con, unt3au.Text))
                    {
                         if (fnt1au.Text == "" || lnt2au.Text == "" || unt3au.Text == "" || unt3au.Text == "" || ct6au.Text == "" || passt4au.Text == "" || rpasst5au.Text == "")
                    {
                        MessageBox.Show("Please enter the details...!");
                    }
                    else if (nameexp(fnt1au.Text) == false || nameexp(lnt2au.Text) == false)
                    {                        
                        MessageBox.Show("name should contain only characters...!");
                    }
                    else if (passwordexp(passt4au.Text) == false)
                    {
                        MessageBox.Show("Password must contain  8 to 15 characters,a-z,A-Z,0-9");
                    }
                    else if(phone(ct6au.Text)==false)
                    {                       
                        MessageBox.Show("Please enter valid contact...!");
                    }                   
                         else if (passt4au.Text == rpasst5au.Text)
                        {
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[registration]
   SET [firstname] =  '" + fnt1au.Text + "'  ,[lastname] = '" + lnt2au.Text + "'  ,[username] = '" + unt3au.Text + "' ,[password] = '" + passt4au.Text + "' ,[contact] = '" + ct6au.Text + "' WHERE  id= '" + id1 + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    resetus_Click(sender, e);
                    MessageBox.Show("Record Updated Successfully!!");
                                                     }
                        else
                        {
                            label7.ForeColor = Color.Red;
                            label7.Text = "Password not Matched";   
                        }

                  }
                    else
                    {
                        MessageBox.Show("'" + unt3au.Text + "' User  does not exist!!");
                    }
                    con.Close();
                  
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
        private void rpasst5au_TextChanged(object sender, EventArgs e)
        {
            if (passt4au.Text == rpasst5au.Text)
            {
                label7.ForeColor = Color.Green;
                label7.Text = "Password Matched";
            }
            else
            {
                label7.ForeColor = Color.Red;
                label7.Text = "Password not Matched";
            }
        }
        private void ct6au_TextChanged(object sender, EventArgs e)
        {

        }
        public bool phone(string no)
        {        
            expr = new Regex(@"^(7|8|9){1}[0-9]{9}$");
           
            if (expr.IsMatch(no))
            {
                return true;
            }
            else return false;
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
        public bool nameexp(string p)
        {
            expr3 = new Regex(@"^[a-z,A-Z]+$");
           
            if (expr3.IsMatch(p))
            {
                return true;
            }
            else return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
        
     /*   public void err()
        {
            errorProvider1.Clear();
            if (fnt1au.Text.Length < 1)
            {
                fnt1au.Focus();
                errorProvider1.SetError(fnt1au, "Please enter first name..!");
            }
            else if (lnt2au.Text.Length < 1)
            {
                errorProvider1.SetError(lnt2au, "Please enter first name..!");
            }
        }*/
    }
}
