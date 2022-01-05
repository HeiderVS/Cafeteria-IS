using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Modelos
{
    public class StringUtils
    {
        public static string EncryptString(string text)
        {
            var textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textBytes);
        }

        public static string DecodeString(string encodedText)
        {
            var textBytes = System.Convert.FromBase64String(encodedText);
            return System.Text.Encoding.UTF8.GetString(textBytes);
        }

        public static string CreateUsername(string name, string paternal, string maternal)
        {
            int randomNumber = new Random().Next(999);

            string user = name.Substring(0, 3) +
                          paternal.Substring(0, 3) +
                          maternal.Substring(0, 3);

            return user + randomNumber;
        }

        public static string CreateRandom()
        {
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[10];
                crypto.GetBytes(tokenBuffer);
                return Convert.ToBase64String(tokenBuffer).Substring(0, 8);
            }
        }
    }
}