using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Product_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "添加产品";
        Ep229User user = (Ep229User)Session["user"];
        if (user == null || user.UserRight == 1)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('没权限');window.location.href='../Index.aspx'", true);
        }
    }
    //上传图片事件
    protected void DetailsViews1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        string saveDir = @"\Views\Images\";

        string appPath = Request.PhysicalApplicationPath;

        FileUpload upload = ((FileUpload)DetailsViews1.FindControl("FileUpload1"));
        e.Values.Add("Category", new Ep229Category
        {
            CatId = Int32.Parse(e.Values["CatId"].ToString())
        });
        e.Values.Remove("CatId");
        if (upload.HasFile)

        {

            int fileSize = upload.PostedFile.ContentLength;
            if (fileSize < 2100000)
            {
                string ext = System.IO.Path.GetExtension(upload.FileName);
                if ((ext == ".jpg") || (ext == ".gif"))
                {
                    string filename = DateTime.Now.Ticks.ToString()+ ext;
                    string savePath = appPath + saveDir + filename;
                    upload.SaveAs(savePath);
                    e.Values.Add("ProdImage", filename);
                }
                else
                {

                    this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                    "", "alert('添加失败上传图片扩展名必须是.jpg或.gif'); ", true);
                    e.Cancel = true;
                }
            }
            else
            {
                this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                    "", "alert('上传文件的大小不能超过2MB'); ", true);
                e.Cancel = true;
            }
                //文件大小大约为2MB

            }
    }
    //上传完成事件
    protected void DetailsViews1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if (e.Exception == null)

        {

            if (e.AffectedRows > 0)

            {

                this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('添加成功');window.location.href='Manage.aspx'", true);
                return;
            }
            this.ClientScript.RegisterClientScriptBlock(this.GetType(),
                 "", "alert('添加失败'); ", true);

        }
    }
    //ModeChanging事件，页面重定向到Manage.aspx
    protected void DetailsViews1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        if (e.CancelingEdit)
        {
            Response.Redirect("~/Views/Product/Manage.aspx");
        }
    }
    //objectSource1c插入后事件,影响的行数
    protected void ObjectDataSource1_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
    {
        e.AffectedRows = (int)e.ReturnValue;
    }

   
}