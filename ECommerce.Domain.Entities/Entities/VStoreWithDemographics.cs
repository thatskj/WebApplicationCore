namespace ECommerce.Domain.Entities.Entities
{
    public partial class VStoreWithDemographics : BaseEntity
    {
        public string Name { get; set; }
        public decimal? AnnualSales { get; set; }
        public decimal? AnnualRevenue { get; set; }
        public string BankName { get; set; }
        public string BusinessType { get; set; }
        public int? YearOpened { get; set; }
        public string Specialty { get; set; }
        public int? SquareFeet { get; set; }
        public string Brands { get; set; }
        public string Internet { get; set; }
        public int? NumberEmployees { get; set; }
    }
}
