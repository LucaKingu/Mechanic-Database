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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MechanicBackend
{
    public partial class AddCustomer : Form
    {
        private SqlConnection conn;

        public AddCustomer(SqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string surname = textBox2.Text;
                string contactNumber = textBox3.Text;
                string email = textBox4.Text;
                string address = textBox5.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("None of the fields can be Empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                string insertQuery = "INSERT INTO dbo.customer(firstName , lastName , contactNumber , email , address)" +
                        "                 VALUES(@name , @surname , @contactNumber , @email , @address)";

                using (SqlCommand command = new SqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@contactNumber", contactNumber);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@address", address);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
