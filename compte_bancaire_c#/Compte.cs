using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.test1;

namespace ConsoleApp2
{
    namespace G41 
    {
        class Compte
        {
            private int numCompte;
            private Client e;
            public static int num = 0;
            private double solde;         
            public Compte(double s,Client e)
            {
                this.e = e;
                this.solde = s;
                num++;
                this.numCompte = num;

                
            }
            public void crediter(double c)
            {
                this.solde += c;
            }
            public void debiter(double d)
            {
                if (this.solde >= d)
                {
                    this.solde -= d;
                }
                else
                {
                    Console.WriteLine("impossible de débiter le compte");
                }
            }
            public void virerArg(double v, Compte c)
            {
                if (this.solde >= v)
                {
                    this.solde -= v;
                     c.solde += v;
                }
                else
                {
                    Console.WriteLine("impossible de traiter le virement");
                }
            }
            public void afficher()
            {
                Console.WriteLine("le num de compte est : " + this.numCompte+ "le solde est : " + this.solde+"le client titulaire est : ");
                e.afficher();

            }

        }

    }
    
}
