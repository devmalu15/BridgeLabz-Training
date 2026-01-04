using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.MultiLevelInheritence
{
    public class PaidOnlineCourse : OnlineCourse
    {
        public double fee;
        public double discount;

        public void ShowDetails()
        {
            Console.WriteLine("Course: " + courseName);
            Console.WriteLine("Platform: " + platform);
            Console.WriteLine("Final Price: " + (fee - discount));
        }
    }
}
