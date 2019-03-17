using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229ProductDAL 的摘要说明
/// </summary>
/// 数据访问实现类
public class Ep229ProductDAL:IEp229ProductDAL
{
    //删除一条数据
    public int Delete(int id)
    {
        string sql = String.Format("delete from ep229_product where prod_id={0}", id);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //根据类别删除该类别下的全部数据
    public int DeleteByCid(int cid)
    {
        string sql = String.Format("delete from ep229_product where cat_id={0}", cid);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //插入一条数据
    public int Insert(Ep229Product product)
    {
        string sql = String.Format("insert into ep229_product(prod_name,cat_id,prod_type, prod_price,prod_image, prod_desc, prod_firstShow) values('{0}',{1},'{2}',{3},'{4}','{5}',{6})", product.ProdName,
        product.Category.CatId, product.ProdType, product.ProdPrice, product.ProdImage, product.ProdDesc, product.ProdFirstShow ? 1 : 0);
        return SqlHelper.ExecuteNonQuery(sql);
     }
    //查询全部数据
    public IList<Ep229Product> SelectAll()
    {
        IList<Ep229Product> list = new List<Ep229Product>();
        String sql = String.Format("select * from ep229_product");
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        Ep229Product product = null;
        foreach (DataRow row in dt.Rows)
        {
            product=new Ep229Product();
            product.ProdId = (int)row[0];
            Ep229CategoryDAL category = new Ep229CategoryDAL();
            int id = (int)row[1];
            product.Category = category.SelectById((int)row[1]);
            product.ProdName = (string)row[2];
            product.ProdType = (string)row[3];
            product.ProdPrice = (double)row[4];
            product.ProdImage = (string)row[5];
            product.ProdDesc = (string)row[6];
            product.ProdDatetime = (DateTime)row[7];
            product.ProdFirstShow =(bool)row[8];
            list.Add(product);

        }
        return list;
    }
    //查找一条数据
    public Ep229Product SelectById(int id)
    {
        Ep229Product product = null;
        string sql = String.Format("select * from ep229_product where prod_id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            product = new Ep229Product();
            product.ProdId = sdr.GetInt32(0);
            Ep229CategoryDAL category = new Ep229CategoryDAL();
            product.Category = category.SelectById(sdr.GetInt32(1));
            product.ProdName = sdr.GetString(2);
            product.ProdType = sdr.GetString(3);
            product.ProdPrice = sdr.GetDouble(4);
            product.ProdImage = sdr.GetString(5);
            product.ProdDesc = sdr.GetString(6);
            product.ProdDatetime = sdr.GetDateTime(7);
            product.ProdFirstShow = sdr.GetBoolean(8);
        }
        sdr.Close();
        return product;

    }
    //out标记需要返回的参数
    //查找首页数据产品
    public IList<Ep229Product> SelectSome(out int total, int start, int count)
    {
        IList<Ep229Product> list = new List<Ep229Product>();
        String sql = String.Format("select * from ep229_product where prod_firstShow=1");
        DataTable dt = SqlHelper.ExecuteQuery(out total, sql, "prod_datetime desc", start, count);
        Ep229Product product = null;
        foreach (DataRow row in dt.Rows)
        {
            product = new Ep229Product();
            product.ProdId = (int)row[0];
            Ep229CategoryDAL category = new Ep229CategoryDAL();
            product.Category = category.SelectById((int)row[1]);
            product.ProdName = (string)row[2];
            product.ProdType = (string)row[3];
            product.ProdPrice = (double)row[4];
            product.ProdImage = (string)row[5];
            product.ProdDesc = (string)row[6];
            product.ProdDatetime = (DateTime)row[7];
            product.ProdFirstShow = (bool)row[8];
            list.Add(product);

        }
        return list;
    }
    //根据cat_id查询数据
    public IList<Ep229Product> SelectSome(out int total, int catId, string prodName, string sortExpression, int start, int count)
    {
        IList<Ep229Product> list = new List<Ep229Product>();
        String sql = String.Format("select * from ep229_product where cat_id={0}", catId);
        DataTable dt = SqlHelper.ExecuteQuery(out total, sql, sortExpression, start, count);
        Ep229Product product = null;
        foreach (DataRow row in dt.Rows)
        {
            product = new Ep229Product();
            product.ProdId = (int)row[0];
            Ep229CategoryDAL category = new Ep229CategoryDAL();
            product.Category = category.SelectById((int)row[1]);
            product.ProdName = (string)row[2];
            product.ProdType = (string)row[3];
            product.ProdPrice = (double)row[4];
            product.ProdImage = (string)row[5];
            product.ProdDesc = (string)row[6];
            product.ProdDatetime = (DateTime)row[7];
            product.ProdFirstShow = (bool)row[8];
            list.Add(product);

        }
        return list;
    }
    //更新数据
    public int Update(Ep229Product product)
    {
        string sql = String.Format("update ep229_product set cat_id={0},prod_name='{1}',prod_type='{2}',prod_price={3},prod_desc='{4}',prod_firstShow={5} where prod_id={6}", product.Category.CatId, product.ProdName,
         product.ProdType, product.ProdPrice, product.ProdDesc, product.ProdFirstShow ? 1 : 0,product.ProdId);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //根据名字查找数据
    public IList<Ep229Product> search(string name)
    {
        IList<Ep229Product> list = new List<Ep229Product>();
        String sql = String.Format("select * from ep229_product where prod_name like '%{0}%'", name);
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        Ep229Product product = null;
        foreach (DataRow row in dt.Rows)
        {
            product = new Ep229Product();
            product.ProdId = (int)row[0];
            Ep229CategoryDAL category = new Ep229CategoryDAL();
            product.Category = category.SelectById((int)row[1]);
            product.ProdName = (string)row[2];
            product.ProdType = (string)row[3];
            product.ProdPrice = (double)row[4];
            product.ProdImage = (string)row[5];
            product.ProdDesc = (string)row[6];
            product.ProdDatetime = (DateTime)row[7];
            product.ProdFirstShow = (bool)row[8];
            list.Add(product);

        }
        return list;
    }
}