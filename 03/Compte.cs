using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class Compte
    {
        private readonly int numComp;
        private MAD solde;
        private readonly Client titulaire;
        private static int cpt = 0;
        private static readonly MAD plafond = new MAD(100000);

        public Compte(MAD s, Client t)
        {
            cpt++;
            numComp = cpt;
            this.solde = s;
            this.titulaire = t;
        }
        public bool Crediter(MAD somme)
        {
            if (somme >= new MAD(0))
            {
                solde += somme;
                Console.Out.WriteLine("traitement effectuée");
                return true;
            }
            else
            {
                Console.WriteLine("refaire le traitement");
                return false;
            }
        }
        public bool Debiter(MAD somme)
        {
            if (plafond >= somme)
            {
                solde -= somme;
                Console.Out.WriteLine("Opération bien effectuée");
                return true;
                
            }
            else
                Console.Out.WriteLine("Votre solde est insuffisant pour cette opération");
            return false;
        }
        public bool Verser(Compte C, MAD somme)
        {
            if (plafond >= somme)
            {
                if (Debiter(somme))
                {
                    C.Crediter(somme);
                }
                
                return true;
            }
            else
                return false;
        }
        public void Consulter()
        {
            Console.Out.WriteLine("Numéro de Compte: " + numComp);
            solde.afficher();
            Console.Out.WriteLine("titulaire du compte est : ");
            titulaire.afficher();
            Console.Out.WriteLine();
        }
    }
}
