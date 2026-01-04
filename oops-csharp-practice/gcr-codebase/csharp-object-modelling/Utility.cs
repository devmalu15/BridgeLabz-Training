using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class Utility
    {
        static void Main(string[] args)
        {
            // Problem 1 Test
            Student s1 = new Student("Alice");
            Course c1 = new Course("Maths");
            s1.Enroll(c1);

            // Problem 2 Test
            University uni = new University("Cambridge");
            uni.AddDepartment("Physics");
            uni.AddDepartment("History");

            Faculty prof = new Faculty("Dr. Hawking");
            uni.AddFaculty(prof);

            Console.WriteLine("University: " + uni.Name);
            Console.WriteLine("Departments created: " + uni.Departments.Count);
            Console.WriteLine("Faculty added: " + uni.Faculties[0].Name);

            // Problem 3 Test
            Doctor d = new Doctor("Smith");
            Patient p = new Patient("John");
            d.Consult(p);

            // Problem 4 Test
            CustomerProfile cp = new CustomerProfile("Bob");
            Order o = new Order(101);
            o.AddProduct(new Product("Phone", 999));
            cp.PlaceOrder(o);
        }
    }
}
