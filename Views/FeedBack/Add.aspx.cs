using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_FeedBack_Add : System.Web.UI.Page
{
    private Ep229FeedBackDAL feedBackDAL = new Ep229FeedBackDAL();
    private Ep229User user = new Ep229User();
    private Ep229FeedBack feedBack = new Ep229FeedBack();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //按钮1添加事件如果返回成功跳回首页，如果用户没登录，或者没反馈成功，还在当前页面
    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((user=(Ep229User)Session["user"]) != null)
        {
            feedBack.FbackTitle = TextBox1.Text;
            feedBack.FbackContent = TextBox2.Text;
            feedBack.user = user;
            if (feedBackDAL.Insert(feedBack) == 1)
            {
                this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                   "", "alert('反馈成功'); window.location.href='../Index.aspx'", true);
            }
            else
            {
                this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                   "", "alert('反馈失败');", true);
            }
            
        }
        else
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                   "", "alert('请先登录'); window.location.href='../Index.aspx'", true);
        }
    }
}