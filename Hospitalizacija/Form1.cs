using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Hospitalizacija
{
    public partial class Frm_pacijent : Form
    {
        ServiceReference1.Service1Client objService = new ServiceReference1.Service1Client(); //konekcija sa web servisom
        public Frm_pacijent()
        {
            InitializeComponent();
            ShowData();
        }

        void ShowData()
        {
            DataSet ds = new DataSet();
            ds = objService.PrikaziPacijenta();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ServiceReference1.Pacijent objPacijent = new ServiceReference1.Pacijent();
            objPacijent.jmbg = txt_jmbg.Text;
            objPacijent.prezime_ime = txt_prezime_ime.Text;
            objPacijent.id_pol = Convert.ToInt32(txt_pol.Text);
            objPacijent.datum_rodjenja = Convert.ToDateTime(txt_datum_rodjenja.Text);
            objPacijent.id_drzavljanstvo = Convert.ToInt32(txt_drzavljanstvo.Text);
            objPacijent.starost = Convert.ToInt32(txt_starost.Text);
            objPacijent.adresa_prebivalista = txt_adresa.Text;
            objPacijent.id_opstina = txt_opstina.Text;
            objPacijent.id_osiguranje = Convert.ToInt32(txt_osiguranje.Text);
            objPacijent.lbo = txt_lbo.Text;
            objService.UnosPacijenta(objPacijent); //unos pacijenta u bazu
            ShowData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ServiceReference1.Pacijent objPacijent = new ServiceReference1.Pacijent();
            if (dataGridView1.Rows.Count > 1)
            {
                DataTable dt = new DataTable();
                objPacijent.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                objService.IzbrisiPacijenta(objPacijent);
                ShowData();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ServiceReference1.Pacijent objPacijent = new ServiceReference1.Pacijent();
            objPacijent.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            objPacijent.jmbg = txt_jmbg.Text;
            objPacijent.prezime_ime = txt_prezime_ime.Text;
            objPacijent.id_pol = Convert.ToInt32(txt_pol.Text);
            objPacijent.datum_rodjenja = Convert.ToDateTime(txt_datum_rodjenja.Text);
            objPacijent.id_drzavljanstvo = Convert.ToInt32(txt_drzavljanstvo.Text);
            objPacijent.starost = Convert.ToInt32(txt_starost.Text);
            objPacijent.adresa_prebivalista = txt_adresa.Text;
            objPacijent.id_opstina = txt_opstina.Text;
            objPacijent.id_osiguranje = Convert.ToInt32(txt_osiguranje.Text);
            objPacijent.lbo = txt_lbo.Text;
            objService.IzmeniPacijenta(objPacijent); //izmena postojeceg pacijenta
            ShowData();
            txt_jmbg.Clear();
            txt_prezime_ime.Clear();
            txt_pol.Clear();
            txt_datum_rodjenja.Clear();
            txt_drzavljanstvo.Clear();
            txt_starost.Clear();
            txt_adresa.Clear();
            txt_opstina.Clear();
            txt_osiguranje.Clear();
            txt_lbo.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            txt_jmbg.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_prezime_ime.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_pol.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_datum_rodjenja.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_drzavljanstvo.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt_starost.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt_adresa.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txt_opstina.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            txt_osiguranje.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            txt_lbo.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
        }
    }
}
