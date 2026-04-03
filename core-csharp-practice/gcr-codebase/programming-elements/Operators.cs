using System;

public class Operators{
    public static void Main(String[] args){

	int data1 = 9;
	int data2 = 10;
	Console.WriteLine("Data1 = " + data1 + "    " + "Data2 = " + data2);

//Arithmetic operators.

	Console.WriteLine("\n--- Arithemtic Operators ---");
	
	int result = data1 + data2;
	Console.WriteLine(data1 + " + " + data2 + " = " + result);

	result = data1 - data2;
	Console.WriteLine(data1 + " - " + data2 + " = " + result);

	result = data1 * data2;
	Console.WriteLine(data1 + " * " + data2 + " = " + result);

	result = data1 / data2;
	Console.WriteLine(data1 + " / " + data2 + " = " + result);

	result = data1 % data2;
	Console.WriteLine(data1 + " % " + data2 + " = " + result);

	
	Console.WriteLine(data1 + "++ " + " = " + data1++);

	Console.WriteLine(data2 + "-- " + " = " + data2--);


//Assignment operators.
	
	data1 = 9;
	data2 = 10;
	Console.WriteLine("\n--- Assignment Operators ---");
	Console.WriteLine("data1 = " + " 9" + " ----- " + "data1 = " + data1);

	data1 += 1;
	Console.WriteLine("data1 += " + " 1" + " ----- " + "data1 = " + data1);
	
	data1 = 9;
	data1 -= 1;
	Console.WriteLine("data1 -= " + " 1" + " ----- " + "data1 = " + data1);

	data1 = 9;
	data1 *= 2;
	Console.WriteLine("data1 *= " + " 2" + " ----- " + "data1 = " + data1);


	data1 = 9;
	data1 /= 2;
	Console.WriteLine("data1 /= " + " 2" + " ----- " + "data1 = " + data1);

//Comparison Operators.
      
        data1 = 9;
        data2 = 10;

        Console.WriteLine("\n--- Comparison Operators ---");

        bool boolResult = (data1 == data2);
        Console.WriteLine(data1 + " == " + data2 + " = " + boolResult);

        boolResult = (data1 != data2);
        Console.WriteLine(data1 + " != " + data2 + " = " + boolResult);

        boolResult = (data1 > data2);
        Console.WriteLine(data1 + " > " + data2 + " = " + boolResult);

        boolResult = (data1 < data2);
        Console.WriteLine(data1 + " < " + data2 + " = " + boolResult);

        boolResult = (data1 >= data2);
        Console.WriteLine(data1 + " >= " + data2 + " = " + boolResult);

        boolResult = (data1 <= data2);
        Console.WriteLine(data1 + " <= " + data2 + " = " + boolResult);


	}
    }