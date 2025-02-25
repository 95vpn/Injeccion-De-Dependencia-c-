namespace MyWebApplication1.Servicios;

public class WelcomeService : IWelcomeService
{
    DateTime _serviceCreated;
    Guid _serviceId;

    public WelcomeService()
    {
        _serviceCreated = DateTime.Now;
        _serviceId = Guid.NewGuid();
    }

    public string GetWelcomeMessage()
    {
        return $"Welcome to Contoso. The current time is {_serviceCreated}, This service instance has an Id of {_serviceId} "
    }
}