using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MechanicBackend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString;
        SqlConnection conn;

        SqlCommand command;
        SqlDataReader reader;
        string query = "";
        string output = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectionString = @"Data Source=DESKTOP-I830V2D; Initial Catalog=MechanicDB;Integrated Security=True;";
            //Integrated security = True; So that you can easily connect to the database engine via windows authentication on your local machine
            conn = new SqlConnection(connectionString);

            conn.Open();
            MessageBox.Show("Connection Succesfully open!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.conn.State == System.Data.ConnectionState.Open)
            {
                this.conn.Close();
                MessageBox.Show("Connection Closed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM dbo.customer";

            command = new SqlCommand(query, conn);

            reader = command.ExecuteReader();

            //Access each row one by one
            while (reader.Read())
            {
                output = output + reader.GetValue(0) + " - " + reader.GetValue(1) + " - "
                                + reader.GetValue(2) + " - " + reader.GetValue(3) + " - "
                                + reader.GetValue(4) + " - " + reader.GetValue(5) + " - ";
            }

            MessageBox.Show(output);

            //Clear the output so that it wont repeat
            output = string.Empty;

            reader.Close();
            command.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!");
                return;
            }

            Form2 form2 = new Form2(conn, "SELECT * FROM dbo.customerReturns");
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!");
                return;
            }

            Form2 form2 = new Form2(conn, "SELECT * FROM dbo.customerVehicleInfo");
            form2.Show();
        }
    }
}
