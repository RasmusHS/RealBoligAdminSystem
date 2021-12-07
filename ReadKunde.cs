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

namespace RealBolig
{
    public partial class ReadKunde : Form
    {
        public ReadKunde()
        {
            InitializeComponent();
        }

        private void ReadKunde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet2.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet2.Kunde);

        }

        private void SearchKunde_Click(object sender, EventArgs e)
        {
            if (tbKiD.Text == "") {
                DisplayDataNummer();
            } else if (tbNummer.Text == "") {
                DisplayDataKiD();
            }
        }

        public void DisplayDataKiD()
        {
            string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";

            SqlConnection conn = new SqlConnection(strconn);


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Kunde where KiD = '" + tbKiD.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void DisplayDataNummer()
        {
            string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";

            SqlConnection conn = new SqlConnection(strconn);


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Kunde where Tlf = '" + tbNummer.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
