using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.MovieManagementSystem
{
    public class Node
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public Node Next;
        public Node Prev;

        public Node(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }

}
