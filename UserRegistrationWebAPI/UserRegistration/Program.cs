using BusinessLayer.Services;
using RepositoryLayer.Services;
using NLog;
using NLog.Web;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Info("Starting Web API...");

var builder = WebApplication.CreateBuilder(args);

// Configure logging
builder.Logging.ClearProviders();
builder.Host.UseNLog();

// Register services
builder.Services.AddControllers();
builder.Services.AddScoped<UserRegistrationBL>();  // ✅ Add this line
builder.Services.AddSingleton<UserRegistrationRL>();// ✅ Ensure this is also registered

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
