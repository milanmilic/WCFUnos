using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFUnos
{
    [ServiceContract]
    public interface IService1
    {
        //metode za CRUD iz interfejsa koje ce biti nasledjene
        [OperationContract]
        string UnosHospitalizacije(Pacijent pacijentInfo, Bolnickiracun bolRac);

        [OperationContract]
        DataSet PrikaziBolnice();

        [OperationContract]
        DataSet PrikaziOdeljenjaPrijem();

        [OperationContract]
        DataSet PrikaziOdeljenjaOtpust();

        [OperationContract]
        DataSet PrikaziDijagnozeOsnovna();

        [OperationContract]
        DataSet PrikaziDijagnozeUputna();

        [OperationContract]
        DataSet PrikaziDijagnozePrateca();

        [OperationContract]
        DataSet PrikaziDijagnozeSmrt();

        [OperationContract]
        DataSet PrikaziOperacije();

        [OperationContract]
        DataSet PrikaziDrzave();

        [OperationContract]
        DataSet PrikaziOpstine();

        [OperationContract]
        DataSet PrikaziOtpust();

        [OperationContract]
        DataSet PrikaziPol();

        [OperationContract]
        DataSet PrikaziOsiguranje();
    }

    //klase koje odgovaraju tabelama iz baze
    [DataContract]
    public class Pacijent
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string jmbg { get; set; }
        [DataMember]
        public string prezime_ime { get; set; }
        [DataMember]
        public int id_pol { get; set; }
        [DataMember]
        public DateTime datum_rodjenja { get; set; }
        [DataMember]
        public int id_drzavljanstvo { get; set; }
        [DataMember]
        public int starost { get; set; }
        [DataMember]
        public string adresa_prebivalista { get; set; }
        [DataMember]
        public string id_opstina { get; set; }
        [DataMember]
        public int id_osiguranje { get; set; }
        [DataMember]
        public string lbo { get; set; }
    }

    [DataContract]
    public class Bolnickiracun
    {
        [DataMember]
        public double id { get; set; }

        [DataMember]
        public int id_bolnica { get; set; }

        [DataMember]
        public int id_odeljenje { get; set; }

        [DataMember]
        public int id_odeljenje_otpust { get; set; }

        [DataMember]
        public string br_istorije_bolesti { get; set; }

        [DataMember]
        public DateTime datum_prijema { get; set; }
        
        [DataMember]
        public DateTime datum_ispisa { get; set; }

        [DataMember]
        public string id_uputna_dijagnoza { get; set; }

        [DataMember]
        public string id_osnovni_uzrok_hospitalizacije { get; set; }

        [DataMember]
        public string id_dijagnoza1 { get; set; }

        [DataMember]
        public int br_dana_lezanja { get; set; }

        [DataMember]
        public string id_operacije1 { get; set; }

        [DataMember]

        public int id_vrsta_otpusta { get; set; }

        [DataMember]

        public string id_osnovni_uzrok_smrti { get; set; }

        [DataMember]

        public DateTime vreme_unosa { get; set; }
    }

    [DataContract]
    public class Bolnica
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Naziv { get; set; }

        public override string ToString()
        {
            return id + " " + Naziv;
        }
    }
    [DataContract]
    public class Odeljenje
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Naziv { get; set; }

        public override string ToString()
        {
            return id + " " + Naziv;
        }
    }
    [DataContract]
    public class Dijagnoza
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string Naziv { get; set; }

        public override string ToString()
        {
            return id + " " + Naziv;
        }
    }
    [DataContract]
    public class Operacije
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string Naziv { get; set; }
    }
    [DataContract]
    public class Drzava
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Naziv { get; set; }

        public override string ToString()
        {
            return id + " " + Naziv;
        }
    }
    [DataContract]
    public class Opstina
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string Naziv { get; set; }

        public override string ToString()
        {
            return id + " " + Naziv;
        }
    }
    [DataContract]
    public class Otpust
    {
        [DataMember]
        public char id { get; set; }
        [DataMember]
        public string naziv { get; set; }

        public override string ToString()
        {
            return id + " " + naziv;
        }
    }
    [DataContract]
    public class Pol
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string naziv { get; set; }

        public override string ToString()
        {
            return id + " " + naziv;
        }
    }

    [DataContract]
    public class Osiguranje
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string naziv { get; set; }
    }
}
