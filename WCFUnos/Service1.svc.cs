﻿using System;
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
    public class Service1 : IService1
    {

        public string UnosHospitalizacije(Pacijent pacijentInfo, Bolnickiracun bolRac)
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                string Message;
                try
                {         
                    con.Open();
     
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procUnos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pJMBG", pacijentInfo.jmbg);
                    cmd.Parameters.AddWithValue("@pPrezime_Ime", pacijentInfo.prezime_ime);
                    cmd.Parameters.AddWithValue("@pID_Pol", pacijentInfo.id_pol);
                    cmd.Parameters.AddWithValue("@pDatum_Rodjenja", pacijentInfo.datum_rodjenja);
                    cmd.Parameters.AddWithValue("@pID_Drzavljanstvo", pacijentInfo.id_drzavljanstvo);
                    cmd.Parameters.AddWithValue("@pStarost", pacijentInfo.starost);
                    cmd.Parameters.AddWithValue("@pAdresa_Prebivalista", pacijentInfo.adresa_prebivalista);
                    cmd.Parameters.AddWithValue("@pID_Opstina", pacijentInfo.id_opstina);
                    cmd.Parameters.AddWithValue("@pID_Osiguranje", pacijentInfo.id_osiguranje);
                    cmd.Parameters.AddWithValue("@pLBO", pacijentInfo.lbo);
                    cmd.Parameters.AddWithValue("@bID_Bolnica", bolRac.id_bolnica);
                    cmd.Parameters.AddWithValue("@bID_Odeljenje", bolRac.id_odeljenje);
                    cmd.Parameters.AddWithValue("@bBR_Istorije_Bolesti", bolRac.br_istorije_bolesti);
                    cmd.Parameters.AddWithValue("@bDatum_Prijema", bolRac.datum_prijema);
                    cmd.Parameters.AddWithValue("@bID_Uputna", bolRac.id_uputna_dijagnoza);
                    cmd.Parameters.AddWithValue("@bID_Osn_Uzr_Hosp", bolRac.id_osnovni_uzrok_hospitalizacije);
                    cmd.Parameters.AddWithValue("@bPrateca_Dijag", bolRac.id_dijagnoza1);
                    cmd.Parameters.AddWithValue("@bDatum_Ispisa", bolRac.datum_ispisa);
                    cmd.Parameters.AddWithValue("@bBR_Dana_Lezanja", bolRac.br_dana_lezanja);
                    cmd.Parameters.AddWithValue("@bID_Operacije", bolRac.id_operacije1);
                    cmd.Parameters.AddWithValue("@bID_Odeljenje_Otpust", bolRac.id_odeljenje_otpust);
                    cmd.Parameters.AddWithValue("@bID_Vrsta_Otpusta", bolRac.id_vrsta_otpusta);
                    cmd.Parameters.AddWithValue("@bID_Osn_Uzr_Smrti", bolRac.id_osnovni_uzrok_smrti);

                    // Set Output Paramater
                    SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Int);
                    outputParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();

                    int returnInt = Convert.ToInt32(cmd.Parameters["@result"].Value);


                    if (returnInt == 1)
                    {
                        Message = "Успешно унет извештај о хоспитализацији. Пацијент: " + pacijentInfo.prezime_ime + ", јмбг: " + pacijentInfo.jmbg;
                    }
                    else
                    {
                        Message = "Грешка! Проблем при уносу новог извештаја о хоспитализацији";
                    }
                }
                catch (Exception ex)
                {

                    Message = ex.Message;
                }
                finally 
                {
                    con.Close();
                }
                return Message;
            }
        }

        public bool BrisanjeHospitalizacije(int id)
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procBrisanje";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bID", id);
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

        public string IzmenaHospitalizacije(Pacijent pacijentInfo, Bolnickiracun bolRac)
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                string Message;
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procIzmena";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bID", bolRac.id);
                    cmd.Parameters.AddWithValue("@pID", pacijentInfo.id);
                    cmd.Parameters.AddWithValue("@pJMBG", pacijentInfo.jmbg);
                    cmd.Parameters.AddWithValue("@pPrezime_Ime", pacijentInfo.prezime_ime);
                    cmd.Parameters.AddWithValue("@pID_Pol", pacijentInfo.id_pol);
                    cmd.Parameters.AddWithValue("@pDatum_Rodjenja", pacijentInfo.datum_rodjenja);
                    cmd.Parameters.AddWithValue("@pID_Drzavljanstvo", pacijentInfo.id_drzavljanstvo);
                    cmd.Parameters.AddWithValue("@pStarost", pacijentInfo.starost);
                    cmd.Parameters.AddWithValue("@pAdresa_Prebivalista", pacijentInfo.adresa_prebivalista);
                    cmd.Parameters.AddWithValue("@pID_Opstina", pacijentInfo.id_opstina);
                    cmd.Parameters.AddWithValue("@pID_Osiguranje", pacijentInfo.id_osiguranje);
                    cmd.Parameters.AddWithValue("@pLBO", pacijentInfo.lbo);
                    cmd.Parameters.AddWithValue("@bID_Bolnica", bolRac.id_bolnica);
                    cmd.Parameters.AddWithValue("@bID_Odeljenje", bolRac.id_odeljenje);
                    cmd.Parameters.AddWithValue("@bBR_Istorije_Bolesti", bolRac.br_istorije_bolesti);
                    cmd.Parameters.AddWithValue("@bDatum_Prijema", bolRac.datum_prijema);
                    cmd.Parameters.AddWithValue("@bID_Uputna", bolRac.id_uputna_dijagnoza);
                    cmd.Parameters.AddWithValue("@bID_Osn_Uzr_Hosp", bolRac.id_osnovni_uzrok_hospitalizacije);
                    cmd.Parameters.AddWithValue("@bPrateca_Dijag", bolRac.id_dijagnoza1);
                    cmd.Parameters.AddWithValue("@bDatum_Ispisa", bolRac.datum_ispisa);
                    cmd.Parameters.AddWithValue("@bBR_Dana_Lezanja", bolRac.br_dana_lezanja);
                    cmd.Parameters.AddWithValue("@bID_Operacije", bolRac.id_operacije1);
                    cmd.Parameters.AddWithValue("@bID_Odeljenje_Otpust", bolRac.id_odeljenje_otpust);
                    cmd.Parameters.AddWithValue("@bID_Vrsta_Otpusta", bolRac.id_vrsta_otpusta);
                    cmd.Parameters.AddWithValue("@bID_Osn_Uzr_Smrti", bolRac.id_osnovni_uzrok_smrti);

                    // Set Output Paramater
                    SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Int);
                    outputParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();

                    int returnInt = Convert.ToInt32(cmd.Parameters["@result"].Value);


                    if (returnInt == 1)
                    {
                        Message = "Успешно измењен извештај о хоспитализацији. Пацијент: " + pacijentInfo.prezime_ime + ", јмбг: " + pacijentInfo.jmbg;
                    }
                    else
                    {
                        Message = "Грешка! Проблем при измени извештаја о хоспитализацији";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
                return Message;}
        }

        public DataSet SviPodaci()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procSviPodaci";
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public DataSet PrikaziBolnice()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procBolnice";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procOdeljenja";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procOdeljenja";
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public DataSet PrikaziDijagnoze()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procDijagnoze";
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public DataSet PrikaziDijagnozeOsnovna()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procDijagnoze";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procDijagnoze";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procDijagnoze";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procDijagnoze";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procOperacije";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procDrzave";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procOpstine";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procVrstaOtpusta";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procPol";
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public DataSet PrikaziOsiguranje()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql1;Initial Catalog=bolnickiracun;User ID=sa;Password=Vegeta1977"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "procOsiguranje";
                    cmd.CommandType = CommandType.StoredProcedure;
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
