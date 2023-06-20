
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
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using CloudVOffice.Core.Domain.Users;
using Microsoft.AspNetCore.Identity;
using Hangfire;


using Hangfire.SqlServer;
using Microsoft.AspNetCore.Hosting;
using WebOptimizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

			string licenseKey = "Mgo+DSMBMAY9C3t2VFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5Xd0JiW39XdHNXRmBb\r\n";
			SyncfusionLicenseProvider.RegisterLicense(licenseKey);
			configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
      

            services.AddDbContext<ApplicationDBContext>(options =>
            {
                //The name of the connection string is taken from appsetting.json under ConnectionStrings
                options.UseSqlServer(configRoot.GetConnectionString("ConnStringMssql"));
            });


            var audienceConfig = configRoot.GetSection("JWT");
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(audienceConfig["Secret"]));
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,
                ValidateIssuer = true,
                ValidIssuer = audienceConfig["ValidIssuer"],
                ValidateAudience = true,
                ValidAudience = audienceConfig["ValidAudience"],
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                RequireExpirationTime = true,
            };

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Custom";
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddPolicyScheme("Custom", "Custom", options =>
            {
                options.ForwardDefaultSelector = context =>
                {
                    // since all my api will be starting with /api, modify this condition as per your need.
                    if (context.Request.Path.StartsWithSegments("/api", StringComparison.InvariantCulture))
                        return JwtBearerDefaults.AuthenticationScheme;
                    else
                        return CookieAuthenticationDefaults.AuthenticationScheme;
                };
            }).AddCookie(x => { x.LoginPath = "/App/Login";

                x.ExpireTimeSpan = TimeSpan.FromMinutes(20 );
                x.SlidingExpiration = true;
                x.AccessDeniedPath = "/Forbidden/";
                
            }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = tokenValidationParameters;

            });
            IdentityModelEventSource.ShowPII = true;
            //// Add Hangfire services.
            //services.AddHangfire(configuration => configuration
            //    .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
            //    .UseSimpleAssemblyNameTypeSerializer()
            //    .UseRecommendedSerializerSettings()
            //    .UseSqlServerStorage(configRoot.GetConnectionString("ConnStringMssql")));
            //// Add the processing server as IHostedService
            //services.AddHangfireServer();
            //// Add the processing server as IHostedService
            //services.AddHangfireServer();
            services.AddHttpContextAccessor();
            services.AddMvcCore();
            services.AddControllersWithViews().AddNewtonsoftJson(delegate (MvcNewtonsoftJsonOptions options)
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            services.AddRazorPages();
            services.AddMvc();
            
            string[] subdirs = Directory.GetDirectories(CloudVOfficePluginDefaults.PathName);

            foreach (string folder in Directory.GetDirectories(CloudVOfficePluginDefaults.PathName))
            {
                //string dllPath = @".\"+ CloudVOfficePluginDefaults.PathName + @"\" + folder.Split(@"\")[1].ToString() + @"\" + folder.Split(@"\")[1].ToString() + ".dll";
                //if (File.Exists(dllPath))
                //{
                //    Assembly assembly2 = Assembly.UnsafeLoadFrom
                //    (dllPath);
                //    var part2 = new AssemblyPart(assembly2);
                //    services.AddControllersWithViews()
                //         .AddNewtonsoftJson(options =>
                //         {


                //             options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;


                //         })
                //        .PartManager.ApplicationParts.Add(part2);
                //}
                string dllPath = CloudVOfficePluginDefaults.PathName + @"\" + folder.Split(@"\")[1].ToString() + @"\" + folder.Split(@"\")[1].ToString() + ".dll";
                if (File.Exists(dllPath))
                {
                    Assembly assembly2 = Assembly.LoadFrom(dllPath);
                    AssemblyPart part2 = new AssemblyPart(assembly2);
                    services.AddControllersWithViews().PartManager.ApplicationParts.Add(part2);
                }
            }

		
		
			services.AddInfrastructure(configRoot);

            // services.AddScoped(IAuthenticationService, AuthenticationService);
            // services.AddScoped(IAuthenticationService, AuthenticationService);
            //  services.AddDbContext<ApplicationDBContext>()

            #region Swagger Config
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "CloudVOffice Open API v1",
                    Version = "v1",
                    Description = "API to communicate with CloudVOffice Server API "
                });
                options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                options.CustomSchemaIds(type => type.ToString());
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //options.IncludeXmlComments(xmlPath);
            });


            #endregion

        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           // app.UseHangfireDashboard();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "CloudVOffice Open Api v1"));
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
           

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=App}/{action=Login}/{id?}");

           


            
                app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=App}/{action=Login}/{id?}"
                );

           
            app.MapRazorPages();
            app.Run();
        }

    }
}
