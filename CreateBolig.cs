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
    public partial class CreateBolig : Form
    {
        string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW"; //Connection string to a local SQL DB
        private const bool test = false;

        public CreateBolig()
        {
            InitializeComponent();
        }

        private void CreateBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Kunde);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);

        }

        private void btnOpretBolig_Click(object sender, EventArgs e)
        {
            string KundeID = mKiDTextbox.Text;
            string PostNR = mPostNRTextbox.Text;
            string Adresse = mAdresseTextbox.Text;
            string Område = mOmrådeTextbox.Text;
            string Kvm = mKvmTextbox.Text;
            string SalgsPris = mSalgsPrisTextbox.Text;
            //string SalgsDato = "";

            // assumption:
            bool KundeID_ok = true, PostNR_ok = true, Adresse_ok = true, Område_ok = true, Kvm_ok = true, SalgsPris_ok = true; ;

            // length check:
            if (PostNR.Length > 4) PostNR_ok = false;
            if (Adresse.Length > 76) Adresse_ok = false;
            if (Kvm.Length > 9) Kvm_ok = false;
            if (SalgsPris.Length > 24) SalgsPris_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(KundeID)) KundeID_ok = false;
            if (!retal.IsMatch(PostNR)) PostNR_ok = false;

            // Check for alphanumeric characters
            Regex dectal = new Regex(@"(^[0-9 ]*.?[0-9]*$)");
            if (!dectal.IsMatch(Kvm)) Kvm_ok = false;
            if (!dectal.IsMatch(SalgsPris)) SalgsPris_ok = false;

            // action
            if (KundeID_ok && PostNR_ok && Adresse_ok && Område_ok && Kvm_ok && SalgsPris_ok)
            {
                // database med bolig tabel:
                SqlConnection conn = new SqlConnection(strconn);

                //C(RUD):
                string sqlCom = "INSERT INTO Bolig VALUES (@KiD, @PostNR, @Adresse, @Område, @SalgsPris, @SalgsDato, @Kvm);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);

                cmd.Parameters.Add("@KiD", System.Data.SqlDbType.Int);
                cmd.Parameters["@KiD"].Value = Convert.ToInt32(KundeID);

                cmd.Parameters.Add("@PostNR", System.Data.SqlDbType.Int);
                cmd.Parameters["@PostNR"].Value = Convert.ToInt32(PostNR);

                cmd.Parameters.Add("@Adresse", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Adresse"].Value = Convert.ToString(Adresse);

                cmd.Parameters.Add("@Område", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Område"].Value = Convert.ToString(Område);

                cmd.Parameters.Add("@SalgsPris", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@SalgsPris"].Value = Convert.ToDecimal(SalgsPris);

                DateTime idag = DateTime.Now;
                string Sidag = Convert.ToString(idag);
                string S2idag = $"{Sidag.Substring(6, 4)}-{Sidag.Substring(3, 2)}-{Sidag.Substring(0, 2)}";
                //xx/xx/xxxx
                cmd.Parameters.Add("@SalgsDato", System.Data.SqlDbType.Date);
                cmd.Parameters["@SalgsDato"].Value = S2idag;

                cmd.Parameters.Add("@Kvm", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@Kvm"].Value = Convert.ToDecimal(Kvm);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@KiD"].Value + ", " +
                                    cmd.Parameters["@PostNR"].Value + ", " +
                                    cmd.Parameters["@Adresse"].Value + ", " +
                                    cmd.Parameters["@Område"].Value + ", " +
                                    cmd.Parameters["@SalgsPris"].Value + ", " +
                                    cmd.Parameters["@SalgsDato"].Value + ", " +
                                    cmd.Parameters["@Kvm"].Value +
                                    ")");
                    mKiDTextbox.Text = "";
                    mPostNRTextbox.Text = "";
                    mAdresseTextbox.Text = "";
                    mOmrådeTextbox.Text = "";
                    mKvmTextbox.Text = "";
                    mSalgsPrisTextbox.Text = "";
                    this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    mKiDTextbox.Text = "";
                    mPostNRTextbox.Text = "";
                    mAdresseTextbox.Text = "";
                    mOmrådeTextbox.Text = "";
                    mKvmTextbox.Text = "";
                    mSalgsPrisTextbox.Text = "";
                }
            }
            else if (!KundeID_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Kunde ID feltet.");
                mKiDTextbox.Text = "";
            }

            else if (!PostNR_ok)
            {
                MessageBox.Show("Der må maks være 4 tegn i Post nr. feltet, samt kun tal");
                mPostNRTextbox.Text = "";
            }

            else if (!Adresse_ok)
            {
                MessageBox.Show("Der må maks være 75 tegn i Adresse feltet.");
                mAdresseTextbox.Text = "";
            }

            else if (!Område_ok)
            {
                MessageBox.Show("Der må maks være 75 tegn i Område feltet,.");
                mOmrådeTextbox.Text = "";
            }

            else if (!Kvm_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Kvm feltet, samt maks 8 tegn.");
                mKvmTextbox.Text = "";
            }

            else if (!SalgsPris_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Salgs Pris feltet, samt maks 23 tegn.");
                mSalgsPrisTextbox.Text = "";
            }
        }
    }
}
