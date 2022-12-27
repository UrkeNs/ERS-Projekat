using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarPanels;
using System.Threading;

namespace SolarPanelsWindGens
{
    class SolarPanelsAndWindGensServices : IsolarPanelsAndWindGens
    {

        public double generisiSnagu() {

            Random rnd = new Random();

            int snagaSolarWind = 0; // snaga u procentima

            double snagaKW = 0;

            double maxSnaga = 750;



            snagaSolarWind = rnd.Next(0, 101);

            snagaKW = maxSnaga * ((double)snagaSolarWind / 100);

            Console.WriteLine("Trenutno generisana snaga u procentima: " + snagaSolarWind + "%");
            Console.WriteLine("Trenutna snaga generisana u KW: " + snagaKW + "KW");



            return snagaKW;
        }

        

    }
}
