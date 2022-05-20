using System;
namespace ORPZ_Lab3_CreationalPatterns
{
    public interface IEncryptor
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}
