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

        SqlConnection conn = new SqlConnection(@"Server=mssql2.unoeuro.com; Database=kaspermark_dk_db_realbolig; User ID=kaspermark_dk; Password=69qom3u9PW; Encrypt=False; TrustServerCertificate=True");

        //CRUD
        public void Insert(EMælger mInsert)
        {
            conn.Open();
            string query = "INSERT INTO Ejendomsmælger VALUES ('" + mInsert.FuldeNavn + "', " + mInsert.Tlf + ", '" + mInsert.Mail + "');";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Delete(EMælger mDelete)
        {
            conn.Open();
            string query = "DELETE FROM Ejendomsmælger WHERE " + mDelete.KiD + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Update(EMælger mUpdate)
        {

            conn.Open();

            string query = "UPDATE Ejendomsmælger SET column1 = value1, column2 = value2, ... WHERE condition; "; //Hjælp

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

        public void Select(EMælger mSelect)
        {

            conn.Open();
            string query = "SELECT * FROM Ejendomsmælger WHERE " + mSelect.KiD + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

    }
}
