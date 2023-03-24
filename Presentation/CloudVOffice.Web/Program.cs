using Autofac.Core;
using CloudVOffice.Web.Framework.Engine;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.Extensions.Hosting.Internal;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpContextAccessor();
var mvcCoreBuilder = builder.Services.AddMvcCore();

Assembly assembly2 = Assembly.LoadFrom
         (@".\Plugins\Accounts.Base\Accounts.Base.dll");
var part2 = new AssemblyPart(assembly2);
builder.Services.AddControllersWithViews().PartManager.ApplicationParts.Add(part2);

builder.Services.AddMvc();
builder.Services.AddControllers();
builder.Services.AddRazorPages();

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.ViewLocationExpanders.Add(new MultiAssemblyViewLocationExpander());

});
// Add framework services.


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{area=Website}/{controller=Website}/{action=Home}/{id?}");

});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "H",
    pattern: "{controller=Website}/{action=Home}/{id?}");

});

app.Run();
