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
    public partial class newform : System.Web.UI.Page
    {
        private SqlConnection sqlCon = null;
        public void OpenConnection(string conStr)
        {
            sqlCon = new SqlConnection { ConnectionString = conStr };
            sqlCon.Open();
        }
        public void Insert(string i, string c, string m)
        {
            // Format and execute SQL statement.  
            string sqlQuery = "Insert Into [blog].[dbo].[Content](Name, Topic, Cont) Values ('" + i + "','" + c + "','" + m + "')";

            // Execute using our connection.  
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlCon))
            {
                command.ExecuteNonQuery();
            }
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void New_Feed(object sender, EventArgs e)
        {
            string str = @"Data Source= (local); Integrated Security=SSPI; Initial Catalog=Blog";
            OpenConnection(str);
            Insert(name.Value, topic.Value, content.Value);
            CloseConnection();
            name.Value = "";
            topic.Value = "";
            content.Value = "";
        }
    }
}