namespace HealthCheckPro.Core
{
    using System;
    using System.Reflection;
    using HealthCheckPro.Attributes;
    public interface IScanner
    {
        void Scan(Type controllerType);
    }
}