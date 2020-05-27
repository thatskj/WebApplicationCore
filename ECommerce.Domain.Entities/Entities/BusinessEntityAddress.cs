using System;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class BusinessEntityAddress : BaseEntity
    {
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
