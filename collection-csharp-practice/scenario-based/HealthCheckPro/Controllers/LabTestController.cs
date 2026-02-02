namespace HealthCheckPro.Controllers;

// using HealthCheckPro.Attributes;

public class LabTestController : BaseController
{
    [PublicAPI]
    public void GetAllTests()
    {
    }

    [AuthAPI]
    public void BookTest()
    {
    }

    public void DeleteTest()
    {
        // Missing annotation (intentional)
    }
}
