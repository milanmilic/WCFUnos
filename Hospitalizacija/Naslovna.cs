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
            await dijagnozeAsync();
        }

        private async Task dijagnozeAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziDijagnozeAsync();
        }

        private async void здравственеУстановеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await zdravstveneUstanoveAsync();
        }

        private async Task zdravstveneUstanoveAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziBolniceAsync();
        }

        private async void одељењаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await odeljenjaAsync();
        }

        private async Task odeljenjaAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziOdeljenjaPrijemAsync();
        }

        private async void процедуреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await procedureAsync();
        }

        private async Task procedureAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziOperacijeAsync();
        }

        private async void државеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await drzaveAsync();
        }

        private async Task drzaveAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziDrzaveAsync();
        }

        private async void општинеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await opstineAsync();
        }

        private async Task opstineAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziOpstineAsync();
        }

        private async void врстаОтпустаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await vrstaOtpustaAsync();
        }

        private async Task vrstaOtpustaAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.PrikaziOtpustAsync();
        }

        private async void свиПодациToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await sviPodaciAsync();
        }

        private async Task sviPodaciAsync()
        {
            DataSet ds = new DataSet();
            ds = await objWebServisa.SviPodaciAsync();
        }
    }
}
