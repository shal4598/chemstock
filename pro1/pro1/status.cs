using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Collections;
using System.IO;



//using PagedList;

namespace pro1
{
    public partial class status : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sdb"].ConnectionString);
        public status()
        {
            InitializeComponent();
        }

        private void status_Load(object sender, EventArgs e)
        {
            displaydata();
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
  FROM [stock].[dbo].[stockdb] where stock < 2", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);                
                gvstatus.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = gvstatus.Rows.Add();
                    gvstatus.Rows[n].Cells[0].Value = false;
                     gvstatus.Rows[n].Cells[1].Value=item["name"].ToString();
                     gvstatus.Rows[n].Cells[2].Value = item["stock"].ToString();
                     gvstatus.Rows[n].Cells[3].Value = item["type"].ToString();                   
                }
               
                con.Close();

                if (gvstatus.Rows.Count > 0)
                {
                    label1.Text = gvstatus.Rows.Count.ToString();                   
                }
                else
                {
                    label1.Text += "0";
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void gvstatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b1status_Click(object sender, EventArgs e)
        {
            gvcart.Rows.Clear();
            foreach(DataGridViewRow item in gvstatus.Rows )
            {
               
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = gvcart.Rows.Add();
                       gvcart.Rows[n].Cells[0].Value=item.Cells[1].Value.ToString();
                        gvcart.Rows[n].Cells[1].Value = item.Cells[3].Value.ToString();
                }

                }
            displaydata();
           
        }

        private void gvstatus_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)gvstatus.SelectedRows[0].Cells[0].Value==false)
            {
                gvstatus.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                gvstatus.SelectedRows[0].Cells[0].Value=false;
            }
        }

        private void b1cart_Click(object sender, EventArgs e)
        {
          // printDocument1.Print();
           PrintDialog printDialog = new PrintDialog();
           printDialog.Document = printDocument1;
           printDialog.UseEXDialog = true;
           if (DialogResult.OK == printDialog.ShowDialog())
           {
               printDocument1.DocumentName = "Document";
               printDocument1.Print();
           }
           

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           Bitmap bm = new Bitmap(this.gvstatus.Width, this.gvstatus.Height);
            gvcart.DrawToBitmap(bm,new Rectangle(0,0,this.gvcart.Width,this.gvcart.Height));
            e.Graphics.DrawImage(bm,0,0);   
                      
        }

        private void gvcart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   /*     private void searchlessthanstockToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.stockdbTableAdapter.searchlessthanstock(this.stockDataSet.stockdb);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/
       private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            string sHeaders = "";
            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            for (int i = 0; i <= dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)                
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
                
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void b2status_Click(object sender, EventArgs e)
        {
           SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(gvcart, sfd.FileName);
            }  
          
        }
    }
}
