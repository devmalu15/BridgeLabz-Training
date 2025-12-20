using System;

public class TriangleArea{
    public static void Main(String[] args){
        Console.WriteLine("Enter base (inches) : ");
        String input1 = Console.ReadLine();
        double baseVal = double.Parse(input1);

        Console.WriteLine("Enter height (inches) : ");
        String input2 = Console.ReadLine();
        double heightVal = double.Parse(input2);

        double areaInches = 0.5 * baseVal * heightVal;
        double areaCm = areaInches * 6.4516; 

        Console.WriteLine("The Area in Square Inches is " + areaInches + " and in Square Centimeters is " + areaCm);
    }
}