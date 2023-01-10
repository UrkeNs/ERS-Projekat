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

           
            Random r = new Random();
            int rb = r.Next(1, 10000);
            Elektrana e = new Elektrana(elektricnaEnergijaProc,DateTime.Now);
            
            while (HydroelectricPowerPlantDataBase.elektrane.ContainsKey(rb))
            {

                rb = r.Next(1, 10000);

            }

            HydroelectricPowerPlantDataBase.elektrane.Add(rb,e);
            

            Console.WriteLine("Trenutno generisana elektricna energija u procentima: " + elektricnaEnergijaProc + "%");
            Console.WriteLine("Trenutna elektricna energija u MV: " + elektricnaEnergija + "MV");

            return elektricnaEnergija;
        }
    }
}

              

