using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class Illustration : BaseEntity
    {
        public Illustration()
        {
            ProductModelIllustration = new HashSet<ProductModelIllustration>();
        }

        public string Diagram { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; }
    }
}
