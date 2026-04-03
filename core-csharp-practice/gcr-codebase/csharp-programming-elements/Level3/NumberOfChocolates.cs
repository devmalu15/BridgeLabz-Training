using System;

public class NumberOfChocolates{
    public static void Main(String[] args){
	Console.WriteLine("Enter Number of Chocolates : ");
	String input1 = Console.ReadLine();
	int chocolates = int.Parse(input1);

	Console.WriteLine("Enter Number of Children : ");
	String input2 = Console.ReadLine();
	int children = int.Parse(input2);


	int chocoPerChild = chocolates / children;
	int extraChocolates = chocolates % children;

	Console.WriteLine("Chocolates per children : " + chocoPerChild + "\n" + "Extra Chocolates : " + extraChocolates);

	

	

}

}