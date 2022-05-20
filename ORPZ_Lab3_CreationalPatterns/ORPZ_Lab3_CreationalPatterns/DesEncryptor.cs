using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ORPZ_Lab3_CreationalPatterns
{
    public class DesEncryptor : IEncryptor
    {
        private byte[] Key;
        private byte[] IV;
        public DesEncryptor()
        {
            using (DES des = DES.Create())
            {
                Key = des.Key;
                IV = des.IV;
            }
        }

        public string Encrypt(string plainText)
        {
            //Key = Encoding.UTF8.GetBytes(plainText);

            // DESCryptoServiceProvider is a cryptography class defind in c#.

            DESCryptoServiceProvider ObjDES = new DESCryptoServiceProvider();

            byte[] inputByteArray = Encoding.UTF8.GetBytes(plainText);

            MemoryStream Objmst = new MemoryStream();

            CryptoStream Objcs = new CryptoStream(Objmst, ObjDES.CreateEncryptor(Key, IV), CryptoStreamMode.Write);

            Objcs.Write(inputByteArray, 0, inputByteArray.Length);

            Objcs.FlushFinalBlock();

            return Convert.ToBase64String(Objmst.ToArray());//encrypted string
           

        }

        public string Decrypt(string cipherText)
        {
            throw new NotImplementedException();
        }

       
    }
}
