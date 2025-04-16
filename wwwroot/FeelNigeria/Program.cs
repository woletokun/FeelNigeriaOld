var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseDefaultFiles();  // 👈 so index.html loads by default
app.UseStaticFiles();   // 👈 serves static assets from wwwroot

app.Run();
