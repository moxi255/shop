using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_User_Detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "用户详情";
        //根据session取得当前用户详情
        Ep229User user = (Ep229User)Session["user"];
        if (user != null)
        {
            userid.Text = user.UserName;
            name.Text = user.UserRName;
            email.Text = user.UserEmail;
            company.Text = user.UserCompany;
            tel.Text = user.UserTel;
            fax.Text = user.UserFax;
        }
    }
}