using System.Data.SqlClient;
using System.Data;
using System;

namespace CSharp_ConnectionDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTT;Integrated Security=True;Encrypt=False");

        private void OpenCnn()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }

        private void CloseCnn()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        private DataTable GetData(string query)
        {
            OpenCnn();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CloseCnn();
            return table;
        }

        private void EditData(string query)
        {
            OpenCnn();
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            string query1 = "SELECT * FROM QuanLyThongTin";
            dgvQLTT.DataSource = GetData(query1);
            CloseCnn();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "Select * from QuanLyThongTin";
            dgvQLTT.DataSource = GetData(query);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            maTen.Clear();
            hoTen.Clear();
            namSinh.Clear();
            queQuan.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO QuanLyThongTin(MATEN, HOTEN, QUEQUAN, NAMSINH) VALUES (N'" + maTen.Text + "', N'" + hoTen.Text + "', N'" + queQuan.Text + "', N'" + namSinh.Text + "' )";
            EditData(query);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE QuanLyThongTin SET MATEN = N'" + maTen.Text + "', HOTEN = N'" + hoTen.Text + "', QUEQUAN = N'" + queQuan.Text + "', NAMSINH = N'" + namSinh.Text + "' WHERE ID = '" + ID.Text + "'";
            EditData(query);
        }

        private void dgvQLTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = dgvQLTT.CurrentRow.Cells[0].Value.ToString();
            maTen.Text = dgvQLTT.CurrentRow.Cells[1].Value.ToString();
            hoTen.Text = dgvQLTT.CurrentRow.Cells[2].Value.ToString();
            queQuan.Text = dgvQLTT.CurrentRow.Cells[3].Value.ToString();
            namSinh.Text = dgvQLTT.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM QuanLyThongTin";
            dgvQLTT.DataSource = GetData(query);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM QuanLyThongTin WHERE ID = '" + ID.Text + "'";
            EditData(query);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "Select * from QuanLyThongTin Where ID = '"+ ID.Text +"'";
            dgvQLTT.DataSource = GetData(query);
        }
    }
}
