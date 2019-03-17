using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229User 的摘要说明
/// </summary>
/// 实体类：和ep229Usert中的字段做映射
public class Ep229User
{

    public int UserId { get; set; }
    public string UserName { get; set; }
    public string UserRName { get; set; }
    public string UserPwd { get; set; }
    public string UserTel { get; set; }
    public string UserEmail { get; set; }
    public string UserCompany { get; set; }
    public string UserFax { get; set; }
    public DateTime UserDatetime { get; set; }
    public byte UserRight { get; set; }
}