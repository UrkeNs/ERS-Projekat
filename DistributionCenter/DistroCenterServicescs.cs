using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerDistributionSystem;
using SolarPanels;
using DistroHidro;
using System.ServiceModel;


namespace DistributionCenter
{
    public class DistroCenterServicescs : IDistributionCenter
    {
        public string TraziZahtjev(Uredjaj u)
        {

            int kwh = u.Kwph;
            double cena = (double)(10 * kwh);
            
            string adresa = "net.tcp://localhost:3999/Solar";
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IsolarPanelsAndWindGens> channel =
                new ChannelFactory<IsolarPanelsAndWindGens>(binding, adresa);
            IsolarPanelsAndWindGens proxy = channel.CreateChannel();

            double snaga= proxy.generisiSnagu();

            if (!(kwh > snaga))
            {

                Obracun o = new Obracun(u, cena, DateTime.Now.ToString());
                Random r = new Random();
                int rb = r.Next(1, 10000);
                while (DistributionCentreDataBase.uredjaji.ContainsKey(rb))
                {

                    rb = r.Next(1, 10000);

                }

                DistributionCentreDataBase.uredjaji.Add(rb, u);
                return "Odobren je zahtjev za uredjaj: " + o.ToString();
            }

            else
                return "Zahtjev odbijen";

            /*string adresa1 = "net.tcp://localhost:3998/Hidro";
            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IHidroelectricPower> channel1 =
                new ChannelFactory<IHidroelectricPower>(binding1, adresa1);
            IHidroelectricPower proxy1 = channel1.CreateChannel();

            double ElektricnaEnergija = proxy1.PotraznjaZaGenerisanje();
            */

            

        }
    }
}
