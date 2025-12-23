using System;

public class EmployeeBonus{
    public static void Main(String[] args){
        Console.WriteLine("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter years of service: ");
        int years = int.Parse(Console.ReadLine());

        double bonus = 0;

        if(years > 5){
            bonus = salary * 0.05;
        }

        Console.WriteLine("Bonus amount is: " + bonus);
    }
}