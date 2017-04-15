using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            connect();
        }
    }
    private void connect()
    {
        string conString = @"Data Source=localhost; Database=mysqltest; UserID=root; password=''";
        using (MySqlConnection con = new MySqlConnection(conString))
        {
            con.Open();
            Response.Write("MySQL Connection Sucessful!");
        }
    }
}