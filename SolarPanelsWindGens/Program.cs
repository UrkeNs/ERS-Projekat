using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using SolarPanels;




namespace SolarPanelsWindGens
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SolarPanelsAndWindGensServices)))
            {

                string adresa = "net.tcp://localhost:4000/DistroCenterServicescs";
                NetTcpBinding binding = new NetTcpBinding();
                host.AddServiceEndpoint(typeof(IsolarPanelsAndWindGens), binding, adresa);
                host.Open();
                Console.WriteLine("Servis je otvoren");

                Console.ReadLine();

                

            }


        }
    }
}
