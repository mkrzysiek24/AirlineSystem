using System;

namespace AirlineSystem
{
    partial class Navigation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReservationsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.AircraftsButton = new System.Windows.Forms.Button();
            this.AirportsButton = new System.Windows.Forms.Button();
            this.ConnectionsButton = new System.Windows.Forms.Button();
            this.PassengersButton = new System.Windows.Forms.Button();
            this.FlightsButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ReservationsButton);
            this.panel1.Controls.Add(this.EmployeesButton);
            this.panel1.Controls.Add(this.AircraftsButton);
            this.panel1.Controls.Add(this.AirportsButton);
            this.panel1.Controls.Add(this.ConnectionsButton);
            this.panel1.Controls.Add(this.PassengersButton);
            this.panel1.Controls.Add(this.FlightsButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 71);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1028, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(245, 71);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1035, 649);
            this.mainPanel.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::AirlineSystem.Properties.Resources.ExitIcon;
            this.ExitButton.Location = new System.Drawing.Point(985, 2);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(47, 38);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirlineSystem.Properties.Resources.NewLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ReservationsButton
            // 
            this.ReservationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ReservationsButton.FlatAppearance.BorderSize = 0;
            this.ReservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationsButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReservationsButton.ForeColor = System.Drawing.Color.White;
            this.ReservationsButton.Image = global::AirlineSystem.Properties.Resources.ReservationsIcon;
            this.ReservationsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationsButton.Location = new System.Drawing.Point(0, 640);
            this.ReservationsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReservationsButton.Name = "ReservationsButton";
            this.ReservationsButton.Size = new System.Drawing.Size(245, 59);
            this.ReservationsButton.TabIndex = 13;
            this.ReservationsButton.Text = "Reservations";
            this.ReservationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReservationsButton.UseVisualStyleBackColor = false;
            this.ReservationsButton.Click += new System.EventHandler(this.ReservationsButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EmployeesButton.FlatAppearance.BorderSize = 0;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmployeesButton.ForeColor = System.Drawing.Color.White;
            this.EmployeesButton.Image = global::AirlineSystem.Properties.Resources.EmployeesIcon;
            this.EmployeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeesButton.Location = new System.Drawing.Point(0, 575);
            this.EmployeesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(245, 59);
            this.EmployeesButton.TabIndex = 12;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeesButton.UseVisualStyleBackColor = false;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // AircraftsButton
            // 
            this.AircraftsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AircraftsButton.FlatAppearance.BorderSize = 0;
            this.AircraftsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AircraftsButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AircraftsButton.ForeColor = System.Drawing.Color.White;
            this.AircraftsButton.Image = global::AirlineSystem.Properties.Resources.AircraftsIcon;
            this.AircraftsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AircraftsButton.Location = new System.Drawing.Point(0, 510);
            this.AircraftsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AircraftsButton.Name = "AircraftsButton";
            this.AircraftsButton.Size = new System.Drawing.Size(245, 59);
            this.AircraftsButton.TabIndex = 11;
            this.AircraftsButton.Text = "Aircrafts";
            this.AircraftsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AircraftsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AircraftsButton.UseVisualStyleBackColor = false;
            this.AircraftsButton.Click += new System.EventHandler(this.AircraftsButton_Click);
            // 
            // AirportsButton
            // 
            this.AirportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AirportsButton.FlatAppearance.BorderSize = 0;
            this.AirportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AirportsButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AirportsButton.ForeColor = System.Drawing.Color.White;
            this.AirportsButton.Image = global::AirlineSystem.Properties.Resources.AirportsIcon;
            this.AirportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AirportsButton.Location = new System.Drawing.Point(0, 446);
            this.AirportsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AirportsButton.Name = "AirportsButton";
            this.AirportsButton.Size = new System.Drawing.Size(245, 59);
            this.AirportsButton.TabIndex = 10;
            this.AirportsButton.Text = "Airports";
            this.AirportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AirportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AirportsButton.UseVisualStyleBackColor = false;
            this.AirportsButton.Click += new System.EventHandler(this.AirportsButton_Click);
            // 
            // ConnectionsButton
            // 
            this.ConnectionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ConnectionsButton.FlatAppearance.BorderSize = 0;
            this.ConnectionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionsButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectionsButton.ForeColor = System.Drawing.Color.White;
            this.ConnectionsButton.Image = global::AirlineSystem.Properties.Resources.ConnectionsIcon;
            this.ConnectionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConnectionsButton.Location = new System.Drawing.Point(0, 380);
            this.ConnectionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectionsButton.Name = "ConnectionsButton";
            this.ConnectionsButton.Size = new System.Drawing.Size(245, 59);
            this.ConnectionsButton.TabIndex = 10;
            this.ConnectionsButton.Text = "Connections";
            this.ConnectionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConnectionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConnectionsButton.UseVisualStyleBackColor = false;
            this.ConnectionsButton.Click += new System.EventHandler(this.ConnectionsButton_Click);
            // 
            // PassengersButton
            // 
            this.PassengersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PassengersButton.FlatAppearance.BorderSize = 0;
            this.PassengersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengersButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassengersButton.ForeColor = System.Drawing.Color.White;
            this.PassengersButton.Image = global::AirlineSystem.Properties.Resources.PassengersIcon;
            this.PassengersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengersButton.Location = new System.Drawing.Point(0, 315);
            this.PassengersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassengersButton.Name = "PassengersButton";
            this.PassengersButton.Size = new System.Drawing.Size(245, 59);
            this.PassengersButton.TabIndex = 8;
            this.PassengersButton.Text = "Passengers";
            this.PassengersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PassengersButton.UseVisualStyleBackColor = false;
            this.PassengersButton.Click += new System.EventHandler(this.PassengersButton_Click);
            // 
            // FlightsButton
            // 
            this.FlightsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FlightsButton.FlatAppearance.BorderSize = 0;
            this.FlightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightsButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlightsButton.ForeColor = System.Drawing.Color.White;
            this.FlightsButton.Image = global::AirlineSystem.Properties.Resources.FlightsIcon;
            this.FlightsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlightsButton.Location = new System.Drawing.Point(0, 250);
            this.FlightsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlightsButton.Name = "FlightsButton";
            this.FlightsButton.Size = new System.Drawing.Size(245, 59);
            this.FlightsButton.TabIndex = 7;
            this.FlightsButton.Text = "Flights";
            this.FlightsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlightsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FlightsButton.UseVisualStyleBackColor = false;
            this.FlightsButton.Click += new System.EventHandler(this.FlightsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = global::AirlineSystem.Properties.Resources.HomeIcon;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 185);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(245, 59);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Navigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button AircraftsButton;
        private System.Windows.Forms.Button AirportsButton;
        private System.Windows.Forms.Button ConnectionsButton;
        private System.Windows.Forms.Button PassengersButton;
        private System.Windows.Forms.Button FlightsButton;
        private System.Windows.Forms.Button ReservationsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
    }
}