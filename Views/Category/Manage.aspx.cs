using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Category_Manage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   
        //判断用户是否能有权限访问该页面
        Ep229User user = (Ep229User)Session["user"];
        if (user == null || user.UserRight == 1)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('没权限');window.location.href='../Index.aspx'", true);
        }
    }

    //对objectDataSource1插入的方法，从text1中获取类名
    protected void ObjectDataSource1_Inserting(object sender,ObjectDataSourceMethodEventArgs e)
    {
        e.InputParameters.Add("category", new Ep229Category { CatName = TextBox1.Text });
    }
    //添加按钮1事件，按钮1消失，按钮2出现，按钮3出现，输入窗出现
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Button1.Visible = false;
        Button2.Visible = true;
        Button3.Visible = true;
        TextBox1.Visible = true;
    }
    //添加按钮2事件，按钮2，3消失，按钮1出现，输入窗消失，插入数据
    protected void Button2_Click1(object sender, EventArgs e)
    {
        ObjectDataSource1.DataObjectTypeName = null;
        ObjectDataSource1.Insert();
        Button1.Visible = true;
        Button2.Visible = false;
        Button3.Visible = false;
        TextBox1.Visible = false;
    }
    //添加按钮3事件，按钮2，3消失，按钮1出现，输入窗消失，
    protected void Button3_Click1(object sender, EventArgs e)
    {
        Button1.Visible = true;
        Button2.Visible = false;
        Button3.Visible = false;
        TextBox1.Visible = false;
    }


}