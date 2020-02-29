using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.master.models
{
    public partial class Product : EntityBase
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Observation { get; set; }
        public int QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitOrders { get; set; }
        public bool Discontinued { get; set; }
        public bool AsSale { get; set; }
        public bool AsInput { get; set; }
        
        public List<FileAttach> FileAttaches { get; set; }
        public List<OrderProduct> Orders { get; set; }
        public List<ProductCategory> Categories { get; set; }


    }
}
