using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229FeedBackDAL 的摘要说明
/// </summary>
/// 数据访问接口层中的Feedback接口
public interface IEp229FeedBackDAL:IEp229BaseDAL<Ep229FeedBack,int>
{
    IList<Ep229FeedBack> SelectSome(out int total, string fbackTitle, string userName, string sortExpression, int start, int count);

}