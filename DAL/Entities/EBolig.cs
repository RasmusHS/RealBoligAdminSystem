using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Operations;

namespace RealBolig.DAL.Entities
{
    class EBolig
    {

        public int BiD { get; set; }
        public int KiD { get; set; }
        public int PostNR { get; set; }
        public string Adresse { get; set; }
        public string Område { get; set; }
        public double SalgsPris { get; set; }
        public DateTime SalgsDato { get; set; }
        public double Kvm { get; set; }



        public EBolig(int KiD, int PostNR, string Adresse, string Område, double SalgsPris, DateTime SalgsDato, double Kvm)
        {

            this.KiD = KiD;
            this.PostNR = PostNR;
            this.Adresse = Adresse;
            this.Område = Område;
            this.SalgsPris = SalgsPris;
            this.SalgsDato = SalgsDato;
            this.Kvm = Kvm;

        }

    }
}
