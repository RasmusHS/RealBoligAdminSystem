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
    public partial class DeleteBolig : Form
    {
        string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW"; //Connection string to a local SQL DB
        private const bool test = false;

        public DeleteBolig()
        {
            InitializeComponent();
        }

        private void DeleteBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);

        }

        private void btnSletBolig_Click(object sender, EventArgs e)
        {
            string BiD = mBoligIDTextBox.Text;

            // assumption:
            bool BiD_ok = true;

            // action
            if (BiD_ok)
            {
                // database med kundetabel:
                SqlConnection conn = new SqlConnection(strconn);

                //(CRU)D:
                string sqlCom = "DELETE FROM Bolig WHERE (BiD = @BiD);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@BiD", System.Data.SqlDbType.Int);
                cmd.Parameters["@BiD"].Value = Convert.ToInt32(BiD);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@BiD"].Value + ")");
                    mBoligIDTextBox.Text = "";
                    this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    mBoligIDTextBox.Text = "";
                }
            }
            else
                MessageBox.Show("Indtast kun heltal.");
                mBoligIDTextBox.Text = "";
        }
    }
}
