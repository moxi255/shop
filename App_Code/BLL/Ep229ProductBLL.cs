using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229ProductBLL 的摘要说明
/// </summary>
/// Product业务逻辑实现类
public class Ep229ProductBLL: IEp229ProductBLL
{

    private Ep229ProductDAL ProductDAL = new Ep229ProductDAL();
    //增加一条产品数据
    public int AddProduct(Ep229Product product)
    {
        return ProductDAL.Insert(product);
    }
    //删除同一类别下的全部产品
    public int DeleteByCid(int cid)
    {
        return ProductDAL.DeleteByCid(cid);
    }
    //删除一条产品
    public int DeleteProduct(Ep229Product product)
    {
        return ProductDAL.Delete(product.ProdId);
    }
    //删除一条产品
    public int DeleteProduct(int ProdId)
    {
        return ProductDAL.Delete(ProdId);
    }
    //编辑一条产品
    public int EditProduct(Ep229Product product)
    {
        return ProductDAL.Update(product);
    }
    //查找一条产品
    public Ep229Product FindProductById(int prodId)
    {
        return ProductDAL.SelectById(prodId);
    }
    //查找全部的产品
    public IList<Ep229Product> FindProducts()
    {
        return ProductDAL.SelectAll();
    }
    //根据类别查找产品
    public IList<Ep229Product> FindProducts(out int total, int catId, string prodName, string sortExpression, int start, int count)
    {
        return ProductDAL.SelectSome(out total,  catId,  prodName, sortExpression, start, count);
    }
    //查找首页产品
    public IList<Ep229Product> FindProductsForFirst(out int total, int start, int count)
    {
        return ProductDAL.SelectSome(out total, start, count);
    }
    //根据产品名字查找产品
    public IList<Ep229Product> search(string name)
    {
        return ProductDAL.search(name);
    }
}