using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229BaseDAL 的摘要说明
/// </summary>
/// 数据访问接口层中的基本接口
public interface IEp229BaseDAL<T,ID>
{
    //插入一条数据
    int Insert(T obj);
    //更新一条数据
    int Update(T obj);
    //删除一条数据
    int Delete(ID id);
    //根据id选择一条数据
    T SelectById(ID id);
    //选择全部数据
    IList<T> SelectAll();
}