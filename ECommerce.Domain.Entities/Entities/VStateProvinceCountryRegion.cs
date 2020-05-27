namespace ECommerce.Domain.Entities.Entities
{
    public partial class VStateProvinceCountryRegion : BaseEntity
    {
        public string StateProvinceCode { get; set; }
        public bool IsOnlyStateProvinceFlag { get; set; }
        public string StateProvinceName { get; set; }
        public int TerritoryId { get; set; }
        public string CountryRegionCode { get; set; }
        public string CountryRegionName { get; set; }
    }
}
