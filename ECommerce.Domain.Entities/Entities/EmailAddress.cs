﻿using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class EmailAddress : BaseEntity
    {
        public int BusinessEntityId { get; set; }
        public int EmailAddressId { get; set; }
        public string EmailAddress1 { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Person BusinessEntity { get; set; }
    }
}
