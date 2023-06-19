using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSystem
{
    public partial class ConnectionsScreen : Form
    {
        public ConnectionsScreen()
        {
            InitializeComponent();
            UpdateTable();
            UpdateDepartureList();
            UpdateArrivalList();
        }
        private readonly SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AirlineSystemDB;Integrated Security=True");

        private void UpdateTable()
        {
            Con.Open();
            string Query = "select CT.[ConnectionID], CT.[DepartureID], DT.[City] as [DCity], CT.[ArrivalID], AT.[City] as [ACity], CT.[Time], CT.[Distance] from ConnectionsTable as CT INNER JOIN AirportsTable as DT on CT.[DepartureID] = DT.[AirportID] inner join AirportsTable as AT on CT.[ArrivalID] = AT.[AirportID]";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            ConnectionsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void UpdateArrivalList()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select AirportID from AirportsTable", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AirportID", typeof(int));
            dt.Load(reader);
            Con.Close();
            CnArrivalID.ValueMember = "AirportID";
            CnArrivalID.DataSource = dt;
        }

        private void UpdateDepartureList()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select AirportID from AirportsTable", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AirportID", typeof(int));
            dt.Load(reader);
            Con.Close();
            CnDepartureID.ValueMember = "AirportID";
            CnDepartureID.DataSource = dt;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CnID.Text == "" || CnDepartureCity.Text == "" || CnDistance.Text == "" || CnTime.Text == "" ||
                CnArrivalID.Text == "" || CnArrivalCity.Text == "" || CnDepartureID.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into ConnectionsTable values('" + this.CnID.Text + "','" + this.CnDepartureID.Text + "','" + this.CnArrivalID.Text + "','" + this.CnTime.Text + "','" + this.CnDistance.Text + "');";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connection recorded");
                    Con.Close();
                    UpdateTable();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
                finally
                {
                    Con.Close();
                }

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CnID.Text == "" || CnDepartureCity.Text == "" || CnDistance.Text == "" || CnTime.Text == "" ||
                CnArrivalID.Text == "" || CnArrivalCity.Text == "" || CnDepartureID.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from ConnectionsTable where ConnectionID='" + ConnectionsDGV.SelectedRows[0].Cells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connection deleted");
                    Con.Close();
                    UpdateTable();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
                finally
                {
                    Con.Close();
                }

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CnID.Text == "" || CnDepartureCity.Text == "" || CnDistance.Text == "" || CnTime.Text == "" ||
                CnArrivalID.Text == "" || CnArrivalCity.Text == "" || CnDepartureID.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update ConnectionsTable set DepartureID='" + this.CnDepartureID.Text + "',Distance='" + this.CnDistance.Text + "',Time='" + this.CnTime.Text + "',ArrivalID='" + this.CnArrivalID.Text  + "' where ConnectionID='" + this.CnID.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connection updated");
                    Con.Close();
                    UpdateTable();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
                finally
                {
                    Con.Close();
                }

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CnID.Text = "";
            CnDepartureID.Text = "";
            CnDepartureCity.Text = "";
            CnDistance.Text = "";
            CnTime.Text = "";
            CnArrivalID.Text = "";
            CnArrivalCity.Text = "";
            UpdateTable();
        }

        private void AircraftsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CnID.Text = ConnectionsDGV.SelectedRows[0].Cells[0].Value.ToString();
            CnDepartureID.Text = ConnectionsDGV.SelectedRows[0].Cells[1].Value.ToString();
            CnDepartureCity.Text = ConnectionsDGV.SelectedRows[0].Cells[2].Value.ToString();
            CnArrivalID.Text = ConnectionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            CnArrivalCity.Text = ConnectionsDGV.SelectedRows[0].Cells[4].Value.ToString();
            CnTime.Text = ConnectionsDGV.SelectedRows[0].Cells[5].Value.ToString();
            CnDistance.Text = ConnectionsDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "";
            if (CnID.Text != "")
                Query += "ConnectionID = '" + this.CnID.Text + "'and ";
            if (CnArrivalID.Text != "")
                Query += "ArrivalID = '" + this.CnArrivalID.Text + "'and ";
            if (CnDistance.Text != "")
                Query += "Distance = '" + this.CnDistance.Text + "'and ";
            if (CnTime.Text != "")
                Query += "Time = '" + this.CnTime.Text + "'and ";
            if (CnDepartureID.Text != "")
                Query += "DepartureID = '" + this.CnDepartureID.Text + "'and ";
            if (Query == "")
            {
                Query = "select CT.[ConnectionID], CT.[DepartureID], DT.[City] as [DCity], CT.[ArrivalID], AT.[City] as [ACity], CT.[Time], CT.[Distance] from ConnectionsTable as CT INNER JOIN AirportsTable as DT on CT.[DepartureID] = DT.[AirportID] inner join AirportsTable as AT on CT.[ArrivalID] = AT.[AirportID]";
            }
            else
            {
                Query = Query.Remove(Query.Length - 4, 4);
                Query = "select CT.[ConnectionID], CT.[DepartureID], DT.[City] as [DCity], CT.[ArrivalID], AT.[City] as [ACity], CT.[Time], CT.[Distance] from ConnectionsTable as CT INNER JOIN AirportsTable as DT on CT.[DepartureID] = DT.[AirportID] inner join AirportsTable as AT on CT.[ArrivalID] = AT.[AirportID] where " + Query;
                Query += ";";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            ConnectionsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void CnDepartureID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string airportID = CnDepartureID.Text;

            string query = "select City from AirportsTable where AirportID = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", airportID);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string city = (string)result;
                    CnDepartureCity.Text = city;
                }
                else
                {
                    MessageBox.Show("No record found with the provided AirportID.");
                }
            }
            Con.Close();
        }

        private void CnArrivalID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string airportID = CnArrivalID.Text;

            string query = "select City from AirportsTable where AirportID = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", airportID);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string city = (string)result;
                    CnArrivalCity.Text = city;
                }
                else
                {
                    MessageBox.Show("No record found with the provided AirportID.");
                }
            }
            Con.Close();
        }
    }
}
