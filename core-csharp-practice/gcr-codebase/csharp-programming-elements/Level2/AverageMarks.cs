using System;

public class AverageMarks{
    public static void Main(String[] args){
	int maths = 94;
	int physics = 95;
	int chemistry = 96;

	double average = (maths + physics + chemistry) / 3;

	Console.WriteLine("Average Marks : " + average);
}
}