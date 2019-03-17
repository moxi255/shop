using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229FeedBackDAL 的摘要说明
/// </summary>
/// 数据访问实现类
public class Ep229FeedBackDAL: IEp229FeedBackDAL
{
    //删除一条数据
    public int Delete(int id)
    {
        string sql = String.Format("delete from ep229_feedback where fback_id={0}", id);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //插入一条数据
    public int Insert(Ep229FeedBack fback)
    {
        string sql = String.Format("insert into ep229_feedback(fback_title,fback_content,user_id) values('{0}','{1}',{2})", fback.FbackTitle,fback.FbackContent,fback.user.UserId);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    //选出全部的数据
    public IList<Ep229FeedBack> SelectAll()
    {
        IList<Ep229FeedBack> list = new List<Ep229FeedBack>();
        String sql = String.Format("select * from ep229_feedback");
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        Ep229FeedBack fback = null;
        foreach (DataRow row in dt.Rows)
        {
            fback = new Ep229FeedBack();
            fback.FbackId= (int)row[0];
            fback.FbackTitle= (string)row[1];
            fback.FbackContent= (string)row[2];
            fback.FbackDatetime= (DateTime)row[4];
            Ep229User user = new Ep229UserDAL().SelectById((int)row[3]);
            fback.user = user;
            list.Add(fback);

        }
        return list;
    }
    //根据id查找数据
    public Ep229FeedBack SelectById(int id)
    {
        Ep229FeedBack feedback = null;
        string sql = String.Format("select * from ep229_feedback where fback_id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            feedback = new Ep229FeedBack();
            feedback.FbackId= sdr.GetInt32(0);
            feedback.FbackTitle= sdr.GetString(1);
            Ep229User user = new Ep229UserDAL().SelectById(sdr.GetInt32(3));
            feedback.user = user;
            feedback.FbackDatetime= sdr.GetDateTime(4);

        }
        sdr.Close();
        return feedback;
    }
    //根据标题和用户名查找反馈
    public IList<Ep229FeedBack> SelectSome(out int total, string fbackTitle, string userName, string sortExpression, int start, int count)
    {
        IList<Ep229FeedBack> list = new List<Ep229FeedBack>();
        String sql = String.Format("select b.*,a.user_name from ep229_user a,ep229_feedback b where a.user_id=b.user_id and b.fback_title linke '{0}' and a.user_name like '{1}'","%"+fbackTitle+"%", "%" + userName + "%");
        DataTable dt = SqlHelper.ExecuteQuery(out total, sql, sortExpression, start, count);
        Ep229FeedBack feedback = null;
        foreach (DataRow row in dt.Rows)
        {
            feedback = new Ep229FeedBack();
            feedback.FbackId = (int)row[0];
            feedback.FbackTitle= (string)row[1];
            feedback.FbackContent= (string)row[2];
            feedback.FbackDatetime= (DateTime)row[4];
            feedback.user = new Ep229User { UserId= (int)row[3],UserName= (string)row[5] };
            list.Add(feedback);

        }
        return list;
    }
    //更新一条反馈记录
    public int Update(Ep229FeedBack fback)
    {
        string sql = String.Format("update ep229_feedback set fback_title='{0}',fback_content='{1}' where fback_id={2}", fback.FbackTitle, fback.FbackContent, fback.FbackId);
        return SqlHelper.ExecuteNonQuery(sql);
    }
}