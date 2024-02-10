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
    public partial class AddVehicle : Form
    {
        private SqlConnection connection;

        public AddVehicle(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = textBox1.Text;
                string model = textBox2.Text;
                string year = textBox3.Text;
                string plate = textBox4.Text;
                string id = textBox5.Text;

                if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(year) || string.IsNullOrWhiteSpace(plate) || string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("None of the fields can be Empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = "INSERT INTO dbo.vehicle(brand , model , year , plate , customerId)" +
                        "                 VALUES(@brand , @model , @year , @plate , @customerId)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@brand", brand);
                    command.Parameters.AddWithValue("@model", model);
                    command.Parameters.AddWithValue("@year", year);
                    command.Parameters.AddWithValue("@plate", plate);
                    command.Parameters.AddWithValue("@customerId", id);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
