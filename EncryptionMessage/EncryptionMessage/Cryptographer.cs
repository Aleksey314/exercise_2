using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace EncryptionMessage
{
    class Cryptographer
    {
        public byte[] encryptedMessage;
        public string decryptedMessage;
        public byte[] encryptedData;
        public byte[] decryptedData;
        public byte[] symmetricKeyOut;
        public byte[] symmetricIVOut;
        public byte[] symmetricKeyIn;
        public byte[] symmetricIVIn;
        public RSAParameters publicKeyRsaIn;
        public RSAParameters publicKeyRsaOut;
        private RSAParameters privateKeyRsa;
        public void EncryptRsa(byte[] dataToEncrypt)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(publicKeyRsaIn);
                    encryptedData = rsa.Encrypt(dataToEncrypt, false);
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DecryptRsa(byte[] dataToDecrypt)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(privateKeyRsa);
                    decryptedData = rsa.Decrypt(dataToDecrypt, false);
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CreateRsaKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                publicKeyRsaOut = rsa.ExportParameters(false);
                privateKeyRsa = rsa.ExportParameters(true);
            }
        }
        public void CreateAesKeys(string password, string salt)
        {
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
            symmetricKeyOut = rfc2898DeriveBytes.GetBytes(32);
            symmetricIVOut = rfc2898DeriveBytes.GetBytes(16);
        }
        public void EncryptAes(string message)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = symmetricKeyIn;
                aes.IV = symmetricIVIn;
                ICryptoTransform cryptoTransform = aes.CreateEncryptor();
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(message);
                        }
                        encryptedMessage = memoryStream.ToArray();
                    }
                }
            }
        }
        public void DecryptAes(byte[] message)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = symmetricKeyOut;
                aes.IV = symmetricIVOut;
                ICryptoTransform cryptoTransform = aes.CreateDecryptor();
                using (MemoryStream memoryStream = new MemoryStream(message))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            decryptedMessage = streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
