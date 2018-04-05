using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWToken.Model
{
    public class AuthenticationSite
    {
        public string Name { get; set; }

        public string Url { get; set; }
        public int Retries { get; set; }

    }
}
