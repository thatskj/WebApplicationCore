using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class AddressType : BaseEntity
    {
        public AddressType()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
        }

        public string Name { get; set; }
        public Guid Rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
    }
}
