using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229ProductDAL 的摘要说明
/// </summary>
/// 数据访问接口层中的Product接口
public interface IEp229ProductDAL:IEp229BaseDAL<Ep229Product,int>
{
    IList<Ep229Product> SelectSome(out int total, int start, int count);
    IList<Ep229Product> SelectSome(out int total, int catId, string prodName, string sortExpression, int start, int count);
}