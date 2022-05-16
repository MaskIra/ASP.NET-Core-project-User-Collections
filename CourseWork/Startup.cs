using CloudinaryDotNet;
using CourseWork.Infrastructures;
using CourseWork.Interface;
using CourseWork.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;
using Westwind.AspNetCore.Markdown;
using System.Reflection;
using System.Globalization;
using Microsoft.Extensions.Localization;
using CourseWork.Models.Contexts;

namespace CourseWork
{
    public class Startup
    {
        public static string[] fieldsDataTypes = new string[] { "text", "number", "checkbox", "date" };
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });

            services.AddMvc().AddApplicationPart(typeof(MarkdownPageProcessorMiddleware).Assembly);

            services.AddMarkdown();

            services.AddSingleton<IMongoClient, MongoClient>(sp => new MongoClient(Configuration.GetConnectionString("MongoDb")));
            services.AddTransient<IMongoDBContext, MongoDBContext>();
            MongoDBData.DataBaseName = Configuration.GetSection("MongoDBName").Value;

            var section = Configuration.GetSection("Cloudinary");
            CloudinaryImageUpload.Path = "maskecourse/images";
            CloudinaryImageUpload.ApiKey = section["APIKey"];
            CloudinaryImageUpload.ApiSecret = section["APISecret"];
            CloudinaryImageUpload.Cloud = section["CloudName"];
            CloudinaryImageUpload.Account = new Account
            {
                ApiKey = section["APIKey"],
                ApiSecret = section["APISecret"],
                Cloud = section["CloudName"]
            };

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddControllersWithViews().AddDataAnnotationsLocalization(option =>
            {
                var type = typeof(LangResource);
                var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
                var factory = services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
                var localizer = factory.Create("LangResource", assemblyName.Name);
                option.DataAnnotationLocalizerProvider = (t, f) => localizer;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            var supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("ru-RU")
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("ru-RU"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMarkdown();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
