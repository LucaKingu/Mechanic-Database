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
    public partial class SearchVehicle : Form
    {
        private SqlConnection connection;

        public SearchVehicle(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string plate = textBox1.Text;

                if (string.IsNullOrWhiteSpace(plate))
                {
                    MessageBox.Show("Field cannot be Empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string searchQuery = "SELECT * FROM dbo.vehicle WHERE plate = @plate";

                using (SqlCommand command = new SqlCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@plate", plate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
