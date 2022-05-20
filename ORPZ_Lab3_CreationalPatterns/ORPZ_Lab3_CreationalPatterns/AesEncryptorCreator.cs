using System;
namespace ORPZ_Lab3_CreationalPatterns
{
    public class AesEncryptorCreator : EncryptorCreator
    {
        public AesEncryptorCreator()
        {
        }
        public override IEncryptor FactoryMethod()
        {
            return new AesEncryptor();
        }
    }
}
