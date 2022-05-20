using System;
using System.Text;

namespace ORPZ_Lab3_CreationalPatterns
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EncryptorCreator creator = new AesEncryptorCreator();
            IEncryptor encryptor = creator.FactoryMethod();
            string test = "test";
            string encrypted = encryptor.Encrypt(test);
            
            Console.WriteLine(encrypted);

            //string decrypthed = encryptor.Decrypt(encrypted);
            foreach(var el in Encoding.UTF8.GetBytes("test"))
            Console.WriteLine(el.ToString());

        }
    }
}
