using System;
using System.Security.Cryptography;
using System.Text;

namespace ORPZ_Lab3_CreationalPatterns
{
    public class AesEncryptor : IEncryptor
    {
        private byte[] Key;

        public string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                this.Key = aes.Key;

            }
            RijndaelManaged objrij = new RijndaelManaged();

            //set the mode for operation of the algorithm

            objrij.Mode = CipherMode.CBC;

            //set the padding mode used in the algorithm.

            objrij.Padding = PaddingMode.PKCS7;

            //set the size, in bits, for the secret key.

            objrij.KeySize = 0x80;

            //set the block size in bits for the cryptographic operation.

            objrij.BlockSize = 0x80;

            //set the symmetric key that is used for encryption & decryption.

            // byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);

            //set the initialization vector (IV) for the symmetric algorithm

            byte[] EncryptionkeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            int len = Key.Length;

            if (len > EncryptionkeyBytes.Length)
            {

                len = EncryptionkeyBytes.Length;

            }

            Array.Copy(Key, EncryptionkeyBytes, len);

            objrij.Key = EncryptionkeyBytes;

            objrij.IV = EncryptionkeyBytes;

            //Creates symmetric AES object with the current key and initialization vector IV.

            ICryptoTransform objtransform = objrij.CreateEncryptor();

            byte[] textDataByte = Encoding.UTF8.GetBytes(plainText);

            //Final transform the test string.

            return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));
        }

        public string Decrypt(string cipherText)
        {
            RijndaelManaged objrij = new RijndaelManaged();

            objrij.Mode = CipherMode.CBC;

            objrij.Padding = PaddingMode.PKCS7;

            objrij.KeySize = 0x80;

            objrij.BlockSize = 0x80;

            byte[] encryptedTextByte = Convert.FromBase64String(cipherText);

            //byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);

            byte[] EncryptionkeyBytes = new byte[0x10];

            int len = Key.Length;

            if (len > EncryptionkeyBytes.Length)

            {

                len = EncryptionkeyBytes.Length;

            }

            Array.Copy(Key, EncryptionkeyBytes, len);

            objrij.Key = EncryptionkeyBytes;

            objrij.IV = EncryptionkeyBytes;

            byte[] TextByte = objrij.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);

            return Encoding.UTF8.GetString(TextByte);  //it will return readable string
        }


    }
}
