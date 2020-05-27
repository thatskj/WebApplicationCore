using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class ContactType : BaseEntity
    {
        public ContactType()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }

        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
    }
}
