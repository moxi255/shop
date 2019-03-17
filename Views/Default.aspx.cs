using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection a = ConnectDB.Connect();
        try
        {
            a.Open();
            Label1.Text = "111";
            a.Close();
        }
        catch (Exception e1)
        {
            Label1.Text = e1.Message;
        }
    }
}