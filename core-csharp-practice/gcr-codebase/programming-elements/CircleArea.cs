using System;

public class CircleArea{
    public static void Main(String[] args){
	Console.WriteLine("enter radius");
        double radius = double.Parse(Console.ReadLine());

	double area = 3.14 * radius * radius;
	
	Console.WriteLine(area);
	}
    }