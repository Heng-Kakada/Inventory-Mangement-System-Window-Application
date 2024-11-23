using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Entities;

public class Inventory
{
    public int InvID {get; set; }
    public decimal UnitCost { get; set; }
    public DateTime ExpirationDate { get; set; }
    public short CurrentStock { get; set; }
    public short InitialQty { get; set; }
    public int ProductID { get; set; }
    public int ImportID { get; set; }

}
