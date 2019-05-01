using System;
using System.Security.Cryptography;

namespace System.Security.Cryptography.KISA
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public class SEEDManaged : SymmetricAlgorithm
    {

        public ICryptoTransform CreateDecryptor()
        {
            if (IV == null || Key == null)
            {
                throw new ArgumentNullException();
            }

            return CreateDecryptor(Key, IV);
        }
        
        public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
        {
            throw new NotImplementedException();
        }
        
        public ICryptoTransform CreateEncryptor()
        {
            if (IV == null || Key == null)
            {
                throw new ArgumentNullException();
            }

            return CreateEncryptor(Key, IV);
        }

        public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
        {
            throw new NotImplementedException();
        }

        public override void GenerateIV()
        {
            
            
        }

        public override void GenerateKey()
        {
            throw new NotImplementedException();
        }
    }
}