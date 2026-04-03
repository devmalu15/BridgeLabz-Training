using System;

public class HeightConversion{
    public static void Main(String[] args){

	Console.WriteLine("Enter height : ");
	String input1 = Console.ReadLine();
	int heightCMs = int.Pars(input1);
	

	double heightInches = heightCMs / 2.54;
	double heightFeet = heightInches / 12;
	
	Console.WriteLine("Height in inches : " + heightInches + "and in feet : " + heightFeet);
}
}