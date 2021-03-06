﻿using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class EmployeePayHistory : BaseEntity
    {
        public int BusinessEntityId { get; set; }
        public DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Employee BusinessEntity { get; set; }
    }
}
