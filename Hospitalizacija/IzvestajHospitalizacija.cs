using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitalizacija
{
    public partial class IzvestajHospitalizacija : Form
    {
        //ovo je objekat web servisa preko koga se kacimo do baze i metoda
        ServiceReference1.Service1Client objWebServisa = new ServiceReference1.Service1Client();

        public IzvestajHospitalizacija()
        {
            InitializeComponent();
            PrikaziPodatke();
        }

        private async Task PrikaziPodatke()
        {
            //popunjavanje bolnica comboboxa
            DataSet ds = new DataSet();
            ds = objWebServisa.PrikaziBolnice();
            cmb_zdr_ustanova.DataSource = ds.Tables[0];
            cmb_zdr_ustanova.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cmb_zdr_ustanova.ValueMember = ds.Tables[0].Columns[0].ToString();
            //popunjavanje odeljenje prijem comboboxa
            DataSet ds1 = new DataSet();
            ds1 = objWebServisa.PrikaziOdeljenjaPrijem();
            cmb_odeljenje_prijem.DataSource = ds1.Tables[0];
            cmb_odeljenje_prijem.DisplayMember = ds1.Tables[0].Columns[1].ToString();
            cmb_odeljenje_prijem.ValueMember = ds1.Tables[0].Columns[0].ToString();
            //popunjavanje drzavljanstvo comboboxa
            DataSet ds2 = new DataSet();
            ds2 = objWebServisa.PrikaziDrzave();
            cmb_drzavljanstvo.DataSource = ds2.Tables[0];
            cmb_drzavljanstvo.DisplayMember = ds2.Tables[0].Columns[1].ToString();
            cmb_drzavljanstvo.ValueMember = ds2.Tables[0].Columns[0].ToString();
            //popunjavanje opstina comboboxa
            DataSet ds3 = new DataSet();
            ds3 = objWebServisa.PrikaziOpstine();
            cmb_opstina.DataSource = ds3.Tables[0];
            cmb_opstina.DisplayMember = ds3.Tables[0].Columns[1].ToString();
            cmb_opstina.ValueMember = ds3.Tables[0].Columns[0].ToString();
            //popunjavanje pola comboboxa
            DataSet ds4 = new DataSet();
            ds4 = objWebServisa.PrikaziPol();
            cmb_pol.DataSource = ds4.Tables[0];
            cmb_pol.DisplayMember = ds4.Tables[0].Columns[1].ToString();
            cmb_pol.ValueMember = ds4.Tables[0].Columns[0].ToString();
            //popunjavanje uputna dijagnoza comboboxa
            DataSet ds5 = new DataSet();
            ds5 = objWebServisa.PrikaziDijagnozeUputna();
            cmb_uputna_dijag.DataSource = ds5.Tables[0];
            cmb_uputna_dijag.DisplayMember = ds5.Tables[0].Columns[1].ToString();
            cmb_uputna_dijag.ValueMember = ds5.Tables[0].Columns[0].ToString();
            //popunjavanje osnovna dijagnoza comboboxa
            DataSet ds6 = new DataSet();
            ds6 = objWebServisa.PrikaziDijagnozeOsnovna();
            cmb_osn_uzr_hosp.DataSource = ds6.Tables[0];
            cmb_osn_uzr_hosp.DisplayMember = ds6.Tables[0].Columns[1].ToString();
            cmb_osn_uzr_hosp.ValueMember = ds6.Tables[0].Columns[0].ToString();
            //popunjavanje prateca dijagnoza comboboxa
            DataSet ds7 = new DataSet();
            ds7 = objWebServisa.PrikaziDijagnozePrateca();
            cmb_prateca_dijag.DataSource = ds7.Tables[0];
            cmb_prateca_dijag.ValueMember = ds7.Tables[0].Columns[0].ToString();
            //popunjavanje procedura/operacija comboboxa
            DataSet ds8 = new DataSet();
            ds8 = objWebServisa.PrikaziOperacije();
            cmb_procedura.DataSource = ds8.Tables[0];
            cmb_procedura.DisplayMember = ds8.Tables[0].Columns[1].ToString();
            cmb_procedura.ValueMember = ds8.Tables[0].Columns[0].ToString();
            //popunjavanje odeljenje otpust comboboxa
            DataSet ds9 = new DataSet();
            ds9 = objWebServisa.PrikaziOdeljenjaOtpust();
            cmb_odeljenje_otpust.DataSource = ds9.Tables[0];
            cmb_odeljenje_otpust.DisplayMember = ds9.Tables[0].Columns[1].ToString();
            cmb_odeljenje_otpust.ValueMember = ds9.Tables[0].Columns[0].ToString();
            //popunjavanje vrsta otpust comboboxa
            DataSet ds10 = new DataSet();
            ds10 = objWebServisa.PrikaziOtpust();
            cmb_vrsta_otpusta.DataSource = ds10.Tables[0];
            cmb_vrsta_otpusta.DisplayMember = ds10.Tables[0].Columns[1].ToString();
            cmb_vrsta_otpusta.ValueMember = ds10.Tables[0].Columns[0].ToString();
            //popunjavanje odeljenje otpust comboboxa
            DataSet ds11 = new DataSet();
            ds11 = objWebServisa.PrikaziDijagnozeSmrt();
            cmb_osn_uzrok_smrti.DataSource = ds11.Tables[0];
            cmb_osn_uzrok_smrti.DisplayMember = ds11.Tables[0].Columns[1].ToString();
            cmb_osn_uzrok_smrti.ValueMember = ds11.Tables[0].Columns[0].ToString();  
        }

        private void btn_unos_izvestaja_Click(object sender, EventArgs e)
        {

        }
    }
}
