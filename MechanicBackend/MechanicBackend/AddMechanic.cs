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
    public partial class AddMechanic : Form
    {
        private SqlConnection connection;

        public AddMechanic(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void AddMechanic_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
             {
                    //Retrieve values from textBoxes
                    string name = textBox1.Text;
                    string surname = textBox2.Text;
                    string salary = textBox3.Text;
                    string contactNumber = textBox4.Text;
                    string email = textBox5.Text;

                    //Get the INSERT Query
                    string insertQuery = "INSERT INTO dbo.mechanic(firstName , lastName , salary , contactNumber , email)" +
                        "                 VALUES(@name , @surname , @salary , @contactNumber , @email)";

                    //Add values with corresponding retrieved values
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@salary", salary);
                        command.Parameters.AddWithValue("@contactNumber", contactNumber);
                        command.Parameters.AddWithValue("@email", email);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Mechanic added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             catch (Exception ex)
             {
                    MessageBox.Show("An error occured: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
        }

      }
    }
