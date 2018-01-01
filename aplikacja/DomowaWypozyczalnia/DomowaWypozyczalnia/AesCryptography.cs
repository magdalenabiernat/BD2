using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace DomowaWypozyczalnia
{
    class AesCryptography
    {
        readonly static string salt = "BiernatBortkiewicz";
        readonly byte[] key = { 0x3, 0x1, 0xd, 0xa, 0x2, 0xd, 0xe, 0x5, 0x4, 0xc, 0xa, 0xd, 0x1, 0x1, 0x2, 0xa,
                                0xf, 0xe, 0x5, 0x8, 0xe, 0xd, 0x7, 0xc, 0x9, 0x9, 0x5, 0x7, 0xc, 0xd, 0x7, 0x8};
        readonly byte[] IV = { 0xc, 0x5, 0x5, 0x2, 0x0, 0x2, 0x8, 0x0, 0x9, 0x8, 0xd, 0x3, 0x4, 0x1, 0x2, 0x9,
                                0x3, 0x4, 0xb, 0xd, 0x8, 0xa, 0xe, 0x9, 0xe, 0x7, 0x5, 0x8, 0x1, 0x8, 0x7, 0xc};

        public static string EncryptString(string textToEncrypt, byte[] key, byte[] IV)
        {
            if (textToEncrypt == null) textToEncrypt = "";

            textToEncrypt = textToEncrypt + salt;

            string encrypted = "";

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(textToEncrypt);
                        }
                        encrypted = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            return encrypted;
        }

        public static string DescryptString(string textToDecrypt, byte[] key, byte[] IV)
        {
            if (textToDecrypt == null || textToDecrypt.Length <= 0)
                throw new ArgumentNullException("textToDecrypt");

            string decrypted = string.Empty;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(textToDecrypt)))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decrypted = sr.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }
    }
}
