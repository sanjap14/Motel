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
    public partial class Sobe : UserControl
    {
        public Sobe()
        {
            InitializeComponent();
            Baza.UpdateGrid(dataGridView2, "SELECT * FROM sobe");
            dataGridView2.Columns["id_sobe"].ReadOnly = true;
        }
        private void ToogleVisibility()
        {
            btNovaSoba.Visible = !btNovaSoba.Visible;
            btUnesi.Visible = !btUnesi.Visible;
            tbTip.Visible = !tbTip.Visible;
            tbCena.Visible = !tbCena.Visible;
            cbStatus.Visible = !cbStatus.Visible;
            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
        }
        private void btNovaSoba_Click(object sender, EventArgs e)
        {
            ToogleVisibility();
        }

        private void btUnesi_Click(object sender, EventArgs e)
        {
            ToogleVisibility();
            string query = "INSERT INTO sobe (tip_sobe, cena_po_nocenju, status_sobe) VALUES ('" + tbTip.Text + "', " + tbCena.Text + ", " + cbStatus.SelectedIndex + ")";
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView2, "SELECT * FROM sobe");
        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM sobe WHERE id_sobe = " + dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            Baza.RunCommand(query);
            Baza.UpdateGrid(dataGridView2, "SELECT * FROM sobe");
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string promenjenPojam = "";
            string promenjenaVrednost;
            switch (e.ColumnIndex)
            {
                case 1: promenjenPojam = "tip_sobe"; break;
                case 2: promenjenPojam = "cena_po_nocenju"; break;
                case 3: promenjenPojam = "status_sobe"; break;
            }
            promenjenaVrednost = dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString();
            if(e.ColumnIndex == 1) promenjenaVrednost = "'" + promenjenaVrednost + "'";
            string query = "UPDATE sobe SET " + promenjenPojam + " = " + promenjenaVrednost + " WHERE id_sobe = " + dataGridView2[0, e.RowIndex].Value;

            Baza.RunCommand(query);
        }
    }
}
