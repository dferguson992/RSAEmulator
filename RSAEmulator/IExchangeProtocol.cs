using System.Numerics;

namespace RSAEmulator
{
    public interface IExchangeProtocol
    {
        bool Encrypt(double message, out BigInteger encryption);

        bool Decrypt(double encryption, out BigInteger decryption);
    }
}
