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
    public partial class CreateKunde : Form
    {
        string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW"; //Connection string to a local SQL DB
        private const bool test = false;

        public CreateKunde()
        {
            InitializeComponent();
        }

        private void CreateKunde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet2.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Kunde);

        }

        private void btnOpretKunde_Click(object sender, EventArgs e)
        {
            string FuldeNavn = mFnavnTextBox.Text;
            string Tlf = mTlfTextBox.Text;
            string Mail = mMailTextBox.Text;
            string Adresse = mAdresseTextBox.Text;

            // assumption:
            bool FuldeNavn_ok = true, Tlf_ok = true, Mail_ok = true, Adresse_ok = true;

            // length check:
            if (FuldeNavn.Length > 51) FuldeNavn_ok = false;
            if (Tlf.Length > 9) Tlf_ok = false;
            if (Mail.Length > 51) Mail_ok = false;
            if (Adresse.Length > 76) Adresse_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(Tlf)) Tlf_ok = false;

            // action
            if (FuldeNavn_ok && Tlf_ok && Mail_ok && Adresse_ok)
            {
                // database med bolig tabel:
                SqlConnection conn = new SqlConnection(strconn);

                //C(RUD):
                string sqlCom = "INSERT INTO Kunde VALUES (@FuldeNavn, @Tlf, @Mail, @Adresse);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);

                cmd.Parameters.Add("@FuldeNavn", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@FuldeNavn"].Value = Convert.ToString(FuldeNavn);

                cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
                cmd.Parameters["@Tlf"].Value = Convert.ToInt32(Tlf);

                cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Mail"].Value = Convert.ToString(Mail);

                cmd.Parameters.Add("@Adresse", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Adresse"].Value = Convert.ToString(Adresse);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@FuldeNavn"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Adresse"].Value +
                                    ")");
                    mFnavnTextBox.Text = "";
                    mTlfTextBox.Text = "";
                    mMailTextBox.Text = "";
                    mAdresseTextBox.Text = "";
                    this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Kunde);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    mFnavnTextBox.Text = "";
                    mTlfTextBox.Text = "";
                    mMailTextBox.Text = "";
                    mAdresseTextBox.Text = "";
                }
            }
            else if (!FuldeNavn_ok)
            {
                MessageBox.Show("Der må maks være 50 tegn i Fulde Navn feltet.");
                mFnavnTextBox.Text = "";
            }

            else if (!Tlf_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Tlf. feltet, samt maks 8 tegn.");
                mTlfTextBox.Text = "";
            }

            else if (!Mail_ok)
            {
                MessageBox.Show("Der må maks være 50 tegn i E-Mail feltet.");
                mMailTextBox.Text = "";
            }

            else if (!Adresse_ok)
            {
                MessageBox.Show("Der må maks være 75 tegn i Adresse feltet.");
                mAdresseTextBox.Text = "";
            }
        }
    }
}
