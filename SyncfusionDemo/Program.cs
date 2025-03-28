using Syncfusion.Licensing;
using Syncfusion.EJ2;
using Syncfusion;

var builder = WebApplication.CreateBuilder(args);

// Register Syncfusion license (replace with your actual license key)
SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NNaF5cXmBCekx0Qnxbf1x1ZFREalhVTnNXUiweQnxTdEBjWn1WcHRRQ2BdUEJxWElfag==");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();