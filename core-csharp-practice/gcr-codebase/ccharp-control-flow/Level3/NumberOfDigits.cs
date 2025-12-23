using System;

public class NumberOfDigits{
    public static void Main(String[] args){
	int num = int.Parse(Console.ReadLine());
	int count = 0;
	while(num > 0){
	    num = num / 10;
	    count++;
}

	Console.WriteLine("Number of digits : " + count);
}

}