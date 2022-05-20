using System;
namespace ORPZ_Lab3_CreationalPatterns
{
    public class Client
    {
        public void Main()
        {
        }

        public void UseEncrypthor(EncryptorCreator creator)
        {
            if (creator is null)
            {
                throw new ArgumentNullException(nameof(creator));
            }
        }
    }
}
