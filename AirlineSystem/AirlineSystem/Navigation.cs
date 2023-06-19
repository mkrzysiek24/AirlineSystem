using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSystem
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }


        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LoadForm(new FlightsScreen());
            label1.Text = "Home";
            HomeButton.BackColor = Color.FromArgb(255, 33, 33, 33);
            FlightsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            PassengersButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ConnectionsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AirportsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AircraftsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            EmployeesButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ReservationsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            LoadForm(new EmployeesScreen());
            label1.Text = "Employess";
            HomeButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            FlightsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            PassengersButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ConnectionsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AirportsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AircraftsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            EmployeesButton.BackColor = Color.FromArgb(255, 33, 33, 33);
            ReservationsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            LoadForm(new HomeScreen());
            label1.Text = "Home";
        }

        private void FlightsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new FlightsScreen());
            label1.Text = "Flights";
            HomeButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            FlightsButton.BackColor = Color.FromArgb(255, 33, 33, 33);
            PassengersButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ConnectionsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AirportsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AircraftsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            EmployeesButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ReservationsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
        }

        private void ReservationsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new ReservationsScreen());
            label1.Text = "Reservations";
            HomeButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            FlightsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            PassengersButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ConnectionsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AirportsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AircraftsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            EmployeesButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ReservationsButton.BackColor = Color.FromArgb(255, 33, 33, 33);
        }

        private void AircraftsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new AircraftsScreen());
            label1.Text = "Aircrafts";
            HomeButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            FlightsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            PassengersButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ConnectionsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AirportsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AircraftsButton.BackColor = Color.FromArgb(255, 33, 33, 33);
            EmployeesButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ReservationsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
        }

        private void AirportsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new AirportsScreen());
            label1.Text = "Airports";
            HomeButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            FlightsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            PassengersButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ConnectionsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AirportsButton.BackColor = Color.FromArgb(255, 33, 33, 33);
            AircraftsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            EmployeesButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ReservationsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
        }

        private void ConnectionsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new ConnectionsScreen());
            label1.Text = "Connections";
            HomeButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            FlightsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            PassengersButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ConnectionsButton.BackColor = Color.FromArgb(255, 33, 33, 33);
            AirportsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AircraftsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            EmployeesButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ReservationsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
        }

        private void PassengersButton_Click(object sender, EventArgs e)
        {
            LoadForm(new PassengersScreen());
            label1.Text = "Passengers";
            HomeButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            FlightsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            PassengersButton.BackColor = Color.FromArgb(255, 33, 33, 33);
            ConnectionsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AirportsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            AircraftsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            EmployeesButton.BackColor = Color.FromArgb(255, 51, 51, 51);
            ReservationsButton.BackColor = Color.FromArgb(255, 51, 51, 51);
        }
    }
}
