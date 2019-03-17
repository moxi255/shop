using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Product_Manage : System.Web.UI.Page
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

    //查询按钮事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        Ep229ProductBLL ep229productBll= new Ep229ProductBLL();
        GridViews1.DataSourceID= null;
        GridViews1.DataSource = ep229productBll.search(name);
        GridViews1.DataBind();

    }
}