using System;
namespace ORPZ_Lab3_CreationalPatterns
{
    public class PBFDK2EncryptorCreator : EncryptorCreator
    {
        public PBFDK2EncryptorCreator()
        {
        }

        public override IEncryptor FactoryMethod()
        {
            return new PBFDK2Encryptor();
        }
    }
}
