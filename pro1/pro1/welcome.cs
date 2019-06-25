using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pro1
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin al = new adminlogin();
            al.Show();
            

        }

        private void welcomeb2_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogin ul = new userlogin();
            ul.Show();
            

        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
