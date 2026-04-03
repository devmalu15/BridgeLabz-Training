using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.MovieManagementSystem
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            MovieList list = new MovieList();
            // Using specific names for Directors
            list.AddAtEnd("Inception", "Loveeeesh", 2010, 8.8);
            list.AddAtBeginning("The Matrix", "Ramaa", 1999, 8.7);
            list.AddAtPosition(1, "Interstellar", "Risita", 2014, 8.6);

            Console.WriteLine("Movies Forward:");
            list.DisplayForward();

            Console.WriteLine("\nMovies Reverse:");
            list.DisplayReverse();

            Console.WriteLine("\nUpdating Matrix Rating and Searching for Loveeeesh:");
            list.UpdateRating("The Matrix", 9.0);
            list.Search("Loveeeesh");

            Console.WriteLine("\nRemoving Inception:");
            list.RemoveByTitle("Inception");
            list.DisplayForward();
        }
    }
}

