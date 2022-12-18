using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerDistributionSystem;

namespace Consumer
{
    class Program
    {



        static void Main(string[] args)
        {
            

            Uredjaj u1 = new Uredjaj("Sporet", 750);
            Uredjaj u2 = new Uredjaj("Punjac", 40);
            Uredjaj u3 = new Uredjaj("Mikrotalasna", 400);
            Uredjaj u4 = new Uredjaj("Fen", 200);

            Console.WriteLine("Odaberite uredjaj koji zelite da upalite: ");
            string uredjaj = Console.ReadLine();

            if (uredjaj == u1.Naziv1) {
                dodajUredjaj(u1);
            }

            











        }
    
    }
}
