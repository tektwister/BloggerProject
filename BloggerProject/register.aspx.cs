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
    public partial class register : System.Web.UI.Page
    {
        private SqlConnection sqlCon = null;
        public void OpenConnection(string conStr)
        {
            sqlCon = new SqlConnection { ConnectionString = conStr };
            sqlCon.Open();
        }
        public void Insert(string i, string c, string m, string p) 
        {
            // Format and execute SQL statement.  
            string sqlQuery = "Insert Into [blog].[dbo].[BlogUser](Name, Profession, Email, Password) Values ('" + i + "','" + c + "','" + m + "', '" + p + "')";

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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Registering_User(object sender, EventArgs e)
        {
            string str = @"Data Source= (local); Integrated Security=SSPI; Initial Catalog=Blog";
            OpenConnection(str);
            Insert(name.Value, prof.Value, mail.Value, pass.Value);
            CloseConnection();
            Response.Redirect("./landing.aspx");
        }
    }
}