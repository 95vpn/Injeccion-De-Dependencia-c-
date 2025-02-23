using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<PersonService>();
var app = builder.Build();

app.MapGet("/",
    (PersonService personService) =>
    {
        return $"Hello, {personService.GetPersonName()}!";
    }
);

app.Run();