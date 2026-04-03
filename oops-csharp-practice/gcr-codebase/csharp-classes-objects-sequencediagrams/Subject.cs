using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesObjectsAndSequenceDiagram
{
    public class Subject
    {
        public string subjectName;
        public int marks;

        public Subject(string subjectName, int marks)
        {
            this.subjectName = subjectName;
            this.marks = marks;
        }
    }
}
