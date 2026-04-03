using System;

public class Average{
    public static void Main(String[] args){
	
	Console.WriteLine("enter first number");
        double num1 = double.Parse(Console.ReadLine());

	Console.WriteLine("enter second number");
        double num2 = double.Parse(Console.ReadLine());

	Console.WriteLine("enter third number");
        double num3 = double.Parse(Console.ReadLine());
	

	double average = (num1 + num2 + num3) / 3;
	
	Console.WriteLine(average);
	}
    }