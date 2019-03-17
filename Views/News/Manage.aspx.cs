using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_News_Manage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ep229User user = (Ep229User)Session["user"];
        if (user == null || user.UserRight == 1)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('没权限');window.location.href='../Index.aspx'", true);
        }
    }
    //按钮1添加属性让他进入添加页面
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Views/News/Add.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}