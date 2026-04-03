using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.SingleInheritence
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            Author myBook = new Author();
            myBook.title = "C# Mastery";
            myBook.publicationYear = 2024;
            myBook.name = "abc";
            myBook.bio = "Tech Writer";
            myBook.DisplayInfo();

            Console.WriteLine("----------------");

            Thermostat livingRoom = new Thermostat();
            livingRoom.deviceId = "TH-101";
            livingRoom.status = "On";
            livingRoom.temperatureSetting = 24.5;
            livingRoom.DisplayStatus();
        }
    }
}
