using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext ve UnitOfWork'ü ekliyoruz
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<AccountingService>();
builder.Services.AddScoped<DocumentService>();
builder.Services.AddScoped<CampaignService>();
builder.Services.AddScoped<OCRService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TaskManagerService>();
builder.Services.AddScoped<AuthorizationService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<HealthCheckerService>();
builder.Services.AddScoped<LogService>();
builder.Services.AddScoped<FirmManagerService>();

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

// Configure the HTTP request pipeline.
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
