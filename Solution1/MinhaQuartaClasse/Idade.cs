using System;

namespace MinhaQuartaClasse
{
    internal class Idade
    {
        public Idade()
        {
        }

        public static implicit operator int(Idade v)
        {
            throw new NotImplementedException();
        }
    }
}