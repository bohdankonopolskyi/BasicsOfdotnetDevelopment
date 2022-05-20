using System;
namespace ORPZ_Lab3_CreationalPatterns
{
    public abstract class EncryptorCreator
    {
        public abstract IEncryptor FactoryMethod();

        public EncryptorCreator()
        {
        }
    }
}
