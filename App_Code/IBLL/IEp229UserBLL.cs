using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IEp229UserBLL 的摘要说明
/// </summary>
/// 业务逻辑接口层
public interface IEp229UserBLL
{

    //增
    int AddUser(Ep229User user);
    //删
    int DeleteUser(Ep229User user);
    //改
    int EditUser(Ep229User user);
    //查
    Ep229User FindUserById(int userId);
    Ep229User FindUserByNameAndPwd(string userName,string userPwd);
    //找出全部的产品
    IList<Ep229User> FindUsers(out int total,String userName,string sortExpression,int start,int count);
}