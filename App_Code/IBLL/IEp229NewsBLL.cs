using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229NewsBLL 的摘要说明
/// </summary>
/// 业务逻辑接口层
public interface IEp229NewsBLL
{
    //增
    int AddNews(Ep229News news);
    //删
    int DeleteNews(Ep229News news);
    //改
    int EditNews(Ep229News news);
    //查
    Ep229News FindNewsById(int newsId);
    //找出全部的产品
    IList<Ep229News> FindNewses(out int total,string sortExpression, int start, int count);
    IList<Ep229News> FindTopNewses(int num);
}