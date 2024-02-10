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
    public partial class DeleteMechanic : Form
    {
        private SqlConnection connection;

        public DeleteMechanic(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void DeleteMechanic_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                if(string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Field cannot be empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                bool mechanicExists = CheckMechanicExists(id);

                if(!mechanicExists)
                {
                    MessageBox.Show("Mechanic with the specified ID does not exist in the database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string deleteQuery = "DELETE FROM mechanic WHERE mechanicId = @mechanicId";

                using(SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@mechanicId", id);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Mechanic deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        //This is an extra check implemented to all DELETE Forms. 
        //It checks if the given input exists before deleting it.
        //If the query returns 1, then given input exists,otherwise it does not.
        private bool CheckMechanicExists(string mechanicId)
        {
            string checkQuery = "SELECT COUNT(1) FROM mechanic WHERE mechanicId = @mechanicId";
            using (SqlCommand command = new SqlCommand(checkQuery, connection))
            {
                command.Parameters.AddWithValue("@mechanicId", mechanicId);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
