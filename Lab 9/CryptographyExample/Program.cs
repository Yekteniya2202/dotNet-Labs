using System;
using System.Security.Cryptography;
using System.Text;

namespace SecurityCSharp
{
    class Program
    {
        
        internal static CngKey aliceKeySignature;
        internal static byte[] alicePubKeyBlob;

        static void Main()
        {

           
            //создаются ключи для Алисы
            CreateKeys();

            byte[] aliceData = Encoding.UTF8.GetBytes("Alice");
            //подписание строки Алисы
            byte[] aliceSignature = CreateSignature(aliceData, aliceKeySignature);
            Console.WriteLine("Alice created signature: {0}",
                  Convert.ToBase64String(aliceSignature));

            //проверка, принадлежит ли подпись Алисе
            if (VerifySignature(aliceData, aliceSignature, alicePubKeyBlob))
            {
                Console.WriteLine("Подпись Алисы была успешно проверена");
            }
        }
        static void CreateKeys()
        {
            aliceKeySignature = CngKey.Create(CngAlgorithm.ECDsaP256);
            alicePubKeyBlob = aliceKeySignature.Export(CngKeyBlobFormat.GenericPublicBlob);
        }

        static byte[] CreateSignature(byte[] data, CngKey key)
        {
            byte[] signature;
            var signingAlg = new ECDsaCng(key);
            signature = signingAlg.SignData(data);
            signingAlg.Clear();
            return signature;
        }

        static bool VerifySignature(byte[] data, byte[] signature, byte[] pubKey)
        {
            bool retValue = false;
            using (CngKey key = CngKey.Import(pubKey, CngKeyBlobFormat.GenericPublicBlob))
            {
                var signingAlg = new ECDsaCng(key);
                retValue = signingAlg.VerifyData(data, signature);
                signingAlg.Clear();
            }
            return retValue;
        }


    }

}

