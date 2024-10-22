using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LawlfyUnitOfWork;

using LawlfyUnitOfWork.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext ve UnitOfWork'ü ekliyoruz
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add DbContexts for each service with their own connection strings
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserDatabase")));

builder.Services.AddDbContext<AccountingDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AccountingDatabase")));

builder.Services.AddDbContext<DocumentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DocumentDatabase")));

builder.Services.AddDbContext<CampaignDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CampaignDatabase")));

builder.Services.AddDbContext<OCRDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OCRDatabase")));

builder.Services.AddDbContext<NotificationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NotificationDatabase")));

builder.Services.AddDbContext<TaskManagerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TaskManagerDatabase")));

builder.Services.AddDbContext<AuthorizationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthorizationDatabase")));

builder.Services.AddDbContext<AuthenticationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthenticationDatabase")));

builder.Services.AddDbContext<HealthCheckerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HealthCheckerDatabase")));

builder.Services.AddDbContext<LogDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LogDatabase")));

builder.Services.AddDbContext<FirmManagerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FirmManagerDatabase")));

// Add generic repository and UnitOfWork for each DbContext
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// UnitOfWork eklenmesi
builder.Services.AddScoped<IUnitOfWork<UserDbContext>, UnitOfWork<UserDbContext>>();
builder.Services.AddScoped<IUnitOfWork<AccountingDbContext>, UnitOfWork<AccountingDbContext>>();
builder.Services.AddScoped<IUnitOfWork<DocumentDbContext>, UnitOfWork<DocumentDbContext>>();
builder.Services.AddScoped<IUnitOfWork<CampaignDbContext>, UnitOfWork<CampaignDbContext>>();
builder.Services.AddScoped<IUnitOfWork<OCRDbContext>, UnitOfWork<OCRDbContext>>();
builder.Services.AddScoped<IUnitOfWork<NotificationDbContext>, UnitOfWork<NotificationDbContext>>();
builder.Services.AddScoped<IUnitOfWork<TaskManagerDbContext>, UnitOfWork<TaskManagerDbContext>>();
builder.Services.AddScoped<IUnitOfWork<AuthorizationDbContext>, UnitOfWork<AuthorizationDbContext>>();
builder.Services.AddScoped<IUnitOfWork<AuthenticationDbContext>, UnitOfWork<AuthenticationDbContext>>();
builder.Services.AddScoped<IUnitOfWork<HealthCheckerDbContext>, UnitOfWork<HealthCheckerDbContext>>();
builder.Services.AddScoped<IUnitOfWork<LogDbContext>, UnitOfWork<LogDbContext>>();
builder.Services.AddScoped<IUnitOfWork<FirmManagerDbContext>, UnitOfWork<FirmManagerDbContext>>();

// Service sınıflarını DI container'a ekliyoruz
// builder.Services.AddScoped<UserService>();
// builder.Services.AddScoped<AccountingService>();
// builder.Services.AddScoped<DocumentService>();
// builder.Services.AddScoped<CampaignService>();
// builder.Services.AddScoped<OCRService>();
// builder.Services.AddScoped<NotificationService>();
// builder.Services.AddScoped<TaskManagerService>();
// builder.Services.AddScoped<AuthorizationService>();
// builder.Services.AddScoped<AuthenticationService>();
// builder.Services.AddScoped<HealthCheckerService>();
// builder.Services.AddScoped<LogService>();
// builder.Services.AddScoped<FirmManagerService>();

// CORS ayarları - Örnek: Herkese açık CORS politikası
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()      // Tüm kaynaklardan gelen isteklere izin ver
              .AllowAnyMethod()      // GET, POST, PUT, DELETE vb. tüm HTTP metodlarına izin ver
              .AllowAnyHeader();     // Tüm header'lara izin ver
    });
});

var app = builder.Build();

// Swagger/OpenAPI yapılandırması
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CORS'u middleware'de kullan
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
