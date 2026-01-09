using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.HashMapHashSet.CustomHashMap
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            MyHashMap<string, string> map = new MyHashMap<string, string>();
            map.Put("Loveeeesh", "Engineer");
            map.Put("Ramaa", "Doctor");
            map.Put("Risita", "Artist");

            Console.WriteLine("Loveeeesh is: " + map.Get("Loveeeesh"));
            Console.WriteLine("Ramaa is: " + map.Get("Ramaa"));

            if (map.ContainsKey("Risita"))
            {
                Console.WriteLine("Risita is present.");
            }

            map.Remove("Ramaa");
            if (!map.ContainsKey("Ramaa"))
            {
                Console.WriteLine("Ramaa removed.");
            }
        }
    }
}
