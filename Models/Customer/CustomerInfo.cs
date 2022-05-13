namespace EDCReminderBot.Models
{
    [Table("edc_ConsultantSearchView")]
    public class CustomerInfo
    {
        public int EntityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int StateProvinceId { get; set; }
        public string ZipPostalCode { get; set; }
        public StateProvince StateProvince { get; set; }
    }
}
