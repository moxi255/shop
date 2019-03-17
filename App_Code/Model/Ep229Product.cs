using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ep229Product 的摘要说明
/// </summary>
/// 实体类：和ep229Product中的字段做映射
public class Ep229Product
{

    public int ProdId { get; set; }
    public Ep229Category Category { get; set; }
    public string ProdName { get; set; }
    public string ProdType { get; set; }
    public double ProdPrice { get; set; }
    public string ProdImage { get; set; }
    public string ProdDesc { get; set; }
    public DateTime ProdDatetime { get; set; }
    public virtual bool ProdFirstShow { get; set; }
}