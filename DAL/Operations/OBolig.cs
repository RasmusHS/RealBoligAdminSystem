using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Entities;
using Microsoft.Data.SqlClient;

namespace RealBolig.DAL.Operations
{
    class OBolig
    {

        SqlConnection conn = new SqlConnection(@"Server=mssql2.unoeuro.com; Database=kaspermark_dk_db_realbolig; User ID=kaspermark_dk; Password=69qom3u9PW; Encrypt=False; TrustServerCertificate=True");
        //string strconn = @"Server=mssql2.unoeuro.com; Database=kaspermark_dk_db_realbolig; User ID=kaspermark_dk; Password=69qom3u9PW";
        //SqlConnection conn = new SqlConnection(strconn);

        //CRUD
        public void Insert(EBolig bInsert)
        {
            conn.Open();
            string query = "INSERT INTO Bolig VALUES ('" + bInsert.KiD + "', " + bInsert.PostNR + ", '" + bInsert.Adresse + "', '" + bInsert.Område + "', '"+bInsert.SalgsPris+"', '"+bInsert.SalgsDato+"', '"+bInsert.Kvm+"');";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Delete(EBolig bDelete)
        {
            conn.Open();
            string query = "DELETE FROM Bolig WHERE " + bDelete.BiD + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Update(EBolig bUpdate)
        {

            conn.Open();

            string query = "UPDATE Bolig SET column1 = value1, column2 = value2, ... WHERE condition; "; //Hjælp

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

        public void Select(EBolig bSelect)
        {

            conn.Open();
            string query = "SELECT * FROM Bolig WHERE " + bSelect.BiD + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

    }

}
