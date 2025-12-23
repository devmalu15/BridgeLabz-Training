using System;

public class BmiCalculator{
    public static void Main(String[] args){
        Console.WriteLine("Enter weight in kg: ");
        String input1 = Console.ReadLine();
        double weight = double.Parse(input1);

        Console.WriteLine("Enter height in cm: ");
        String input2 = Console.ReadLine();
        double heightCm = double.Parse(input2);

        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);

        Console.WriteLine("Your BMI is: " + bmi);

        if(bmi < 18.5){
            Console.WriteLine("Status: Underweight");
        }
        else if(bmi >= 18.5 && bmi < 24.9){
            Console.WriteLine("Status: Normal Weight");
        }
        else if(bmi >= 25 && bmi < 29.9){
            Console.WriteLine("Status: Overweight");
        }
        else{
            Console.WriteLine("Status: Obese");
        }
    }
}