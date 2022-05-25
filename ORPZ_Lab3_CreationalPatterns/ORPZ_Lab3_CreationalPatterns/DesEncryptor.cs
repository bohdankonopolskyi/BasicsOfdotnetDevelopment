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

        public string Encrypt(string plainText)
        {
            using (DES des = DES.Create())
            {
                this.Key = des.Key;
                this.IV = des.IV;
            }
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
            //key = Encoding.UTF8.GetBytes(strKey);

            DESCryptoServiceProvider ObjDES = new DESCryptoServiceProvider();

           byte[] inputByteArray = Convert.FromBase64String(cipherText);

            MemoryStream Objmst = new MemoryStream();

            CryptoStream Objcs = new CryptoStream(Objmst, ObjDES.CreateDecryptor(Key, IV), CryptoStreamMode.Write);

            Objcs.Write(inputByteArray, 0, inputByteArray.Length);

            Objcs.FlushFinalBlock();

            Encoding encoding = Encoding.UTF8;

            return encoding.GetString(Objmst.ToArray());
        }

       
    }
}
