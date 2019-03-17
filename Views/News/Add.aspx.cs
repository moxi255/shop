using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_News_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "添加新闻";
        Ep229User user = (Ep229User)Session["user"];
        if (user == null || user.UserRight == 1)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('没权限');window.location.href='../Index.aspx'", true);
        }
    }
    //添加成功事件，添加成功返回管理页面，失败则停在当前页面
    protected void Button1_Click(object sender, EventArgs e)
    {
        Ep229NewsBLL NewsBll = new Ep229NewsBLL();
        Ep229News News=new Ep229News();
        News.NewsTitle=title1.Text;
        News.NewsContent=contain.Text;
        if (NewsBll.AddNews(News) == 1)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                   "", "alert('添加成功'); window.location.href='Manage.aspx'", true);
        }
        else
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                  "", "alert('添加失败'); window.location.href='Add.aspx'", true);
        }
    }
}