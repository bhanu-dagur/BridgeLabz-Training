namespace HealthCheckPro.Controllers;

public abstract class BaseController
{
    public string ControllerName => GetType().Name;
}
