using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using connectdb;
using System.Data.SqlClient;
using System.Data;
using databaseconn;

namespace mathcalldll
{
    public partial class calldb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnview_Click(object sender, EventArgs e)
        {
            string str = "Data Source=desktop-tb3r1mj;Initial Catalog=nibl;Integrated Security=True";
            connectdb.Class1 db = new connectdb.Class1(str);
            if (db.connect() == true)
            {
                Response.Write("Database connected successfully!");
                string sqlqr = @"select branch from niblbranch";
                db.sqlreader(sqlqr);
                DataTable dt = new DataTable();
                dt.Load(db.sqlreader(sqlqr));
                gdview1.DataSource = dt;
                gdview1.DataBind();

            }
            else
            {
                Response.Write("Not able to connect to database!");
            }

            /*/ string str = "Data Source=desktop-tb3r1mj;Initial Catalog=nibl;Integrated Security=True;";
             SqlConnection sqlconn = new SqlConnection(str);
             sqlconn.Open();
             string sql = @"select branch from niblbranch";
             SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
             SqlDataReader reader = sqlcmd.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(reader);*/
            //sqlconn.Close();
           
            
            /*connectdb.Class1 db1 = new connectdb.Class1();
            db1.niblconn();
            gdview1.DataSource = db1.niblconn();
            gdview1.DataBind();*/

            /*databaseconn.Class1 db = new databaseconn.Class1();
            db.connectsql();
            gdview1.DataSource = db.connectsql();
            gdview1.DataBind();*/

            



        }

        protected void btndb_Click(object sender, EventArgs e)
        {
            string str = "Data Source=desktop-tb3r1mj;Initial Catalog=nibl;Integrated Security=True";
            connectdb.Class1 db = new connectdb.Class1(str);
            if(db.connect()==true)
            {
                Response.Write("Database connected successfully!");
                string sql= @"select * from info";
                db.sqlreader(sql);
                db.dataread(sql);
                gdview2.DataSource = db.dataread(sql);
                gdview2.DataBind();
            }

        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            string str = "Data Source=desktop-tb3r1mj;Initial Catalog=nibl;Integrated Security=True";
            connectdb.Class1 db = new connectdb.Class1(str);
            if(db.connect()==true)
            {
                string sql="insert into niblbranch(sol,branch) values(3,'BIRGUNJ')";
                db.Insert(sql);

            }
            else
            {
                Response.Write("Not able to connect to database!");

            }
        }
    }
}