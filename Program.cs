using System;
using System.Security.Cryptography;

namespace Hashes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var token = CreateToken("Message", "secret");


            Console.WriteLine(token);

            Console.ReadLine();
        }

        private static string CreateToken(string message, string secret)
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                var str = Convert.ToBase64String(hashmessage);
                string hex = Base64ToHex(str);

                return hex;
            }
        }

        public static string Base64ToHex(string strInput)
        {
            try
            {
                var bytes = Convert.FromBase64String(strInput);
                var hex = BitConverter.ToString(bytes);
                return hex.Replace("-", "").ToLower();
            }
            catch (Exception)
            {
                return "-1";
            }
        }
    }
}
