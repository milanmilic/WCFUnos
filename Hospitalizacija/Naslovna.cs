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
    public partial class Naslovna : Form
    {
        ServiceReference1.Service1Client objWebServisa = new ServiceReference1.Service1Client();
        public Naslovna()
        {
            InitializeComponent();
            dugme_brisanje();
            PrikaziDatumVreme();
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
        }

        private void dugme_brisanje()
        {
            if (gridView2.SelectedRowsCount == 1)
            {
                btn_brisanje.Show();
            }
            else
            {
                btn_brisanje.Hide();
            }
        }

        private void PrikaziDatumVreme()
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
#region Dugmici za meni
        private void излазToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void уносToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IzvestajHospitalizacija izHos = new IzvestajHospitalizacija();
            izHos.ShowDialog();
        }

        private async void дијагнозеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
            await dijagnozeAsync();
        }

        private async Task dijagnozeAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziDijagnozeAsync();
            grid_sifarnici.DataSource = ds.Tables[0];
            grid_sifarnici.Show();
            gridView1.BestFitColumns();
        }

        private async void здравственеУстановеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
            await zdravstveneUstanoveAsync();
        }

        private async Task zdravstveneUstanoveAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziBolniceAsync();
            grid_sifarnici.DataSource = ds.Tables[0];
            grid_sifarnici.Show();
            gridView1.BestFitColumns();
        }

        private async void одељењаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
            await odeljenjaAsync();
        }

        private async Task odeljenjaAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziOdeljenjaPrijemAsync();
            grid_sifarnici.DataSource = ds.Tables[0];
            grid_sifarnici.Show();
            gridView1.BestFitColumns();
        }

        private async void процедуреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
            await procedureAsync();
        }

        private async Task procedureAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziOperacijeAsync();
            grid_sifarnici.DataSource = ds.Tables[0];
            grid_sifarnici.Show();
            gridView1.BestFitColumns();
        }

        private async void државеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
            await drzaveAsync();
        }

        private async Task drzaveAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziDrzaveAsync();
            grid_sifarnici.DataSource = ds.Tables[0];
            grid_sifarnici.Show();
            gridView1.BestFitColumns();
        }

        private async void општинеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
            await opstineAsync();
        }

        private async Task opstineAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziOpstineAsync();
            grid_sifarnici.DataSource = ds.Tables[0];
            grid_sifarnici.Show();
            gridView1.BestFitColumns();
        }

        private async void врстаОтпустаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
            await vrstaOtpustaAsync();
        }

        private async Task vrstaOtpustaAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziOtpustAsync();
            grid_sifarnici.DataSource = ds.Tables[0];
            grid_sifarnici.Show();
            gridView1.BestFitColumns();}

        private async void свиПодациToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();
            await sviPodaciAsync();
        }

        private async Task sviPodaciAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.SviPodaciAsync();
            grid_svi_podaci.DataSource = ds.Tables[0];
            grid_svi_podaci.Show();
            gridView2.BestFitColumns(true);
        }
#endregion
#region Prenos podataka iz grida u formu
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            IzvestajHospitalizacija ih = new IzvestajHospitalizacija();

            foreach (int i in gridView2.GetSelectedRows())
            {
                DataRow red = gridView2.GetDataRow(i);
                ih.id_bolRac = Convert.ToInt32(red[0]);
                ih.id_pacijent = Convert.ToInt32(red[1]);
                ih.txt_jmbg.Text = red[2].ToString();
                ih.txt_prezime_ime_pacijenta.Text = red[3].ToString();
                ih.cmb_pol.Text = red[4].ToString();
                ih.dtp_datum_rodjenja.Text = red[5].ToString();
                ih.cmb_drzavljanstvo.Text = red[6].ToString();
                ih.txt_starost.Text = red[7].ToString();
                ih.txt_adresa_preb.Text = red[8].ToString();
                ih.cmb_opstina.Text = red[9].ToString();
                ih.cmb_osiguranje.Text = red[10].ToString();
                ih.txt_lbo.Text = red[11].ToString();
                ih.cmb_zdr_ustanova.Text = red[12].ToString();
                ih.cmb_odeljenje_prijem.Text = red[13].ToString();
                ih.txt_br_istorije_bol.Text = red[14].ToString();
                ih.dtp_datum_prijema.Text = red[15].ToString();
                ih.cmb_uputna_dijag_sifra.Text = red[16].ToString();
                ih.cmb_uputna_dijag.Text = red[17].ToString();
                ih.cmb_osn_uzr_hosp_sifra.Text = red[18].ToString();
                ih.cmb_osn_uzr_hosp.Text = red[19].ToString();
                ih.cmb_prateca_dijag_sifra.Text = red[20].ToString();
                ih.cmb_prateca_dijag.Text = red[21].ToString();
                ih.dtp_datum_otpusta.Text = red[22].ToString();
                ih.txt_br_dana_lezanja.Text = red[23].ToString();
                ih.cmb_procedura_sifra.Text = red[24].ToString();
                ih.cmb_procedura.Text = red[25].ToString();
                ih.cmb_odeljenje_otpust.Text = red[26].ToString();
                ih.cmb_vrsta_otpusta.Text = red[27].ToString();
                ih.cmb_osn_uzrok_smrti_sifra.Text = red[28].ToString();
                ih.cmb_osn_uzrok_smrti.Text = red[29].ToString();
            }
            ih.ShowDialog();
        }
#endregion

        private void btn_brisanje_Click(object sender, EventArgs e)
        {
            int id = 0;
            string jmbg = "";
            string prezime_ime = "";
            foreach (int i in gridView2.GetSelectedRows())
            {
                DataRow selektovaniRed = gridView2.GetDataRow(i);
                id = Convert.ToInt32(selektovaniRed[0]);
                jmbg = selektovaniRed[2].ToString();
                prezime_ime = selektovaniRed[3].ToString();
            }

            try
            {
                if (objWebServisa.BrisanjeHospitalizacije(id))
                {
                    MessageBox.Show(
                        "Успешно је обрисана изабрана хоспитализација са јмбг-ом: " + jmbg + ", и са именом пацијента: " +
                        prezime_ime, "Порука");
                }
                else
                {
                    MessageBox.Show("Проблем при брисању изабране хоспитализације. Молимо Вас, покушајте касније!",
                        "Грешка");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                grid_svi_podaci.RefreshDataSource();
            }
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            dugme_brisanje();
        }
    }
}
