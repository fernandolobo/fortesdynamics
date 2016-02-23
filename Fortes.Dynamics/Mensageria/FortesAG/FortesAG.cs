using Mensageria.AGWebReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

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