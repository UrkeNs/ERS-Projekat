using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using DistroHidro;

namespace HydroelectricPowerPlant
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HydroelectricPowerPlantServices)))
            {

                string adresa = "net.tcp://localhost:3998/Hidro";
                NetTcpBinding binding = new NetTcpBinding();
                host.AddServiceEndpoint(typeof(IHidroelectricPower), binding, adresa);
                host.Open();
                Console.WriteLine("Hidroelektrana je otvorena");

                Console.ReadLine();
            }
        }
    }
}
