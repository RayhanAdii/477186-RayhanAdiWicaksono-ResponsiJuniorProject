using Npgsql;
using System.Data;


namespace EmployeeWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host = localhost; port = 5432; Username = postgres; Password = informatika; Database= Employee-raw";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                try
                {
                    conn.Open();
                    sql = @"select * from st_insert(:_id_karyawan, :_nama, :_id_dep)";
                    cmd = new NpgsqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("_id_karyawan", textBoxIDKaryawan.Text);
                    cmd.Parameters.AddWithValue("_nama", textBoxNama.Text);
                    cmd.Parameters.AddWithValue("_id_dep", textBoxDept.Text);

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Employee berhasil Diinput", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoad.PerformClick();
                        textBoxDept = textBoxIDKaryawan = textBoxNama = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                try
                {
                    conn.Open();
                    dgvData.DataSource = null;

                    sql = @"select * from karyawan";
                    cmd = new NpgsqlCommand(sql, conn);

                    dt = new DataTable();
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    dgvData.DataSource = dt;

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgvData.Rows[e.RowIndex];
            textBoxIDKaryawan.Text = r.Cells["id_karyawan"].Value.ToString();
            textBoxNama.Text = r.Cells["nama"].Value.ToString();
            textBoxDept.Text = r.Cells["id_dep"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon Pilih Baris Data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                try
                {
                    conn.Open();
                    sql = @"select * from st_update(:_id_karyawan, :_nama, :_id_dep)";
                    cmd = new NpgsqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value);
                    cmd.Parameters.AddWithValue("_nama", textBoxNama.Text);
                    cmd.Parameters.AddWithValue("_id_dep", textBoxDept.Text);

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Employee berhasil Diupdate", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoad.PerformClick();
                        textBoxDept = textBoxIDKaryawan = textBoxNama = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon Pilih Baris Data yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                try
                {
                    conn.Open();
                    sql = @"select * from st_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value.ToString());

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Employee berhasil Dihapus", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoad.PerformClick();
                        textBoxDept = textBoxIDKaryawan = textBoxNama = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
