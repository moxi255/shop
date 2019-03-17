using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Product_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "编辑产品";
        Ep229User user = (Ep229User)Session["user"];
        if (user == null || user.UserRight == 1)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('没权限');window.location.href='../Index.aspx'", true);
        }
    }
    //更新成功后返回影响的行数
    protected void ObjectDataSource1_Updated(object sender, ObjectDataSourceStatusEventArgs e)
    {
        e.AffectedRows = (int)e.ReturnValue;
    }
    //更新成功则跳转到Manage页面，否则在当前页面
    protected void DetailsViews1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        if (e.Exception == null)
        {
            if (e.AffectedRows > 0)
            {


                this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('修改成功');window.location.href='Manage.aspx'", true);
                return;
            }
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('修改失败'); ", true);

        }
    }
    //更新事件
    protected void DetailsViews1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        string catId = ((DropDownList)DetailsViews1.FindControl("DropDownList1")).SelectedValue;
        e.NewValues.Add("Category", new Ep229Category { CatId = Int32.Parse(catId) });
        
    }

    protected void DetailsViews1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        if (e.CancelingEdit)
        {
            Response.Redirect("~/Views/Product/Manage.aspx");
        }
    }


}