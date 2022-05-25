using System;
using System.Collections.Generic;

namespace ORPZ_Lab3_CreationalPatterns
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string teststring = "Hello world!";
            List<EncryptorCreator> creators = new List<EncryptorCreator>();

            creators.Add(new PBFDK2EncryptorCreator());
            creators.Add(new AesEncryptorCreator());
            creators.Add(new DesEncryptorCreator());

            Console.WriteLine("Non-Generic Factory");
            foreach (var creator in creators)
                Client(creator, teststring);


            Console.WriteLine("\n\n\n Generic factory");
            IEncryptor Encryptor = GenericEncryptorFactory<IEncryptor, AesEncryptor>.Create();

            Client(Encryptor, teststring);

            Encryptor = GenericEncryptorFactory<IEncryptor, DesEncryptor>.Create();
            Client(Encryptor, teststring);

        }

        public static void Client(EncryptorCreator creator, string text)
        {
            IEncryptor encryptor;
            encryptor = creator.FactoryMethod();

            Console.WriteLine($"Encryption algorithm: {encryptor.GetType()}");
            string encrypted = encryptor.Encrypt(text);
            Console.WriteLine($"Encryption {encrypted}");

            string decrypthed = encryptor.Decrypt(encrypted);
            Console.WriteLine($"Decrypted  {decrypthed}\n");

        }
        public static void Client(IEncryptor encryptor, string text)
        {
            string encrypted = encryptor.Encrypt(text);
            Console.WriteLine($"Encryption {encrypted}");

            string decrypthed = encryptor.Decrypt(encrypted);
            Console.WriteLine($"Decrypted  {decrypthed}\n");
        }
    }
}
