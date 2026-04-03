using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesObjectsAndSequenceDiagram
{
    public class Student
    {
        public string studentName;
        public Subject[] subjects;
        public int subjectCount;

        public Student(string studentName, int maxSubjects)
        {
            this.studentName = studentName;
            this.subjects = new Subject[maxSubjects];
            this.subjectCount = 0;
        }

        public void AddSubject(string name, int marks)
        {
            if (subjectCount < subjects.Length)
            {
                subjects[subjectCount] = new Subject(name, marks);
                subjectCount++;
            }
        }
    }
}
