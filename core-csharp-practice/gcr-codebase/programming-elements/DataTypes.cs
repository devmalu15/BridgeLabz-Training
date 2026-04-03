using System;

public class DataTypes{
    public static void Main(String[] args){

//Below are the examples of primitive data types in c#.


	int intData = 1000;
	Console.WriteLine("This is a " + intData.GetType()  + " ----- " + intData);

	double doubleData = 10.0;
	Console.WriteLine("This is a " + doubleData.GetType()  + " ----- " + doubleData);

	char charData = 'a';
	Console.WriteLine("This is a " + charData.GetType()  + " ----- " + charData);

	float floatData = 1000.0f;
	Console.WriteLine("This is a " + floatData.GetType()  + " ----- " + floatData);

 	decimal decimalData = 1000.50m;
	Console.WriteLine("This is a " + decimalData.GetType()  + " ----- " + decimalData);

	bool boolData = true;
	Console.WriteLine("This is a " + boolData.GetType()  + " ----- " + boolData);
	}
    }