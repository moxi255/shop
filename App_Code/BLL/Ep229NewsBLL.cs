using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229NewsBLL 的摘要说明
/// </summary>
/// News业务逻辑实现类
public class Ep229NewsBLL: IEp229NewsBLL
{

    private Ep229NewsDAL NewsDAL = new Ep229NewsDAL();
    //添加一条新闻数据
    public int AddNews(Ep229News news)
    {
        return NewsDAL.Insert(news);
    }
    //删除一条新闻数据
    public int DeleteNews(Ep229News news)
    {
        return NewsDAL.Delete(news.NewsId);
    }
    
    //编辑一条新闻数据
    public int EditNews(Ep229News news)
    {
        return NewsDAL.Update(news);
    }
    //根据id查找一条新闻数据
    public Ep229News FindNewsById(int newsId)
    {
        return NewsDAL.SelectById(newsId);
    }
    //选出全部的新闻数据
    public IList<Ep229News> SelectAll()

    {
        return NewsDAL.SelectAll();
    }
    //删选出一些数据
    public IList<Ep229News> FindNewses(out int total, string sortExpression, int start, int count)
    {
        return NewsDAL.SelectSome(out total, sortExpression, start, count);
    }
    //选出前几条的新闻数据
    public IList<Ep229News> FindTopNewses(int num)
    {
        return NewsDAL.SelectTopSome(num);
    }
}