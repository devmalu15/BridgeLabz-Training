using System;

public class CylinderVolume{
    public static void Main(String[] args){
	Console.WriteLine("enter radius");
        double radius = double.Parse(Console.ReadLine());

	Console.WriteLine("enter height");
        double height = double.Parse(Console.ReadLine());

	double volume = 3.14 * radius * radius * height;
	
	Console.WriteLine(volume);
	}
    }