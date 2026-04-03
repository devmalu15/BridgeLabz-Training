using System;
using System.Reflection;

public class HealthCheckProScanner : IApiScanner
{
    public void ScanAndDocument(Type controllerType)
    {
        Console.WriteLine($"Scanning: {controllerType.Name}");
        var methods = controllerType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

        foreach (var method in methods)
        {
            var isPublic = method.GetCustomAttribute<PublicAPIAttribute>() != null;
            var requiresAuth = method.GetCustomAttribute<RequiresAuthAttribute>() != null;

            string status = (isPublic, requiresAuth) switch
            {
                (true, _) => "[PUBLIC]",
                (_, true) => "[SECURE]",
                _ => "[WARNING: MISSING METADATA]"
            };

            Console.WriteLine($"{status} Endpoint: {method.Name}");
        }
    }
}