var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var app = builder.Build();


//Устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
