using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sinav.Core.Concretes;
using Sinav.DAL.Context;
using Sinav.DAL.Repositories.Concretes;
using Sinav.DAL.Repositories.Interfaces;
using Sinav.Service.Services.Concretes;
using Sinav.Service.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseLazyLoadingProxies();
});

// Identity
builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequiredLength = 3;

    options.User.RequireUniqueEmail = true;
}
).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Repositories 
builder.Services.AddTransient<ITopicRepository, TopicRepository>();
builder.Services.AddTransient<IArticleRepository, ArticleRepository>();

//Services
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<ITopicService,TopicService>();
builder.Services.AddScoped<IAppUserService, AppUserService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
