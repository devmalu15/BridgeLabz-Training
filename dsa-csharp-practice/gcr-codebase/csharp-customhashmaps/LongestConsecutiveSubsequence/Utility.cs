using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.HashMapHashSet.LongestConsecutiveSubsequence
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            MyHashMap<string, string> map = new MyHashMap<string, string>();
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            int result = map.FindLongest(arr);
            Console.WriteLine("Longest sequence for Risita is: " + result);
        }
    }
}
