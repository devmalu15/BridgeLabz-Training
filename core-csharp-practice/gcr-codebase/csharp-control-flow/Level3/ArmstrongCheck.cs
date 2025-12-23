using System;

public class ArmstrongCheck{
    public static void Main(String[] args){
	String input = Console.ReadLine();
	int len = input.Length;
	int num = int.Parse(input); 
	int numPrint = num;
	double sum = 0;

	while(num > 0){
	    int lastDigit = num % 10;
	    num = num / 10;
	    sum = sum + Math.Pow(lastDigit, len);
		
	}

	Console.WriteLine(sum);

	if(sum == numPrint){
	    Console.WriteLine(numPrint + " is an Armstrong Number.");
	}
	
	else{
	    Console.WriteLine(numPrint + " is not an Armstrong Number.");
	}	
	
}

}