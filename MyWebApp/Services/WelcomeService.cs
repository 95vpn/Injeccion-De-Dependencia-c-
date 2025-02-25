using MyWebApp.Interfaces;
namespace MyWebApp.Services;


public class welcomeService : IWelcomeService
{
    DateTime _serviceCreated;
    Guid _serviceId;

    public welcomeService()
    {
        _serviceCreated = DateTime.Now;
        _serviceId = Guid.NewGuid();
    }

    public string GetWelcomeMessage()
    {
        return $"Welcome to Contoso! The current time is {_serviceCreated}, This service instance has an ID of {_serviceId}";
    }
}