using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class TransactionHistoryArchive : BaseEntity
    {
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int ReferenceOrderId { get; set; }
        public int ReferenceOrderLineId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public decimal ActualCost { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
