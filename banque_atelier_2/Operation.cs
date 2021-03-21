using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class Operation
    {
        private static int cpt = 10000;
        private DateTime date;
        private int numop;
        private MAD montant;
        private string libelle;
        public Operation(DateTime d,int numop,MAD m,string lib)
        {
            this.date = DateTime.Now;
            this.numop =++ cpt;
            this.montant = m;
            this.libelle = lib;
        }

    }
}
