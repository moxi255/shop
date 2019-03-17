using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229UserBLL 的摘要说明
/// </summary>
///user业务逻辑实现类
public class Ep229UserBLL:IEp229UserBLL
{
    private Ep229UserDAL UserDAL = new Ep229UserDAL();
    //增加用户
    public int AddUser(Ep229User user)
    {
        return UserDAL.Insert(user);
    }
    //删除用户
    public int DeleteUser(Ep229User user)
    {
        return UserDAL.Delete(user.UserId);
    }
    //编辑用户
    public int EditUser(Ep229User user)
    {
        return UserDAL.Update(user);
    }
    //根据用户id查找用户
    public Ep229User FindUserById(int userId)
    {
        return UserDAL.SelectById(userId);
    }
    //根据用户名密码，查找用户，在验证在用户中用
    public Ep229User FindUserByNameAndPwd(string userName, string userPwd)
    {
        return UserDAL.SelectOne(userName, userPwd);
    }
    //查找用户名字
    public IList<Ep229User> FindUsers(out int total, string userName, string sortExpression, int start, int count)
    {
        return UserDAL.SelectSome(out total, userName, sortExpression, start, count);
    }
    //根据名字邮箱，查找用户，在找回密码中用
    public int FindPwd(string name, string email)
    {
        return UserDAL.FindPwd(name, email);
    }
}