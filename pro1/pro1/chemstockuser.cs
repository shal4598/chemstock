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
    public partial class chemstockuser : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sdb"].ConnectionString);
        public chemstockuser()
        {
            InitializeComponent();
        }
        private void chemstockuser_Load(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            c.notify();
        }

        private void chemicalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "chemicaldetails")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                chemicaldetails cd = new chemicaldetails();
                cd.MdiParent = this;
                cd.Show();
            }
        }

        private void chemstockuser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            } 
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "status")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                status cd = new status();
                cd.MdiParent = this;
                cd.Show();
            }      
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userlogin w = new userlogin();
            this.Hide();
            w.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "history")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                history cd = new history();
                cd.MdiParent = this;
                cd.Show();
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                 bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "aboutus")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                aboutus cd = new aboutus();
                cd.MdiParent = this;
                cd.Show();
            }
        }
    }
}
