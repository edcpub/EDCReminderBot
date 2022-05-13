using EDCReminderBot.Data;

namespace EDCReminderBot
{
    public interface IReminderService
    {
        public IList<Reminder> GetReminders();
        public IQueryable<IList<ShoppingCartItem>> GetReminderData(Reminder reminder);
        public string ParseTokens(MessageTemplate template, IList<ShoppingCartItem> Cart);
    }
    public class ReminderService : IReminderService
    {

        public ReminderService()
        {
        }

        public IQueryable<Reminder> ActiveReminders()
        {
            using (var Nop = new NopConnection())
            {
                var query = from reminder in Nop.Reminder
                            where !reminder.Deleted && reminder.Enabled
                            select reminder;
                return query;
            };
        }

        public IQueryable<GenericAttribute> CustomerGenericAttributes()
        {
            using (var Nop = new NopConnection())
            {
                var query = from attribute in Nop.GenericAttribute
                            where attribute.KeyGroup == "Customer"
                            select attribute;

                return query;
            };
        }

        public IQueryable<Customer> ActiveCustomers()
        {
            using (var Nop = new NopConnection())
            {
                var query = from customer in Nop.Customer
                            join affiliate in Nop.Affiliate on customer.AffiliateId equals affiliate.Id
                            join custInfo in Nop.CustomerInfo on customer.Id equals custInfo.EntityId
                            join consultant in Nop.Consultant on affiliate.Id equals consultant.AffiliateId
                            join store in Nop.Store on consultant.StoreId equals store.Id
                            where customer.Active
                            select customer;

                return query;
            };
        }

        public IList<Reminder> GetReminders()
        {
            using (var Nop = new NopConnection())
            {
                var query = from reminder in ActiveReminders()
                            select reminder;

                var reminders = query.ToList();

                return reminders;
            };
        }

        public IQueryable<IList<ShoppingCartItem>> GetReminderData(Reminder reminder)
        {
            using (var Nop = new NopConnection())
            {


                return query;
            };
        }

        public string ParseTokens(MessageTemplate template, IList<ShoppingCartItem> Cart)
        {

        }
    }
}
