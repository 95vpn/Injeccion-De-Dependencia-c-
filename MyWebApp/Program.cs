using MyWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<welcomeService>();

var app = builder.Build();

app.MapGet("/", (welcomeService welcomeService) => welcomeService.GetWelcomeMessage());

app.Run();