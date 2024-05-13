using System;
using System.Windows.Forms;

namespace SanjaProgramiranje
{
    public partial class Zaposleni : UserControl
    {
        public Zaposleni()
        {
            InitializeComponent();
            Baza.UpdateGrid(dataGridView6, "SELECT * from zaposleni");
            dataGridView6.Columns["id"].ReadOnly = true;
            //dataGridView6.Columns["aktivan"].ReadOnly = true;
        }
        private void ToogleVisibility()
        {
            btNoviZaposleni.Visible = !btNoviZaposleni.Visible;
            btUnesi.Visible = !btUnesi.Visible;
            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            tbIme.Visible = !tbIme.Visible;
            tbPrezime.Visible = !tbPrezime.Visible;
            tbPozicija.Visible = !tbPozicija.Visible;
            tbPlata.Visible = !tbPlata.Visible;
            tbKontakt.Visible = !tbKontakt.Visible;
        }
        private void UpdateGridCheck()
        {
            if (cbAktivni.Checked) Baza.UpdateGrid(dataGridView6, "SELECT * FROM zaposleni WHERE aktivan = 1");
            else Baza.UpdateGrid(dataGridView6, "SELECT * FROM zaposleni");
        }

        private void btNoviZaposleni_Click(object sender, EventArgs e)
        {
            ToogleVisibility();
        }

        private void btUnesi_Click(object sender, EventArgs e)
        {
            ToogleVisibility();
            string query = "INSERT INTO zaposleni(ime, prezime, pozicija, plata, kontakt, aktivan) VALUES ('"
                + tbIme.Text + "', '" + tbPrezime.Text + "', '" + tbPozicija.Text + "', " + tbPlata.Text + ", '" + tbKontakt.Text + "', 1)";
            Baza.RunCommand(query);
            UpdateGridCheck();
        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            string query = "UPDATE zaposleni SET aktivan = 0 WHERE id = " + dataGridView6[0, dataGridView6.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            UpdateGridCheck();
        }

        private void dataGridView6_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string promenjenPojam = "";
            switch (e.ColumnIndex)
            {
                case 1: promenjenPojam = "ime"; break;
                case 2: promenjenPojam = "prezime"; break;
                case 3: promenjenPojam = "pozicija"; break;
                case 4: promenjenPojam = "plata"; break;
                case 5: promenjenPojam = "kontakt"; break;
            }
            string promenjenaVrednost = dataGridView6[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (e.ColumnIndex != 4) promenjenaVrednost = "'" + promenjenaVrednost + "'";
            string query = "UPDATE zaposleni SET " + promenjenPojam + " = " + promenjenaVrednost + " WHERE id = " + dataGridView6[0, e.RowIndex].Value;
            Baza.RunCommand(query);
        }

        private void btVrati_Click(object sender, EventArgs e)
        {
            string query = "UPDATE zaposleni SET aktivan = 1 WHERE id = " + dataGridView6[0, dataGridView6.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            UpdateGridCheck();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGridCheck();
        }
    }
}
