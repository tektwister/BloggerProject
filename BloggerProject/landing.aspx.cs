using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloggerProject
{
    public partial class landing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["id"]!=null)
            {
                logLabel.Text = Session["id"].ToString();
                logstatus.InnerHtml = "<b>Log out</b>";
                
            }
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=blog;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Content", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            feed.DataSource = ds;
            feed.DataBind();
        }
    }
}