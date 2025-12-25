using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Level3Methods
{
    public class NumberChecker
    {
        public static int digitCount(int num)
        {

            int count = 0;
            while(num > 0){
                count++;
                num = num / 10;
            }
            return count;
        }

        public static int[] digitsArray(int num)
        {
            int count = 0;

            int number = num;
            
            while (num > 0)
            {
                count++;
                num = num / 10;
            }

            int[] result = new int[count];

            for(int i = 0; i < num; i++)
            {
                result[i] = number % 10;
                number = number / 10;
            }

            return result;
        }



    }
}
