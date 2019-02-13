using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BloggerProject
{
    public partial class profile : System.Web.UI.Page
    {
        private SqlConnection sqlCon = null;
        public void OpenConnection(string conStr)
        {
            sqlCon = new SqlConnection { ConnectionString = conStr };
            sqlCon.Open();
        }
        public void CloseConnection()
        {
            sqlCon.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                logLabel.Text = Session["id"].ToString();
                logstatus.InnerHtml = "<b>Log out</b>";
                string str = @"Data Source= (local); Integrated Security=SSPI; Initial Catalog=blog";
                OpenConnection(str);
                string sql = "Select * From [blog].[dbo].[BlogUser] where [blog].[dbo].[BlogUser].[Email] = '" + Session["id"].ToString() + "'";
                SqlCommand myCommand = new SqlCommand(sql, sqlCon);

                // Obtain a data reader using ExecuteReader().      
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        name.Text = myDataReader["Name"].ToString();
                        prof.Text = myDataReader["Profession"].ToString();
                        mail.Text = myDataReader["Email"].ToString();
                    }
                }
                CloseConnection();
            }
        }
    }
}