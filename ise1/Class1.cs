using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using Newtonsoft.Json.Linq;
//using System.Net.Http.Formatting;

namespace WindowsFormsApp15
{
    class Class1
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nitis\OneDrive\Documents\niteshdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public int adddata(int id,string name, int price, int amount)
        {
            String qry = "Insert into nik123 values ("+ id +",'" + name + "'," + price + "," + amount + ")";
            Con.Open();
            cmd = new SqlCommand(qry, Con);
            int no = cmd.ExecuteNonQuery();
            Con.Close();
            return no;
        }
        SqlDataAdapter adpt;
        SqlCommandBuilder bld;
        DataTable dt;

        public SqlConnection Con { get => con; set => con = value; }

        public DataTable Display_data()
        {
            String qry = "select * from nik123";
            adpt = new SqlDataAdapter(qry, Con);
            bld = new SqlCommandBuilder(adpt);
            dt = new DataTable();
            adpt.Fill(dt);
            Con.Close();
            return dt;

        }

        public int deleteAsset(int id)
        {
            String qry = "Delete from nik123 where id = " + id + "";
            Con.Open();
            cmd=new SqlCommand(qry, Con);
            int dele = cmd.ExecuteNonQuery();
            Con.Close();
            return dele;
        }
        public void NumberOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }

    internal class sqlConnection
    {
    }
}
