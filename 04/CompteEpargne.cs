using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class CompteEpargne:Compte
    {
        private double TauxInteret;
        public CompteEpargne(MAD s, Client t,double i) :base(s,t)
        {
            this.TauxInteret = i;

        }
        public void CalculInteret()
        {
            MAD interet = new MAD(this.solde * TauxInteret);
            solde += interet;
            Console.WriteLine("le solde finale est :" + solde);
        }

    }
}
