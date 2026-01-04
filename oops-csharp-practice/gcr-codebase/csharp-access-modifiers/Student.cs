using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.AccessModifiers
{
    public class Student
    {
        public int rollNumber;
        protected string name;
        private double cgpa;

        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public double GetCGPA()
        {
            return cgpa;
        }
    }
}
