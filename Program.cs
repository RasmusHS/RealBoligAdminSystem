using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using RealBolig.DAL.Entities;
using RealBolig.DAL.Operations;

namespace RealBolig
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());


            //EKunde kd = new EKunde("Kasper Mark", "22504663", "kaspermarks@gmail.com", "Carl Blochs Gade"); //Det der står her inde skal så være vores textboxes!
            //OKunde kdOP = new OKunde(); //Kalder et nyt objekt om indeholder CRUD funktinoer for en kunde.

            //kdOP.Insert(kd);//Her bruges en fuktion i det objekt til at oprette en kunde i vores database.
            //i denne funktioner både åbnes og lukkes connection til database. inde i OKunder under DAL
            //I OKunder skal der så input valideres og try catch laves.

        }
    }
}
