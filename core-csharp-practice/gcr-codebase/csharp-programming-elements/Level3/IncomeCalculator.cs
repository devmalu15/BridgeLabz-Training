using System;

public class IncomeCalculator{
    public static void Main(String[] args){
        Console.WriteLine("Enter salary: ");
        String input1 = Console.ReadLine();
        double salary = double.Parse(input1);

        Console.WriteLine("Enter bonus: ");
        String input2 = Console.ReadLine();
        double bonus = double.Parse(input2);

        double totalIncome = salary + bonus;

        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }
}