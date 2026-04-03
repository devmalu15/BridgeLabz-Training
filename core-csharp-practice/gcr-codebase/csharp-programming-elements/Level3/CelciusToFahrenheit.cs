using System;

public class CelciusToFahrenheit{
    public static void Main(String[] args){
        Console.WriteLine("Enter temperature (Celcius): ");
        String input = Console.ReadLine();
        double celsiusTemp = double.Parse(input);

        double fahrenheitResult = (celsius * 9.0 / 5.0) + 32;

        Console.WriteLine("The " + celsiusTemp + " Celsius is " + fahrenheitResult + " Fahrenheit");
    }
}