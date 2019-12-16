using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_598
{
    class Encryptor
    {
        public string encryptString(string a)
        {
            byte[] data;

            string Hash = a;
            for (int i = 0; i < 1000; i++)
            {
                data = System.Text.Encoding.ASCII.GetBytes(Hash);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                Hash = System.Text.Encoding.ASCII.GetString(data);
            }

            return Hash;
        }
    }
}
