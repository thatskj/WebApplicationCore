using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class PhoneNumberType : BaseEntity
    {
        public PhoneNumberType()
        {
            PersonPhone = new HashSet<PersonPhone>();
        }

        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
