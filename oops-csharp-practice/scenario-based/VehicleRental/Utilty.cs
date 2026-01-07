using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.VehicleRental
{
    public class Utilty
    {
        public static void Main(String[] args)
        {
            Customer billingSystem = new Customer();
            bool keepRunning = true;

            while (keepRunning)
            {
                // --- MAIN MENU UI ---
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("    VEHICLE RENTAL SYSTEM - MAIN MENU");
                Console.WriteLine("=============================================");
                Console.WriteLine("1. Rent a Bike");
                Console.WriteLine("2. Rent a Car");
                Console.WriteLine("3. Rent a Truck");
                Console.WriteLine("4. Exit Application");
                Console.WriteLine("=============================================");
                Console.Write("Please select an option (1-4): ");

                string choice = Console.ReadLine();
                Vehicle vehicleToRent = null;

                // --- INPUT HANDLING ---
                switch (choice)
                {
                    case "1":
                        vehicleToRent = GetBikeDetails();
                        break;
                    case "2":
                        vehicleToRent = GetCarDetails();
                        break;
                    case "3":
                        vehicleToRent = GetTruckDetails();
                        break;
                    case "4":
                        keepRunning = false;
                        Console.WriteLine("Exiting... Thank you!");
                        continue;
                    default:
                        Console.WriteLine("Invalid selection. Press Enter to try again.");
                        Console.ReadLine();
                        continue;
                }

                // --- FINAL BILL CALCULATION ---
                if (vehicleToRent != null)
                {
                    Console.WriteLine("\n--- RENTAL DURATION ---");
                    
                    int hours = GetValidInt("Enter total hours rented: ");
                    int distance = GetValidInt("Enter total distance (km): ");

                    
                    int totalAmount = billingSystem.CalculateBill(vehicleToRent, distance, hours);

                    Console.WriteLine("\n*********************************************");
                    Console.WriteLine($"  FINAL BILL AMOUNT: Rs. {totalAmount}");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Press Enter to return to main menu...");
                    Console.ReadLine();
                }
            }
        }

        // --- HELPER METHOD: BIKE INPUTS ---
        static Bike GetBikeDetails()
        {
            Console.WriteLine("\n>> ENTER BIKE DETAILS");
            Console.Write("Model Name: ");
            string model = Console.ReadLine();
            Console.Write("Vehicle Number: ");
            string number = Console.ReadLine();

            int price = GetValidInt("Hourly Rent Price: ");
            int driverRate = GetValidInt("Driver Rate (per hour): ");

            // Creating the Bike object
            return new Bike(model, price, driverRate, "Petrol", number);
        }

        // --- HELPER METHOD: CAR INPUTS ---
        static Car GetCarDetails()
        {
            Console.WriteLine("\n>> ENTER CAR DETAILS");
            Console.Write("Model Name: ");
            string model = Console.ReadLine();
            Console.Write("Vehicle Number: ");
            string number = Console.ReadLine();
            Console.Write("Fuel Type (Petrol/Diesel): ");
            string fuel = Console.ReadLine();

            int price = GetValidInt("Hourly Rent Price: ");
            int driverRate = GetValidInt("Driver Rate (per hour): ");
            int people = GetValidInt("Passenger Capacity: ");

            // Creating the Car object
            return new Car(model, price, driverRate, fuel, number, people);
        }

        // --- HELPER METHOD: TRUCK INPUTS ---
        static Truck GetTruckDetails()
        {
            Console.WriteLine("\n>> ENTER TRUCK DETAILS");
            Console.Write("Model Name: ");
            string model = Console.ReadLine();
            Console.Write("Vehicle Number: ");
            string number = Console.ReadLine();

            int price = GetValidInt("Hourly Rent Price: ");
            int driverRate = GetValidInt("Driver Rate (per hour): ");
            int load = GetValidInt("Load Weight (kg): ");
            int loadRate = GetValidInt("Rate per KG: ");

            // Creating the Truck object (Defaulting to Diesel)
            return new Truck(model, price, driverRate, number, load, loadRate);
        }

        // --- UTILITY: PREVENTS CRASHES ON INVALID NUMBERS ---
        static int GetValidInt(string question)
        {
            while (true)
            {
                Console.Write(question);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result) && result >= 0)
                {
                    return result;
                }
                Console.WriteLine(" [!] Invalid input. Please enter a positive number.");
            }
        
        }
    }
}
