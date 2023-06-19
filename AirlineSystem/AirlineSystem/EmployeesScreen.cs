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
    public partial class EmployeesScreen : Form
    {
        public EmployeesScreen()
        {
            InitializeComponent();
            UpdateTable();
        }

        private readonly SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AirlineSystemDB;Integrated Security=True");

        private void UpdateTable()
        {
            Con.Open();
            string Query = "select * from EmployeesTable";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            EmployeesDGV.DataSource = data.Tables[0];
            Con.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (EyID.Text == "" || EySurname.Text == "" || EyPosition.Text == "" || EyNationality.Text == "" ||
                EyName.Text == "" || EyGender.Text == "" || EyPassport.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into EmployeesTable values('" + this.EyID.Text + "','" + this.EyName.Text + "','" + this.EySurname.Text + "','" + this.EyPosition.Text + "','" + this.EyNationality.Text + "','" + this.EyPassport.Text + "','" + this.EyGender.Text + "');";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee recorded");
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
            if (EyID.Text == "" || EySurname.Text == "" || EyPosition.Text == "" || EyNationality.Text == "" ||
                EyName.Text == "" || EyGender.Text == "" || EyPassport.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from EmployeesTable where EmployeeID='" + EmployeesDGV.SelectedRows[0].Cells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted");
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
            if (EyID.Text == "" || EySurname.Text == "" || EyPosition.Text == "" || EyNationality.Text == "" ||
                EyName.Text == "" || EyGender.Text == "" || EyPassport.Text == "")
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update EmployeesTable set Name='" + this.EyName.Text + "',Surname='" + this.EySurname.Text + "',Position='" + this.EyPosition.Text + "',Nationality='" + this.EyNationality.Text + "',Passport='" + this.EyPassport.Text + "',Gender='" + this.EyGender.Text + "' where EmployeeID='" + this.EyID.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee updated");
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
            EyID.Text = "";
            EyName.Text = "";
            EySurname.Text = "";
            EyPosition.Text = "";
            EyNationality.Text = "";
            EyPassport.Text = "";
            EyGender.Text = "";
            UpdateTable();
        }

        private void EmployeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EyID.Text = EmployeesDGV.SelectedRows[0].Cells[0].Value.ToString();
            EyName.Text = EmployeesDGV.SelectedRows[0].Cells[1].Value.ToString();
            EySurname.Text = EmployeesDGV.SelectedRows[0].Cells[2].Value.ToString();
            EyPosition.Text = EmployeesDGV.SelectedRows[0].Cells[3].Value.ToString();
            EyNationality.Text = EmployeesDGV.SelectedRows[0].Cells[4].Value.ToString();
            EyPassport.Text = EmployeesDGV.SelectedRows[0].Cells[5].Value.ToString();
            EyGender.Text = EmployeesDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string frontText = "select * from EmployeesTable where ";
            string Query = "";
            if (EyID.Text != "")
                Query += "EmployeeID = '" + this.EyID.Text + "'and ";
            if (EyName.Text != "")
                Query += "Name = '" + this.EyName.Text + "'and ";
            if (EyPosition.Text != "")
                Query += "Position = '" + this.EyPosition.Text + "'and ";
            if (EySurname.Text != "")
                Query += "Surname = '" + this.EySurname.Text + "'and ";
            if (EyNationality.Text != "")
                Query += "Nationality = '" + this.EyNationality.Text + "'and ";
            if (EyPassport.Text != "")
                Query += "Passport = '" + this.EyPassport.Text + "'and ";
            if (EyGender.Text != "")
                Query += "Gender = '" + this.EyGender.Text + "'and ";
            if (Query == "")
            {
                Query = "select * from EmployeesTable";
            }
            else
            {
                Query = Query.Remove(Query.Length - 4, 4);
                Query = "select * from EmployeesTable where " + Query;
                Query += ";";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            EmployeesDGV.DataSource = data.Tables[0];
            Con.Close();
        }
    }
}
