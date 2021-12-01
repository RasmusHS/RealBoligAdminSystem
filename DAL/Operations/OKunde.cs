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

        SqlConnection conn = new SqlConnection(@"Data Source = mssql2.unoeuro.com; Initial Catalog = kaspermark_dk_db_realbolig; Persist Security Info=True;User ID = kaspermark_dk; Password=69qom3u9PW");

        //CRUD
        public void Insert(EKunde kd)
        {
            conn.Open();
            string query = "INSERT INTO Kunde VALUES ('"+kd.FuldeNavn+"', "+kd.Tlf+", '"+kd.Mail+"', '"+kd.Adresse+"');";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
        }

        public void Delete() { 
        
        }

        public void Update() { 
        
        }

        public void Select() { 
        
        }

    }
}
