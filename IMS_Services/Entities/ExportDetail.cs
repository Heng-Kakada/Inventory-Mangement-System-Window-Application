using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Entities;

public class ExportDetail
{
    public int ID { get; set; }
    public short QtyExported { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal SubTotal { get; set; }
    public int ExportID { get; set; }
    public int ProductID { get; set; }
    public int InvID { get; set; }
}
