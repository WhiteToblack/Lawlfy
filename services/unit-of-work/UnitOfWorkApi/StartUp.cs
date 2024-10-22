// public class Startup
// {
//     public IConfiguration Configuration { get; }

//     public Startup(IConfiguration configuration)
//     {
//         Configuration = configuration;
//     }

//     public void ConfigureServices(IServiceCollection services)
//     {
//         // UserDbContext için veritabanı bağlantısı
//         services.AddDbContext<UserDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("UserDatabase")));

//         // AccountingDbContext için veritabanı bağlantısı
//         services.AddDbContext<AccountingDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("AccountingDatabase")));

//         // DocumentDbContext için veritabanı bağlantısı
//         services.AddDbContext<DocumentDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("DocumentDatabase")));

//         // CampaignDbContext için veritabanı bağlantısı
//         services.AddDbContext<CampaignDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("CampaignDatabase")));

//         // OCRDbContext için veritabanı bağlantısı
//         services.AddDbContext<OCRDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("OCRDatabase")));

//         // NotificationDbContext için veritabanı bağlantısı
//         services.AddDbContext<NotificationDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("NotificationDatabase")));

//         // TaskManagerDbContext için veritabanı bağlantısı
//         services.AddDbContext<TaskManagerDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("TaskManagerDatabase")));

//         // AuthorizationDbContext için veritabanı bağlantısı
//         services.AddDbContext<AuthorizationDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("AuthorizationDatabase")));

//         // AuthenticationDbContext için veritabanı bağlantısı
//         services.AddDbContext<AuthenticationDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("AuthenticationDatabase")));

//         // HealthCheckerDbContext için veritabanı bağlantısı
//         services.AddDbContext<HealthCheckerDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("HealthCheckerDatabase")));

//         // LogDbContext için veritabanı bağlantısı
//         services.AddDbContext<LogDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("LogDatabase")));

//         // FirmManagerDbContext için veritabanı bağlantısı
//         services.AddDbContext<FirmManagerDbContext>(options =>
//             options.UseSqlServer(Configuration.GetConnectionString("FirmManagerDatabase")));

//         // Diğer servisler için de benzer şekilde DbContext ekleyebilirsiniz.
        
//         services.AddScoped<IUnitOfWork, UnitOfWork>();

//         services.AddControllers();
//     }

//     public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//     {
//         if (env.IsDevelopment())
//         {
//             app.UseDeveloperExceptionPage();
//         }

//         app.UseHttpsRedirection();
//         app.UseRouting();
//         app.UseAuthorization();
//         app.UseEndpoints(endpoints =>
//         {
//             endpoints.MapControllers();
//         });
//     }
// }
