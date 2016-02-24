using Mensageria.AGWebReference;

namespace Mensageria.FortesAG
{
    public class AGService
    {
        private static IAGservice service  = new IAGservice();

        public static IAGservice getIAGService()
        {
            if (service == null)
            {
                service = new IAGservice();
            }
            return service;
        }
    }
}