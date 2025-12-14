using Todo_SRP_DIP.Filters;
using Todo_SRP_DIP.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//injection de dependnce

builder.Services.AddSession();
builder.Services.AddScoped<ISessionManagerService, SessionManagerService>();
builder.Services.AddScoped<AuthFilter>();
builder.Services.AddScoped<ThemeFilter>();
builder.Services.AddScoped<ILogService, FileLogService>();
builder.Services.AddScoped<LogFilter>();
//possibilité que nous pouvons donner a une classe A de travailler avec une instance de classe B, sans l'instancier. 
var app = builder.Build();
//tout au dessus: c'est la configuration de MiddlWare
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseSession();//verifier la presence de cookie de session ID dans la requete
//Si exist --> Récuperer la session
//sinon creer une nouvelle session --> Session_Start()
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}");

app.Run();
