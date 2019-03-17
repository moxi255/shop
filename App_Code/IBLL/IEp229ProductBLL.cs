using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229ProductBLL 的摘要说明
/// </summary>
/// 业务逻辑接口层
public interface IEp229ProductBLL
{   
    //增
    int AddProduct(Ep229Product product);
    //删
    int DeleteProduct(Ep229Product product);
    //改
    int EditProduct(Ep229Product product);
    //查
    Ep229Product FindProductById(int prodId);
    //找出全部的产品
    IList<Ep229Product> FindProducts();
    //分页
    IList<Ep229Product> FindProducts(out int total,int catId,string prodName,string sortExpression,int start ,int count);
    IList<Ep229Product> FindProductsForFirst(out int total,  int start, int count);
}