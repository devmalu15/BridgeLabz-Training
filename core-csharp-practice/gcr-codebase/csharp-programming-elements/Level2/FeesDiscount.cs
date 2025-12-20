using System;

public class FeesDiscount{
    public static void Main(String[] args){
	int totalFees = 125000;
	double discount = 10;

	double dicountedFees = totalFees - (totalFees * discount);
	
	Console.WriteLine("Total Discount Fees : " + discountedFees);
}
}