using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RealBolig
{
    public partial class UpdateBolig : Form
    {
        public UpdateBolig()
        {
            InitializeComponent();
        }

        private void UpdateBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);

        }

        private void btnOpdaterBolig_Click(object sender, EventArgs e)
        {
            string BiD = mBiDTextBox.Text;
            string Salgspris = mSalgsPrisTextBox.Text;
            string KøbersID = mKøberIDTextBox.Text;
            string KøbsPris = mKøbsPrisTextBox.Text;
            string Købsdato = mKøbsDatoTextBox.Text;

            // assumption:
            bool BiD_ok = true, Salgspris_ok = true, KøbersID_ok = true, KøbsPris_ok = true, Købsdato_ok = true;

            // length check:
            if (KundeTlf.Length > 11) KundeTlf_ok = false;
            if (Tekst.Length > 50) Tekst_ok = false;
            if (Pris.Length > 20) Pris_ok = false;

            // "<" check for JS tags ... NO cross site scripting here.:
            if (KundeTlf.Contains("<")) KundeTlf_ok = false;
            if (Tekst.Contains("<")) Tekst_ok = false;
            if (Pris.Contains("<")) Pris_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(KundeTlf)) KundeTlf_ok = false;

            // Check for alphanumeric characters
            Regex dectal = new Regex(@"(^[0-9 ]*.?[0-9]*$)");
            if (!dectal.IsMatch(Pris)) Pris_ok = false;

            // action
            if (BiD_ok && Salgspris_ok && KøbersID_ok && KøbsPris_ok && Købsdato_ok)
            {
                // database med kundetabel:
                SqlConnection conn = new SqlConnection(strconn);

                //(CR)U(D):
                string sqlCom = "UPDATE Ordre SET KundeTlf = @kundetlf, Tekst = @tekst, Pris = @pris WHERE OrdreId = @OrdreId;";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@OrdreId", System.Data.SqlDbType.Int);
                cmd.Parameters["@OrdreId"].Value = Convert.ToInt32(OrdreId);
                cmd.Parameters.Add("@kundetlf", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@kundetlf"].Value = Convert.ToString(KundeTlf);
                cmd.Parameters.Add("@tekst", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@tekst"].Value = Convert.ToString(Tekst);
                cmd.Parameters.Add("@pris", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@pris"].Value = Convert.ToDecimal(Pris);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@OrdreId"].Value + ", " +
                                    cmd.Parameters["@kundetlf"].Value + ", " +
                                    cmd.Parameters["@tekst"].Value + ", " +
                                    cmd.Parameters["@pris"].Value +
                                    ")");
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                    this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                }
            }
            else if (!KundeTlf_ok) //Fejl besked for Kunde Tlf. feltet
            {
                MessageBox.Show("Der må kun indtastes tal i Kunde Tlf. feltet, samt maks 11 tegn.");
                maskedOIDTextBox.Text = "";
                maskedKtlfTextBox.Text = "";
            }

            else if (!Tekst_ok) //Fejl besked for Tekst feltet
            {
                MessageBox.Show("Der må maks være 50 tegn i Tekst feltet.");
                maskedOIDTextBox.Text = "";
                maskedTekstBox.Text = "";
            }

            else if (!Pris_ok) //Fejl besked for Pris feltet
            {
                MessageBox.Show("Der må kun indtastes tal og et komma/punktum i Pris feltet, samt maks 50 tegn og maks 2 decimaler.");
                maskedOIDTextBox.Text = "";
                maskedPrisTextBox.Text = "";
            }
        }
    }
}
