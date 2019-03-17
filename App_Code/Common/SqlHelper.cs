using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// SqlHelper 的摘要说明
/// </summary>
/// 数据库操作类
public abstract class SqlHelper
{
    //执行增删改
    public static int ExecuteNonQuery(string sql,params SqlParameter[] cmdParms)
    {
        SqlConnection con = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, con);
        foreach(SqlParameter parm in cmdParms)
        {
            cmd.Parameters.Add(parm);
        }
        try
        {
            con.Open();
            int num = cmd.ExecuteNonQuery();
            return num;
        }
        catch
        {
            return 0;
        }
        finally
        {
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }
    }
    //返回数据表
    public static DataTable ExecuteQuery(string sql, params SqlParameter[] cmdParms)
    {
        SqlConnection con = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, con);
        foreach (SqlParameter parm in cmdParms)
        {
            cmd.Parameters.Add(parm);
        }
        DataTable dt = new DataTable();//建立数据表
        SqlDataAdapter da = new SqlDataAdapter(cmd);//建立数据适配器
        try
        {
            da.Fill(dt);
            return dt;
        }
        catch
        {
            return null;
        }
        finally
        {
            da.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }
    }
    //排序
    public static DataTable ExecuteQuery(out int total,string sql,string sortExpression,int start,int count, params SqlParameter[] cmdParms)
    {
        string sort = String.IsNullOrEmpty(sortExpression) ? "":" order by " + sortExpression;
        string sql1 = "select count(*)" + sql.Substring(sql.IndexOf(" from"));
        SqlConnection con = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql + sort, con);
        SqlCommand cmd1 = new SqlCommand(sql1, con);
        con.Open();
        foreach (SqlParameter parm in cmdParms)
        {
            cmd.Parameters.Add(parm);
            cmd1.Parameters.Add(parm);
        }
        total = Int32.Parse(cmd1.ExecuteScalar().ToString());//查询第一行获取记录
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        try
        {
            da.Fill(start,count,dt);
            return dt;
        }
        catch
        {
            return null;
        }
        finally
        {
            da.Dispose();
            cmd.Dispose();
            cmd1.Dispose();
            con.Close();
            con.Dispose();
        }

    }
    //结果读取器
    public static SqlDataReader ExecuteReader(string sql,params SqlParameter[] cmdParms)
    {
        SqlConnection con = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, con);
        foreach (SqlParameter parm in cmdParms)
        {
            cmd.Parameters.Add(parm);
        }
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        catch
        {
            return null;
        }

    }
    //对象
    public static object ExecuteScalar(string sql,params SqlParameter[] cmdParms)
    {
        SqlConnection con = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, con);
        try
        {
            con.Open();
            object val = cmd.ExecuteScalar();
            return val;
        }
        catch
        {
            return null;
        }
        finally
        {

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }
    }
}