using System;

public class HarshadNumber{
    public static void Main(String[] args){
	int num = int.Parse(Console.ReadLine());
	int numPrint = num;
	int digitSum = 0;
	while(num > 0){
	    int lastDigit = num % 10;
	    num = num / 10;
	    digitSum = digitSum + lastDigit;
        }
	Console.WriteLine("Sum of digits : " + digitSum);

	if(numPrint % digitSum == 0){
	    Console.WriteLine("It is a Harshad Number.");
        }
	else{
	    Console.WriteLine("It is not a Harshad Number.");
	}
    }
}