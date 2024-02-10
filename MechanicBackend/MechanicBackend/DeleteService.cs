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
    public partial class DeleteService : Form
    {
        private SqlConnection connection;

        public DeleteService(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Field cannot be empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool mechanicExists = CheckServiceExists(id);

                if (!mechanicExists)
                {
                    MessageBox.Show("Service with the specified ID does not exist in the database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string deleteQuery = "DELETE FROM service WHERE serviceId = @serviceId";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@serviceId", id);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Service deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckServiceExists(string mechanicId)
        {
            string checkQuery = "SELECT COUNT(1) FROM service WHERE serviceId = @serviceId";
            using (SqlCommand command = new SqlCommand(checkQuery, connection))
            {
                command.Parameters.AddWithValue("@serviceId", mechanicId);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
