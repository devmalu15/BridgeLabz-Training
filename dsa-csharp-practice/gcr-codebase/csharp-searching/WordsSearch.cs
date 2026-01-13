using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Searching
{
    public class WordsSearch
    {
        public static void Main(string[] args)
        {
            string[] sentences = {
            "rama is going to the market",
            "lovish is learning c#",
            "risita completed the project",
            "lovish and rama are friends"
        };

            string target = "risita";
            string result = FindSentenceWithWord(sentences, target);

            Console.WriteLine("Sentence containing '" + target + "': " + result);
        }

        public static string FindSentenceWithWord(string[] sentences, string word)
        {
            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(' ');
                foreach (string w in words)
                {
                    if (w == word) // Simple string comparison
                    {
                        return sentence;
                    }
                }
            }
            return "Not found";
        }
    }
}
