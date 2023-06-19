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
    public partial class PassengersScreen : Form
    {
        public PassengersScreen()
        {
            InitializeComponent();
            UpdateTable();
        }
        private readonly SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AirlineSystemDB;Integrated Security=True");

        private void UpdateTable()
        {
            Con.Open();
            string Query = "select * from PassengersTable";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            PassengersDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (PsID.Text == "" || PsSurname.Text == "" || PsDate.Text == "" || PsNationality.Text == "" ||
                PsName.Text == "" || PsGender.Text == "" || PsPassport.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into PassengersTable values('" + this.PsID.Text + "','" + this.PsName.Text + "','" + this.PsSurname.Text + "','" + this.PsDate.Text + "','" + this.PsNationality.Text + "','" + this.PsPassport.Text + "','" + this.PsGender.Text + "');";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger recorded");
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
            if (PsID.Text == "" || PsSurname.Text == "" || PsDate.Text == "" || PsNationality.Text == "" ||
                PsName.Text == "" || PsGender.Text == "" || PsPassport.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from PassengersTable where PassengerID='" + PassengersDGV.SelectedRows[0].Cells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger deleted");
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
            if (PsID.Text == "" || PsSurname.Text == "" || PsDate.Text == "" || PsNationality.Text == "" ||
                PsName.Text == "" || PsGender.Text == "" || PsPassport.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update PassengersTable set Name='" + this.PsName.Text + "',Surname='" + this.PsSurname.Text + "',BirthdayDate='" + this.PsDate.Text + "',Nationality='" + this.PsNationality.Text + "',Passport='" + this.PsPassport.Text + "',Gender='" + this.PsGender.Text + "' where PassengerID='" + this.PsID.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger updated");
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
            PsID.Text = "";
            PsName.Text = "";
            PsSurname.Text = "";
            PsDate.Text = "02 February 1859";
            PsNationality.Text = "";
            PsPassport.Text = "";
            PsGender.Text = "";
            UpdateTable();
        }

        private void AirportsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PsID.Text = PassengersDGV.SelectedRows[0].Cells[0].Value.ToString();
            PsName.Text = PassengersDGV.SelectedRows[0].Cells[1].Value.ToString();
            PsSurname.Text = PassengersDGV.SelectedRows[0].Cells[2].Value.ToString();
            PsDate.Text = PassengersDGV.SelectedRows[0].Cells[3].Value.ToString();
            PsNationality.Text = PassengersDGV.SelectedRows[0].Cells[4].Value.ToString();
            PsPassport.Text = PassengersDGV.SelectedRows[0].Cells[5].Value.ToString();
            PsGender.Text = PassengersDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "";
            if (PsID.Text != "")
                Query += "PassengerID = '" + this.PsID.Text + "'and ";
            if (PsName.Text != "")
                Query += "Name = '" + this.PsName.Text + "'and ";
            if (PsSurname.Text != "")
                Query += "Surname = '" + this.PsSurname.Text + "'and ";
            if (PsDate.Text != "02 February 1859")
                Query += "BirthdayDate = '" + this.PsDate.Text + "'and ";
            if (PsNationality.Text != "")
                Query += "Nationality = '" + this.PsNationality.Text + "'and ";
            if (PsPassport.Text != "")
                Query += "Passport = '" + this.PsPassport.Text + "'and ";
            if (PsGender.Text != "")
                Query += "Gender = '" + this.PsGender.Text + "'and ";
            if (Query == "")
            {
                Query = "select * from PassengersTable";
            }
            else
            {
                Query = Query.Remove(Query.Length - 4, 4);
                Query = "select * from PassengersTable where " + Query;
                Query += ";";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            PassengersDGV.DataSource = data.Tables[0];
            Con.Close();
        }
    }
}
