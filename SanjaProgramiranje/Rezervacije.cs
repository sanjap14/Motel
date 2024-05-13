using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace SanjaProgramiranje
{
    public partial class Rezervacije : UserControl
    {

        public Rezervacije()
        {
            InitializeComponent();
            Baza.UpdateGrid(dataGridView1, "SELECT * FROM rezervacije");
            Baza.UpdateComboBox(cbGost, "SELECT ime + ' ' + prezime FROM gosti");
            Baza.UpdateComboBox(cbSoba, "SELECT id_sobe FROM sobe WHERE status_sobe = 0");
            Baza.UpdateComboBox(cbZaposleni, "SELECT ime + ' ' + prezime FROM zaposleni");
            dataGridView1.Columns["id_rezervacije"].ReadOnly = true;
        }
      
        private void ToggleVisibility()
        {
            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            cbGost.Visible = !cbGost.Visible;
            cbSoba.Visible = !cbSoba.Visible;
            cbZaposleni.Visible = !cbZaposleni.Visible;
            dtDolazak.Visible = !dtDolazak.Visible;
            dtOdlazak.Visible = !dtOdlazak.Visible;
            btUnos.Visible = !btUnos.Visible;
            btNovaRez.Visible = !btNovaRez.Visible;
        }
        private void btNovaRez_Click(object sender, EventArgs e)
        {
            ToggleVisibility();
        }

        private void btUnos_Click(object sender, EventArgs e)
        {
            ToggleVisibility();
            string idGosta =
                "(SELECT id_gosta FROM gosti WHERE ime + ' ' + prezime = '" + cbGost.Text + "')";
            string idZaposleni =
                "(SELECT id FROM zaposleni WHERE ime + ' ' + prezime = '" + cbZaposleni.Text + "')";
            string datumOd = dtDolazak.Value.ToString("yyyy-MM-dd");
            string datumDo = dtOdlazak.Value.ToString("yyyy-MM-dd");
            string query = "INSERT INTO rezervacije(gost_id, soba_id, zaposleni_id, datum_od, datum_do) VALUES ("
                + idGosta + ", " + cbSoba.Text + " , " + idZaposleni + ",'" + datumOd + "', '" + datumDo + "')";
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView1, "SELECT * FROM rezervacije");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string promenjenPojam = "";
            string promenjenaVrednost;
            switch(e.ColumnIndex)
            {
                case 1: promenjenPojam = "gost_id"; break;
                case 2: promenjenPojam = "soba_id"; break;
                case 3: promenjenPojam = "zaposleni_id"; break;
                case 4: promenjenPojam = "datum_od"; break;
                case 5: promenjenPojam = "datum_do"; break;
            }
            if (e.ColumnIndex < 4) promenjenaVrednost = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            else
            {
                promenjenaVrednost = "'" + PomocneFunkcije.IspravanFormatDatuma(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString()) + "'";
                
            }
            string query = "UPDATE rezervacije SET " + promenjenPojam + " = " + promenjenaVrednost + " WHERE id_rezervacije = " + dataGridView1[0, e.RowIndex].Value;

            Baza.RunCommand(query);
        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM rezervacije WHERE id_rezervacije = " + dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView1, "SELECT * FROM rezervacije");
        }
    }
}
