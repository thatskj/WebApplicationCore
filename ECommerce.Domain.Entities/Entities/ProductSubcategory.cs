using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class ProductSubcategory : BaseEntity
    {
        public ProductSubcategory()
        {
            Product = new HashSet<Product>();
        }

        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
