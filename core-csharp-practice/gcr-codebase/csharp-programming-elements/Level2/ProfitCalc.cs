using System;

public class ProfitCalc{
    public static void Main(String[] args){
	int costPrice = 119;
	int sellingPrice = 191;

	int profit = sellingPrice - costPrice;
	
	double profitPerc = (profit / costPrice) * 100;

	Console.WriteLine("Profit : " + profit + "Profit % : " + profitPerc);
}
}