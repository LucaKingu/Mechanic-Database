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
    public partial class Form2 : Form
    {
        private SqlConnection conn;

        public Form2(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;   //Connect with Form1 connection

            if (this.conn.State == System.Data.ConnectionState.Closed)
            {
                this.conn.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataReader reader;
            string query = "";
            string output = "";

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

            reader.Close();
            command.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.conn.State == System.Data.ConnectionState.Open)
            {
                this.conn.Close();
                MessageBox.Show("Connection Closed");
            }
        }
    }
}