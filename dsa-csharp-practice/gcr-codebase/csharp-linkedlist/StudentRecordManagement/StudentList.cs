using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.StudentRecordManagement
{
    public class StudentList
    {
        public Node Head;

        public void AddAtBeginning(int rollNumber, string name, int age, string grade)
        {
            Node newNode = new Node(rollNumber, name, age, grade);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddAtEnd(int rollNumber, string name, int age, string grade)
        {
            Node newNode = new Node(rollNumber, name, age, grade);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void AddAtPosition(int position, int rollNumber, string name, int age, string grade)
        {
            if (position == 0)
            {
                AddAtBeginning(rollNumber, name, age, grade);
                return;
            }
            Node newNode = new Node(rollNumber, name, age, grade);
            Node temp = Head;
            for (int i = 0; i < position - 1; i++)
            {
                if (temp == null) return;
                temp = temp.Next;
            }
            if (temp == null) return;
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void DeleteByRollNumber(int rollNumber)
        {
            if (Head == null) return;
            if (Head.RollNumber == rollNumber)
            {
                Head = Head.Next;
                return;
            }
            Node temp = Head;
            while (temp.Next != null && temp.Next.RollNumber != rollNumber)
            {
                temp = temp.Next;
            }
            if (temp.Next == null) return;
            temp.Next = temp.Next.Next;
        }

        public void SearchByRollNumber(int rollNumber)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    Console.WriteLine("Found: " + temp.Name + ", Grade: " + temp.Grade);
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.");
        }

        public void DisplayAll()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine("Roll: " + temp.RollNumber + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
                temp = temp.Next;
            }
        }

        public void UpdateGrade(int rollNumber, string newGrade)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    temp.Grade = newGrade;
                    return;
                }
                temp = temp.Next;
            }
        }
    }
}
