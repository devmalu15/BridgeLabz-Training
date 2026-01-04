using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Constructors
{
    public class Circle
    {
        double radius;

        public Circle() : this(1.0)
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle(5.5);
            Console.WriteLine("Circles created with radius " + c1.radius + " and " + c2.radius);
        }
    }
}
