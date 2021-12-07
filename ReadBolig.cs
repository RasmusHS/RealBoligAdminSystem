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
            string område = tbOmråde.Text;

            EBolig bolig = new EBolig("0", "0", "0", område, "0", "0", 0);
            OBolig boligOP = new OBolig();

            boligOP.Select(bolig);

            
            dataGridView1.Refresh();
            MessageBox.Show("Record Updated");


        }
    }
}
