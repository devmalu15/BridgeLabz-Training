using System;

namespace projectTwo.oops.VehicleRentalSystem
{
    public class VehicleRentalSystem
    {
        public static void Main(string[] args)
        {
            Vehicle[] Vehicles = new Vehicle[3];

            for (int i = 0; i < Vehicles.Length; i++)
            {
                Console.WriteLine("\nSelect Vehicle Type:");
                Console.WriteLine("1. Bike");
                Console.WriteLine("2. Car");
                Console.WriteLine("3. Truck");
                Console.Write("Enter choice: ");

                int Choice = Convert.ToInt32(Console.ReadLine());

                Vehicle Vehicle;

                switch (Choice)
                {
                    case 1:
                        Vehicle = new Bike();
                        Vehicle.Type = "Bike";
                        break;

                    case 2:
                        Vehicle = new Car();
                        Vehicle.Type = "Car";
                        break;

                    case 3:
                        Vehicle = new Truck();
                        Vehicle.Type = "Truck";
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        i--;
                        continue;
                }

                Console.Write("Enter Vehicle Number: ");
                Vehicle.VehicleNumber = Console.ReadLine();

                Console.Write("Enter Rental Rate: ");
                Vehicle.RentalRate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Insurance Policy Number: ");
                Vehicle.InsurancePolicyNumber = Console.ReadLine();

                Vehicles[i] = Vehicle;
            }

            VehicleProcessor Processor = new VehicleProcessor();
            Processor.displayVehicles(Vehicles, Vehicles.Length);
        }
    }
}
