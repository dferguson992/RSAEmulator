using System;
using System.Numerics;


namespace RSAEmulator
{
    public class CPublicKeyExchange : IExchangeProtocol
    {
        private User _Sender;
        private User _Receiver;

        public CPublicKeyExchange(User sender, User receiver)
        {
            _Sender = sender;
            _Receiver = receiver;
        }


        public bool Encrypt(double message, out BigInteger encryption)
        {
            double encryptNumber = _Receiver.PublicKey;
            BigInteger modularBase = new BigInteger(_Receiver.N);
            encryption = BigInteger.Pow(new BigInteger(message), Convert.ToInt32(encryptNumber));
            encryption = Operations.BigMod(encryption, modularBase);
            return true;
        }

        public bool Decrypt(double encryption, out BigInteger decryption)
        {
            double decryptNumber = _Receiver.PrivateKey;
            BigInteger modularBase = new BigInteger(_Receiver.N);
            decryption = BigInteger.Pow(new BigInteger(encryption), Convert.ToInt32(decryptNumber));
            decryption = Operations.BigMod(decryption, modularBase);
            return true;
        }
    }
}
