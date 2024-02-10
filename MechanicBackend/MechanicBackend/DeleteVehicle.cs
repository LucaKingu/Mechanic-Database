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
    public partial class DeleteVehicle : Form
    {
        private SqlConnection connection;

        public DeleteVehicle(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                {
                    try
                    {
                        string id = textBox1.Text;
                        if (string.IsNullOrEmpty(id))
                        {
                            MessageBox.Show("Field cannot be empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        bool vehicleExists = checkVehicleExists(id);

                        if (!vehicleExists)
                        {
                            MessageBox.Show("Vehicle with the specified ID does not exist in the database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string deleteQuery = "DELETE FROM vehicle WHERE vehicleId = @vehicleId";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@vehicleId", id);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Vehicle deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }
            private bool checkVehicleExists(string vehicleId)
            {
                string checkQuery = "SELECT COUNT(1) FROM vehicle WHERE vehicleId = @vehicleId";
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@vehicleId", vehicleId);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
   

