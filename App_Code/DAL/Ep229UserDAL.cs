using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229UserDAL 的摘要说明
/// </summary>
/// 数据访问实现类
public class Ep229UserDAL:IEp229UserDAL
{
    //删除一条用户数据
    public int Delete(int id)
    {
        string sql = String.Format("delete from ep229_user where user_id={0}", id);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //插入一条数据
    public int Insert(Ep229User user)
    {
        string sql = String.Format("insert into ep229_user(user_name,user_pwd,user_rname,user_email,user_company,user_tel,user_fax) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",user.UserName,
        user.UserPwd, user.UserRName, user.UserEmail, user.UserCompany, user.UserTel,user.UserFax);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //查出全部的用户
    public IList<Ep229User> SelectAll()
    {
        IList<Ep229User> list = new List<Ep229User>();
        String sql = String.Format("select * from ep229_user");
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        Ep229User user = null;
        foreach (DataRow row in dt.Rows)
        {
            user = new Ep229User();
            user.UserId = (int)row[0];
            user.UserName= (string)row[1];
            user.UserPwd= (string)row[2];
            user.UserRName = (string)row[3];
            user.UserEmail= (string)row[4];
            user.UserCompany= (string)row[5];
            user.UserTel=(string)row[6];
            user.UserFax = (string)row[7];
            user.UserDatetime = (DateTime)row[8];
            user.UserRight = (byte)row[9];
            list.Add(user);

        }
        return list;
    }
    //根据id查找用户
    public Ep229User SelectById(int id)
    {
        Ep229User user = null;
        string sql = String.Format("select * from ep229_user where user_id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            user = new Ep229User();
            user.UserId= sdr.GetInt32(0);
            user.UserName= sdr.GetString(1);
            user.UserPwd = sdr.GetString(2);
            user.UserRName = sdr.GetString(3);
            user.UserEmail = sdr.GetString(4);
            user.UserCompany = sdr.GetString(5);
            user.UserTel = sdr.GetString(6);
            user.UserFax = sdr.GetString(7);
            user.UserDatetime = sdr.GetDateTime(8);
            user.UserRight = sdr.GetByte(9);

        }
        sdr.Close();
        return user;
    }
    //根据用户名密码查询数据
    public Ep229User SelectOne(string username, string userpwd)
    {
        Ep229User user = null;
        string sql = String.Format("select * from ep229_user where user_name='{0}' and user_pwd='{1}'", username,userpwd);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            user = new Ep229User();
            user.UserId = sdr.GetInt32(0);
            user.UserName = sdr.GetString(1);
            user.UserPwd = sdr.GetString(2);
            user.UserRName = sdr.GetString(3);
            user.UserEmail = sdr.GetString(4);
            user.UserCompany = sdr.GetString(5);
            user.UserTel = sdr.GetString(6);
            user.UserFax = sdr.GetString(7);
            user.UserDatetime = sdr.GetDateTime(8);
            user.UserRight = sdr.GetByte(9);

        }
        sdr.Close();
        return user;
    }
    //根据用户名查询用户
    public IList<Ep229User> SelectSome(out int total, string username, string sortExpression, int start, int count)
    {
        IList<Ep229User> list = new List<Ep229User>();
        String sql = String.Format("select * from ep229_user where user_name like '{0}'","%"+username+"%");
        DataTable dt = SqlHelper.ExecuteQuery(out total, sql, sortExpression, start, count);
        Ep229User user = null;
        foreach (DataRow row in dt.Rows)
        {
            user = new Ep229User();
            user.UserId = (int)row[0];
            user.UserName = (string)row[1];
            user.UserPwd = (string)row[2];
            user.UserRName = (string)row[3];
            user.UserEmail = (string)row[4];
            user.UserCompany = (string)row[5];
            user.UserTel = (string)row[6];
            user.UserFax = (string)row[7];
            user.UserDatetime = (DateTime)row[8];
            user.UserRight = (byte)row[9];
            list.Add(user);

        }
        return list;
    }
    //更新用户
    public int Update(Ep229User user)
    {
        string sql = String.Format("update ep229_user set user_name='{0}',user_pwd='{1}',user_rname='{2}',user_email='{3}',user_company='{4}',user_tel='{5}',user_fax='{6}',user_right={7} where user_id={8}", user.UserName,
        user.UserPwd, user.UserRName, user.UserEmail, user.UserCompany, user.UserTel, user.UserFax,user.UserRight,user.UserId);
        return SqlHelper.ExecuteNonQuery(sql);
    }

    //找回密码
    public int FindPwd(string name,string email)
    {
        int count=0;
        string sql = String.Format("select count(*) from ep229_user where user_name='{0}' and user_email='{1}'", name, email);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
           
            count = sdr.GetInt32(0);
           

        }
        return count;
    }
}