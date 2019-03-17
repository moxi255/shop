using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229UserDAL 的摘要说明
/// </summary>
/// 数据访问接口层中的User接口
public interface IEp229UserDAL:IEp229BaseDAL<Ep229User,int>
{
    Ep229User SelectOne(string username, string userpwd);
    IList<Ep229User> SelectSome(out int total, string username, String sortExpression, int start, int count);
    
}