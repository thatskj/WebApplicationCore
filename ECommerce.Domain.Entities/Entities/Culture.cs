using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class Culture : BaseEntity
    {
        public Culture()
        {
            ProductModelProductDescriptionCulture = new HashSet<ProductModelProductDescriptionCulture>();
        }

        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
    }
}
