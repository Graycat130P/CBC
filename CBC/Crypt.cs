using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CBC
{
    class Crypt
    {
        private string AesIV = @"";
        private string AesKey = @"";

        public void setAesIV(byte[] b){
            this.AesIV = System.Text.Encoding.ASCII.GetString(b);
        }

        public void setAesKey(byte[] b)
        {
            this.AesKey = System.Text.Encoding.ASCII.GetString(b);
        }

        public void GenerateKeyFromPassword(string password,
        int keySize, out byte[] key, int blockSize, out byte[] iv)
        {
            //パスワードから共有キーと初期化ベクタを作成する
            //saltを決める
            byte[] salt = System.Text.Encoding.UTF8.GetBytes("saltは必ず8バイト以上");
            //Rfc2898DeriveBytesオブジェクトを作成する
            System.Security.Cryptography.Rfc2898DeriveBytes deriveBytes =
                new System.Security.Cryptography.Rfc2898DeriveBytes(password, salt);
            //.NET Framework 1.1以下の時は、PasswordDeriveBytesを使用する
            //System.Security.Cryptography.PasswordDeriveBytes deriveBytes =
            //    new System.Security.Cryptography.PasswordDeriveBytes(password, salt);
            //反復処理回数を指定する デフォルトで1000回
            deriveBytes.IterationCount = 1000;

            //共有キーと初期化ベクタを生成する
            key = deriveBytes.GetBytes(keySize / 8);
            iv = deriveBytes.GetBytes(blockSize / 8);
        }

        public string EnCrypt(string text)
        {

            RijndaelManaged aes = new RijndaelManaged();
            aes.BlockSize = 128;
            aes.KeySize = 128;
            aes.Padding = PaddingMode.Zeros;
            aes.Mode = CipherMode.CBC;      // CBCモードを利用する

            aes.Key = System.Text.Encoding.UTF8.GetBytes(AesKey);

            // CBCモードを利用する場合はIVの設定を行う
            aes.IV = System.Text.Encoding.UTF8.GetBytes( AesIV );

            ICryptoTransform encrypt = aes.CreateEncryptor();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(memoryStream, encrypt, CryptoStreamMode.Write);

            byte[] text_bytes = System.Text.Encoding.UTF8.GetBytes(text);

            cryptStream.Write(text_bytes, 0, text_bytes.Length);
            cryptStream.FlushFinalBlock();

            byte[] encrypted = memoryStream.ToArray();

            //Debug.Log("byte :" + encrypted[0]);
            return (System.Convert.ToBase64String(encrypted));
        }

        public string Decrypt(string cryptText)
        {
            RijndaelManaged aes = new RijndaelManaged();
            aes.BlockSize = 128;
            aes.KeySize = 128;
            aes.Padding = PaddingMode.Zeros;
            aes.Mode = CipherMode.CBC;  // CBCモードを利用する

            aes.Key = System.Text.Encoding.UTF8.GetBytes(AesKey);

            // CBCモードを利用する場合はIVの設定を行う
            aes.IV = System.Text.Encoding.UTF8.GetBytes( AesIV );

            ICryptoTransform decryptor = aes.CreateDecryptor();

            byte[] encrypted = System.Convert.FromBase64String(cryptText);
            byte[] planeText = new byte[encrypted.Length];

            MemoryStream memoryStream = new MemoryStream(encrypted);
            CryptoStream cryptStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            cryptStream.Read(planeText, 0, planeText.Length);

            return (System.Text.Encoding.UTF8.GetString(planeText));
        }
    }
}
