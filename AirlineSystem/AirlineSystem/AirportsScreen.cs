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
    public partial class AirportsScreen : Form
    {
        public AirportsScreen()
        {
            InitializeComponent();
            UpdateTable();
        }
        private readonly SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AirlineSystemDB;Integrated Security=True");

        private void UpdateTable()
        {
            Con.Open();
            string Query = "select * from AirportsTable";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            AirportsDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ApID.Text == "" || ApCountry.Text == "" || ApCity.Text == "" || ApAddress.Text == "" ||
                ApName.Text == "" || ApPostalCode.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into AirportsTable values('" + this.ApID.Text + "','" + this.ApName.Text + "','" + this.ApCountry.Text + "','" + this.ApCity.Text + "','" + this.ApAddress.Text + "','" + this.ApPostalCode.Text + "');";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Airport recorded");
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
            if (ApID.Text == "" || ApCountry.Text == "" || ApCity.Text == "" || ApAddress.Text == "" ||
                ApName.Text == "" || ApPostalCode.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from AirportsTable where AirportID='" + AirportsDGV.SelectedRows[0].Cells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Airport deleted");
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
            if (ApID.Text == "" || ApCountry.Text == "" || ApCity.Text == "" || ApAddress.Text == "" ||
                ApName.Text == "" || ApPostalCode.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update AirportsTable set Name='" + this.ApName.Text + "',Country='" + this.ApCountry.Text  + "',City='" + this.ApCity.Text + "',Address='" + this.ApAddress.Text + "',PostalCode='" + this.ApPostalCode.Text + "' where AirportID='" + this.ApID.Text + "';";
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
            ApID.Text = "";
            ApName.Text = "";
            ApCountry.Text = "";
            ApCity.Text = "";
            ApAddress.Text = "";
            ApPostalCode.Text = "";
            UpdateTable();
        }

        private void AirportsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ApID.Text = AirportsDGV.SelectedRows[0].Cells[0].Value.ToString();
            ApName.Text = AirportsDGV.SelectedRows[0].Cells[1].Value.ToString();
            ApCountry.Text = AirportsDGV.SelectedRows[0].Cells[2].Value.ToString();
            ApCity.Text = AirportsDGV.SelectedRows[0].Cells[3].Value.ToString();
            ApAddress.Text = AirportsDGV.SelectedRows[0].Cells[4].Value.ToString();
            ApPostalCode.Text = AirportsDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string frontText = "select * from AirportsTable where ";
            string Query = "";
            if(ApID.Text != "")
                Query += "AirportID = '" + this.ApID.Text + "'and ";
            if (ApName.Text != "")
                Query += "Name = '" + this.ApName.Text + "'and ";
            if (ApCity.Text != "")
                Query += "City = '" + this.ApCity.Text + "'and ";
            if (ApCountry.Text != "")
                Query += "Country = '" + this.ApCountry.Text + "'and ";
            if (ApAddress.Text != "")
                Query += "Address = '" + this.ApAddress.Text + "'and ";
            if (ApPostalCode.Text != "")
                Query += "PostalCode = '" + this.ApPostalCode.Text + "'and ";
            if (Query == "")
            {
                Query = "select * from AirportsTable";
            }
            else
            {
                Query = Query.Remove(Query.Length - 4, 4);
                Query = "select * from AirportsTable where " + Query;
                Query += ";";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            AirportsDGV.DataSource = data.Tables[0];
            Con.Close();
        }
    }
}
