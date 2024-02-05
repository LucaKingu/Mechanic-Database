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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection conn;

            connectionString = @"Data Source=DESKTOP-I830V2D; Initial Catalog=MechanicDB;Integrated Security=True;";
            //Integrated security = True; So that you can easily connect to the database engine via windows authentication on your local machine
            conn = new SqlConnection(connectionString);

            conn.Open();
            MessageBox.Show("Connection Succesfully open!");

            //The below is testing for queries to see the data is indeed being extracted

            /* SqlCommand command;
            SqlDataReader reader;
            string query = "";
            string output = "";

            query = "SELECT * FROM dbo.customer";

            command = new SqlCommand(query, conn);

            reader = command.ExecuteReader();

            //Access each row one by one
            while(reader.Read())
            {
                output = output + reader.GetValue(0) + " - " + reader.GetValue(1) + " - "
                                + reader.GetValue(2) + " - " + reader.GetValue(3) + " - "
                                + reader.GetValue(4) + " - " + reader.GetValue(5) + " - ";
            }

            MessageBox.Show(output);

            reader.Close();
            command.Dispose(); */
            conn.Close();
        }
    }
}
