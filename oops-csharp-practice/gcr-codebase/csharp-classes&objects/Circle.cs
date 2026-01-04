using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesAndObjects
{
    public class Circle
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void CalculateArea()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }

        public void CalculateCircumference()
        {
            double circumference = 2 * 3.14 * radius;
            Console.WriteLine("Circumference of Circle: " + circumference);
        }

        public static void Main(string[] args)
        {
            Circle c = new Circle(5.0);
            c.CalculateArea();
            c.CalculateCircumference();
        }
    }
}
