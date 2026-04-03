using System;

public class PenDistribution{
    public static void Main(String[] args){
	int pens = 14;
	int people = 3;

	int pensPerPerson = pens / people;
	
	int pensLeft = pens % people;

	Console.WriteLine("Pens per person : " + penPerPerson + "Pen left : " + pensLeft);
}
}