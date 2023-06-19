namespace AirlineSystem
{
    partial class ReservationsScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConnectionsDGV = new System.Windows.Forms.DataGridView();
            this.FlID = new System.Windows.Forms.TextBox();
            this.FlIDLabel = new System.Windows.Forms.Label();
            this.FlDateLabel = new System.Windows.Forms.Label();
            this.FlFlightIDLabel = new System.Windows.Forms.Label();
            this.CnArrivalCityLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FlSurnameLabel = new System.Windows.Forms.Label();
            this.FlDpDate = new System.Windows.Forms.DateTimePicker();
            this.FlDpTime = new System.Windows.Forms.DateTimePicker();
            this.FlArTime = new System.Windows.Forms.DateTimePicker();
            this.FlArDate = new System.Windows.Forms.DateTimePicker();
            this.FlArrivalCityLabel = new System.Windows.Forms.Label();
            this.FlDepartureCityLabel = new System.Windows.Forms.Label();
            this.FlPassengerIDLabel = new System.Windows.Forms.Label();
            this.FlNameLabel = new System.Windows.Forms.Label();
            this.FlFlightID = new System.Windows.Forms.ComboBox();
            this.FlArrivalCity = new System.Windows.Forms.TextBox();
            this.FlDepartureCity = new System.Windows.Forms.TextBox();
            this.FlPassengerID = new System.Windows.Forms.ComboBox();
            this.FlName = new System.Windows.Forms.TextBox();
            this.FlSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionsDGV
            // 
            this.ConnectionsDGV.AllowUserToAddRows = false;
            this.ConnectionsDGV.AllowUserToDeleteRows = false;
            this.ConnectionsDGV.AllowUserToResizeColumns = false;
            this.ConnectionsDGV.AllowUserToResizeRows = false;
            this.ConnectionsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConnectionsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ConnectionsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectionsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.ConnectionsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConnectionsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ConnectionsDGV.ColumnHeadersHeight = 25;
            this.ConnectionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ConnectionsDGV.EnableHeadersVisualStyles = false;
            this.ConnectionsDGV.Location = new System.Drawing.Point(29, 301);
            this.ConnectionsDGV.Margin = new System.Windows.Forms.Padding(0);
            this.ConnectionsDGV.MultiSelect = false;
            this.ConnectionsDGV.Name = "ConnectionsDGV";
            this.ConnectionsDGV.ReadOnly = true;
            this.ConnectionsDGV.RowHeadersVisible = false;
            this.ConnectionsDGV.RowHeadersWidth = 52;
            this.ConnectionsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ConnectionsDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ConnectionsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ConnectionsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectionsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.ConnectionsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.ConnectionsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.ConnectionsDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConnectionsDGV.RowTemplate.Height = 40;
            this.ConnectionsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConnectionsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConnectionsDGV.Size = new System.Drawing.Size(967, 320);
            this.ConnectionsDGV.TabIndex = 0;
            this.ConnectionsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AircraftsDGV_CellContentClick);
            // 
            // FlID
            // 
            this.FlID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlID.Location = new System.Drawing.Point(182, 30);
            this.FlID.Name = "FlID";
            this.FlID.Size = new System.Drawing.Size(293, 39);
            this.FlID.TabIndex = 2;
            // 
            // FlIDLabel
            // 
            this.FlIDLabel.AutoSize = true;
            this.FlIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlIDLabel.ForeColor = System.Drawing.Color.Red;
            this.FlIDLabel.Location = new System.Drawing.Point(32, 34);
            this.FlIDLabel.Name = "FlIDLabel";
            this.FlIDLabel.Size = new System.Drawing.Size(136, 33);
            this.FlIDLabel.TabIndex = 3;
            this.FlIDLabel.Text = "ReservID";
            // 
            // FlDateLabel
            // 
            this.FlDateLabel.AutoSize = true;
            this.FlDateLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDateLabel.ForeColor = System.Drawing.Color.Red;
            this.FlDateLabel.Location = new System.Drawing.Point(32, 143);
            this.FlDateLabel.Name = "FlDateLabel";
            this.FlDateLabel.Size = new System.Drawing.Size(151, 33);
            this.FlDateLabel.TabIndex = 7;
            this.FlDateLabel.Text = "DepaTime";
            // 
            // FlFlightIDLabel
            // 
            this.FlFlightIDLabel.AutoSize = true;
            this.FlFlightIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlFlightIDLabel.ForeColor = System.Drawing.Color.Red;
            this.FlFlightIDLabel.Location = new System.Drawing.Point(514, 34);
            this.FlFlightIDLabel.Name = "FlFlightIDLabel";
            this.FlFlightIDLabel.Size = new System.Drawing.Size(119, 33);
            this.FlFlightIDLabel.TabIndex = 11;
            this.FlFlightIDLabel.Text = "FlightID";
            // 
            // CnArrivalCityLabel
            // 
            this.CnArrivalCityLabel.AutoSize = true;
            this.CnArrivalCityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnArrivalCityLabel.ForeColor = System.Drawing.Color.Red;
            this.CnArrivalCityLabel.Location = new System.Drawing.Point(514, 143);
            this.CnArrivalCityLabel.Name = "CnArrivalCityLabel";
            this.CnArrivalCityLabel.Size = new System.Drawing.Size(170, 33);
            this.CnArrivalCityLabel.TabIndex = 15;
            this.CnArrivalCityLabel.Text = "ArrivalTime";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.AddButton.Location = new System.Drawing.Point(511, 245);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 40);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DeleteButton.Location = new System.Drawing.Point(608, 245);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 40);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UpdateButton.Location = new System.Drawing.Point(705, 245);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(91, 40);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClearButton.Location = new System.Drawing.Point(802, 245);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(91, 40);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SearchButton.Location = new System.Drawing.Point(899, 245);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(91, 40);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FlSurnameLabel
            // 
            this.FlSurnameLabel.AutoSize = true;
            this.FlSurnameLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlSurnameLabel.ForeColor = System.Drawing.Color.Red;
            this.FlSurnameLabel.Location = new System.Drawing.Point(32, 250);
            this.FlSurnameLabel.Name = "FlSurnameLabel";
            this.FlSurnameLabel.Size = new System.Drawing.Size(137, 33);
            this.FlSurnameLabel.TabIndex = 9;
            this.FlSurnameLabel.Text = "Surname";
            // 
            // FlDpDate
            // 
            this.FlDpDate.Enabled = false;
            this.FlDpDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDpDate.Location = new System.Drawing.Point(182, 137);
            this.FlDpDate.Name = "FlDpDate";
            this.FlDpDate.Size = new System.Drawing.Size(176, 39);
            this.FlDpDate.TabIndex = 23;
            this.FlDpDate.Value = new System.DateTime(1859, 2, 2, 0, 0, 0, 0);
            // 
            // FlDpTime
            // 
            this.FlDpTime.Enabled = false;
            this.FlDpTime.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FlDpTime.Location = new System.Drawing.Point(364, 137);
            this.FlDpTime.Name = "FlDpTime";
            this.FlDpTime.Size = new System.Drawing.Size(111, 39);
            this.FlDpTime.TabIndex = 24;
            this.FlDpTime.Value = new System.DateTime(2023, 6, 18, 20, 0, 0, 0);
            // 
            // FlArTime
            // 
            this.FlArTime.Enabled = false;
            this.FlArTime.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlArTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FlArTime.Location = new System.Drawing.Point(869, 137);
            this.FlArTime.Name = "FlArTime";
            this.FlArTime.Size = new System.Drawing.Size(121, 39);
            this.FlArTime.TabIndex = 26;
            this.FlArTime.Value = new System.DateTime(2023, 6, 18, 20, 0, 0, 0);
            // 
            // FlArDate
            // 
            this.FlArDate.Enabled = false;
            this.FlArDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlArDate.Location = new System.Drawing.Point(688, 137);
            this.FlArDate.Name = "FlArDate";
            this.FlArDate.Size = new System.Drawing.Size(175, 39);
            this.FlArDate.TabIndex = 25;
            this.FlArDate.Value = new System.DateTime(1859, 2, 2, 0, 0, 0, 0);
            // 
            // FlArrivalCityLabel
            // 
            this.FlArrivalCityLabel.AutoSize = true;
            this.FlArrivalCityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlArrivalCityLabel.ForeColor = System.Drawing.Color.Red;
            this.FlArrivalCityLabel.Location = new System.Drawing.Point(514, 87);
            this.FlArrivalCityLabel.Name = "FlArrivalCityLabel";
            this.FlArrivalCityLabel.Size = new System.Drawing.Size(156, 33);
            this.FlArrivalCityLabel.TabIndex = 28;
            this.FlArrivalCityLabel.Text = "ArrivalCity";
            // 
            // FlDepartureCityLabel
            // 
            this.FlDepartureCityLabel.AutoSize = true;
            this.FlDepartureCityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDepartureCityLabel.ForeColor = System.Drawing.Color.Red;
            this.FlDepartureCityLabel.Location = new System.Drawing.Point(32, 87);
            this.FlDepartureCityLabel.Name = "FlDepartureCityLabel";
            this.FlDepartureCityLabel.Size = new System.Drawing.Size(137, 33);
            this.FlDepartureCityLabel.TabIndex = 27;
            this.FlDepartureCityLabel.Text = "DepaCity";
            // 
            // FlPassengerIDLabel
            // 
            this.FlPassengerIDLabel.AutoSize = true;
            this.FlPassengerIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlPassengerIDLabel.ForeColor = System.Drawing.Color.Red;
            this.FlPassengerIDLabel.Location = new System.Drawing.Point(32, 194);
            this.FlPassengerIDLabel.Name = "FlPassengerIDLabel";
            this.FlPassengerIDLabel.Size = new System.Drawing.Size(140, 33);
            this.FlPassengerIDLabel.TabIndex = 36;
            this.FlPassengerIDLabel.Text = "PassenID";
            // 
            // FlNameLabel
            // 
            this.FlNameLabel.AutoSize = true;
            this.FlNameLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlNameLabel.ForeColor = System.Drawing.Color.Red;
            this.FlNameLabel.Location = new System.Drawing.Point(514, 194);
            this.FlNameLabel.Name = "FlNameLabel";
            this.FlNameLabel.Size = new System.Drawing.Size(93, 33);
            this.FlNameLabel.TabIndex = 38;
            this.FlNameLabel.Text = "Name";
            // 
            // FlFlightID
            // 
            this.FlFlightID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlFlightID.FormattingEnabled = true;
            this.FlFlightID.Location = new System.Drawing.Point(688, 30);
            this.FlFlightID.Name = "FlFlightID";
            this.FlFlightID.Size = new System.Drawing.Size(302, 40);
            this.FlFlightID.TabIndex = 42;
            this.FlFlightID.SelectedIndexChanged += new System.EventHandler(this.FlFlightID_SelectedIndexChanged);
            // 
            // FlArrivalCity
            // 
            this.FlArrivalCity.Enabled = false;
            this.FlArrivalCity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlArrivalCity.Location = new System.Drawing.Point(688, 83);
            this.FlArrivalCity.Name = "FlArrivalCity";
            this.FlArrivalCity.Size = new System.Drawing.Size(302, 39);
            this.FlArrivalCity.TabIndex = 43;
            // 
            // FlDepartureCity
            // 
            this.FlDepartureCity.Enabled = false;
            this.FlDepartureCity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDepartureCity.Location = new System.Drawing.Point(182, 83);
            this.FlDepartureCity.Name = "FlDepartureCity";
            this.FlDepartureCity.Size = new System.Drawing.Size(293, 39);
            this.FlDepartureCity.TabIndex = 44;
            // 
            // FlPassengerID
            // 
            this.FlPassengerID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlPassengerID.FormattingEnabled = true;
            this.FlPassengerID.Location = new System.Drawing.Point(182, 190);
            this.FlPassengerID.Name = "FlPassengerID";
            this.FlPassengerID.Size = new System.Drawing.Size(302, 40);
            this.FlPassengerID.TabIndex = 45;
            this.FlPassengerID.SelectedIndexChanged += new System.EventHandler(this.FlPassengerID_SelectedIndexChanged);
            // 
            // FlName
            // 
            this.FlName.Enabled = false;
            this.FlName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlName.Location = new System.Drawing.Point(688, 190);
            this.FlName.Name = "FlName";
            this.FlName.Size = new System.Drawing.Size(302, 39);
            this.FlName.TabIndex = 46;
            // 
            // FlSurname
            // 
            this.FlSurname.Enabled = false;
            this.FlSurname.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlSurname.Location = new System.Drawing.Point(182, 246);
            this.FlSurname.Name = "FlSurname";
            this.FlSurname.Size = new System.Drawing.Size(302, 39);
            this.FlSurname.TabIndex = 47;
            // 
            // ReservationsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 649);
            this.Controls.Add(this.FlSurname);
            this.Controls.Add(this.FlName);
            this.Controls.Add(this.FlPassengerID);
            this.Controls.Add(this.FlDepartureCity);
            this.Controls.Add(this.FlArrivalCity);
            this.Controls.Add(this.FlFlightID);
            this.Controls.Add(this.FlNameLabel);
            this.Controls.Add(this.FlPassengerIDLabel);
            this.Controls.Add(this.FlArrivalCityLabel);
            this.Controls.Add(this.FlDepartureCityLabel);
            this.Controls.Add(this.FlArTime);
            this.Controls.Add(this.FlArDate);
            this.Controls.Add(this.FlDpTime);
            this.Controls.Add(this.FlDpDate);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CnArrivalCityLabel);
            this.Controls.Add(this.FlFlightIDLabel);
            this.Controls.Add(this.FlSurnameLabel);
            this.Controls.Add(this.FlDateLabel);
            this.Controls.Add(this.FlIDLabel);
            this.Controls.Add(this.FlID);
            this.Controls.Add(this.ConnectionsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationsScreen";
            this.Text = "AirportsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConnectionsDGV;
        private System.Windows.Forms.TextBox FlID;
        private System.Windows.Forms.Label FlIDLabel;
        private System.Windows.Forms.Label FlDateLabel;
        private System.Windows.Forms.Label FlFlightIDLabel;
        private System.Windows.Forms.Label CnArrivalCityLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label FlSurnameLabel;
        private System.Windows.Forms.DateTimePicker FlDpDate;
        private System.Windows.Forms.DateTimePicker FlDpTime;
        private System.Windows.Forms.DateTimePicker FlArTime;
        private System.Windows.Forms.DateTimePicker FlArDate;
        private System.Windows.Forms.Label FlArrivalCityLabel;
        private System.Windows.Forms.Label FlDepartureCityLabel;
        private System.Windows.Forms.Label FlPassengerIDLabel;
        private System.Windows.Forms.Label FlNameLabel;
        private System.Windows.Forms.ComboBox FlFlightID;
        private System.Windows.Forms.TextBox FlArrivalCity;
        private System.Windows.Forms.TextBox FlDepartureCity;
        private System.Windows.Forms.ComboBox FlPassengerID;
        private System.Windows.Forms.TextBox FlName;
        private System.Windows.Forms.TextBox FlSurname;
    }
}