using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using DAL.Entities;
using DAL.Operations;

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

            EKunde kd = new EKunde();
            OKunde kdOP = new OKunde();

            kd.FuldeNavn = "sad";

            kdOP.Insert(kd);

            

        }
    }
}
