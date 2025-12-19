using System;

public class RectanglePerimeter{
    public static void Main(String[] args){
	
	Console.WriteLine("enter length");
        double length = double.Parse(Console.ReadLine());

	Console.WriteLine("enter width");
        double width = double.Parse(Console.ReadLine());
	

	double perimeter = 2 * (length + width);
	
	Console.WriteLine(perimeter);
	}
    }