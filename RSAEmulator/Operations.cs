using System;
using System.Numerics;

namespace RSAEmulator
{
    public static class Operations
    {
        public static BigInteger BigMod(BigInteger f1, BigInteger f2)
        {
            BigInteger mod = BigInteger.Remainder(f1, f2);
            if (mod < 0)
                mod = f2 + mod;
            return mod;
        }
    }
}
