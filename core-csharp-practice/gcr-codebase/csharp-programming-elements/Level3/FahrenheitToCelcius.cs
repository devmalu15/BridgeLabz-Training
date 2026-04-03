using System;

public class FahrenheitToCelcius{
    public static void Main(String[] args){


        Console.WriteLine("Enter temperature in Fahrenheit: ");
        String input = Console.ReadLine();
        double fahrenheit = double.Parse(input);

        double celsiusResult = (fahrenheit - 32) * 5.0 / 9.0;

        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsiusResult + " Celsius");
    }
}