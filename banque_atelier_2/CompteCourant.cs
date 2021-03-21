using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class CompteCourant:Compte
    {
        private double decouvert;
        public CompteCourant(MAD s, Client t, double d) : base(s, t)
        {
            this.decouvert = d;
        }
    }
}
