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
        public string KiD { get; set; }
        public string PostNR { get; set; }
        public string Adresse { get; set; }
        public string Område { get; set; }
        public string SalgsPris { get; set; }
        public string Kvm { get; set; }



        public EBolig(string KiD, string PostNR, string Adresse, string Område, string SalgsPris, string Kvm)
        {

            this.KiD = KiD;
            this.PostNR = PostNR;
            this.Adresse = Adresse;
            this.Område = Område;
            this.SalgsPris = SalgsPris;
            this.Kvm = Kvm;

        }

    }
}
