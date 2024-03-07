using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Triple_DES_files
{
    class triple
    {
        private TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        public triple(string key)
        {
            tdes.Key = UTF8Encoding.UTF8.GetBytes(key);
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
        }
        public void encrypt(string filpath)
        {
            byte[] Bytes = File.ReadAllBytes(filpath);
            byte[] eBytes = tdes.CreateEncryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filpath, eBytes);
        }

        public void decrypt(string filpath)
        {
            byte[] Bytes = File.ReadAllBytes(filpath);
            byte[] dBytes = tdes.CreateDecryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filpath, dBytes);
        }
    }
}
