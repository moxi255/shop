using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Shared_Controls_CatMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) ViewState["CatId"] = 0;
    }
    //从视图状态中取值
    public int CatId
    {
        get { return Int32.Parse(ViewState["CatId"].ToString()); }
    }

    //根据点击，取出catID进行查询产品
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        ViewState["CatId"] = Int32.Parse(e.CommandArgument.ToString());
    }
    

}