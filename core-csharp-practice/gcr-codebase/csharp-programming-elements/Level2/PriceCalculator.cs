using System;

public class PriceCalculator{
    public static void Main(String[] args){
        Console.WriteLine("Enter unitPrice : ");
        String input1 = Console.ReadLine();
        double unitPrice = double.Parse(input1);

        Console.WriteLine("Enter quantity : ");
        String input2 = Console.ReadLine();
        int quantity = int.Parse(input2);

        double totalPrice = unitPrice * quantity;

        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
    }
}