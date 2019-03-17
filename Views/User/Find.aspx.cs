using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_User_Find : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    //验证码控件事件
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string cede = (string)Session["CheckCode"];
        if (Session["CheckCode"].ToString().Trim().Equals(TextBox3.Text.Trim().ToUpper()))
        {
            args.IsValid = true;
            
        }else
        {
            args.IsValid = false;
            return;
        }
    }
    //根据名字邮箱查找用户，确定修改密码
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string email = TextBox2.Text;
        Ep229UserDAL UserDAL = new Ep229UserDAL();
        int i=UserDAL.FindPwd(name, email);
        if (i == 1)
        {
            Response.Redirect("Edit.aspx");
        }
        else
        {
            Response.Write("<script>alert('用户名或邮箱错误')</script>");
        }
        
    }
}