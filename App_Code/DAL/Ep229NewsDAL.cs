using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229NewsDAL 的摘要说明
/// </summary>
///  数据访问实现类
public class Ep229NewsDAL:IEp229NewsDAL
{
    //删除一条数据
    public int Delete(int id)
    {
        string sql = String.Format("delete from ep229_news where news_id={0}" ,id);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //插入一条数据
    public int Insert(Ep229News news)
    {
        string sql = String.Format("insert into ep229_news(news_title,news_content) values('{0}','{1}')", news.NewsTitle,news.NewsContent);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //选出全部数据
    public IList<Ep229News> SelectAll()
    {
        IList<Ep229News> list = new List<Ep229News>();
        String sql = String.Format("select * from ep229_news order by news_datetime desc");
        DataTable dt = SqlHelper.ExecuteQuery( sql);
        Ep229News news = null;
        foreach (DataRow row in dt.Rows)
        {
            news = new Ep229News();
            news.NewsId = (int)row[0];
            news.NewsTitle = (string)row[1];
            news.NewsContent = (string)row[2];
            news.NewsDatetime = (DateTime)row[3];

            list.Add(news);

        }
        return list;
    }
    //根据id查找数据
    public Ep229News SelectById(int id)
    {
        Ep229News news = null;
        string sql = String.Format("select * from ep229_news where news_id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            news = new Ep229News();
            news.NewsId= sdr.GetInt32(0);
            news.NewsTitle=sdr.GetString(1);
            news.NewsContent= sdr.GetString(2);
            news.NewsDatetime= sdr.GetDateTime(3);

        }
        sdr.Close();
        return news;
    }
    //选出全部数据
    public IList<Ep229News> SelectSome(out int total, string sortExpression, int start, int count)
    {
        IList<Ep229News> list = new List<Ep229News>();
        String sql = String.Format("select * from ep229_news");
        DataTable dt = SqlHelper.ExecuteQuery(out total, sql, sortExpression, start, count);
        Ep229News news = null;
        foreach (DataRow row in dt.Rows)
        {
            news = new Ep229News();
            news.NewsId= (int)row[0];
            news.NewsTitle= (string)row[1];
            news.NewsContent = (string)row[2];
            news.NewsDatetime= (DateTime)row[3];

            list.Add(news);

        }
        return list;
    }
    //查询前几条数据
    public IList<Ep229News> SelectTopSome(int num)
    {
        IList<Ep229News> list = new List<Ep229News>();
        String sql = String.Format("select top {0} * from ep229_news order by news_datetime desc ",num);
        DataTable dt = SqlHelper.ExecuteQuery( sql);
        Ep229News news = null;
        foreach (DataRow row in dt.Rows)
        {
            news = new Ep229News();
            news.NewsId = (int)row[0];
            news.NewsTitle = (string)row[1];
            news.NewsContent = (string)row[2];
            news.NewsDatetime = (DateTime)row[3];

            list.Add(news);

        }
        return list;
    }
    //更新数据
    public int Update(Ep229News news)
    {
        string sql = String.Format("update ep229_news set news_title='{0}' ,news_content='{1}' where news_id={2}", news.NewsTitle,news.NewsContent,news.NewsId);
        return SqlHelper.ExecuteNonQuery(sql);
    }
}