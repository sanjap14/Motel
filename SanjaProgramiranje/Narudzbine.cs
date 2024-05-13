using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace SanjaProgramiranje
{
    public partial class Narudzbine : UserControl
    {
        public Narudzbine()
        {
            InitializeComponent();
            Baza.UpdateGrid(dataGridView4, "SELECT * FROM narudzbina");
            dataGridView4.Columns["vreme"].ReadOnly = true;
            dataGridView4.Columns["datum"].ReadOnly = true;
            dataGridView4.Columns["vrednost"].ReadOnly = true;
            dataGridView4.Columns["id"].ReadOnly = true;
            Baza.UpdateComboBox(cbZaposleni, "SELECT ime + ' ' + prezime FROM zaposleni");

            dtVreme.CustomFormat = "HH:mm";
            dtVreme.ShowUpDown = true;
            dtProizvodi = new DataTable();
        }
        public DataTable dtProizvodi;
        private SelekcijaProizvoda sp;
        private int ukupnaCena;
        private void ToogleVisibility()
        {
            btNovaNarudzbina.Visible = !btNovaNarudzbina.Visible;
            btUnesi.Visible = !btUnesi.Visible;
            cbZaposleni.Visible = !cbZaposleni.Visible;
            nmBrojStola.Visible = !nmBrojStola.Visible;
            dtDatum.Visible = !dtDatum.Visible;
            dtVreme.Visible = !dtVreme.Visible;
            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            rtbPregled.Visible = !rtbPregled.Visible;
            btUnesiProizvode.Visible = !btUnesiProizvode.Visible;
        }

        private void btNovaNarudzbina_Click(object sender, EventArgs e)
        {
            ToogleVisibility();
        }

        public void UcitajNarudzbinu(DataTable dt)
        {
            sp.Close();
            dtProizvodi = dt;
            IspisiTekst();

        }
        private void IspisiTekst()
        {
            ukupnaCena = 0;
            for(int i = 0; i < dtProizvodi.Rows.Count; i++)
            {
                rtbPregled.AppendText(dtProizvodi.Rows[i][1].ToString() + ", "
                    + dtProizvodi.Rows[i][2].ToString() + " komada, " + dtProizvodi.Rows[i][3].ToString() + " dinara\n");
                ukupnaCena += Convert.ToInt32(dtProizvodi.Rows[i][2]) * Convert.ToInt32(dtProizvodi.Rows[i][3]);
            }
            rtbPregled.AppendText("Ukupno " + ukupnaCena + " dinara");
        }
        private void btUnesi_Click(object sender, EventArgs e)
        {
            ToogleVisibility();

            string query = "INSERT INTO narudzbina(sto_br, id_zaposlenog, datum, vreme, vrednost) VALUES (" + nmBrojStola.Value.ToString()
                + ", (SELECT id FROM zaposleni WHERE ime + ' ' + prezime = '" + cbZaposleni.Text + "'), '"
                + PomocneFunkcije.IspravanFormatDatuma(dtDatum.Value.ToString()) + "', '" + dtVreme.Value.ToString("HH:mm:ss") + "', "
                + ukupnaCena + ")";
            string id = Baza.RunCommandReturn(query);
            

            for (int i = 0; i < dtProizvodi.Rows.Count; i++)
            {
                query = "UPDATE artikli SET raspoloziva_kolicina = raspoloziva_kolicina - " + dtProizvodi.Rows[i][2].ToString() + " WHERE id = " +
                    dtProizvodi.Rows[i][0].ToString();
                Baza.RunCommand(query);

                query = "INSERT INTO narudzbina_stavke(id_narudzbine, id_artikla, kolicina, cena, vrednost) VALUES (" + id + ", "
                    + dtProizvodi.Rows[i][0].ToString() + ", " + dtProizvodi.Rows[i][2].ToString() + ", " + dtProizvodi.Rows[i][3].ToString() + ", "
                    + Convert.ToInt32(dtProizvodi.Rows[i][2]) * Convert.ToInt32(dtProizvodi.Rows[i][3]) + ")";
                Baza.RunCommand(query);
            }

            Baza.UpdateGrid(dataGridView4, "SELECT * FROM narudzbina");
        }
       
        private void btStaviProizvode_Click(object sender, EventArgs e)
        {
            rtbPregled.Clear();
            sp = new SelekcijaProizvoda(this);
            sp.Show();
        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string promenjenPojam = "";
            switch (e.ColumnIndex)
            {
                case 1: promenjenPojam = "sto_br"; break;
                case 2: promenjenPojam = "id_zaposlenog"; break;
            }
            string promenjenaVrednost = dataGridView4[e.ColumnIndex, e.RowIndex].Value.ToString();
            string query = "UPDATE sobe SET " + promenjenPojam + " = " + promenjenaVrednost + " WHERE id_sobe = " + dataGridView4[0, e.RowIndex].Value;

            Baza.RunCommand(query);

        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM narudzbina_stavke WHERE id_narudzbine = " + dataGridView4[0, dataGridView4.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            query = "DELETE FROM narudzbina WHERE id = " + dataGridView4[0, dataGridView4.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView4, "SELECT * FROM narudzbina");
        }
    }
}
