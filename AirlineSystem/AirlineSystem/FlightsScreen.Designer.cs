namespace AirlineSystem
{
    partial class FlightsScreen
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
            this.FlConnectionIDLabel = new System.Windows.Forms.Label();
            this.CnArrivalCityLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FlCapacityLabel = new System.Windows.Forms.Label();
            this.FlDpDate = new System.Windows.Forms.DateTimePicker();
            this.FlDpTime = new System.Windows.Forms.DateTimePicker();
            this.FlArTime = new System.Windows.Forms.DateTimePicker();
            this.FlArDate = new System.Windows.Forms.DateTimePicker();
            this.FlArrivalCityLabel = new System.Windows.Forms.Label();
            this.FlDepartureCityLabel = new System.Windows.Forms.Label();
            this.FlAircraftIDLabel = new System.Windows.Forms.Label();
            this.FlDistanceLabel = new System.Windows.Forms.Label();
            this.FlDistanceMax = new System.Windows.Forms.TextBox();
            this.FlDistance = new System.Windows.Forms.TextBox();
            this.FlCapacity = new System.Windows.Forms.TextBox();
            this.FlCapacityMax = new System.Windows.Forms.TextBox();
            this.FlConnectionID = new System.Windows.Forms.ComboBox();
            this.FlArrivalCity = new System.Windows.Forms.TextBox();
            this.FlDepartureCity = new System.Windows.Forms.TextBox();
            this.FlAircraftID = new System.Windows.Forms.ComboBox();
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
            this.FlIDLabel.Size = new System.Drawing.Size(119, 33);
            this.FlIDLabel.TabIndex = 3;
            this.FlIDLabel.Text = "FlightID";
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
            // FlConnectionIDLabel
            // 
            this.FlConnectionIDLabel.AutoSize = true;
            this.FlConnectionIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlConnectionIDLabel.ForeColor = System.Drawing.Color.Red;
            this.FlConnectionIDLabel.Location = new System.Drawing.Point(514, 34);
            this.FlConnectionIDLabel.Name = "FlConnectionIDLabel";
            this.FlConnectionIDLabel.Size = new System.Drawing.Size(130, 33);
            this.FlConnectionIDLabel.TabIndex = 11;
            this.FlConnectionIDLabel.Text = "ConneID";
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
            // FlCapacityLabel
            // 
            this.FlCapacityLabel.AutoSize = true;
            this.FlCapacityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlCapacityLabel.ForeColor = System.Drawing.Color.Red;
            this.FlCapacityLabel.Location = new System.Drawing.Point(32, 250);
            this.FlCapacityLabel.Name = "FlCapacityLabel";
            this.FlCapacityLabel.Size = new System.Drawing.Size(133, 33);
            this.FlCapacityLabel.TabIndex = 9;
            this.FlCapacityLabel.Text = "Capacity";
            // 
            // FlDpDate
            // 
            this.FlDpDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDpDate.Location = new System.Drawing.Point(182, 137);
            this.FlDpDate.Name = "FlDpDate";
            this.FlDpDate.Size = new System.Drawing.Size(176, 39);
            this.FlDpDate.TabIndex = 23;
            this.FlDpDate.Value = new System.DateTime(1859, 2, 2, 0, 0, 0, 0);
            // 
            // FlDpTime
            // 
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
            // FlAircraftIDLabel
            // 
            this.FlAircraftIDLabel.AutoSize = true;
            this.FlAircraftIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlAircraftIDLabel.ForeColor = System.Drawing.Color.Red;
            this.FlAircraftIDLabel.Location = new System.Drawing.Point(32, 194);
            this.FlAircraftIDLabel.Name = "FlAircraftIDLabel";
            this.FlAircraftIDLabel.Size = new System.Drawing.Size(142, 33);
            this.FlAircraftIDLabel.TabIndex = 36;
            this.FlAircraftIDLabel.Text = "AircraftID";
            // 
            // FlDistanceLabel
            // 
            this.FlDistanceLabel.AutoSize = true;
            this.FlDistanceLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDistanceLabel.ForeColor = System.Drawing.Color.Red;
            this.FlDistanceLabel.Location = new System.Drawing.Point(514, 194);
            this.FlDistanceLabel.Name = "FlDistanceLabel";
            this.FlDistanceLabel.Size = new System.Drawing.Size(132, 33);
            this.FlDistanceLabel.TabIndex = 38;
            this.FlDistanceLabel.Text = "Distance";
            // 
            // FlDistanceMax
            // 
            this.FlDistanceMax.Enabled = false;
            this.FlDistanceMax.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDistanceMax.Location = new System.Drawing.Point(837, 190);
            this.FlDistanceMax.Name = "FlDistanceMax";
            this.FlDistanceMax.Size = new System.Drawing.Size(153, 39);
            this.FlDistanceMax.TabIndex = 37;
            // 
            // FlDistance
            // 
            this.FlDistance.Enabled = false;
            this.FlDistance.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlDistance.Location = new System.Drawing.Point(688, 190);
            this.FlDistance.Name = "FlDistance";
            this.FlDistance.Size = new System.Drawing.Size(143, 39);
            this.FlDistance.TabIndex = 39;
            // 
            // FlCapacity
            // 
            this.FlCapacity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlCapacity.Location = new System.Drawing.Point(182, 246);
            this.FlCapacity.Name = "FlCapacity";
            this.FlCapacity.Size = new System.Drawing.Size(143, 39);
            this.FlCapacity.TabIndex = 41;
            // 
            // FlCapacityMax
            // 
            this.FlCapacityMax.Enabled = false;
            this.FlCapacityMax.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlCapacityMax.Location = new System.Drawing.Point(331, 246);
            this.FlCapacityMax.Name = "FlCapacityMax";
            this.FlCapacityMax.Size = new System.Drawing.Size(153, 39);
            this.FlCapacityMax.TabIndex = 40;
            // 
            // FlConnectionID
            // 
            this.FlConnectionID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlConnectionID.FormattingEnabled = true;
            this.FlConnectionID.Location = new System.Drawing.Point(688, 30);
            this.FlConnectionID.Name = "FlConnectionID";
            this.FlConnectionID.Size = new System.Drawing.Size(302, 40);
            this.FlConnectionID.TabIndex = 42;
            this.FlConnectionID.SelectedIndexChanged += new System.EventHandler(this.FlConnectionID_SelectedIndexChanged);
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
            // FlAircraftID
            // 
            this.FlAircraftID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlAircraftID.FormattingEnabled = true;
            this.FlAircraftID.Location = new System.Drawing.Point(182, 190);
            this.FlAircraftID.Name = "FlAircraftID";
            this.FlAircraftID.Size = new System.Drawing.Size(302, 40);
            this.FlAircraftID.TabIndex = 45;
            this.FlAircraftID.SelectedIndexChanged += new System.EventHandler(this.FlAircraftID_SelectedIndexChanged);
            // 
            // FlightsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 649);
            this.Controls.Add(this.FlAircraftID);
            this.Controls.Add(this.FlDepartureCity);
            this.Controls.Add(this.FlArrivalCity);
            this.Controls.Add(this.FlConnectionID);
            this.Controls.Add(this.FlCapacity);
            this.Controls.Add(this.FlCapacityMax);
            this.Controls.Add(this.FlDistance);
            this.Controls.Add(this.FlDistanceLabel);
            this.Controls.Add(this.FlDistanceMax);
            this.Controls.Add(this.FlAircraftIDLabel);
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
            this.Controls.Add(this.FlConnectionIDLabel);
            this.Controls.Add(this.FlCapacityLabel);
            this.Controls.Add(this.FlDateLabel);
            this.Controls.Add(this.FlIDLabel);
            this.Controls.Add(this.FlID);
            this.Controls.Add(this.ConnectionsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightsScreen";
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
        private System.Windows.Forms.Label FlConnectionIDLabel;
        private System.Windows.Forms.Label CnArrivalCityLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label FlCapacityLabel;
        private System.Windows.Forms.DateTimePicker FlDpDate;
        private System.Windows.Forms.DateTimePicker FlDpTime;
        private System.Windows.Forms.DateTimePicker FlArTime;
        private System.Windows.Forms.DateTimePicker FlArDate;
        private System.Windows.Forms.Label FlArrivalCityLabel;
        private System.Windows.Forms.Label FlDepartureCityLabel;
        private System.Windows.Forms.Label FlAircraftIDLabel;
        private System.Windows.Forms.Label FlDistanceLabel;
        private System.Windows.Forms.TextBox FlDistanceMax;
        private System.Windows.Forms.TextBox FlDistance;
        private System.Windows.Forms.TextBox FlCapacity;
        private System.Windows.Forms.TextBox FlCapacityMax;
        private System.Windows.Forms.ComboBox FlConnectionID;
        private System.Windows.Forms.TextBox FlArrivalCity;
        private System.Windows.Forms.TextBox FlDepartureCity;
        private System.Windows.Forms.ComboBox FlAircraftID;
    }
}