using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;
using System.Data;

namespace pro1
{
    class Class1
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sdb"].ConnectionString);
        public void notify()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand(@"SELECT [name] FROM [dbo].[stockdb]
      WHERE stock=0", con);
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int a = dt.Rows.Count;
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = a+" Stock is over";
                popup.TitleColor = System.Drawing.Color.Red;
                popup.ContentColor = System.Drawing.Color.RoyalBlue;
                
                
               // popup.Image = Properties.Resources.imagename;
                popup.ContentText = "Please refill the stock and for more detail see status";
                popup.Popup();
            }
            con.Close();
        }
    }
}
