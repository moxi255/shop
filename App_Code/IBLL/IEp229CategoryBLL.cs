using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229CategoryBLL 的摘要说明
/// </summary>
/// 业务逻辑接口层

public interface IEp229CategoryBLL
    {
        int AddCategory(Ep229Category category);
        int EditCategory(Ep229Category category);
        int DeleteCategory(Ep229Category category);
        Ep229Category FindCategoryById(int CatId);
        IList<Ep229Category> FindCategoryies();
    }