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

        private void autocomplete(ComboBox cmb, DataSet ds)
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i < ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["id"].ToString());
            }
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb.AutoCompleteCustomSource = col;
            cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void PrikaziPodatke()
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
            cmb_uputna_dijag_sifra.DataSource =  ds5.Tables[0];
            cmb_uputna_dijag_sifra.DisplayMember = ds5.Tables[0].Columns[0].ToString();
            cmb_uputna_dijag_sifra.ValueMember = ds5.Tables[0].Columns[0].ToString();
            autocomplete(cmb_uputna_dijag_sifra, ds5);
            cmb_uputna_dijag.DisplayMember = ds5.Tables[0].Columns[1].ToString();
            //popunjavanje osnovna dijagnoza comboboxa
            DataSet ds6 = new DataSet();
            ds6 = objWebServisa.PrikaziDijagnozeOsnovna();
            cmb_osn_uzr_hosp.DataSource = ds6.Tables[0];
            cmb_osn_uzr_hosp_sifra.DataSource = ds6.Tables[0];
            cmb_osn_uzr_hosp_sifra.DisplayMember = ds6.Tables[0].Columns[0].ToString();
            cmb_osn_uzr_hosp_sifra.ValueMember = ds6.Tables[0].Columns[0].ToString();
            autocomplete(cmb_osn_uzr_hosp_sifra, ds6);
            cmb_osn_uzr_hosp.DisplayMember = ds6.Tables[0].Columns[1].ToString();
            //popunjavanje prateca dijagnoza comboboxa
            DataSet ds7 = new DataSet();
            ds7 = objWebServisa.PrikaziDijagnozePrateca();
            cmb_prateca_dijag.DataSource = ds7.Tables[0];
            cmb_prateca_dijag_sifra.DataSource = ds7.Tables[0];
            cmb_prateca_dijag_sifra.DisplayMember = ds7.Tables[0].Columns[0].ToString();
            cmb_prateca_dijag_sifra.ValueMember = ds7.Tables[0].Columns[0].ToString();
            autocomplete(cmb_prateca_dijag_sifra, ds7);
            cmb_prateca_dijag.DisplayMember = ds7.Tables[0].Columns[1].ToString();
            //popunjavanje procedura/operacija comboboxa
            DataSet ds8 = new DataSet();
            ds8 = objWebServisa.PrikaziOperacije();
            cmb_procedura.DataSource = ds8.Tables[0];
            cmb_procedura_sifra.DataSource = ds8.Tables[0];
            cmb_procedura_sifra.DisplayMember = ds8.Tables[0].Columns[0].ToString();
            cmb_procedura_sifra.ValueMember = ds8.Tables[0].Columns[0].ToString();
            autocomplete(cmb_procedura_sifra, ds8);
            cmb_procedura.DisplayMember = ds8.Tables[0].Columns[1].ToString();
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
            //popunjavanje osnovni uzrok smrti comboboxa
            DataSet ds11 = new DataSet();
            ds11 = objWebServisa.PrikaziDijagnozeSmrt();
            cmb_osn_uzrok_smrti.DataSource = ds11.Tables[0];
            cmb_osn_uzrok_smrti_sifra.DataSource = ds11.Tables[0];
            cmb_osn_uzrok_smrti_sifra.DisplayMember = ds11.Tables[0].Columns[0].ToString();
            cmb_osn_uzrok_smrti_sifra.ValueMember = ds11.Tables[0].Columns[0].ToString();
            autocomplete(cmb_osn_uzrok_smrti_sifra, ds11);
            cmb_osn_uzrok_smrti.DisplayMember = ds11.Tables[0].Columns[1].ToString();
            //popunjavanje osiguranja comboboxa
            DataSet ds12 = new DataSet();
            ds12 = objWebServisa.PrikaziOsiguranje();
            cmb_osiguranje.DataSource = ds12.Tables[0];
            cmb_osiguranje.DisplayMember = ds12.Tables[0].Columns[1].ToString();
            cmb_osiguranje.ValueMember = ds12.Tables[0].Columns[0].ToString();
            autocomplete(cmb_osiguranje, ds12);
        }

        private void btn_unos_izvestaja_Click(object sender, EventArgs e)
        {
            ServiceReference1.Pacijent objPacijent = new ServiceReference1.Pacijent();
            ServiceReference1.Bolnickiracun objBolRac = new ServiceReference1.Bolnickiracun();

            try
            {
                objPacijent.jmbg = txt_jmbg.Text;
                objPacijent.prezime_ime = txt_prezime_ime_pacijenta.Text;
                objPacijent.id_pol = Convert.ToInt32(cmb_pol.SelectedValue);
                objPacijent.datum_rodjenja = Convert.ToDateTime(dtp_datum_rodjenja.Value);
                objPacijent.id_drzavljanstvo = Convert.ToInt32(cmb_drzavljanstvo.SelectedValue);
                objPacijent.starost = Convert.ToInt32(txt_starost.Text);
                objPacijent.adresa_prebivalista = txt_adresa_preb.Text;
                objPacijent.id_opstina = Convert.ToString(cmb_opstina.SelectedValue);
                objPacijent.id_osiguranje = Convert.ToInt32(cmb_osiguranje.SelectedValue);
                objPacijent.lbo = txt_lbo.Text;

                objBolRac.id_bolnica = Convert.ToInt32(cmb_zdr_ustanova.SelectedValue);
                objBolRac.id_odeljenje = Convert.ToInt32(cmb_odeljenje_prijem.SelectedValue);
                objBolRac.br_istorije_bolesti = txt_br_istorije_bol.Text;
                objBolRac.datum_prijema = Convert.ToDateTime(dtp_datum_prijema.Value);
                objBolRac.id_uputna_dijagnoza = cmb_uputna_dijag_sifra.Text;
                objBolRac.id_osnovni_uzrok_hospitalizacije = cmb_osn_uzr_hosp_sifra.Text;
                objBolRac.id_dijagnoza1 = cmb_prateca_dijag_sifra.Text;
                objBolRac.datum_ispisa = Convert.ToDateTime(dtp_datum_otpusta.Value);
                objBolRac.br_dana_lezanja = Convert.ToInt32(txt_br_dana_lezanja.Text);
                objBolRac.id_operacije1 = cmb_procedura_sifra.Text;
                objBolRac.id_odeljenje_otpust = Convert.ToInt32(cmb_odeljenje_otpust.SelectedValue);
                objBolRac.id_vrsta_otpusta = Convert.ToInt32(cmb_vrsta_otpusta.SelectedValue);
                objBolRac.id_osnovni_uzrok_smrti = cmb_osn_uzrok_smrti_sifra.Text;

                string status = objWebServisa.UnosHospitalizacije(objPacijent, objBolRac);

                lbl_status.Text = status;
                lbl_status.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lbl_status.Text = ex.Message;
                lbl_status.ForeColor = Color.Red;
            }
            
        }

        private void dtp_datum_otpusta_Leave(object sender, EventArgs e)
        {
            DateTime datum_prijema = Convert.ToDateTime(dtp_datum_prijema.Value);
            DateTime datum_otpusta = Convert.ToDateTime(dtp_datum_otpusta.Value);

            int br_dana_lezanja = datum_otpusta.Day - datum_prijema.Day;

            txt_br_dana_lezanja.Text = br_dana_lezanja.ToString();
        }

        private void dtp_datum_rodjenja_Leave(object sender, EventArgs e)
        {
            DateTime datum_rodjenja = Convert.ToDateTime(dtp_datum_rodjenja.Value);

            int starost = DateTime.Now.Year - datum_rodjenja.Year;

            txt_starost.Text = starost.ToString();
        }

        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
