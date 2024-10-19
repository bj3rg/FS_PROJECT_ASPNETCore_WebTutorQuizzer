using FS_PROJECT_ASPNETCore_WebTutorQuizzer.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();


app.Run();
