using System;
namespace ORPZ_Lab3_CreationalPatterns
{
    public class DesEncryptorCreator : EncryptorCreator
    {
        public DesEncryptorCreator()
        {
        }

        public override IEncryptor FactoryMethod()
        {
            return new DesEncryptor();
        }
    }
}
