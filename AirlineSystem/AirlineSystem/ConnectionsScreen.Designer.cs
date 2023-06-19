namespace AirlineSystem
{
    partial class ConnectionsScreen
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
            this.CnID = new System.Windows.Forms.TextBox();
            this.CnIDLabel = new System.Windows.Forms.Label();
            this.CnDepartureIDLabel = new System.Windows.Forms.Label();
            this.CnDepartureCityLabel = new System.Windows.Forms.Label();
            this.CnDepartureCity = new System.Windows.Forms.TextBox();
            this.CnArrivalIDLabel = new System.Windows.Forms.Label();
            this.CnTimeLabel = new System.Windows.Forms.Label();
            this.CnTime = new System.Windows.Forms.TextBox();
            this.CnDistance = new System.Windows.Forms.TextBox();
            this.CnArrivalCityLabel = new System.Windows.Forms.Label();
            this.CnArrivalCity = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CnDistanceLabel = new System.Windows.Forms.Label();
            this.CnDepartureID = new System.Windows.Forms.ComboBox();
            this.CnArrivalID = new System.Windows.Forms.ComboBox();
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
            this.ConnectionsDGV.Location = new System.Drawing.Point(29, 249);
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
            this.ConnectionsDGV.RowTemplate.Height = 24;
            this.ConnectionsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConnectionsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConnectionsDGV.Size = new System.Drawing.Size(967, 372);
            this.ConnectionsDGV.TabIndex = 0;
            this.ConnectionsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AircraftsDGV_CellContentClick);
            // 
            // CnID
            // 
            this.CnID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnID.Location = new System.Drawing.Point(235, 30);
            this.CnID.Name = "CnID";
            this.CnID.Size = new System.Drawing.Size(240, 39);
            this.CnID.TabIndex = 2;
            // 
            // CnIDLabel
            // 
            this.CnIDLabel.AutoSize = true;
            this.CnIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnIDLabel.ForeColor = System.Drawing.Color.Red;
            this.CnIDLabel.Location = new System.Drawing.Point(32, 34);
            this.CnIDLabel.Name = "CnIDLabel";
            this.CnIDLabel.Size = new System.Drawing.Size(197, 33);
            this.CnIDLabel.TabIndex = 3;
            this.CnIDLabel.Text = "ConnectionID";
            // 
            // CnDepartureIDLabel
            // 
            this.CnDepartureIDLabel.AutoSize = true;
            this.CnDepartureIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnDepartureIDLabel.ForeColor = System.Drawing.Color.Red;
            this.CnDepartureIDLabel.Location = new System.Drawing.Point(32, 87);
            this.CnDepartureIDLabel.Name = "CnDepartureIDLabel";
            this.CnDepartureIDLabel.Size = new System.Drawing.Size(176, 33);
            this.CnDepartureIDLabel.TabIndex = 5;
            this.CnDepartureIDLabel.Text = "DepartureID";
            // 
            // CnDepartureCityLabel
            // 
            this.CnDepartureCityLabel.AutoSize = true;
            this.CnDepartureCityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnDepartureCityLabel.ForeColor = System.Drawing.Color.Red;
            this.CnDepartureCityLabel.Location = new System.Drawing.Point(32, 140);
            this.CnDepartureCityLabel.Name = "CnDepartureCityLabel";
            this.CnDepartureCityLabel.Size = new System.Drawing.Size(201, 33);
            this.CnDepartureCityLabel.TabIndex = 7;
            this.CnDepartureCityLabel.Text = "DepartureCity";
            // 
            // CnDepartureCity
            // 
            this.CnDepartureCity.Enabled = false;
            this.CnDepartureCity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnDepartureCity.Location = new System.Drawing.Point(235, 136);
            this.CnDepartureCity.Name = "CnDepartureCity";
            this.CnDepartureCity.Size = new System.Drawing.Size(240, 39);
            this.CnDepartureCity.TabIndex = 6;
            // 
            // CnArrivalIDLabel
            // 
            this.CnArrivalIDLabel.AutoSize = true;
            this.CnArrivalIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnArrivalIDLabel.ForeColor = System.Drawing.Color.Red;
            this.CnArrivalIDLabel.Location = new System.Drawing.Point(514, 87);
            this.CnArrivalIDLabel.Name = "CnArrivalIDLabel";
            this.CnArrivalIDLabel.Size = new System.Drawing.Size(131, 33);
            this.CnArrivalIDLabel.TabIndex = 13;
            this.CnArrivalIDLabel.Text = "ArrivalID";
            // 
            // CnTimeLabel
            // 
            this.CnTimeLabel.AutoSize = true;
            this.CnTimeLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnTimeLabel.ForeColor = System.Drawing.Color.Red;
            this.CnTimeLabel.Location = new System.Drawing.Point(514, 34);
            this.CnTimeLabel.Name = "CnTimeLabel";
            this.CnTimeLabel.Size = new System.Drawing.Size(159, 33);
            this.CnTimeLabel.TabIndex = 11;
            this.CnTimeLabel.Text = "Time (min)";
            // 
            // CnTime
            // 
            this.CnTime.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnTime.Location = new System.Drawing.Point(688, 30);
            this.CnTime.Name = "CnTime";
            this.CnTime.Size = new System.Drawing.Size(302, 39);
            this.CnTime.TabIndex = 10;
            // 
            // CnDistance
            // 
            this.CnDistance.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnDistance.Location = new System.Drawing.Point(235, 189);
            this.CnDistance.Name = "CnDistance";
            this.CnDistance.Size = new System.Drawing.Size(240, 39);
            this.CnDistance.TabIndex = 8;
            // 
            // CnArrivalCityLabel
            // 
            this.CnArrivalCityLabel.AutoSize = true;
            this.CnArrivalCityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnArrivalCityLabel.ForeColor = System.Drawing.Color.Red;
            this.CnArrivalCityLabel.Location = new System.Drawing.Point(514, 140);
            this.CnArrivalCityLabel.Name = "CnArrivalCityLabel";
            this.CnArrivalCityLabel.Size = new System.Drawing.Size(156, 33);
            this.CnArrivalCityLabel.TabIndex = 15;
            this.CnArrivalCityLabel.Text = "ArrivalCity";
            // 
            // CnArrivalCity
            // 
            this.CnArrivalCity.Enabled = false;
            this.CnArrivalCity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnArrivalCity.Location = new System.Drawing.Point(688, 136);
            this.CnArrivalCity.Name = "CnArrivalCity";
            this.CnArrivalCity.Size = new System.Drawing.Size(302, 39);
            this.CnArrivalCity.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.AddButton.Location = new System.Drawing.Point(511, 188);
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
            this.DeleteButton.Location = new System.Drawing.Point(608, 188);
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
            this.UpdateButton.Location = new System.Drawing.Point(705, 188);
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
            this.ClearButton.Location = new System.Drawing.Point(802, 188);
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
            this.SearchButton.Location = new System.Drawing.Point(899, 188);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(91, 40);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CnDistanceLabel
            // 
            this.CnDistanceLabel.AutoSize = true;
            this.CnDistanceLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnDistanceLabel.ForeColor = System.Drawing.Color.Red;
            this.CnDistanceLabel.Location = new System.Drawing.Point(32, 193);
            this.CnDistanceLabel.Name = "CnDistanceLabel";
            this.CnDistanceLabel.Size = new System.Drawing.Size(132, 33);
            this.CnDistanceLabel.TabIndex = 9;
            this.CnDistanceLabel.Text = "Distance";
            // 
            // CnDepartureID
            // 
            this.CnDepartureID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnDepartureID.FormattingEnabled = true;
            this.CnDepartureID.Location = new System.Drawing.Point(235, 83);
            this.CnDepartureID.Name = "CnDepartureID";
            this.CnDepartureID.Size = new System.Drawing.Size(240, 40);
            this.CnDepartureID.TabIndex = 21;
            this.CnDepartureID.SelectedIndexChanged += new System.EventHandler(this.CnDepartureID_SelectedIndexChanged);
            // 
            // CnArrivalID
            // 
            this.CnArrivalID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CnArrivalID.FormattingEnabled = true;
            this.CnArrivalID.Location = new System.Drawing.Point(688, 83);
            this.CnArrivalID.Name = "CnArrivalID";
            this.CnArrivalID.Size = new System.Drawing.Size(302, 40);
            this.CnArrivalID.TabIndex = 22;
            this.CnArrivalID.SelectedIndexChanged += new System.EventHandler(this.CnArrivalID_SelectedIndexChanged);
            // 
            // ConnectionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 649);
            this.Controls.Add(this.CnArrivalID);
            this.Controls.Add(this.CnDepartureID);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CnArrivalCityLabel);
            this.Controls.Add(this.CnArrivalCity);
            this.Controls.Add(this.CnArrivalIDLabel);
            this.Controls.Add(this.CnTimeLabel);
            this.Controls.Add(this.CnTime);
            this.Controls.Add(this.CnDistanceLabel);
            this.Controls.Add(this.CnDistance);
            this.Controls.Add(this.CnDepartureCityLabel);
            this.Controls.Add(this.CnDepartureCity);
            this.Controls.Add(this.CnDepartureIDLabel);
            this.Controls.Add(this.CnIDLabel);
            this.Controls.Add(this.CnID);
            this.Controls.Add(this.ConnectionsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionsScreen";
            this.Text = "AirportsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConnectionsDGV;
        private System.Windows.Forms.TextBox CnID;
        private System.Windows.Forms.Label CnIDLabel;
        private System.Windows.Forms.Label CnDepartureIDLabel;
        private System.Windows.Forms.Label CnDepartureCityLabel;
        private System.Windows.Forms.TextBox CnDepartureCity;
        private System.Windows.Forms.Label CnArrivalIDLabel;
        private System.Windows.Forms.Label CnTimeLabel;
        private System.Windows.Forms.TextBox CnTime;
        private System.Windows.Forms.TextBox CnDistance;
        private System.Windows.Forms.Label CnArrivalCityLabel;
        private System.Windows.Forms.TextBox CnArrivalCity;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label CnDistanceLabel;
        private System.Windows.Forms.ComboBox CnDepartureID;
        private System.Windows.Forms.ComboBox CnArrivalID;
    }
}