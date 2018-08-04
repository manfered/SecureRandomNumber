using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureRandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random numbers");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            for(var i = 0; i < 10; ++i)
            {
                Console.WriteLine($"Random number {i} : {Convert.ToBase64String(SecureRandom.GenerateRandomNumber(32))}");
            }
        }
    }
}
