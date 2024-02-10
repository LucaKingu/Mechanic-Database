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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace MechanicBackend
{
    public partial class AddServiceRecord : Form
    {
        private SqlConnection connection;

        public AddServiceRecord(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string serviceDate = textBox1.Text;
                string status = textBox2.Text;
                string laborHours = textBox3.Text;
                string partsUsed = textBox4.Text;
                string totalCost = textBox5.Text;
                string serviceId = textBox6.Text;
                string customerId = textBox7.Text;
                string mechanicId = textBox8.Text;
                string description = textBox9.Text;

                //partsUsed will not be allowed null, I took it in such a way that the boss would want to know
                //where all his stock is going, if none was used then he rather would have it written down for integrity
                //and security rather then leaving it null. Ofcourse leaving it null was an option, which would of been implemented
                //the same way as description.
                if (string.IsNullOrWhiteSpace(serviceDate) || string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(laborHours) || string.IsNullOrWhiteSpace(partsUsed) || string.IsNullOrWhiteSpace(totalCost) || string.IsNullOrWhiteSpace(mechanicId) || string.IsNullOrWhiteSpace(customerId) || string.IsNullOrWhiteSpace(serviceId))
                {
                    MessageBox.Show("Only the DESCRIPTION field can be empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = "INSERT INTO dbo.serviceRecord(serviceDate , status , laborHours , partsUsed , totalCost , serviceId , customerId, mechanicId , description)" +
                        "                 VALUES(@serviceDate , @status , @laborHours , @partsUsed , @totalCost , @serviceId , @customerId, @mechanicId , @description)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@serviceDate", serviceDate);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@laborHours", laborHours);
                    command.Parameters.AddWithValue("@partsUsed", partsUsed);
                    command.Parameters.AddWithValue("@totalCost", totalCost);
                    command.Parameters.AddWithValue("@serviceId", serviceId);
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@mechanicId", mechanicId);
                    command.Parameters.AddWithValue("@description", description);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
