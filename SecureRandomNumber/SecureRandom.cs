using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecureRandomNumber
{
    public class SecureRandom
    {
        public static byte[] GenerateRandomNumber(int length)
        {
            using (var RandomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                RandomNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }
    }
}
