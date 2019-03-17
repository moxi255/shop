using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_News_Details : System.Web.UI.Page
{   
    private Ep229NewsBLL NewsBll = new Ep229NewsBLL();
    private Ep229News News = new Ep229News();
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "新闻详情";
        int newsId = Convert.ToInt32(Request["NewsId"]);
        News = NewsBll.FindNewsById(newsId);
        TextBox3.Text = News.NewsTitle;
        TextBox4.Text = News.NewsContent;
        Uri Url = HttpContext.Current.Request.UrlReferrer;
        //根据url判读返回的路径
        if (String.Compare(Url.LocalPath, "Views/News/Browse") == 0)
        {
            Button2.PostBackUrl = "~/Views/Index.aspx";
        }
        else if (String.Compare(Url.LocalPath, "/Views/News/Manage") == 0)
        {
            Button2.PostBackUrl = "~/Views/Product/Manage.aspx";
        }else
        {
            Button2.PostBackUrl = "~/Views/Index.aspx";
        }
    }

}