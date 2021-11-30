using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBolig
{
    public partial class CreateBolig : Form
    {
        public CreateBolig()
        {
            InitializeComponent();
        }

        private void CreateBolig_Load(object sender, EventArgs e)
        {
            /*
             Telefon nummer som kunde id i stedet for KiD? (Dvs. Tlf kolonnen i Kunde tabellen vil blive til en Primary Key kaldet Ktlf)
                Case-teksten siger bl.a. at oprettede boliger skal tilknyttes en kunde(sælger), samt deres kontaktoplysninger under oprettelsen.
            
            For at oprette en ny bolig skal der først oprettes en ny række i Bolig_Status tabellen. Dette gi'r ikke mening, fordi KiD i Bolig_Status tabellen tilhører køberen,
            men hvordan kan der allerede være en køber til et hus som overhovedet ikke findes i databasen? 

             Væk med BstatusID fra Bolig og Bolig_Status tabellerne. Giv Bolig_Status tabellen en Foreign Key der referer til Bolig tabellen (BiD).
             I Bolig_Status tabellen skal KiD(FK) sættes til at gerne må være NULL. Derudover ønskes der evnen til at når en bolig er blevet oprettet i Bolig tabellen, så 
             oprettes der en ny række i Bolig_Status tabellen, 
             hvor BiD(FK) = den BiD(PK) der lige blev oprettet og KiD = NULL, HandelsPris = NULL, HandelsDato = NULL og Købt = 0.

             Når man så skal lave en Update, så kan man opdater enten Bolig tabellen eller Bolig_Status tabellen.
             I Bolig_Status tabellen kan opdater den til at inkludere købers KiD, HandelsPris og/eller om de har Købt den bolig som BiD(FK) referer til. 
             Hvis HandelsDato ikke er NULL, så sættes Købt til 1.

            Jeg har ikke lavet nogle af de ovennævnte ændringer endnu. Venter til jeg har snakket med jer andre om det. 
            Dog er et nyt SQL script lagt ud på google drev. Scriptet indeholder CREATE TABLE sætninger der reflektere ovennævnte ændringer, men de kan ikke køres endnu. 
             */
        }
    }
}
