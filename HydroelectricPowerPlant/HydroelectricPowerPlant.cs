using DistroHidro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroelectricPowerPlant
{
    public class HydroelectricPowerPlant : IHidroelectricPower
    {
        public double PotraznjaZaGenerisanje()
        {
            Random rnd = new Random();

            int elekticnaEnergijaProc = 0; 

            double elektricnaEnergija = 0;

            double maxElektricnaEnergija = 2000;



            elekticnaEnergijaProc = rnd.Next(0, 101);

            elektricnaEnergija = maxElektricnaEnergija * ((double)elekticnaEnergijaProc / 100);

            Console.WriteLine("Trenutno generisana snaga u procentima: " + elekticnaEnergijaProc + "%");
            Console.WriteLine("Trenutna elekticna energija u MV: " + elektricnaEnergija + "MV");
            return elektricnaEnergija;
        }
    }
}
