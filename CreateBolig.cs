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
    public partial class CreateBolig : Form
    {
        //string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW"; //Connection string to a local SQL DB
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
            string KiD = mKiDTextbox.Text;
            string PostNR = mPostNRTextbox.Text;
            string Adresse = mAdresseTextbox.Text;
            string Område = mOmrådeTextbox.Text;
            string Kvm = mKvmTextbox.Text;
            string SalgsPris = mSalgsPrisTextbox.Text;
            //string SalgsDato = "";

            EBolig bolig = new EBolig(KiD, PostNR, Adresse, Område, SalgsPris, Kvm);
            OBolig boligOP = new OBolig();

            boligOP.Insert(bolig);

                mKiDTextbox.Text = "";
                mPostNRTextbox.Text = "";
                mAdresseTextbox.Text = "";
                mOmrådeTextbox.Text = "";
                mKvmTextbox.Text = "";
                mSalgsPrisTextbox.Text = "";
           
        }
    }
}
