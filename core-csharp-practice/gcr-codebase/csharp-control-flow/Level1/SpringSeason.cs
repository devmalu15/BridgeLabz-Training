using System;

public class SpringSeason{
    public static void Main(String[] args){
        Console.WriteLine("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        bool isSpring = false;

        if (month == 3 && day >= 20 && day <= 31) isSpring = true;
        else if (month == 4 && day >= 1 && day <= 30) isSpring = true;
        else if (month == 5 && day >= 1 && day <= 31) isSpring = true;
        else if (month == 6 && day >= 1 && day <= 20) isSpring = true;

        if(isSpring){
            Console.WriteLine("Its a Spring Season");
        }
        else{
            Console.WriteLine("Not a Spring Season");
        }
    }
}