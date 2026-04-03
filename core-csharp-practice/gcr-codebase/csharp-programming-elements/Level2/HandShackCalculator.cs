using System;

public class HandshakeCalculator{
    public static void Main(String[] args){
        Console.WriteLine("Enter numberOfStudents : ");
        String input1 = Console.ReadLine();
        int numberOfStudents = int.Parse(input1);

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("The maximum number of possible handshakes is " + handshakes);
    }
}