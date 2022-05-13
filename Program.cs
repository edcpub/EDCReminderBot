var builder = new ConfigurationBuilder();
BuildConfig(builder);

var Configuration = builder.Build();

Log.Logger = new LoggerConfiguration()
	.ReadFrom.Configuration(builder.Build())
	.Enrich.FromLogContext()
	.WriteTo.Console()
	.CreateLogger();

// create options builder
var L2Builder = new LinqToDbConnectionOptionsBuilder();

L2Builder.UseConnectionFactory(
	SqlServerTools.GetDataProvider(
		SqlServerVersion.v2017,
		SqlServerProvider.MicrosoftDataSqlClient),
	() =>
	{
		return new SqlConnection();
	});

var host = Host.CreateDefaultBuilder()
	.ConfigureServices((context, services) =>
	{
		services.AddLinqToDbContext<NopConnection>((provider, options) =>
		{
			options = L2Builder
			.UseSqlServer(Configuration.GetConnectionString("Nop"))
			.UseDefaultLogging(provider);
		});
	})
	.UseSerilog()
	.Build();

static void BuildConfig(IConfigurationBuilder builder)
{
	builder.SetBasePath(Directory.GetCurrentDirectory())
		.AddJsonFile("appsettings.json", false, true)
		.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", true)
		.AddEnvironmentVariables();
}