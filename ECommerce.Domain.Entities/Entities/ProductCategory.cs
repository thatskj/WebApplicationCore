using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class ProductCategory : BaseEntity
    {
        public ProductCategory()
        {
            ProductSubcategory = new HashSet<ProductSubcategory>();
        }

        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductSubcategory> ProductSubcategory { get; set; }
    }
}
