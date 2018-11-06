using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace FIEK_ECC
{
    public class FIEK_ELLIPTIC_CURVE
    {
        public byte[] PublicKey;

        ECDiffieHellmanCng ECDH = null;

        public FIEK_ELLIPTIC_CURVE()
        {
            // Gjenerimi i ciftit te celesave (publik/privat) sipas eliptic curve
            ECDH = new ECDiffieHellmanCng(ECCurve.NamedCurves.nistP521);   // specifikimi i tipit te lakores
            ECDH.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
            ECDH.HashAlgorithm = CngAlgorithm.Sha256;
            PublicKey = ECDH.PublicKey.ToByteArray();
 
        }

        // funksioni per enkriptim te mesazhit qe shkembehet
        public string[] Encrypt(byte[] recv_key, string msg)
        {
           
            byte[] rec_key = recv_key;
            byte[] encryption_key = ECDH.DeriveKeyMaterial(CngKey.Import(rec_key, CngKeyBlobFormat.EccPublicBlob));
            byte[] encryptedMessage = null;
            byte[] iv = null;

            // hybrid encryption using AES
            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = encryption_key;
                iv = aes.IV;
             
                // Enkriptimi i mesazhit
                using (MemoryStream ciphertext = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ciphertext, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] plaintextMessage = Encoding.UTF8.GetBytes(msg);
                    cs.Write(plaintextMessage, 0, plaintextMessage.Length);
                    cs.Close();
                    encryptedMessage = ciphertext.ToArray();
                }

                string enc_msg = Convert.ToBase64String(encryptedMessage);
                string out_iv = Convert.ToBase64String(iv);
                string[] out_params = { enc_msg, out_iv };
                return out_params;
            }
        }

        // funksioni per dekriptim te mesazhit
        public string Decrypt(byte[] snd_key, byte[] iv, byte[] msg)
        {
            byte[] decryption_key = ECDH.DeriveKeyMaterial(CngKey.Import(snd_key, CngKeyBlobFormat.EccPublicBlob));
            string dec_msg = "";
            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = decryption_key;
                aes.IV = iv;

                using (MemoryStream plaintext = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(plaintext, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(msg, 0, msg.Length);
                        cs.Close();
                        string message = Encoding.UTF8.GetString(plaintext.ToArray());
                        dec_msg = message;
                   
                    }
                }
            }

            return dec_msg;   
        }
    }
}
