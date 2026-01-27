using System.Text.RegularExpressions;

public class SecureDataValidator
{
    public static void Main()
    {
        // Problem 10: IPv4 (Each octet 0-255)
        string ip = "192.168.1.1";
        string ipPattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        
        // Problem 15: SSN
        string ssn = "123-45-6789";
        bool isSsnValid = Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$");

        Console.WriteLine($"IP {ip} valid: {Regex.IsMatch(ip, ipPattern)}");
        Console.WriteLine($"SSN {ssn} valid: {isSsnValid}");
    }
}