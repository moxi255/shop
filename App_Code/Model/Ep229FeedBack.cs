using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229FeedBack 的摘要说明
/// </summary>
/// 实体类：和ep229FeedBack中的字段做映射
public class Ep229FeedBack
{
    public int FbackId { get; set; }
    public string FbackTitle { get; set; }
    public string FbackContent { get; set; }
    public Ep229User user{ get; set; }
    public DateTime FbackDatetime { get; set; }
}