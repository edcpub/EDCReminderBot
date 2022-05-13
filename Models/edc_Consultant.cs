namespace EDCReminderBot.Models
{
  [Serializable]
  public partial class edc_Consultant : BaseEntity, ILocalizedEntity
  {
    public virtual string ConsultantId { get; set; }
    public virtual int CustomerId { get; set; }
    public virtual int StoreId { get; set; }
    public virtual int AffiliateId { get; set; }
    public virtual int LeaderAffiliateId { get; set; }
    [NotColumn]
    public Affiliate Affiliate { get; set; }
    [NotColumn]
    public Affiliate LeaderAffiliate { get; set; }
    [NotColumn]
    public Store Store { get; set; }
    [NotColumn]
    public Customer Customer { get; set; }
  }
}
