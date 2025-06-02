using MySql.Data.MySqlClient;
namespace ProjectAutentikasi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            textBox1.Text = "admin";
            textBox2.Text = "admin123";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text.Trim();
            String password = textBox2.Text.Trim();

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    String query = "SELECT password FROM pengguna WHERE username=@username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        String hashFromDb = reader.GetString("password");
                        Boolean isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDb);

                        if (isValid)
                        {
                            MessageBox.Show("Berhasil login", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMain frm = new FormMain();
                            this.Hide();
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Password salah", "Login Gagal!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan!!", "Login Gagal!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan koneksi:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
