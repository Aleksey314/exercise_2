using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cryptographer Jon = new Cryptographer();
            Cryptographer Bob = new Cryptographer();

            Jon.CreateAesKeys("password1", "salt1");
            Jon.CreateRsaKeys();

            Bob.CreateAesKeys("password2", "salt2");
            Bob.CreateRsaKeys();

            Jon.publicKeyRsaIn = Bob.publicKeyRsaOut;
            Bob.publicKeyRsaIn = Jon.publicKeyRsaOut;

            Jon.EncryptRsa(Jon.symmetricKeyOut);
            Bob.DecryptRsa(Jon.encryptedData);
            Bob.symmetricKeyIn = Bob.decryptedData;

            Jon.EncryptRsa(Jon.symmetricIVOut);
            Bob.DecryptRsa(Jon.encryptedData);
            Bob.symmetricIVIn = Bob.decryptedData;

            Bob.EncryptRsa(Bob.symmetricKeyOut);
            Jon.DecryptRsa(Bob.encryptedData);
            Jon.symmetricKeyIn = Jon.decryptedData;

            Bob.EncryptRsa(Bob.symmetricIVOut);
            Jon.DecryptRsa(Bob.encryptedData);
            Jon.symmetricIVIn = Jon.decryptedData;

            Bob.EncryptAes("Hello, Jon!");
            Jon.DecryptAes(Bob.encryptedMessage);
            Console.WriteLine($"Jon received message: {Jon.decryptedMessage}");

            Jon.EncryptAes("Hello, Bob!");
            Bob.DecryptAes(Jon.encryptedMessage);
            Console.WriteLine($"Bob received message: {Bob.decryptedMessage}");

            Console.WriteLine();

            Console.WriteLine($"Bob encrypted message: {Convert.ToBase64String(Bob.encryptedMessage)}");
            Console.WriteLine($"Jon encrypted message: {Convert.ToBase64String(Jon.encryptedMessage)}");

            Console.WriteLine();

            Console.WriteLine($"Jon transmitted symmetric key: {Convert.ToBase64String(Jon.symmetricKeyOut)}");
            Console.WriteLine($"Jon received symmetric key: {Convert.ToBase64String(Jon.symmetricKeyIn)}");
            Console.WriteLine($"Bob transmitted symmetric key: {Convert.ToBase64String(Bob.symmetricKeyOut)}");
            Console.WriteLine($"Bob received symmetric key: {Convert.ToBase64String(Bob.symmetricKeyIn)}");

            Console.WriteLine($"\nJon public RSA modulus: {Convert.ToBase64String(Jon.publicKeyRsaOut.Modulus)}");
            Console.WriteLine($"\nBob public RSA modulus: {Convert.ToBase64String(Bob.publicKeyRsaOut.Modulus)}");
        }
    }
}
