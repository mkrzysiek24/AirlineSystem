using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSystem
{
    public partial class FlightsScreen : Form
    {
        public FlightsScreen()
        {
            InitializeComponent();
            FlDpDate.ValueChanged += new EventHandler(FlDpDate_ValueChanged);
            FlDpTime.ValueChanged += new EventHandler(FlDpTime_ValueChanged);
            UpdateTable();
            UpdateConnectionsList();
            UpdateAircraftsList();
        }

        private readonly SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AirlineSystemDB;Integrated Security=True");

        private void UpdateTable()
        {
            Con.Open();
            string Query = "select FT.[FlightId], FT.[ConnID], AT_Arrival.[City] as [Arrival], FT.[ATime], AT_Departure.[City] as [Departure], FT.[DTime], FT.[AircraftID], FT.[Capacity] from FlightsTable as FT inner join ConnectionsTable as CT on FT.[ConnID] = CT.[ConnectionID] inner join AirportsTable as AT_Arrival on CT.[ArrivalID] = AT_Arrival.[AirportID] inner join AirportsTable as AT_Departure on CT.[DepartureID] = AT_Departure.[AirportID]";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            ConnectionsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void UpdateConnectionsList()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ConnectionID from ConnectionsTable", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ConnectionID", typeof(int));
            dt.Load(reader);
            Con.Close();
            FlConnectionID.ValueMember = "ConnectionID";
            FlConnectionID.DataSource = dt;
        }

        private void UpdateAircraftsList()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select AircraftID from AircraftsTable", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AircraftID", typeof(int));
            dt.Load(reader);
            Con.Close();
            FlAircraftID.ValueMember = "AircraftID";
            FlAircraftID.DataSource = dt;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FlID.Text == "" || FlAircraftID.Text == "" || FlArDate.Text == "" || FlConnectionID.Text == "" ||
                FlArTime.Text == "" || FlDpDate.Text == "" || FlDpTime.Text == "" || FlDepartureCity.Text == ""
                || FlArrivalCity.Text == "" || FlDistance.Text == "" || FlDistanceMax.Text == ""
                || FlCapacity.Text == "" || FlCapacityMax.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into FlightsTable values('" + this.FlID.Text + "','" + this.FlConnectionID.Text + "','" + this.FlArDate.Text + " " + this.FlArTime.Text + "','" + this.FlDpDate.Text + " " + this.FlDpTime.Text + "','" + this.FlAircraftID.Text + "','" +  this.FlCapacity.Text + "');";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight recorded");
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
            if (FlID.Text == "" || FlAircraftID.Text == "" || FlArDate.Text == "" || FlConnectionID.Text == "" ||
                FlArTime.Text == "" || FlDpDate.Text == "" || FlDpTime.Text == "" || FlDepartureCity.Text == ""
                || FlArrivalCity.Text == "" || FlDistance.Text == "" || FlDistanceMax.Text == ""
                || FlCapacity.Text == "" || FlCapacityMax.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from FlightsTable where FlightID='" + ConnectionsDGV.SelectedRows[0].Cells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight deleted");
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
            if (FlID.Text == "" || FlAircraftID.Text == "" || FlArDate.Text == "" || FlConnectionID.Text == "" ||
                FlArTime.Text == "" || FlDpDate.Text == "" || FlDpTime.Text == "" || FlDepartureCity.Text == ""
                || FlArrivalCity.Text == "" || FlDistance.Text == "" || FlDistanceMax.Text == ""
                || FlCapacity.Text == "" || FlCapacityMax.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update FlightsTable set ConnID='" + this.FlConnectionID.Text + "',ATime='" + this.FlArDate.Text + " " + this.FlArTime.Text + "',DTime='" + this.FlDpDate.Text + " " + this.FlDpTime.Text + "',AircraftID='" + this.FlAircraftID.Text + "',Capacity='" + this.FlCapacity.Text +  "' where FlightID='" + this.FlID.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight updated");
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
            FlID.Text = "";
            FlConnectionID.Text = "";
            FlArrivalCity.Text = "";
            FlArDate.Text = "02 February 1859";
            FlArTime.Text = "20:00:00";
            FlDepartureCity.Text = "";
            FlDpDate.Text = "02 February 1859";
            FlDpTime.Text = "20:00:00";
            FlAircraftID.Text = "";
            FlCapacity.Text = "";
            FlCapacityMax.Text = "";
            FlDistance.Text = "";
            FlDistanceMax.Text = "";
            UpdateTable();
        }

        private void AircraftsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FlID.Text = ConnectionsDGV.SelectedRows[0].Cells[0].Value.ToString();
            FlConnectionID.Text = ConnectionsDGV.SelectedRows[0].Cells[1].Value.ToString();
            FlAircraftID.Text = ConnectionsDGV.SelectedRows[0].Cells[6].Value.ToString();
            FlArDate.Text = ConnectionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            FlArTime.Text = ConnectionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            FlDpDate.Text = ConnectionsDGV.SelectedRows[0].Cells[5].Value.ToString();
            FlDpTime.Text = ConnectionsDGV.SelectedRows[0].Cells[5].Value.ToString();
            FlCapacity.Text = ConnectionsDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "";
            if (FlID.Text != "")
                Query += "FlightID = '" + this.FlID.Text + "'and ";
            if (FlConnectionID.Text != "")
                Query += "ConnID = '" + this.FlConnectionID.Text + "'and ";
            if (FlArDate.Text != "02 February 1859")
                Query += "ATime = '" + this.FlArDate.Text + " " + this.FlArTime.Text + "'and ";
            if (FlAircraftID.Text != "")
                Query += "AircraftID = '" + this.FlAircraftID.Text + "'and ";
            if (FlCapacity.Text != "")
                Query += "Capacity = '" + this.FlCapacity.Text + "'and ";
            if (Query == "")
            {
                Query = "select FT.[FlightId], FT.[ConnID], AT_Arrival.[City] as [Arrival], FT.[ATime], AT_Departure.[City] as [Departure], FT.[DTime], FT.[AircraftID], FT.[Capacity] from FlightsTable as FT inner join ConnectionsTable as CT on FT.[ConnID] = CT.[ConnectionID] inner join AirportsTable as AT_Arrival on CT.[ArrivalID] = AT_Arrival.[AirportID] inner join AirportsTable as AT_Departure on CT.[DepartureID] = AT_Departure.[AirportID]";
            }
            else
            {
                Query = Query.Remove(Query.Length - 4, 4);
                Query = "select FT.[FlightId], FT.[ConnID], AT_Arrival.[City] as [Arrival], FT.[ATime], AT_Departure.[City] as [Departure], FT.[DTime], FT.[AircraftID], FT.[Capacity] from FlightsTable as FT inner join ConnectionsTable as CT on FT.[ConnID] = CT.[ConnectionID] inner join AirportsTable as AT_Arrival on CT.[ArrivalID] = AT_Arrival.[AirportID] inner join AirportsTable as AT_Departure on CT.[DepartureID] = AT_Departure.[AirportID] where " + Query;
                Query += ";";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            ConnectionsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void FlAircraftID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string aircraftID = FlAircraftID.Text;

            string query = "SELECT Capacity, Range FROM AircraftsTable WHERE AircraftID = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", aircraftID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int capacityValue = Convert.ToInt32(reader["Capacity"]);
                    string capacity = capacityValue.ToString();
                    FlCapacityMax.Text = capacity;

                    int rangeValue = Convert.ToInt32(reader["Range"]);
                    string range = rangeValue.ToString();
                    FlDistanceMax.Text = range;
                }
                else
                {
                    MessageBox.Show("No record found with the provided AircraftID.");
                }

                reader.Close();
            }
            Con.Close();
        }

        private void FlConnectionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string connectionID = FlConnectionID.Text;

            string query = "select D.[City] as [DepartureCity], A.[City] as [ArrivalCity], CT.[Distance] from ConnectionsTable as CT inner join AirportsTable as D on CT.[DepartureID] = D.[AirportID] inner join AirportsTable as A on CT.[ArrivalID] = A.[AirportID] where CT.[ConnectionID] = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", connectionID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string departureCity = (string)reader["DepartureCity"];
                    FlDepartureCity.Text = departureCity;

                    string arrivalCity = (string)reader["ArrivalCity"];
                    FlArrivalCity.Text = arrivalCity;

                    int distanceValue = Convert.ToInt32(reader["Distance"]);
                    string distance = distanceValue.ToString();
                    FlDistance.Text = distance;
                }
                else
                {
                    MessageBox.Show("No record found with the provided ConnectionID.");
                }

                reader.Close();
            }
            Con.Close();
        }

        private int CheckConnectionTime(string index)
        {
            Con.Open();
            int timeValue = 0;
            string connectionID = index;

            string query = "select Time from ConnectionsTable where ConnectionID = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", connectionID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    timeValue = Convert.ToInt32(reader["Time"]);
                }
                else
                {
                    MessageBox.Show("No record found with the provided ConnectionID.");
                }

                reader.Close();
            }
            Con.Close();
            return timeValue;
        }

        private void FlDpDate_ValueChanged(Object sender, EventArgs e)
        {
            if (FlConnectionID.Text == "")
            {
                MessageBox.Show("ConnectionID field is empty");
            }
            else
            {
                int time = CheckConnectionTime(FlConnectionID.Text);
                int days = (time + (FlDpTime.Value.Hour * 60 + FlDpTime.Value.Minute)) / 1440;
                FlArDate.Value = FlDpDate.Value.AddDays(days);
            }
        }
        private void FlDpTime_ValueChanged(Object sender, EventArgs e)
        {
            if (FlConnectionID.Text == "")
            {
                MessageBox.Show("ConnectionID field is empty");
            }
            else
            {
                int time = CheckConnectionTime(FlConnectionID.Text);
                int days = (time + (FlDpTime.Value.Hour * 60 + FlDpTime.Value.Minute)) / 1440;
                FlArDate.Value = FlDpDate.Value.AddDays(days);
                FlArTime.Value = FlDpTime.Value.AddMinutes(time);
            }
        }
    }
}
