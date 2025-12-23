using System;

public class NaturalSumCompareWhile{
    public static void Main(String[] args){
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if(number > 0){
            int formulaSum = number * (number + 1) / 2;
            
            int loopSum = 0;
            int i = 1;
            while(i <= number){
                loopSum = loopSum + i;
                i++;
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