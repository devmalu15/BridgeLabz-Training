using System;

public class PoundsToKg{
    public static void Main(String[] args){
	Console.WriteLine("Enter weight in pounds : ");
	String input1 = Console.ReadLine();
	int weightPounds = int.Parse(input1);

	double weightKgs = weightPounds * 2.2;

	Console.WriteLine("Weight in Kgs : " + weightKgs);
	
}

}