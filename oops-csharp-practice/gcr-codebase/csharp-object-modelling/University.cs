using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class University
    {
        public string Name;
        public List<UniDepartment> Departments = new List<UniDepartment>();
        public List<Faculty> Faculties = new List<Faculty>();

        public University(string name)
        {
            Name = name;
        }

        public void AddDepartment(string deptName)
        {
            Departments.Add(new UniDepartment(deptName));
        }

        public void AddFaculty(Faculty f)
        {
            Faculties.Add(f);
        }
    }
}
