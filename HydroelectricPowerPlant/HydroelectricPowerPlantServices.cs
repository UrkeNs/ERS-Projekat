using DistroHidro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroelectricPowerPlant
{
    public class HydroelectricPowerPlantServices : IHidroelectricPower
    {
        public double PotraznjaZaGenerisanje()
        {
            Random rnd = new Random();

            int elektricnaEnergijaProc = 0; 

            double elektricnaEnergija = 0;

            double maxElektricnaEnergija = 2000;



            elektricnaEnergijaProc = rnd.Next(0, 101);

            elektricnaEnergija = maxElektricnaEnergija * ((double)elektricnaEnergijaProc / 100);

            Console.WriteLine("Trenutno generisana snaga u procentima: " + elektricnaEnergijaProc + "%");
            Console.WriteLine("Trenutna snaga generisana u KW: " + elektricnaEnergija + "KW");

            return elektricnaEnergija;
        }
    }
}

              

