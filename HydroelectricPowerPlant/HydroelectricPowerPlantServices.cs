using DistroHidro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroelectricPowerPlant
{
    class HydroelectricPowerPlantServices : IHidroelectricPower
    {
        public double PotraznjaZaGenerisanje()
        {
            Random rand = new Random();

            double elektricnaEnergija = 0;

            int elektricnaEnergijaProc = 0;

            double maxEnergija = 2000;

            elektricnaEnergijaProc = rand.Next(0, 101);

            elektricnaEnergija = maxEnergija * ((double)elektricnaEnergijaProc / 100);

            Console.WriteLine("Trenutno generisana elektricna energija u procentima: " + elektricnaEnergijaProc + "%");
            Console.WriteLine("Trenutna elektricna energija u MV: " + elektricnaEnergija + "MV");

            return elektricnaEnergija;
        }
    }
}
