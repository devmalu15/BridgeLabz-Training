using System;

public class NaturalSumCompareFor{
    public static void Main(String[] args){
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if(number > 0){
            int formulaSum = number * (number + 1) / 2;
            
            int loopSum = 0;
            for(int i = 1; i <= number; i++){
                loopSum = loopSum + i;
            }

            Console.WriteLine("Formula Sum: " + formulaSum);
            Console.WriteLine("Loop Sum: " + loopSum);
            
            if(formulaSum == loopSum){
                Console.WriteLine("Both computations are correct.");
            }
        }
        else{
            Console.WriteLine("Not a natural number");
        }
    }
}