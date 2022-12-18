using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace PowerDistributionSystem
{
    [DataContract]
    public class Uredjaj
    {
        private string Naziv;
        private int Kwph;
        private  static int kljucUredjaja = 0;

        Dictionary<int, Uredjaj> RecnikUredjaja = new Dictionary<int, Uredjaj>();


        
        public Uredjaj(string naziv, int kwph)
        {
            Naziv = naziv;
            Kwph = kwph;
            kljucUredjaja++;
        }

       /* public void dodajUredjaj(Uredjaj x) {
            RecnikUredjaja.Add(kljucUredjaja, x);
        }*/

        public Uredjaj() : this("", 0) { }

        [DataMember]
        public string Naziv1 { get => Naziv; set => Naziv = value; }
        [DataMember]
        public int Kwph1 { get => Kwph; set => Kwph = value; }



    }
}
