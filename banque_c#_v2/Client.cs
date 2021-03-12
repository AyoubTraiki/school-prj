using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class Client
    {
        private readonly string nom;
        private readonly string prenom;
        private readonly string adresse;

        public Client(string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
        }
        public void afficher()
        {
            Console.Out.WriteLine("Nom: " + nom);
            Console.Out.WriteLine("Prénom: " + prenom);
            Console.Out.WriteLine("Adresse: " + adresse);
        }
    }
}
