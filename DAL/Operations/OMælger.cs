using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Entities;
using Microsoft.Data.SqlClient;

namespace RealBolig.DAL.Operations
{
    class OMælger
    {

        SqlConnection conn = new SqlConnection(@"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;User ID=kaspermark_dk; Password=69qom3u9PW");

        //CRUD
        public void Insert(EMælger mInsert)
        {
            conn.Open();
            string query = "INSERT INTO Kunde VALUES ('" + mInsert.FuldeNavn + "', " + mInsert.Tlf + ", '" + mInsert.Mail + "', '" + mInsert.Adresse + "');";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Delete(EMælger mDelete)
        {
            conn.Open();
            string query = "DELETE FROM Kunde WHERE " + mDelete.KiD + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Update(EMælger mUpdate)
        {

            conn.Open();

            string query = "UPDATE Kunde SET column1 = value1, column2 = value2, ... WHERE condition; "; //Hjælp

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

        public void Select(EMælger mSelect)
        {

            conn.Open();
            string query = "SELECT * FROM Kunde WHERE " + mSelect.KiD + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

    }
}
