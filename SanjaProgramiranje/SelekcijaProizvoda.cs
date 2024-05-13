using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanjaProgramiranje
{
    public partial class SelekcijaProizvoda : Form
    {

        private Narudzbine narudzbina;
        public SelekcijaProizvoda(Narudzbine narudzbina)
        {
            InitializeComponent();
            this.narudzbina = narudzbina;
            
            dgUneti.DataSource = dtUneti;
            dtUneti.Columns.Add("id proizvoda", typeof(int));
            dtUneti.Columns.Add("naziv", typeof(string));
            dtUneti.Columns.Add("kolicina", typeof(int));
            dtUneti.Columns.Add("cena", typeof(int));

            Baza.UpdateGrid(dgRaspolozivi, "SELECT * FROM artikli");
        }

        private DataTable dtUneti = new DataTable();
        private int ukupnaCena = 0;
        private void IzmeniCenu(int promena)
        {
            ukupnaCena += promena;
            label5.Text = Convert.ToString(ukupnaCena) + " din.";
        }

        private void btStavi_Click(object sender, EventArgs e)
        {
            if (nmKolicina.Value == 0) return;
            DataRow dr = dtUneti.NewRow();
            int index = 0;
            if (dgRaspolozivi.SelectedCells.Count == 1) index = dgRaspolozivi.SelectedCells[0].OwningRow.Index;
            else
            {
                MessageBox.Show("Ili nije izabrana ni jedna ili je izabrano više ćelija", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(nmKolicina.Value > (int)dgRaspolozivi[2,index].Value)
            {
                MessageBox.Show("Nema dovoljno raspoloživih artikala.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgRaspolozivi[2, index].Value = (int)dgRaspolozivi[2,index].Value - nmKolicina.Value;

            IzmeniCenu((int)nmKolicina.Value * Convert.ToInt32(dgRaspolozivi[3, index].Value));

            for (int i = 0; i < dtUneti.Rows.Count; i++)
            {
                if ((int)dgRaspolozivi[0,index].Value == (int)dtUneti.Rows[i][0])
                {
                    dtUneti.Rows[i][2] = (int)dtUneti.Rows[i][2] + nmKolicina.Value;
                    return;
                }
            }

            dr["id proizvoda"] = dgRaspolozivi[0, index].Value;
            dr["naziv"] = dgRaspolozivi[1, index].Value;
            dr["kolicina"] = nmKolicina.Value;
            dr["cena"] = dgRaspolozivi[3, index].Value;

            dtUneti.Rows.Add(dr);
            nmKolicina.Value = 0;
        }
        private void btUkloni_Click(object sender, EventArgs e)
        {
            if (dgUneti.SelectedCells.Count == 1)
            {
                IzmeniCenu(-Convert.ToInt32(dgUneti.SelectedCells[0].OwningRow.Cells[2].Value) * Convert.ToInt32(dgUneti.SelectedCells[0].OwningRow.Cells[3].Value));
                dtUneti.Rows[dgUneti.SelectedCells[0].OwningRow.Index].Delete();
            }
            else
            {
                MessageBox.Show("Ili nije izabran ili je izabrano više redova", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btZavrsi_Click(object sender, EventArgs e)
        {
            narudzbina.UcitajNarudzbinu(dtUneti);
        }

        private void btIsprazni_Click(object sender, EventArgs e)
        {
            dtUneti.Rows.Clear();
            IzmeniCenu(-ukupnaCena);
        }
    }
}
