using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
/// <summary>
/// ConnectDB 的摘要说明
/// </summary>
/// 数据库连接类
public class ConnectDB
{
    //从webconfig读取字符串连接类进行连接数据库
    private static string connectString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    public static SqlConnection Connect()
    {
        SqlConnection con = new SqlConnection(connectString);
        return con;
    }
   
}