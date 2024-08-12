using System.Data.SqlClient;
using System.Data;

namespace CSharp_ConnectionDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable  GetData(string query, string cnnString)
        {
            SqlConnection cnn = new SqlConnection(cnnString);            
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cnn.Close();
            return table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = @"Data Source=01-LAB402\SQLEXPRESS;Initial Catalog=QLTT;Integrated Security=True;Encrypt=False";
            string query = "Select * from QuanLyThongTin";
            dgvQLTT.DataSource = GetData(query, connString);
        }
    }
}
