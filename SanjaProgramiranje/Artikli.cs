using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanjaProgramiranje
{
    public partial class Artikli : UserControl
    {
        public Artikli()
        {
            InitializeComponent();
            Baza.UpdateGrid(dataGridView5, "SELECT * from artikli");
            dataGridView5.Columns["id"].ReadOnly = true;
            dataGridView5.Columns["cena"].ReadOnly = true;

        }



        private void ToogleVisibility()
        {
            btNoviArtikal.Visible = !btNoviArtikal.Visible;
            btUnesi.Visible = !btUnesi.Visible;
            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
            tbNaziv.Visible = !tbNaziv.Visible;
            tbKolicina.Visible = !tbKolicina.Visible;
            tbCena.Visible = !tbCena.Visible;
        }


        private void btNoviArtikal_Click(object sender, EventArgs e)
        {
            ToogleVisibility();        
        }

        private void btUnesi_Click(object sender, EventArgs e)
        {
            ToogleVisibility();
            string query = "INSERT INTO artikli(naziv, raspoloziva_kolicina, cena) VALUES ('"
                + tbNaziv.Text + "', " + tbKolicina.Text + ", " + tbCena.Text + ")";
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView5, "SELECT * FROM artikli");
        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM narudzbina_stavke WHERE id_artikla = " + dataGridView5[0, dataGridView5.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            query = "DELETE FROM artikli WHERE id = " + dataGridView5[0, dataGridView5.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView5, "SELECT * FROM artikli");
        }

        private void dataGridView5_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string promenjenPojam = "";
            switch (e.ColumnIndex)
            {
                case 1: promenjenPojam = "naziv"; break;
                case 2: promenjenPojam = "raspoloziva_kolicina"; break;
                case 3: promenjenPojam = "cena"; break;
            }
            string promenjenaVrednost = dataGridView5[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (e.ColumnIndex == 1) promenjenaVrednost = "'" + promenjenaVrednost + "'";
            string query = "UPDATE artikli SET " + promenjenPojam + " = " + promenjenaVrednost + " WHERE id = " + dataGridView5[0, e.RowIndex].Value;

            Baza.RunCommand(query);
        }

        
    }
}
