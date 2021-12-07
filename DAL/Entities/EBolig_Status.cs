using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Operations;

namespace RealBolig.DAL.Entities
{
    class EBolig_Status
    {

        public double handelsPris { get; set; }
        public DateTime handelsDato { get; set; }
        public bool købt { get; set; }
        public int BiD { get; set;}
        public int KiD { get; set; }


        public EBolig_Status(double handelsPris, DateTime handelsDato, bool købt, int BiD, int KiD)
        {

            this.handelsPris = handelsPris;
            this.handelsDato = handelsDato;
            this.købt = købt;
            this.BiD = BiD;
            this.KiD = KiD;

        }

    }
}
