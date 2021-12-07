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
        string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";
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
            if (Salgspris.Length > 23) Salgspris_ok = false;
            if (KøbsPris.Length > 23) KøbsPris_ok = false;

            // "<" check for JS tags ... NO cross site scripting here.:
            if (Salgspris.Contains("<")) Salgspris_ok = false;
            if (KøbersID.Contains("<")) KøbersID_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(BiD)) BiD_ok = false;
            if (!retal.IsMatch(KøbersID)) KøbersID_ok = false;

            // Check for alphanumeric characters
            Regex dectal = new Regex(@"(^[0-9 ]*.?[0-9]*$)");
            if (!dectal.IsMatch(Salgspris)) Salgspris_ok = false;
            if (!dectal.IsMatch(KøbsPris)) KøbsPris_ok = false;

            // action
            if (BiD_ok && Salgspris_ok && KøbersID_ok && KøbsPris_ok && Købsdato_ok)
            {
                // database med kundetabel:
                SqlConnection conn = new SqlConnection(strconn);

                //(CR)U(D):
                string sqlCom = "UPDATE Bolig SET Salgspris = @SalgsPris WHERE BiD = @BiD;";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@BiD", System.Data.SqlDbType.Int);
                cmd.Parameters["@BiD"].Value = Convert.ToInt32(BiD);
                cmd.Parameters.Add("@SalgsPris", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SalgsPris"].Value = Convert.ToString(Salgspris);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@BiD"].Value + ", " +
                                    cmd.Parameters["@SalgsPris"].Value +
                                    ")");
                    mBiDTextBox.Text = "";
                    mSalgsPrisTextBox.Text = "";
                    this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    mBiDTextBox.Text = "";
                    mSalgsPrisTextBox.Text = "";
                }
            }
            else if (!BiD_ok) //Fejl besked for Kunde Tlf. feltet
            {
                MessageBox.Show("Der må kun indtastes tal i BiD feltet");
                mBiDTextBox.Text = "";
            }

            else if (!Salgspris_ok) //Fejl besked for Tekst feltet
            {
                MessageBox.Show("Der må maks være 23 tegn i Salgspris feltet.");
                mSalgsPrisTextBox.Text = "";
            }



        }
    }
}
