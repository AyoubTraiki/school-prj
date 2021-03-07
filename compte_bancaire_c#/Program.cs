using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.test1;
using ConsoleApp2.G41;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte C1 = new Compte(10000, new Client("L1", "F1", "103,bd ok ville lol "));
            C1.afficher();
            Compte C2 = new Compte(40000, new Client("L2", "F2", "105,bd oke ville lol2 "));
            C2.afficher();
            C1.crediter(2000);
            C1.afficher();
            C2.debiter(44000);
            C1.virerArg(4000, C2);
            C1.afficher();
            C2.afficher();

            Console.ReadKey();
        }
    }
}
