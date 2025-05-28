using MySql.Data.MySqlClient;
using System.Data;


namespace kutuphanekayit
{

    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=kutuphane;Uid=root;Pwd=sifre;";
        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        private void KitaplariListele()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM bilgiler", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTckn.Text) ||
            string.IsNullOrWhiteSpace(txtKitapIsmi.Text) ||
            string.IsNullOrWhiteSpace(txtYazar.Text) ||
            string.IsNullOrWhiteSpace(txtIlkTarih.Text) ||
            string.IsNullOrWhiteSpace(txtSonTarih.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO bilgiler (tckn, kitap_ismi, yazar, ilk_tarih, son_tarih) VALUES (@tckn, @kitap_ismi, @yazar, @ilk_tarih, @son_tarih)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@tckn", (txtTckn.Text));
            cmd.Parameters.AddWithValue("@kitap_ismi", txtKitapIsmi.Text);
            cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
            cmd.Parameters.AddWithValue("@ilk_tarih", txtIlkTarih.Text);
            cmd.Parameters.AddWithValue("@son_tarih", txtSonTarih.Text);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            KitaplariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string query = "DELETE FROM bilgiler WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            KitaplariListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTckn.Text) ||
            string.IsNullOrWhiteSpace(txtKitapIsmi.Text) ||
            string.IsNullOrWhiteSpace(txtYazar.Text) ||
            string.IsNullOrWhiteSpace(txtIlkTarih.Text) ||
            string.IsNullOrWhiteSpace(txtSonTarih.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(txtId.Text);
            string query = "UPDATE bilgiler SET tckn=@tckn, kitap_ismi=@kitap_ismi, yazar=@yazar, ilk_tarih=@ilk_tarih, son_tarih=@son_tarih WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tckn", (txtTckn.Text));
            cmd.Parameters.AddWithValue("@kitap_ismi", txtKitapIsmi.Text);
            cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
            cmd.Parameters.AddWithValue("@ilk_tarih", txtIlkTarih.Text);
            cmd.Parameters.AddWithValue("@son_tarih", txtSonTarih.Text);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            KitaplariListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KitaplariListele();
        }
    }
}
