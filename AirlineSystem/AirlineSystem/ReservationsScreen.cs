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

namespace AirlineSystem
{
    public partial class ReservationsScreen : Form
    {
        public ReservationsScreen()
        {
            InitializeComponent();
            UpdateTable();
            UpdateFlightsList();
            UpdatePassengersList();
        }
        private readonly SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AirlineSystemDB;Integrated Security=True");

        private void UpdateTable()
        {
            Con.Open();
            string Query = "select RT.[ReservationId] as ReseID, RT.[FlightID], AT_Arrival.[City] as Arrival, FT.[ATime], AT_Departure.[City] as Departure, FT.[DTime], RT.[PassengerID] as PassID, PT.[Name] as PName, PT.[Surname] as PSurname from ReservationsTable as RT inner join FlightsTable as FT on RT.[FlightID] = FT.[FlightId] inner join ConnectionsTable as CT on FT.[ConnID] = CT.[ConnectionID] inner join AirportsTable as AT_Arrival on CT.[ArrivalID] = AT_Arrival.[AirportID] inner join AirportsTable as AT_Departure on CT.[DepartureID] = AT_Departure.[AirportID] inner join PassengersTable as PT on RT.[PassengerID] = PT.[PassengerID]";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            ConnectionsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void UpdateFlightsList()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select FlightID from FlightsTable", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FlightID", typeof(int));
            dt.Load(reader);
            Con.Close();
            FlFlightID.ValueMember = "FlightID";
            FlFlightID.DataSource = dt;
        }

        private void UpdatePassengersList()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassengerID from PassengersTable", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassengerID", typeof(int));
            dt.Load(reader);
            Con.Close();
            FlPassengerID.ValueMember = "PassengerID";
            FlPassengerID.DataSource = dt;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FlID.Text == "" || FlPassengerID.Text == "" || FlArDate.Text == "" || FlFlightID.Text == "" ||
                FlArTime.Text == "" || FlDpDate.Text == "" || FlDpTime.Text == "" || FlDepartureCity.Text == ""
                || FlArrivalCity.Text == "" || FlName.Text == "" || FlSurname.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into ReservationsTable values('" + this.FlID.Text + "','" + this.FlFlightID.Text + "','" + this.FlPassengerID.Text + "');";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation recorded");
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
            if (FlID.Text == "" || FlPassengerID.Text == "" || FlArDate.Text == "" || FlFlightID.Text == "" ||
                FlArTime.Text == "" || FlDpDate.Text == "" || FlDpTime.Text == "" || FlDepartureCity.Text == ""
                || FlArrivalCity.Text == "" || FlName.Text == "" || FlSurname.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from ReservationsTable where ReservationID='" + ConnectionsDGV.SelectedRows[0].Cells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation deleted");
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
            if (FlID.Text == "" || FlPassengerID.Text == "" || FlArDate.Text == "" || FlFlightID.Text == "" ||
                FlArTime.Text == "" || FlDpDate.Text == "" || FlDpTime.Text == "" || FlDepartureCity.Text == ""
                || FlArrivalCity.Text == "" || FlName.Text == "" || FlSurname.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update ReservationsTable set FlightID='" + this.FlFlightID.Text + "',PassengerID='" + this.FlPassengerID.Text + "' where ReservationID='" + this.FlID.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation updated");
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
            FlFlightID.Text = "";
            FlArrivalCity.Text = "";
            FlArDate.Text = "02 February 1859";
            FlArTime.Text = "20:00:00";
            FlDepartureCity.Text = "";
            FlDpDate.Text = "02 February 1859";
            FlDpTime.Text = "20:00:00";
            FlPassengerID.Text = "";
            FlName.Text = "";
            FlSurname.Text = "";
            UpdateTable();
        }

        private void AircraftsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FlID.Text = ConnectionsDGV.SelectedRows[0].Cells[0].Value.ToString();
            FlFlightID.Text = ConnectionsDGV.SelectedRows[0].Cells[1].Value.ToString();
            FlPassengerID.Text = ConnectionsDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "";
            if (FlID.Text != "")
                Query += "RT.ReservationID = '" + this.FlID.Text + "'and ";
            if (FlFlightID.Text != "")
                Query += "FT.FlightID = '" + this.FlFlightID.Text + "'and ";
            if (FlPassengerID.Text != "")
                Query += "PT.PassengerID = '" + this.FlPassengerID.Text + "'and ";
            if (Query == "")
            {
                Query = "select RT.[ReservationId] as ReseID, RT.[FlightID], AT_Arrival.[City] as Arrival, FT.[ATime], AT_Departure.[City] as Departure, FT.[DTime], RT.[PassengerID] as PassID, PT.[Name] as PName, PT.[Surname] as PSurname from ReservationsTable as RT inner join FlightsTable as FT on RT.[FlightID] = FT.[FlightId] inner join ConnectionsTable as CT on FT.[ConnID] = CT.[ConnectionID] inner join AirportsTable as AT_Arrival on CT.[ArrivalID] = AT_Arrival.[AirportID] inner join AirportsTable as AT_Departure on CT.[DepartureID] = AT_Departure.[AirportID] inner join PassengersTable as PT on RT.[PassengerID] = PT.[PassengerID]";
            }
            else
            {
                Query = Query.Remove(Query.Length - 4, 4);
                Query = "select RT.[ReservationId] as ReseID, RT.[FlightID], AT_Arrival.[City] as Arrival, FT.[ATime], AT_Departure.[City] as Departure, FT.[DTime], RT.[PassengerID] as PassID, PT.[Name] as PName, PT.[Surname] as PSurname from ReservationsTable as RT inner join FlightsTable as FT on RT.[FlightID] = FT.[FlightId] inner join ConnectionsTable as CT on FT.[ConnID] = CT.[ConnectionID] inner join AirportsTable as AT_Arrival on CT.[ArrivalID] = AT_Arrival.[AirportID] inner join AirportsTable as AT_Departure on CT.[DepartureID] = AT_Departure.[AirportID] inner join PassengersTable as PT on RT.[PassengerID] = PT.[PassengerID] where " + Query;
                Query += ";";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            ConnectionsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void FlPassengerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string passengerID = FlPassengerID.Text;

            string query = "SELECT Name, Surname FROM PassengersTable WHERE PassengerID = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", passengerID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string name = (string)reader["Name"];
                    FlName.Text = name;

                    string surname = (string)reader["Surname"];
                    FlSurname.Text = surname;
                }
                else
                {
                    MessageBox.Show("No record found with the provided AircraftID.");
                }

                reader.Close();
            }
            Con.Close();
        }

        private void FlFlightID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string fligthID = FlFlightID.Text;

            string query = "select AT_Arrival.[City] as Arrival, FT.[ATime], AT_Departure.[City] as Departure, FT.[DTime] from FlightsTable as FT inner join ConnectionsTable as CT on FT.[ConnID] = CT.[ConnectionID] inner join AirportsTable as AT_Arrival on CT.[ArrivalID] = AT_Arrival.[AirportID] inner join AirportsTable as AT_Departure on CT.[DepartureID] = AT_Departure.[AirportID] where FT.[FlightId] = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", fligthID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string departureCity = (string)reader["Departure"];
                    FlDepartureCity.Text = departureCity;

                    string arrivalCity = (string)reader["Arrival"];
                    FlArrivalCity.Text = arrivalCity;

                    DateTime aDate = (DateTime)reader["ATime"];
                    FlArDate.Text = aDate.ToShortDateString();
                    FlArTime.Text = aDate.ToShortTimeString();

                    DateTime dDate = (DateTime)reader["DTime"];
                    FlDpDate.Text = dDate.ToShortDateString();
                    FlDpTime.Text = dDate.ToShortTimeString();
                }
                else
                {
                    MessageBox.Show("No record found with the provided AircraftID.");
                }

                reader.Close();
            }
            Con.Close();
        }
    }
}
