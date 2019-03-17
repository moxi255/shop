using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229NewsDAL 的摘要说明
/// </summary>
/// 数据访问接口层中的News接口
public interface IEp229NewsDAL:IEp229BaseDAL<Ep229News ,int>
{
    IList<Ep229News> SelectSome(out int total, string sortExpression ,int start, int count);
    IList<Ep229News> SelectTopSome(int num);
}