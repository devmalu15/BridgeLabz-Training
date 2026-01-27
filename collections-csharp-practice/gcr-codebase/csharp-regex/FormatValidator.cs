using System.Text.RegularExpressions;

public class FormatValidators
{
    public static void Main(String[] args)
    {
        // License Plate: 2 Uppercase + 4 Digits
        string plate = "AB1234";
        bool isPlateValid = Regex.IsMatch(plate, @"^[A-Z]{2}\d{4}$");
        Console.WriteLine($"License {plate} valid: {isPlateValid}");

        // Hex Color: # + 6 Hex chars
        string hex = "#FFA500";
        bool isHexValid = Regex.IsMatch(hex, @"^#[a-fA-F0-9]{6}$");
        Console.WriteLine($"Hex {hex} valid: {isHexValid}");
    }
}