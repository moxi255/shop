using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229FeedBackBLL 的摘要说明
/// </summary>
/// Category业务逻辑实现类
public class Ep229FeedBackBLL: IEp229FeedBackBLL
{

    private Ep229FeedBackDAL FeedBackDAL = new Ep229FeedBackDAL();
    //增加一条反馈记录
    public int AddFeedBack(Ep229FeedBack feedBack)
    {
        return FeedBackDAL.Insert(feedBack);
    }
    //删除一条反馈记录
    public int DeleteFeedBack(Ep229FeedBack feedBack)
    {
        return FeedBackDAL.Delete(feedBack.FbackId);
    }
    //编辑一条反馈记录
    public int EditFeedBack(Ep229FeedBack feedBack)
    {
        return FeedBackDAL.Update(feedBack);
    }
    //根据proId查找一条反馈记录
    public Ep229FeedBack FindFeedBackById(int prodId)
    {
        return FeedBackDAL.SelectById(prodId);
    }
    //根据反馈标题和反馈人物查找一条记录
    public IList<Ep229FeedBack> FindFeedBacks(out int total, string fbackTitle, string userName, string sortExpression, int start, int count)
    {
        return FeedBackDAL.SelectSome(out total, fbackTitle, userName, sortExpression, start, count);
    }
    //查找全部反馈记录
    public IList<Ep229FeedBack> FindFeedBacks()
    {
        return FeedBackDAL.SelectAll();
    }
 
}