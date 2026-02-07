using System;

public class HealthCheckApp
{
    public static void Run()
    {
        IApiScanner scanner = new HealthCheckProScanner();
        scanner.ScanAndDocument(typeof(LabController));
    }
}