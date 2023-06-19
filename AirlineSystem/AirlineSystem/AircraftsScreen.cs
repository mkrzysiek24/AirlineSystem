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
using System.Windows.Forms.VisualStyles;

namespace AirlineSystem
{
    public partial class AircraftsScreen : Form
    {
        public AircraftsScreen()
        {
            InitializeComponent();
            UpdateTable();
            UpdateCrewList();
            UpdatePilotList();
        }
        private readonly SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AirlineSystemDB;Integrated Security=True");

        private void UpdateTable()
        {
            Con.Open();
            string Query = "select AT.[AircraftID], AT.[Model], AT.[Producer], AT.[Capacity], AT.[Range], AT.[PilotID], PT.[Surname] as[PSurname], AT.[CrewID], CT.[Surname] as[CSurname] from AircraftsTable as AT inner join EmployeesTable as PT on AT.[PilotID] = PT.[EmployeeID] inner join EmployeesTable as CT on AT.[CrewID] = CT.[EmployeeID]";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            AircraftsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void UpdateCrewList()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select EmployeeID from EmployeesTable where Position = 'Cabin Crew'", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID", typeof(int));
            dt.Load(reader);
            Con.Close();
            ArIDCrew.ValueMember = "EmployeeID";
            ArIDCrew.DataSource = dt;
        }

        private void UpdatePilotList()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select EmployeeID from EmployeesTable where Position = 'Pilot'", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID", typeof(int));
            dt.Load(reader);
            Con.Close();
            ArIDPilot.ValueMember = "EmployeeID";
            ArIDPilot.DataSource = dt;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ArID.Text == "" || ArProducer.Text == "" || ArIDCrew.Text == ""  || ArSurnameCrew.Text == "" || ArCapacity.Text == "" ||
                ArModel.Text == "" || ArRange.Text == "" || ArIDPilot.Text == "" || ArSurnamePilot.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into AircraftsTable values('" + this.ArID.Text + "','" + this.ArModel.Text + "','" + this.ArProducer.Text + "','" + this.ArCapacity.Text + "','" + this.ArRange.Text + "','" + this.ArIDPilot.Text + "','" + this.ArIDCrew.Text + "');";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aircraft recorded");
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
            if (ArID.Text == "" || ArProducer.Text == "" || ArIDCrew.Text == "" || ArSurnameCrew.Text == "" || ArCapacity.Text == "" ||
                ArModel.Text == "" || ArRange.Text == "" || ArIDPilot.Text == "" || ArSurnamePilot.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from AircraftsTable where AircraftID='" + AircraftsDGV.SelectedRows[0].Cells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aircraft deleted");
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
            if (ArID.Text == "" || ArProducer.Text == "" || ArIDCrew.Text == "" || ArSurnameCrew.Text == "" || ArCapacity.Text == "" ||
                ArModel.Text == "" || ArRange.Text == "" || ArIDPilot.Text == "" || ArSurnamePilot.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update AircraftsTable set Model='" + this.ArModel.Text + "',Producer='" + this.ArProducer.Text +  "',Capacity='" + this.ArCapacity.Text + "',Range='" + this.ArRange.Text + "',PilotID='" + this.ArIDPilot.Text +  "',CrewID='" + this.ArIDCrew.Text + "' where AircraftID='" + this.ArID.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Airport updated");
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
            ArID.Text = "";
            ArModel.Text = "";
            ArProducer.Text = "";
            ArIDCrew.Text = "";
            ArSurnameCrew.Text = "";
            ArCapacity.Text = "";
            ArIDPilot.Text = "";
            ArSurnamePilot.Text = "";
            ArRange.Text = "";
            UpdateTable();
        }

        private void AircraftsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ArID.Text = AircraftsDGV.SelectedRows[0].Cells[0].Value.ToString();
            ArModel.Text = AircraftsDGV.SelectedRows[0].Cells[1].Value.ToString();
            ArProducer.Text = AircraftsDGV.SelectedRows[0].Cells[2].Value.ToString();
            ArCapacity.Text = AircraftsDGV.SelectedRows[0].Cells[3].Value.ToString();
            ArRange.Text = AircraftsDGV.SelectedRows[0].Cells[4].Value.ToString();
            ArIDPilot.Text = AircraftsDGV.SelectedRows[0].Cells[5].Value.ToString();
            ArSurnamePilot.Text = AircraftsDGV.SelectedRows[0].Cells[6].Value.ToString();
            ArIDCrew.Text = AircraftsDGV.SelectedRows[0].Cells[7].Value.ToString();
            ArSurnameCrew.Text = AircraftsDGV.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "";
            if (ArID.Text != "")
                Query += "AircraftID = '" + this.ArID.Text + "'and ";
            if (ArModel.Text != "")
                Query += "Model = '" + this.ArModel.Text + "'and ";
            if (ArIDCrew.Text != "")
                Query += "CrewID = '" + this.ArIDCrew.Text + "'and ";
            if (ArProducer.Text != "")
                Query += "Producer = '" + this.ArProducer.Text + "'and ";
            if (ArCapacity.Text != "")
                Query += "Capacity = '" + this.ArCapacity.Text + "'and ";
            if (ArIDPilot.Text != "")
                Query += "PilotID = '" + this.ArIDPilot.Text + "'and ";
            if (ArRange.Text != "")
                Query += "Range = '" + this.ArRange.Text + "'and ";
            if (Query == "")
            {
                Query = "select AT.[AircraftID], AT.[Model], AT.[Producer], AT.[Capacity], AT.[Range], AT.[PilotID], PT.[Surname] as[PSurname], AT.[CrewID], CT.[Surname] as[CSurname] from AircraftsTable as AT inner join EmployeesTable as PT on AT.[PilotID] = PT.[EmployeeID] inner join EmployeesTable as CT on AT.[CrewID] = CT.[EmployeeID]";
            }
            else
            {
                Query = Query.Remove(Query.Length - 4, 4);
                Query = "select AT.[AircraftID], AT.[Model], AT.[Producer], AT.[Capacity], AT.[Range], AT.[PilotID], PT.[Surname] as[PSurname], AT.[CrewID], CT.[Surname] as[CSurname] from AircraftsTable as AT inner join EmployeesTable as PT on AT.[PilotID] = PT.[EmployeeID] inner join EmployeesTable as CT on AT.[CrewID] = CT.[EmployeeID] where " + Query;
                Query += ";";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            AircraftsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void ArIDCrew_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string CrewID = ArIDCrew.Text;

            string query = "select Surname from EmployeesTable where EmployeeID = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", CrewID);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string city = (string)result;
                    ArSurnameCrew.Text = city;
                }
                else
                {
                    MessageBox.Show("No record found with the provided AirportID.");
                }
            }
            Con.Close();
        }

        private void ArIDPilot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string PilotID = ArIDPilot.Text;

            string query = "select Surname from EmployeesTable where EmployeeID = @ID";

            using (SqlCommand command = new SqlCommand(query, Con))
            {
                command.Parameters.AddWithValue("@ID", PilotID);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string city = (string)result;
                    ArSurnamePilot.Text = city;
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
