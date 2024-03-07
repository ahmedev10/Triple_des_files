using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Triple_DES_files
{
    class encr
    {
        private DESCryptoServiceProvider des = new DESCryptoServiceProvider();
        public encr (string key)
        {
            des.Key = UTF8Encoding.UTF8.GetBytes(key);
            des.Mode = CipherMode.ECB;
        }
        public void encrypt(string filpath)
        {
            byte[] Bytes = File.ReadAllBytes(filpath);
            byte[] eBytes = des.CreateEncryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filpath, eBytes);
        }

        public void decrypt(string filpath)
        {
            byte[] Bytes = File.ReadAllBytes(filpath);
            byte[] dBytes = des.CreateDecryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filpath, dBytes);
        }
    }
}
