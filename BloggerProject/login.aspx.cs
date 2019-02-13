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
    public partial class login : System.Web.UI.Page
    {
        /*private SqlConnection Connection;
        private DataSet ds;
        private SqlDataAdapter adapter;
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
         public void LoginCheck()
         {
             string sql = "Select * From [blog].[dbo].[BlogUser]";
             SqlCommand myCommand = new SqlCommand(sql, sqlCon);
             int flag = 0;
             // Obtain a data reader using ExecuteReader().      
             using (SqlDataReader myDataReader = myCommand.ExecuteReader())
             {
                 while (myDataReader.Read())
                 {
                     if ((myDataReader["Email"].ToString() == mail.Value) && (myDataReader["Password"].ToString() == pass.Value))
                     {
                         flag = 1;
                     }
                 }
                 if (flag == 1)
                 {
                     Label1.Text = "Login Sucessfull";
                 }
                 else
                 {
                     Label1.Text = myDataReader["Email"].ToString();
                 }
             }

         }*/
        public Boolean checkEqual(string a,string b)
        {
            int fl = 0;
            if(a.Length == b.Length)
            {
                for (var i = 0; i < a.Length; i++)
                {
                    
                    if (a[i] == b[i])
                    {
                        fl++;
                    }
                }
            }
            
            if(fl==a.Length)
            {
                return true;
            }
            return false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login(object sender, EventArgs e)
        {/*
            string str = @"Data Source= (local); Integrated Security=SSPI; Initial Catalog=blog";
            OpenConnection(str);
            LoginCheck();
            CloseConnection();
            string ConnectionString = @"Data Source= (local); Integrated Security=SSPI; Initial Catalog=blog";
            Connection = new SqlConnection(ConnectionString);
            ds = new DataSet("BlogLogin");
            string sql = "Select * From [blog].[dbo].[BlogUser]";

            adapter = new SqlDataAdapter(sql, Connection);

            // Fill our DataSet with a new table, named Inventory.  
            //Fill Method returns number of rows extracted from the table
            int RowsInInventory = adapter.Fill(ds, "LoginClient");
            DataTable dt = ds.Tables[0];
            int flag = 0;
            for (var curRow = 0; curRow < dt.Rows.Count; curRow++)
            {
                if(checkEqual(dt.Rows[curRow][2].ToString(),mail.Value.ToString()))
                {
                    if(checkEqual(dt.Rows[curRow][3].ToString(),pass.Value.ToString()))
                    {
                        flag = 1;
                    }
                }
                //Label1.Text = checkEqual(dt.Rows[curRow][2].ToString(), mail.Value.ToString()).ToString();
                Label1.Text = (string.Compare(dt.Rows[curRow][2].ToString(), mail.Value.ToString()) == 0).ToString();
            }
            if(flag==1)
            {
                Label1.Text = "Login Sucessfull";
            }
            else
            {
                Label1.Text = "Login Unsucessfull";
            }*/
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source= (local); Integrated Security=SSPI; Initial Catalog=blog");
                SqlCommand cmd = new SqlCommand("select * from [blog].[dbo].[BlogUser] where [blog].[dbo].[BlogUser].[Email]=@username and [blog].[dbo].[BlogUser].[Password]=@word", con);
                cmd.Parameters.AddWithValue("@username", mail.Value);
                cmd.Parameters.AddWithValue("@word", pass.Value);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    Session["id"] = mail.Value;
                    logLabel.Text = mail.Value;
                    logstatus.InnerHtml = "<b>Log out</b>";
                    Response.Redirect("./landing.aspx");
                }
                else
                {
                    Label1.Text = "Credentials incorrect";
                    Label1.ForeColor = System.Drawing.Color.Red;

                }
            }
            catch (SqlException sq) { }
            finally { }
        }
    }
}