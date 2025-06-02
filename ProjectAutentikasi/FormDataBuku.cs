using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProjectAutentikasi
{
    public partial class FormDataBuku : Form
    {
        private int selectedId = -1;
        public FormDataBuku()
        {
            InitializeComponent();
            loadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO buku (judul, penulis, penerbit, tahun_terbit) " +
               "VALUES (@judul, @penulis, @penerbit, @tahun_terbit)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@judul", textBox1.Text);
                    cmd.Parameters.AddWithValue("@penulis", textBox2.Text);
                    cmd.Parameters.AddWithValue("@penerbit", textBox3.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    loadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil ditambahkan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan data buku " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void loadData()
        {

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    String query = "SELECT * FROM buku";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["id"].HeaderText = "ID";
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["judul"].HeaderText = "Judul";
                    dataGridView1.Columns["penulis"].HeaderText = "Penulis";
                    dataGridView1.Columns["penerbit"].HeaderText = "Penerbit";
                    dataGridView1.Columns["tahun_terbit"].HeaderText = "Tahun Terbit";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load data: " + ex.Message);
                }
            }
        }
        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            selectedId = -1;
            btnSimpan.Enabled = true;
        }
        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Judul wajib diisi", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Penulis wajib diisi", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;

            }
            if (!int.TryParse(textBox4.Text, out int tahun) || textBox4.Text.Length != 4)
            {
                MessageBox.Show("Tahun terbit harus 4 digit", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return false;
            }

            return true;
        }

        private void FormDataBuku_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valueSelectedId = dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value) ? Convert.ToInt32(valueSelectedId) : -1;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["judul"].Value?.ToString() ?? "";
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["penulis"].Value?.ToString() ?? "";
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["penerbit"].Value?.ToString() ?? "";
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["tahun_terbit"].Value?.ToString() ?? "";
                btnSimpan.Enabled = false;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    String query = "UPDATE BUKU SET judul=@judul, penulis=@penulis, penerbit=@penerbit," + " tahun_terbit=@tahun_terbit WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.Parameters.AddWithValue("@judul", textBox1.Text);
                    cmd.Parameters.AddWithValue("@penulis", textBox2.Text);
                    cmd.Parameters.AddWithValue("@penerbit", textBox3.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    loadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil di update");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update " + ex.Message);
                }
            }
        }

        private void hapusData(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnStr))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM buku where id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    loadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus data " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data buku ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            hapusData(selectedId);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void TampilkanDataFiltered()
        {
            string kolom = filterCari.SelectedItem?.ToString();
            string keyword = textBoxCari.Text.Trim();
            string kolomDB = "judul";

            if (kolom == "Penulis") kolomDB = "Penulis";
            else if (kolom == "Penerbit") kolomDB = "Penerbit";

            string query = $"SELECT * FROM buku where {kolomDB} LIKE @keyword ORDER BY id DESC";

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            TampilkanDataFiltered();

        }

        private void filterCari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
