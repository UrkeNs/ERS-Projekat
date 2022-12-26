using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using PowerDistributionSystem;
using System.Text.RegularExpressions;

namespace Consumer
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string adresa = "net.tcp://localhost:4000/DistroCenterServicescs";
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IDistributionCenter> channel = 
                new ChannelFactory<IDistributionCenter>(binding,adresa);
            IDistributionCenter proxy = channel.CreateChannel();

            while (true) {

                Console.WriteLine("Odaberite uredjaj koji zelite da prikljucite[1-4]:");
                Console.WriteLine("1.Sporet");
                Console.WriteLine("2.Punjac");
                Console.WriteLine("3.Mikrotalasna");
                Console.WriteLine("4.Fen");
                Console.WriteLine("5.Izlaz");
                string rbrurdj = Console.ReadLine();
                string strRegex = "^[1-5]$";
                Regex re = new Regex(strRegex);

            if (!re.IsMatch(rbrurdj))
            {
                Console.WriteLine("Niste unijeli validnu vrednost,pokusajte ponovo !");
                continue;
            }

                int rbr = Int32.Parse(rbrurdj);

                switch (rbr) {


                    case 1:

                        Uredjaj u = new Uredjaj("Sporet",750);
                        Console.WriteLine(proxy.TraziZahtjev(u));

                        break;

                    case 2:

                        Uredjaj u1 = new Uredjaj("Punjac", 40);
                        Console.WriteLine(proxy.TraziZahtjev(u1));

                        break;

                    case 3:

                        Uredjaj u2 = new Uredjaj("Mikrotalasna", 340);
                        Console.WriteLine(proxy.TraziZahtjev(u2));

                        break;

                    case 4:

                        Uredjaj u3 = new Uredjaj("Fen", 20);
                        Console.WriteLine(proxy.TraziZahtjev(u3));

                        break;



                    default:
                        break;

                }


                if (rbr == 5)
                {
                    Console.WriteLine("Kraj!");
                    break;
                }

                
            
            
            
            }



        }
    
    }
}
