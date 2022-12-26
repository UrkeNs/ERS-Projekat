using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerDistributionSystem;
using DistroHidro;

namespace DistributionCenter
{
    public class DistroCenterServicescs : IDistributionCenter
    {
        public void DodajUBazuPodataka(Uredjaj u)
        {
            Random r = new Random();
            int rb=r.Next(1,10000);
            while (DistributionCentreDataBase.uredjaji.ContainsKey(rb)) {

                rb = r.Next(1, 10000);
            
            }

            DistributionCentreDataBase.uredjaji.Add(rb,u);
        }

        

        public string TraziZahtjev(Uredjaj u)
        {

            int kwh = u.Kwph;
            double cena = (double)(10 * kwh);

            Obracun o = new Obracun(u, cena, DateTime.Now.ToString());

            return o.ToString();

            


            
        }
    }
}
