using System;
using System.Web.UI.WebControls;
public partial class Views_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "主页";
    }
    //图片点击跳转相应的页面详情页面
    protected void ListViews1_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        Response.Redirect("~/Views/Product/Details.aspx?prodId="+e.CommandArgument);
    }
}