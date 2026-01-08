using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.StudentRecordManagement
{
    public class Node
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public string Grade;
        public Node Next;

        public Node(int rollNumber, string name, int age, string grade)
        {
            RollNumber = rollNumber;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }
}
