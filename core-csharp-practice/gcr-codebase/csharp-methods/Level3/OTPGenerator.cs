using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Level3Methods
{

    public class OtpGenerator
    {
        public static void Main(string[] args)
        {
            string[] otps = new string[10];
            int count = 0;

            Console.WriteLine("Generating 10 Unique OTPs...");

            while (count < 10)
            {
                string newOtp = GenerateOtp();
                if (IsUnique(otps, newOtp))
                {
                    otps[count] = newOtp;
                    Console.WriteLine("OTP " + (count + 1) + ": " + newOtp);
                    count++;
                }
            }
        }

        static string GenerateOtp()
        {
            Random random = new Random();
            int otpNumber = random.Next(100000, 1000000);
            return otpNumber.ToString();
        }

        static bool IsUnique(string[] existingOtps, string newOtp)
        {
            for (int i = 0; i < existingOtps.Length; i++)
            {
                if (existingOtps[i] == newOtp)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
