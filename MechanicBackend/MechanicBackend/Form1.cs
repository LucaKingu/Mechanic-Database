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


        //Open connection
        private void button1_Click(object sender, EventArgs e)
        {
            connectionString = @"Data Source=DESKTOP-I830V2D; Initial Catalog=MechanicDB;Integrated Security=True;";
            //Integrated security = True; So that you can easily connect to the database engine via windows authentication on your local machine
            conn = new SqlConnection(connectionString);

            conn.Open();
            MessageBox.Show("Connection Succesfully open!");
        }

        //Close connection
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.conn.State == System.Data.ConnectionState.Open)
            {
                this.conn.Close();
                MessageBox.Show("Connection Closed");
            }
        }


        //Views are also explained in .sql file
        //View to check all customers that need to come back get serviced.
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

        //View to check all the customer vehicles information
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

        //View to check all the services that each mechanic can perform
        private void button5_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!");
                return;
            }

            Form2 form2 = new Form2(conn, "SELECT * FROM dbo.mechanicService");
            form2.Show();
        }


        //They go 'Add' , 'Delete' , 'Show' for each table.
        //Mechanic table Manipulation
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }


        //Service table Manipulation
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }



        //Customer table Manipulation
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }



        //Vehicle table Manipulation
        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }



        //Service Records table Manipulation
        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}
