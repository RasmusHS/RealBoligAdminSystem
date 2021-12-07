using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Entities;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RealBolig.DAL.Operations
{
    
    class OBolig
    {

        string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";
        

        //CRUD
        public void Insert(EBolig bInsert)
        {
            // assumption:
            bool KundeID_ok = true, PostNR_ok = true, Adresse_ok = true, Område_ok = true, Kvm_ok = true, SalgsPris_ok = true; ;

            // length check:
            if (bInsert.PostNR.Length > 4) PostNR_ok = false;
            if (bInsert.Adresse.Length > 76) Adresse_ok = false;
            if (bInsert.Kvm.Length > 9) Kvm_ok = false;
            if (bInsert.SalgsPris.Length > 24) SalgsPris_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(bInsert.KiD)) KundeID_ok = false;
            if (!retal.IsMatch(bInsert.PostNR)) PostNR_ok = false;

            // Check for alphanumeric characters
            Regex dectal = new Regex(@"(^[0-9 ]*.?[0-9]*$)");
            if (!dectal.IsMatch(bInsert.Kvm)) Kvm_ok = false;
            if (!dectal.IsMatch(bInsert.SalgsPris)) SalgsPris_ok = false;

            // action
            if (KundeID_ok && PostNR_ok && Adresse_ok && Område_ok && Kvm_ok && SalgsPris_ok)
            {
                // database med bolig tabel:
                string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";
                SqlConnection conn = new SqlConnection(strconn);

                //C(RUD):
                string sqlCom = "INSERT INTO Bolig VALUES (@KiD, @PostNR, @Adresse, @Område, @SalgsPris, @SalgsDato, @Kvm, "+bInsert.Solgt+");";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);

                cmd.Parameters.Add("@KiD", System.Data.SqlDbType.Int);
                cmd.Parameters["@KiD"].Value = Convert.ToInt32(bInsert.KiD);

                cmd.Parameters.Add("@PostNR", System.Data.SqlDbType.Int);
                cmd.Parameters["@PostNR"].Value = Convert.ToInt32(bInsert.PostNR);

                cmd.Parameters.Add("@Adresse", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Adresse"].Value = Convert.ToString(bInsert.Adresse);

                cmd.Parameters.Add("@Område", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Område"].Value = Convert.ToString(bInsert.Område);

                cmd.Parameters.Add("@SalgsPris", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@SalgsPris"].Value = Convert.ToDecimal(bInsert.SalgsPris);

                DateTime idag = DateTime.Now;
                string Sidag = Convert.ToString(idag);
                string S2idag = $"{Sidag.Substring(6, 4)}-{Sidag.Substring(3, 2)}-{Sidag.Substring(0, 2)}";
                //xx/xx/xxxx
                cmd.Parameters.Add("@SalgsDato", System.Data.SqlDbType.Date);
                cmd.Parameters["@SalgsDato"].Value = S2idag;

                cmd.Parameters.Add("@Kvm", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@Kvm"].Value = Convert.ToDecimal(bInsert.Kvm);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@KiD"].Value + ", " +
                                    cmd.Parameters["@PostNR"].Value + ", " +
                                    cmd.Parameters["@Adresse"].Value + ", " +
                                    cmd.Parameters["@Område"].Value + ", " +
                                    cmd.Parameters["@SalgsPris"].Value + ", " +
                                    cmd.Parameters["@SalgsDato"].Value + ", " +
                                    cmd.Parameters["@Kvm"].Value +
                                    ")");

                    SqlConnection conn2 = new SqlConnection(strconn);
                    string sqlCom2 = "INSERT INTO Bolig_Status VALUES (null, null, " + getbid() + ", null);";
                    SqlCommand cmd2 = new SqlCommand(sqlCom2, conn2);
                    conn2.Open();
                    cmd2.ExecuteNonQuery();
                    conn2.Close();


                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    
                }
            }
            else if (!KundeID_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Kunde ID feltet.");
                
            }

            else if (!PostNR_ok)
            {
                MessageBox.Show("Der må maks være 4 tegn i Post nr. feltet, samt kun tal");
                
            }

            else if (!Adresse_ok)
            {
                MessageBox.Show("Der må maks være 75 tegn i Adresse feltet.");
                
            }

            else if (!Område_ok)
            {
                MessageBox.Show("Der må maks være 75 tegn i Område feltet,.");
                
            }

            else if (!Kvm_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Kvm feltet, samt maks 8 tegn.");
                
            }

            else if (!SalgsPris_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Salgs Pris feltet, samt maks 23 tegn.");
                
            }

            
            
        }

        /*public void Delete(EBolig bDelete)
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
        */
        public void Select(EBolig bSelect)
        {

            SqlConnection conn = new SqlConnection(strconn);

            conn.Open();
            string query = "SELECT * FROM Bolig where BiD = "+bSelect.BiD+"";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();

        }
        

        public static int getbid () {

                string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";



                SqlConnection conn = new SqlConnection(strconn);
                string sqltest = "SELECT MAX(BiD) FROM Bolig";
                SqlCommand cmd = new SqlCommand(sqltest, conn);

                using (conn)
                {
                    SqlCommand command = new SqlCommand(
                      "SELECT CategoryID, CategoryName FROM Categories;",
                      conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine(reader.GetInt32(0));
                            int testtest = reader.GetInt32(0);
                            return testtest;

                            

                        }

                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                        
                    }

                    reader.Close();
                conn.Close();



                    return 0;
                    
                }
        }


        public static int getpris (EBolig bgetpris) {

                string strconn = @"Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";



                SqlConnection conn = new SqlConnection(strconn);
                string sqltest = "SELECT SalgsPris FROM Bolig where Bid = "+bgetpris.BiD+"";
                SqlCommand cmd = new SqlCommand(sqltest, conn);

                using (conn)
                {
                    SqlCommand command = new SqlCommand(
                      "SELECT CategoryID, CategoryName FROM Categories;",
                      conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine(reader.GetInt32(0));
                            int testtest = reader.GetInt32(0);
                            return testtest;

                            

                        }

                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                        
                    }

                    reader.Close();
                conn.Close();



                    return 0;
                    
                }
        }
    }

}
