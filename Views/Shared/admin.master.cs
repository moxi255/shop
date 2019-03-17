using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Shared_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ep229User user = (Ep229User)Session["user"];
        //根据权限显示页面
        if (user == null || user.UserRight == 1)
        {
            manage_list1.Visible = false;
            manage_list2.Visible = false;
            manage_list3.Visible = false;
            manage_list4.Visible = false;
            manage_list5.Visible = false;
            manage_list6.Visible = false;
            user_list2.Visible = false;
            user_list3.Visible = false;
            user_list4.Visible = false;
            user_list1.InnerHtml="";
            user_list1.InnerHtml = "<a href='../index.aspx'>登录</a>";
            contain.Attributes.Add("class", "span12");
        }
    }
    //退出登录事件
    public void loginOutClick(object sender, EventArgs e)
    {
        Session.Abandon();
        HttpCookie cookie = new HttpCookie("userId");
        cookie.Expires = DateTime.Now.AddDays(-30);
        Response.Cookies.Add(cookie);
        Response.Redirect("~/Views/Index.aspx");
    }
}
