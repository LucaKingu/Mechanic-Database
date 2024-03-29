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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        string connectionString;
        SqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Open connection
        private void button1_Click(object sender, EventArgs e)
        {
            connectionString = @"Data Source=DESKTOP-I830V2D; Initial Catalog=MechanicDB;Integrated Security=True;";
            //Integrated security = True; So that you can easily connect to the database engine via windows authentication on your local machine
            conn = new SqlConnection(connectionString);

            //try catch block to catch the connectionString being wrong
            try
            {
                conn.Open();

                if (conn != null && this.conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection is open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message + "\n\nPLESAE CHECK YOU HAVE THE CORRECT DATA SOURCE INPUTTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Added my own more user-friendly message under system exception so that the error can be better understood.
            }
        }

        //Close connection
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (conn != null && this.conn.State == ConnectionState.Open)
            {
                this.conn.Close();
                MessageBox.Show("Connection Closed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection is not open", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //Views are also explained in .sql file, they are the orange buttons in the main program
        //View to check all customers that need to come back get serviced.
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            showInformation information = new showInformation(conn, "SELECT * FROM dbo.customerReturns");
            information.Show();
        }

        //View to check all the customer vehicles information
        private void button4_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            showInformation information = new showInformation(conn, "SELECT * FROM dbo.customerVehicleInfo");
            information.Show();
        }

        //View to check all the services that each mechanic can perform
        private void button5_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            showInformation information = new showInformation(conn, "SELECT * FROM dbo.mechanicService");
            information.Show();
        }


        //They go 'Add' , 'Delete' , 'Show' for each table.
        //Mechanic table Manipulation
        private void button7_Click(object sender, EventArgs e)
        {
            //No query is needed here
            AddMechanic addMechanic = new AddMechanic(conn);
            addMechanic.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteMechanic delete = new DeleteMechanic(conn);
            delete.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            showInformation information = new showInformation(conn, "SELECT * FROM dbo.mechanic");
            information.Show();
        }


        //Service table Manipulation
        private void button9_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService(conn);
            addService.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteService deleteService = new DeleteService(conn);
            deleteService.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            showInformation information = new showInformation(conn, "SELECT * FROM dbo.service");
            information.Show();
        }



        //Customer table Manipulation
        private void button12_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(conn);
            addCustomer.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer(conn);
            deleteCustomer.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            showInformation information = new showInformation(conn, "SELECT * FROM dbo.customer");
            information.Show();
        }



        //Vehicle table Manipulation
        private void button15_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle(conn);
            addVehicle.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DeleteVehicle deleteVehicle = new DeleteVehicle(conn);
            deleteVehicle.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            showInformation information = new showInformation(conn, "SELECT * FROM dbo.vehicle");
            information.Show();
        }



        //Service Records table Manipulation
        private void button18_Click(object sender, EventArgs e)
        {
            AddServiceRecord addServiceRecord = new AddServiceRecord(conn);
            addServiceRecord.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DeleteServiceRecord deleteServiceRecord = new DeleteServiceRecord(conn);
            deleteServiceRecord.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection is not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            showInformation information = new showInformation(conn, "SELECT * FROM dbo.serviceRecords");
            information.Show();
        }


        //'SEARCH BY' Queries
        private void button21_Click(object sender, EventArgs e)
        {
            SearchMechanic search = new SearchMechanic(conn);
            search.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SearchService search = new SearchService(conn);
            search.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SearchCustomer search = new SearchCustomer(conn);
            search.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            SearchVehicle search = new SearchVehicle(conn);
            search.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            SearchServiceRecord search = new SearchServiceRecord(conn);
            search.Show();
        }
    }
}
