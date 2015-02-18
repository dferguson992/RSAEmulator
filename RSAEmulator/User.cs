
namespace RSAEmulator
{
    public class User
    {
        private double privateKey;
        private double publicKey;
        private double p;
        private double q;
        private string name;
        
        public User(string name, double publicKey, double privateKey, double p, double q)
        {
            this.name = name;
            this.privateKey = privateKey;
            this.publicKey = publicKey;
            this.p = p;
            this.q = q;
        }

        public double PublicKey { get { return publicKey; } }
        public double PrivateKey { get { return privateKey; } }
        public string Name { get { return name; } }
        public double N { get { return p * q; } }

        public override string ToString()
        {
            return "User: " + name + "\n\tPublicKey: (" + publicKey + ", " + N + ")";
        }
    }
}