using System;

public class BasicCalculator{
    public static void Main(String[] args){
        Console.WriteLine("Enter number1 : ");
        String input1 = Console.ReadLine();
        double number1 = double.Parse(input1);

        Console.WriteLine("Enter number2 : ");
        String input2 = Console.ReadLine();
        double number2 = double.Parse(input2);

        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + number1 + " and " + number2 + " is " + addition + ", " + subtraction + ", " + multiplication + ", and " + division);
    }
}