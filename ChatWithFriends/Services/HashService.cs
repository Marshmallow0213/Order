using ChatWithFriends.Interfaces;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System;

namespace CoreMvc5_CookieAuthentication.Services
{
    public class HashService : IHashService
    {
        public string SHA512Hash(string rawString)
        {
            if (string.IsNullOrEmpty(rawString))
            {
                return "";
            }

            StringBuilder sb;

            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(rawString);

                byte[] encryption = sha512.ComputeHash(byteArray);


                sb = new StringBuilder();

               

                foreach (byte bt in encryption)
                {
                    sb.Append(bt.ToString("x2"));
                }
            }

            return sb.ToString(); ;
        }
    }
}