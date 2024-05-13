using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace SanjaProgramiranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pocetni pocetni = new Pocetni();
            AddUserControl(pocetni);
        }


        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervacije rezervacije = new Rezervacije();
            AddUserControl(rezervacije);
        }

        private void sobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobe sobe = new Sobe();
            AddUserControl(sobe);
        }

        private void gostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gosti gosti = new Gosti();
            AddUserControl(gosti);
        }

        public Narudzbine narudzbine;
        private void narudžbineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            narudzbine = new Narudzbine();
            AddUserControl(narudzbine);
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artikli artikli = new Artikli();
            AddUserControl(artikli);
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaposleni zaposleni = new Zaposleni();
            AddUserControl(zaposleni);
        }
    }

    class Baza
    {
        //OVDE STAVLJAS SVOJ CONNECTION STRING
        public static string connectionString =
            "Data Source=UCENIK_3_UCIONI\\SQLEXPRESS; Initial Catalog=Motel; Integrated Security=True";

        private static readonly SqlConnection connection = new SqlConnection(connectionString);
        public static void UpdateGrid(DataGridView grid, string query)
        {
            Debug.WriteLine(query);
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Debug.WriteLine(dataTable.ToString());
            grid.DataSource = dataTable;
            connection.Close();
        }

        public static void UpdateComboBox(System.Windows.Forms.ComboBox box, string query)
        {
            Debug.WriteLine(query);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.GetFieldType(0) == typeof(int))
                        box.Items.Add(reader.GetInt32(0).ToString());
                    
                    else box.Items.Add(reader.GetString(0));
                }
            }

            connection.Close();
        }

        public static void RunCommand(string query)
        {
            Debug.WriteLine(query);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static string RunCommandReturn(string query)
        {
            string combinedQuery = query + "; SELECT SCOPE_IDENTITY();";
            Debug.WriteLine(combinedQuery);
            connection.Open();
            SqlCommand cmd = new SqlCommand(combinedQuery, connection);
            object result = cmd.ExecuteScalar();
            connection.Close();
            return result.ToString();
        }



    }
    class PomocneFunkcije
    {
        public static string IspravanFormatDatuma(string s)
        {
            s = s.Split()[0];
            string format = "d.M.yyyy";
            if (s[s.Length - 1] == '.') format += '.';
            DateTime datum = DateTime.ParseExact(s, format, CultureInfo.InvariantCulture);
            return datum.ToString("yyyy-MM-dd");
        }
    }
}
