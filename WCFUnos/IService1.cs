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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string UnosPacijenta(Pacijent pacijentInfo);

        [OperationContract]
        DataSet PrikaziPacijenta();

        [OperationContract]
        bool IzbrisiPacijenta(Pacijent pacijentInfo);

        [OperationContract]
        void IzmeniPacijenta(Pacijent pacijentInfo);

        [OperationContract]
        DataSet PrikaziBolnice();

        [OperationContract]
        DataSet PrikaziOdeljenja();

        [OperationContract]
        DataSet PrikaziDijagnoze();

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
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
    }
    [DataContract]
    public class Odeljenje
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Naziv { get; set; }
    }
    [DataContract]
    public class Dijagnoza
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string Naziv { get; set; }
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
    }
    [DataContract]
    public class Opstina
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string Naziv { get; set; }
    }
    [DataContract]
    public class Otpust
    {
        [DataMember]
        public char id { get; set; }
        [DataMember]
        public string naziv { get; set; }
    }
    [DataContract]
    public class Pol
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string naziv { get; set; }
    }
}
