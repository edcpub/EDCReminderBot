using LinqToDB;
using LinqToDB.Data;
using EDCReminderBot.Models;
using Nop.Plugin.EDC.Base.Domains.EDC;

namespace EDCReminderBot.Data
{
	public class NopConnection : DataConnection
	{
		public NopConnection(LinqToDbConnectionOptions<NopConnection> options)
		:base(options)
		{
		}
		
		public NopConnection()
	   : base("NopConnection")
		{
		}

		public ITable<Reminder> Reminder => GetTable<Reminder>();
		public ITable<ShoppingCartItem> ShoppingCartItem => GetTable<ShoppingCartItem>();
		public ITable<MessageTemplate> MessageTemplate => GetTable<MessageTemplate>();
		public ITable<Customer> Customer => GetTable<Customer>();
		public ITable<Address> Address => GetTable<Address>();
		public ITable<EmailAccount> EmailAccount => GetTable<EmailAccount>();
		public ITable<Order> Order => GetTable<Order>();
		public ITable<CustomerAttribute> CustomerAttribute => GetTable<CustomerAttribute>();
		public ITable<GenericAttribute> GenericAttribute => GetTable<GenericAttribute>();
		public ITable<Affiliate> Affiliate => GetTable<Affiliate>();
		public ITable<CustomerInfo> CustomerInfo => GetTable<CustomerInfo>();
		public ITable<StateProvince> StateProvince => GetTable<StateProvince>();
		public ITable<edc_Consultant> Consultant => GetTable<edc_Consultant>();
		public ITable<Store> Store => GetTable<Store>();
	}
}