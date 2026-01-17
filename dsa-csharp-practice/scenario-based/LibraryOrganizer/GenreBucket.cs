using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.LibraryOrganizer
{
    public class GenreBucket
    {
        public string GenreName;
        public Book BooksHead;
        public GenreBucket NextBucket;

        public GenreBucket(string genre)
        {
            GenreName = genre;
            BooksHead = null;
            NextBucket = null;
        }
    }
}
