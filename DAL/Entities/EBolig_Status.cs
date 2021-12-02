﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Operations;

namespace RealBolig.DAL.Entities
{
    class EBolig_Status
    {

        public int KiD { get; set; }
        public string FuldeNavn { get; set; }
        public int Tlf { get; set; }
        public string Mail { get; set; }
        public string Adresse { get; set; }


        public EBolig_Status(string FuldeNavn, int Tlf, string Mail, string Adresse)
        {

            this.FuldeNavn = FuldeNavn;
            this.Tlf = Tlf;
            this.Mail = Mail;
            this.Adresse = Adresse;

        }

    }
}
