using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Product_Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "产品详情";
        //根据url判断返回的url
        Uri Url = HttpContext.Current.Request.UrlReferrer;
        if(String.Compare(Url.LocalPath, "/Views/Index") == 0)
        {
            Button1.PostBackUrl = "~/Views/Index.aspx";
        }else if(String.Compare(Url.LocalPath, "/Views/Product/Manage") == 0)
        {
            Button1.PostBackUrl = "~/Views/Product/Manage.aspx";
        }
        else{
            Button1.PostBackUrl = "~/Views/Index.aspx";
        }

    }

}