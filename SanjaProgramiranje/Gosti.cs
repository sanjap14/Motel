using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanjaProgramiranje
{
    public partial class Gosti : UserControl
    {
        public Gosti()
        {
            InitializeComponent();
            Baza.UpdateGrid(dataGridView3, "SELECT * FROM gosti");
            dataGridView3.Columns["id_gosta"].ReadOnly = true;
        }
        private void ToogleVisibility()
        {
            btNoviGost.Visible = !btNoviGost.Visible;
            btUnesi.Visible = !btUnesi.Visible;
            tbIme.Visible = !tbIme.Visible;
            tbPrezime.Visible = !tbPrezime.Visible;
            tbBroj.Visible = !tbBroj.Visible;
            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
        }

        private void btNoviGost_Click(object sender, EventArgs e)
        {
            ToogleVisibility();
        }

        private void btUnesi_Click(object sender, EventArgs e)
        {
            ToogleVisibility();
            string query = "INSERT INTO gosti (ime, prezime, telefon) VALUES ('" + tbIme.Text + "', '" + tbPrezime.Text + "', '" + tbBroj.Text + "')";
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView3, "SELECT * FROM gosti");
        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM gosti WHERE id_gosta = " + dataGridView3[0, dataGridView3.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView3, "SELECT * FROM gosti");
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string promenjenPojam = "";
            string promenjenaVrednost;
            switch (e.ColumnIndex)
            {
                case 1: promenjenPojam = "ime"; break;
                case 2: promenjenPojam = "prezime"; break;
                case 3: promenjenPojam = "telefon"; break;
            }
            promenjenaVrednost = dataGridView3[e.ColumnIndex, e.RowIndex].Value.ToString();
            promenjenaVrednost = "'" + promenjenaVrednost + "'";
            string query = "UPDATE gosti SET " + promenjenPojam + " = " + promenjenaVrednost + " WHERE id_gosta = " + dataGridView3[0, e.RowIndex].Value;

            Baza.RunCommand(query);
        }
    }
}
