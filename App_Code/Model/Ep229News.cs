using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229News 的摘要说明
/// </summary>
///  实体类：和ep229News中的字段做映射
public class Ep229News
{
    public int NewsId { get; set; }
    public string NewsTitle { get; set; }
    public string NewsContent { get; set; }
    public DateTime NewsDatetime { get; set; }
}