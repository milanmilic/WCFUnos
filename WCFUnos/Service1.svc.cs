using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WCFUnos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string UnosPacijenta(Pacijent pacijentInfo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                string Message;
                try
                {
                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pacijent (jmbg, prezime_ime, id_pol, datum_rodjenja, id_drzavljanstvo, starost, adresa_prebivalista, id_opstina, id_osiguranje, lbo) " +
                    "VALUES (@jmbg, @prezime_ime, @id_pol, @datum_rodjenja, @id_drzavljanstvo, @starost, @adresa_prebivalista, @id_opstina, @id_osiguranje, @lbo)", con);
                    cmd.Parameters.AddWithValue("@jmbg", pacijentInfo.jmbg);
                    cmd.Parameters.AddWithValue("@prezime_ime", pacijentInfo.prezime_ime);
                    cmd.Parameters.AddWithValue("@id_pol", pacijentInfo.id_pol);
                    cmd.Parameters.AddWithValue("@datum_rodjenja", pacijentInfo.datum_rodjenja);
                    cmd.Parameters.AddWithValue("@id_drzavljanstvo", pacijentInfo.id_drzavljanstvo);
                    cmd.Parameters.AddWithValue("@starost", pacijentInfo.starost);
                    cmd.Parameters.AddWithValue("@adresa_prebivalista", pacijentInfo.adresa_prebivalista);
                    cmd.Parameters.AddWithValue("@id_opstina", pacijentInfo.id_opstina);
                    cmd.Parameters.AddWithValue("@id_osiguranje", pacijentInfo.id_osiguranje);
                    cmd.Parameters.AddWithValue("@lbo", pacijentInfo.lbo);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        Message = "Uspesno unet novi pacijent";
                    }
                    else
                    {
                        Message = "Greska! Problem pri unosu novog pacijenta";
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
                finally 
                {
                    con.Close();
                }
                return Message;
            }
        }

        public DataSet PrikaziPacijenta()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Pacijent WHERE starost = 90", con);
                    
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;
                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
            

        }

        public bool IzbrisiPacijenta(Pacijent pacijentInfo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Pacijent WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", pacijentInfo.id);
                    cmd.ExecuteNonQuery();
                    return true;  
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
                finally { con.Close(); }
            }
            
        }

        public void IzmeniPacijenta(Pacijent pacijentInfo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Pacijent SET jmbg = @jmbg, prezime_ime = @prezime_ime, " +
                   "id_pol = @id_pol, datum_rodjenja = @datum_rodjenja, id_drzavljanstvo = @id_drzavljanstvo, starost = @starost, " +
                    "adresa_prebivalista = @adresa_prebivalista, id_opstina = @id_opstina, id_osiguranje = @id_osiguranje, lbo = @lbo WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", pacijentInfo.id);
                    cmd.Parameters.AddWithValue("@jmbg", pacijentInfo.jmbg);
                    cmd.Parameters.AddWithValue("@prezime_ime", pacijentInfo.prezime_ime);
                    cmd.Parameters.AddWithValue("@id_pol", pacijentInfo.id_pol);
                    cmd.Parameters.AddWithValue("@datum_rodjenja", pacijentInfo.datum_rodjenja);
                    cmd.Parameters.AddWithValue("@id_drzavljanstvo", pacijentInfo.id_drzavljanstvo);
                    cmd.Parameters.AddWithValue("@starost", pacijentInfo.starost);
                    cmd.Parameters.AddWithValue("@adresa_prebivalista", pacijentInfo.adresa_prebivalista);
                    cmd.Parameters.AddWithValue("@id_opstina", pacijentInfo.id_opstina);
                    cmd.Parameters.AddWithValue("@id_osiguranje", pacijentInfo.id_osiguranje);
                    cmd.Parameters.AddWithValue("@lbo", pacijentInfo.lbo);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }


        public DataSet PrikaziBolnice()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM i_bolnica WHERE id < 91 ORDER BY naziv ASC", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;
                    
                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }

        public DataSet PrikaziOdeljenjaPrijem()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM i_odeljenje ORDER BY naziv ASC", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }

        public DataSet PrikaziOdeljenjaOtpust()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM i_odeljenje ORDER BY naziv ASC", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }

        public DataSet PrikaziDijagnozeOsnovna()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 500 * FROM i_dijagnoza ORDER BY id ASC", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            } throw new NotImplementedException();
        }

        public DataSet PrikaziDijagnozeUputna()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 500 * FROM i_dijagnoza ORDER BY id ASC", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            } throw new NotImplementedException();
        }

        public DataSet PrikaziDijagnozePrateca()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 500 * FROM i_dijagnoza ORDER BY id ASC", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            } throw new NotImplementedException();
        }

        public DataSet PrikaziDijagnozeSmrt()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 500 * FROM i_dijagnoza ORDER BY id ASC", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            } throw new NotImplementedException();
        }

        public DataSet PrikaziOperacije()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 500 id, naziv FROM i_operacije ORDER BY naziv ASC", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }

        public DataSet PrikaziDrzave()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM i_drzava", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }

        public DataSet PrikaziOpstine()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM i_opstina", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }

        public DataSet PrikaziOtpust()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM i_vrsta_otpusta", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }

        public DataSet PrikaziPol()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT id, naziv FROM i_pol", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmd.ExecuteNonQuery();
                    return ds;

                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }
    }
}
