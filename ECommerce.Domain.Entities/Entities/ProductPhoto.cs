using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class ProductPhoto : BaseEntity
    {
        public ProductPhoto()
        {
            ProductProductPhoto = new HashSet<ProductProductPhoto>();
        }

        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public byte[] LargePhoto { get; set; }
        public string LargePhotoFileName { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductProductPhoto> ProductProductPhoto { get; set; }
    }
}
