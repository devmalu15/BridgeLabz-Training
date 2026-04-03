using System;
using System.Reflection;
using System.Text.Json;

public class EventTrackerProcessor : IAuditTracker
{
    public void TrackEvents(object serviceInstance)
    {
        var type = serviceInstance.GetType();
        var methods = type.GetMethods();
        var logs = new List<object>();

        foreach (var method in methods)
        {
            var attr = method.GetCustomAttribute<AuditTrailAttribute>();
            if (attr != null)
            {
                var logEntry = new
                {
                    Event = attr.ActionName,
                    Method = method.Name,
                    Timestamp = DateTime.Now,
                    Class = type.FullName
                };
                logs.Add(logEntry);
            }
        }

        string jsonOutput = JsonSerializer.Serialize(logs, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(jsonOutput);
    }
}