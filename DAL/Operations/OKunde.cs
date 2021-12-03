using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using RealBolig.DAL.Entities;

namespace RealBolig.DAL.Operations
{
    public class OKunde
    {

        SqlConnection conn = new SqlConnection(@"Server=mssql2.unoeuro.com; Database=kaspermark_dk_db_realbolig; User ID=kaspermark_dk; Password=69qom3u9PW; Encrypt=False; TrustServerCertificate=True");

        //CRUD
        public void Insert(EKunde kdInsert)
        {
            conn.Open();
            string query = "INSERT INTO Kunde VALUES ('"+ kdInsert.FuldeNavn+"', "+ kdInsert.Tlf+", '"+ kdInsert.Mail+"', '"+ kdInsert.Adresse+"');";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();        
        }

        public void Delete(EKunde kdDelete) {
            conn.Open();
            string query = "DELETE FROM Kunde WHERE "+kdDelete.KiD+";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Update(EKunde kdUpdate) {

            conn.Open();

            string query = "UPDATE Kunde SET column1 = value1, column2 = value2, ... WHERE condition; "; //Hjælp

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

        public void Select(EKunde kdSelect) {

            conn.Open();
            string query = "SELECT * FROM Kunde WHERE " + kdSelect.KiD + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

    }
}
