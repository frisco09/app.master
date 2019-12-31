using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.master.models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set;}
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public string ShipAdress { get; set; }
        public string State { get; set; }

        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }

        public List<OrderProduct> Products { get; set; }
    }
}
