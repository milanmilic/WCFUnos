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
            PrikaziDatumVreme();
            grid_sifarnici.Hide();
            grid_svi_podaci.Hide();

        }

        private void PrikaziDatumVreme()
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

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
        }

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
        }
    }
}
