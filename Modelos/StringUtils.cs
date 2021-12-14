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
    }
}