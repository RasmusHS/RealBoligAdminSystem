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
using RealBolig.DAL.Entities;
using RealBolig.DAL.Operations;

namespace RealBolig
{
    public partial class ReadBolig : Form
    {
        public ReadBolig()
        {
            InitializeComponent();
        }

        private void ReadBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);

        }

        private void btnIndlæsBolig_Click(object sender, EventArgs e)
        {
           DisplayData();

        }
        public void DisplayData()
        {
            string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";

            SqlConnection conn = new SqlConnection(strconn);
            
            
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig where Område = '" + tbOmråde.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
