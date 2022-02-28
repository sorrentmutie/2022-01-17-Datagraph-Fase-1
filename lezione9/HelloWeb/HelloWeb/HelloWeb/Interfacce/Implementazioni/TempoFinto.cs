using System;

namespace HelloWeb.Interfacce.Implementazioni
{
    public class TempoFinto : IGestioneTempo
    {
        public DateTime OraCorrente()
        {
            return new DateTime(2000, 1, 1);
        }
    }

    public class TempoServer : IGestioneTempo
    {
        public DateTime OraCorrente()
        {
            return DateTime.Now;
        }
    }

    public class TempoOrologioAtomico : IGestioneTempo
    {
        public DateTime OraCorrente()
        {
            throw new NotImplementedException();
        }
    }

}
