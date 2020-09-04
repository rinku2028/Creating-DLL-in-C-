using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using addnumdll;

namespace mathcalldll
{
    public partial class math : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsum_Click(object sender, EventArgs e)
        {
            int a, b;
            //string str;
            addnumdll.Class1 aa = new addnumdll.Class1();
            a = Convert.ToInt32(txtfirst.Text);
            b = Convert.ToInt32(txtsecond.Text);
            Response.Write( "Total:"+"\t" +aa.substract(a, b));
            int total;
            //total = Convert.ToInt32(txttotal.Text);
            Response.Write("Substract:" + aa.substract(a, b));
            total = aa.substract(a, b);
            lblmsg.Text = Convert.ToInt32(total).ToString();
            txttotal.Text = Convert.ToInt32(total).ToString();

            //txttotal.Text = (aa.substract(a, b));

        }
    }
}