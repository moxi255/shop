using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_User_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "密码更改";
        if (!IsPostBack)
        {   
            Ep229User user = (Ep229User)Session["user"];
            if (user != null)
            {
                TextBox1.Text = user.UserName;
            }
            
        }
    }
    //修改密码事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        Ep229UserBLL UserBLL = new Ep229UserBLL();
        Ep229User user = new Ep229User();
        user = (Ep229User)Session["user"];
        user.UserPwd = TextBox2.Text;       
        if (UserBLL.EditUser(user) == 1)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                   "", "alert('修改成功'); window.location.href='../index.aspx'", true);
        }
        else
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                  "", "alert('修改失败'); window.location.href='Edit.aspx'", true);
        }
    }
}