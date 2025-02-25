using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Services;
using MyWebApplication1.Servicios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<PersonService>();
builder.Services.AddSingleton<WelcomePageOptions>();
;var app = builder.Build();

app.MapGet("/",
    (PersonService personService,
    WelcomeService welcomeService) =>
    {
        return $"Hello, {personService.GetPersonName()}!";
    }
);

app.Run();