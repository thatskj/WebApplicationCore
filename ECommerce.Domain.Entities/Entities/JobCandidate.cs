using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class JobCandidate : BaseEntity
    {
        public int? BusinessEntityId { get; set; }
        public string Resume { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Employee BusinessEntity { get; set; }
    }
}
