
using CloudVOffice.Services.Plugins;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Configuration;
using System.Reflection;
using CloudVOffice.Data;
using LinqToDB.Common;
using CloudVOffice.Data.Persistence;
using Autofac.Core;
using Microsoft.EntityFrameworkCore;
using CloudVOffice.Services.Authentication;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.FileProviders;
using Syncfusion.Licensing;

namespace CloudVOffice.Web
{
    public class Startup
    {
     

        
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {

			string licenseKey = "ODE4NkAzMTM5MmUzMjJlMzBjdUVOOVZZOW1XSGgrck5CendtZHZXbm91M2hhV3k1SEtPT25oUGVmQzc0PQ==";
			SyncfusionLicenseProvider.RegisterLicense(licenseKey);
			configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
             //services.AddPersistence(configRoot);
            // services.AddDbContext<ApplicationDBContext>();

            services.AddDbContext<ApplicationDBContext>(options =>
            {
                //The name of the connection string is taken from appsetting.json under ConnectionStrings
                options.UseSqlServer(configRoot.GetConnectionString("ConnStringMssql"));
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(x => { x.LoginPath = "/Users/Login";

                x.ExpireTimeSpan = TimeSpan.FromMinutes(2);
                x.SlidingExpiration = true;
                x.AccessDeniedPath = "/Forbidden/";
            }) ;
            services.AddHttpContextAccessor();
            services.AddMvcCore();
          
            string[] subdirs = Directory.GetDirectories(CloudVOfficePluginDefaults.PathName);

            foreach (string folder in Directory.GetDirectories(CloudVOfficePluginDefaults.PathName))
            {
                string dllPath = @".\"+ CloudVOfficePluginDefaults.PathName + @"\" + folder.Split(@"\")[1].ToString() + @"\" + folder.Split(@"\")[1].ToString() + ".dll";
               
                Assembly assembly2 = Assembly.LoadFrom
                    (dllPath);
                var part2 = new AssemblyPart(assembly2);
                services.AddControllersWithViews().PartManager.ApplicationParts.Add(part2);
            }
          
            services.AddMvc();
          
			services.AddControllers().AddNewtonsoftJson(options =>
	        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
			services.AddRazorPages();
            services.AddInfrastructure(configRoot);

            // services.AddScoped(IAuthenticationService, AuthenticationService);
            // services.AddScoped(IAuthenticationService, AuthenticationService);
            //  services.AddDbContext<ApplicationDBContext>()

        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(env.ContentRootPath, "Plugins")),
                RequestPath = "/Plugin"
            });

            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Login}/{id?}");

            app.MapControllerRoute(
                name: "area",
                pattern: "{Area=Dashbaord}/{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
