using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1 = new Compte(new MAD(18000), new Client("tr", "Ayb", "Bens"));
            c1.Consulter();
           
            Compte c2 = new Compte(new MAD(20000), new Client("tr", "ayo", "Bens"));
            c2.Consulter();
            
            c1.Crediter(new MAD(9000));
            c1.Consulter();

            c1.Debiter(new MAD(18000));
            c1.Consulter();

            c1.Verser(c2, new MAD(2000));
            c1.Consulter();
            c2.Consulter();

            Console.ReadKey();

        }
    }
}
