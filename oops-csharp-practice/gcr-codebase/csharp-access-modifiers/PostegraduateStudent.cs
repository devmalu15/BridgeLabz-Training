using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.AccessModifiers
{
    public class PostegraduateStudent : Student
    {
        public void ShowDetails()
        {
            rollNumber = 101;
            name = "Emily";
            Console.WriteLine("Roll: " + rollNumber);
            Console.WriteLine("Name: " + name);
        }
    }
}
