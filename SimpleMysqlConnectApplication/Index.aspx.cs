using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleMysqlConnectApplication
{
    public partial class Index : System.Web.UI.Page
    {
        public MySqlConnection con = new MySqlConnection("Server=localhost;Database=databasename;Uid=username;Pwd=password;Encrypt=false;AllowUserVariables=True;UseCompression=True;Charset=utf8");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            if (con.State != ConnectionState.Closed)
            {

                connectsuccess.Style["display"] = "block";
                con.Close();
            }
            else
            {
                connectfailed.Style["display"] = "block";                
            }
        }
    }
}