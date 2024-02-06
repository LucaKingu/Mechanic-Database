using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicBackend
{
    public partial class Form2 : Form
    {

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection connection;
        private string query;

        public Form2(SqlConnection conn, string query)
        {
            InitializeComponent();
            connection = conn;
            this.query = query;
            LoadData();
        }

        private void LoadData()
        {
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            reader.Close();
        }
    }
}
