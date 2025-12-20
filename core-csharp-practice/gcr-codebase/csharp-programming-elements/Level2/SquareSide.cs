using System;

public class SquareSide{
    public static void Main(String[] args){
        Console.WriteLine("Enter perimeter : ");
        String input1 = Console.ReadLine();
        double perimeter = double.Parse(input1);

        double side = perimeter / 4;

        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}