namespace EDCReminderBot.Models
{
    public class Reminder : BaseEntity, ISoftDeletedEntity
    {
		public bool Enabled { get; set; }
		public string Name { get; set; }
		public IntervalType ConditionMetDateLaterThanIntervalTypeId { get; set; }
		public int ConditionMetDateLaterThan { get; set; }
		public int StoreId { get; set; }
		public IntervalType ConditionMetDateEarlierThanIntervalTypeId { get; set; }
		public int ConditionMetDateEarlierThan { get; set; }
		public IntervalType IntervalBetweenMessagesTypeId { get; set; }
		public int IntervalBetweenMessages { get; set; }
		public int MessageTemplateId { get; set; }
		public Guid ReminderRuleId { get; set; }
		public int NumberOfMessagesToSendPerCustomer { get; set; }
		public DateTime LastRunOnUtc { get; set; }
		public bool Deleted { get; set; }
		[NotColumn]
		public MessageTemplate MessageTemplate { get; set; }
		[NotColumn]
		public Store Store { get; set; }

	}
}
