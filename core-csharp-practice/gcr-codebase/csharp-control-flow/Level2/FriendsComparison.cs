using System;

public class FriendsComparison{
    public static void Main(String[] args){
        
        Console.WriteLine("Enter Amar's Age: ");
        int ageAmar = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Amar's Height: ");
        int heightAmar = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Akbar's Age: ");
        int ageAkbar = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Akbar's Height: ");
        int heightAkbar = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Anthony's Age: ");
        int ageAnthony = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Anthony's Height: ");
        int heightAnthony = int.Parse(Console.ReadLine());

        int minAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        int maxHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));

        Console.WriteLine("The Youngest Age is: " + minAge);
        if(minAge == ageAmar) Console.WriteLine("Youngest is Amar");
        if(minAge == ageAkbar) Console.WriteLine("Youngest is Akbar");
        if(minAge == ageAnthony) Console.WriteLine("Youngest is Anthony");

        Console.WriteLine("The Tallest Height is: " + maxHeight);
        if(maxHeight == heightAmar) Console.WriteLine("Tallest is Amar");
        if(maxHeight == heightAkbar) Console.WriteLine("Tallest is Akbar");
        if(maxHeight == heightAnthony) Console.WriteLine("Tallest is Anthony");
    }
}