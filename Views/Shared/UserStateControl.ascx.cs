using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Shared_UserStateControl : System.Web.UI.UserControl
{
    private Ep229UserBLL userBLL = new Ep229UserBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {   //先根据session判断，如果没有从cookie中取
            Ep229User user = (Ep229User)Session["user"];
            if (user == null)
            {
                if (Request.Cookies["userId"] != null)
                {
                    int userId = Int32.Parse(Request.Cookies["userId"].Value);
                    user = userBLL.FindUserById(userId);
                    Session["user"] = user;
                }
            }
        }
        //如果会话存在则根据权限，选择面版
        if (Session["user"] != null)
        {
            Ep229User user = (Ep229User)Session["user"];
            Literal1.Text = user.UserName;
            //0为管理员
            if (user.UserRight == 0)
            {
                HyperLink2.Visible = true;
                HyperLink3.Visible = true;
                HyperLink4.Visible = true;
                HyperLink5.Visible = true;
               
            }
            //1为普通用户
            else if(user.UserRight == 1)
            {
                HyperLink2.Visible = false;
                HyperLink3.Visible = false;
                HyperLink4.Visible = false;
                HyperLink5.Visible = false;
            }
            MultiView1.ActiveViewIndex = 1;
        }
        else
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
    //登录按钮事件，先去判断用户名和密码是否正确
    protected void Login_Click(object sender, EventArgs e)
    {
        Ep229User user = userBLL.FindUserByNameAndPwd(UserName.Text,Pwd.Text);
        if (user != null)
        {
            if (Remember.Checked)
            {
                HttpCookie cookie = new HttpCookie("userId");
                cookie.Path = "/";
                cookie.Value = user.UserId.ToString();
                cookie.Expires = DateTime.Now.AddDays(7) ;
                Response.Cookies.Add(cookie);

            }
            Session["user"] = user;
            Response.Redirect("~/Views/index.aspx");
        }else
        {
            Response.Write("<script>alert('用户名或密码错误')</script>");
        }
    }
   //注册按钮事件
    protected void Register_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Views/User/Register.aspx");
    }
    //注销点击事件
    protected void LinkButton_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/Views/Index.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        HttpCookie cookie = new HttpCookie("userId");
        cookie.Expires = DateTime.Now.AddDays(-30);
        Response.Cookies.Add(cookie);
        Response.Redirect("~/Views/Index.aspx");
    }

}