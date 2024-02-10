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
    public partial class DeleteCustomer : Form
    {
        private SqlConnection connection;

        public DeleteCustomer(SqlConnection connection)
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

                    bool customerExists = checkCustomerExist(id);

                    if (!customerExists)
                    {
                        MessageBox.Show("Customer with the specified ID does not exist in the database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string deleteQuery = "DELETE FROM customer WHERE customerId = @customerId";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@customerId", id);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
            private bool checkCustomerExist(string customerId)
            {
                string checkQuery = "SELECT COUNT(1) FROM customer WHERE customerId = @customerId";
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }

