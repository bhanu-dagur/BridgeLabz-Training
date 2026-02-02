namespace HealthCheckPro
{
    using HealthCheckPro.Core;
    using HealthCheckPro.Controllers;
    using HealthCheckPro.Documentation;
    class Program
    {
        static void Main()
        {
            IScanner scanner = new HealthCheckProScanner();
            scanner.Scan(typeof(LabTestController));

            ApiDocumentation.Generate(typeof(LabTestController));
        }
    }
}




