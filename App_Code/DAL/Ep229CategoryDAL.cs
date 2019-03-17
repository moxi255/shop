using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229CategoryDAL 的摘要说明
/// </summary>
/// 数据访问实现类
public class Ep229CategoryDAL : IEp229CategoryDAL
{
    //根据cat_id删除数据
    public int Delete(int CatId)
    {
        string sql = String.Format("delete from ep229_category where cat_id={0}", CatId);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //插入数据
    public int Insert(Ep229Category category)
    {
        string sql = String.Format("insert into ep229_category(cat_name)values('{0}')",category.CatName);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //选出数据库的全部数据
    public IList<Ep229Category> SelectAll()
    {
        IList<Ep229Category> list = new List<Ep229Category>();
        string sql = String.Format("select * from Ep229_category");
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        if (dt != null)
        {
            Ep229Category c = null;
            foreach (DataRow row in dt.Rows)
            {
                c = new Ep229Category
                {
                    CatId = Int32.Parse(row["cat_id"].ToString()),
                    CatName = row["cat_name"].ToString()
                };
                list.Add(c);
            }
        }
        return list;
    }
    //根据一条Catid选出一条数据
    public Ep229Category SelectById(int CatId)
    {
        Ep229Category category = null;
        string sql = String.Format("select * from ep229_category where cat_id={0}", CatId);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            category = new Ep229Category
            {
                CatId = sdr.GetInt32(0),
                CatName = sdr.GetString(1)
            };
        }
        sdr.Close();
        return category;
    }
    //更新一条数据
    public int Update(Ep229Category category)
    {
        string sql = String.Format("update ep229_category set cat_name='{0}'where cat_id={1}",category.CatName, category.CatId);
        return SqlHelper.ExecuteNonQuery(sql);
    }
}