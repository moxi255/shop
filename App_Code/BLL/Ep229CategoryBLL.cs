using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229CategoryBLL 的摘要说明
/// </summary>
/// Category业务逻辑实现类（实现了Iep229categoryBLL的接口）
public class Ep229CategoryBLL:IEp229CategoryBLL
{
    private Ep229CategoryDAL CategoryDAL = new Ep229CategoryDAL();
    private Ep229ProductDAL ProductDAL = new Ep229ProductDAL();
    //增加一个类别
    public int AddCategory(Ep229Category category)
    {
        return CategoryDAL.Insert(category);
    }
    //删除一个类别（先删选该类下的全部产品再删除该类）
    public int DeleteCategory(Ep229Category category)
    {
        ProductDAL.DeleteByCid(category.CatId);
        return CategoryDAL.Delete(category.CatId);
    }
    //编辑一个类别
    public int EditCategory(Ep229Category category)
    {
        return CategoryDAL.Update(category);
    }
    //根据Cid找一个类
    public Ep229Category FindCategoryById(int CatId)
    {
        return CategoryDAL.SelectById(CatId);
    }
    //找到全部的类
    public IList<Ep229Category> FindCategoryies()
    {
        return CategoryDAL.SelectAll();
    }
}