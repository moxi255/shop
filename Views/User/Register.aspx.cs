using System;

public partial class Views_User_Register : System.Web.UI.Page
{
    private Ep229User user = new Ep229User();
    private Ep229UserBLL userBLL = new Ep229UserBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "注册界面";
    }
    //注册按钮事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        user.UserName = TextBox1.Text;
        user.UserPwd = TextBox2.Text;
        user.UserRName = TextBox4.Text;
        user.UserEmail=TextBox5.Text;
        user.UserCompany=TextBox6.Text;
        user.UserTel = TextBox7.Text;
        user.UserFax = TextBox8.Text;
        if (userBLL.AddUser(user) == 1) {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('注册成功');window.location.href='../Index.aspx'", true);
        }
        else
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('注册成功');window.location.href='Register.aspx'", true);
        }
            
    }
}