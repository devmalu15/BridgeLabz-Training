using System;

public class NumberOfRounds{
    public static void Main(String[] args){

	Console.WriteLine("Enter Side 1 : ");
	String s1 = Console.ReadLine();
	int side1 = int.Parse(s1);

	Console.WriteLine("Enter Side 2 : ");
	String s2 = Console.ReadLine();
	int side2 = int.Parse(s2);

	Console.WriteLine("Enter Side 3 : ");
	String s3 = Console.ReadLine();
	int side3 = int.Parse(s3);


	int perimeter = side1 + side2 + side3;
	int distance = 5;
	double numberOfRounds = distance / perimeter;

	Console.WriteLine("Number of Rounds : " + numberOfRounds);

} 

}