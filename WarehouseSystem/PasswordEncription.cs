using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
    class PasswordEncription
    {
        private string _str;

        public PasswordEncription(string str)
        {
            _str = str;
        }

        public string getHash()
        {
            //Build hash string from entered password
            byte[] hash;
            HashAlgorithm sha = new SHA512CryptoServiceProvider();
            hash = sha.ComputeHash(Encoding.Default.GetBytes(_str));

            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < hash.Length; i++)
            {
                sBuilder.Append(hash[i].ToString("x2"));
            }

            return sBuilder.ToString(); 
        }
    }
}
