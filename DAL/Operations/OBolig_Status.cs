using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Entities;
using Microsoft.Data.SqlClient;

namespace RealBolig.DAL.Operations
{
    class OBolig_Status
    {

        SqlConnection conn = new SqlConnection(@"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;User ID=kaspermark_dk; Password=69qom3u9PW");

        //CRUD
        public void Insert(EBolig_Status bsInsert)
        {
            conn.Open();
            string query = "INSERT INTO Bolig_Status VALUES ('" + bsInsert.handelsPris + "', " + bsInsert.handelsDato + ", '" + bsInsert.købt + "', '" + bsInsert.BiD + "', '"+ bsInsert.KiD+"');";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Delete(EBolig_Status bsDelete) //Skal denne være her?
        {
            conn.Open();
            string query = "DELETE FROM Bolig_Status WHERE " + bsDelete.købt + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Update(EBolig_Status bsUpdate)
        {

            conn.Open();

            string query = "UPDATE Bolig_Status SET column1 = value1, column2 = value2, ... WHERE condition; "; //Hjælp

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }

        public void Select(EBolig_Status bsSelect)
        {

            conn.Open();
            string query = "SELECT * FROM Bolig_Status WHERE " + bsSelect.købt + ";";

            SqlCommand cmd = new SqlCommand(query, conn);

            //Man kan også tilf'je flere som fx
            //De skal bare sættes i en if statement
            string query2 = "SELECT * FROM Bolig_Status WHERE " + bsSelect.KiD + ";";

            SqlCommand cmd2 = new SqlCommand(query2, conn);


            conn.Close();

        }

    }
}
