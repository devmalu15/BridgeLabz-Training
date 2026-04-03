using System;

public class FeesDiscountUserIP{
    public static void Main(String[] args){

	Console.WriteLine("Enter Fees : ");
	String input1 = Console.ReadLine();
	int totalFees = int.Pars(input1);
	Console.WriteLine("Enter Discount : ");
	String input2 = Console.ReadLine();
	double discount = double.Pars(input2);

	double dicountedFees = totalFees - (totalFees * discount);
	
	Console.WriteLine("Total Discount Fees : " + discountedFees);
}
}