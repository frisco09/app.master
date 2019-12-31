using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.master.models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }

        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }

        public List<ProductCategory> Products { get; set; }
    }
}
