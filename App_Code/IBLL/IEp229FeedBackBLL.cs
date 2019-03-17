using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229FeedBackBLL 的摘要说明
/// </summary>
/// 业务逻辑接口层
public interface IEp229FeedBackBLL
{
    //增
    int AddFeedBack(Ep229FeedBack feedBack);
    //删
    int DeleteFeedBack(Ep229FeedBack feedBack);
    //改
    int EditFeedBack(Ep229FeedBack feedBack);
    //查
    Ep229FeedBack FindFeedBackById(int prodId);
    IList<Ep229FeedBack> FindFeedBacks();
    //找出全部的产品
    IList<Ep229FeedBack> FindFeedBacks(out int total, String fbackTitle, string userName,string sortExpression, int start, int count);
}