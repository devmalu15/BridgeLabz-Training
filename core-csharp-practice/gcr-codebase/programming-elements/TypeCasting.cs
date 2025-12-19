using System;

public class TypeCasting{
    public static void Main(String[] args){

//Conversion of data types (TypeCasting).

//Implicit TypeCasting flow "char ➔ int ➔ long ➔ float ➔ double".

	char implicitChar = 'a';
	Console.WriteLine("This is a " + implicitChar.GetType()  + " ----- " + implicitChar);

	int implicitInt = implicitChar;
	Console.WriteLine("This is a " + implicitInt.GetType()  + " ----- " + implicitInt);

	long implicitLong = implicitInt;
	Console.WriteLine("This is a " + implicitLong.GetType()  + " ----- " + implicitLong);

	float implicitFloat = implicitLong;
	Console.WriteLine("This is a " + implicitFloat.GetType()  + " ----- " + implicitFloat);

	double implicitDouble = implicitFloat;
	Console.WriteLine("This is a " + implicitDouble.GetType()  + " ----- " + implicitDouble);


//Explicit TypeCasting has a risk of data loss.

	double explicitDouble = 10.1;
	Console.WriteLine("This is a " + explicitDouble.GetType()  + " ----- " + explicitDouble);
	int explicitInt = (int)explicitDouble;

//lost the data 0.1 of 10.1, which can be harmfull for some scenarios.

	Console.WriteLine("This is a " + explicitInt.GetType()  + " ----- " + explicitInt);

//we can also use System.convert to overcome the data loss.		

	}
    }