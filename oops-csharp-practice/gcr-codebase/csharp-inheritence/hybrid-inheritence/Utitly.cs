using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HybridInheritence
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.name = "Gordon";
            chef.PerformDuties();

            Waiter waiter = new Waiter();
            waiter.name = "Lara";
            waiter.PerformDuties();

            Console.WriteLine("----------------");

            PetrolVehicle car = new PetrolVehicle();
            car.model = "Toyota Camry";
            car.Refuel();

            ElectricVehicle ev = new ElectricVehicle();
            ev.model = "Tesla Model 3";
            ev.Charge();
        }
    }
}
