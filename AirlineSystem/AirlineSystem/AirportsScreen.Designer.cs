namespace AirlineSystem
{
    partial class AirportsScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AirportsDGV = new System.Windows.Forms.DataGridView();
            this.ApID = new System.Windows.Forms.TextBox();
            this.ApIDLabel = new System.Windows.Forms.Label();
            this.ApNameLabel = new System.Windows.Forms.Label();
            this.ApName = new System.Windows.Forms.TextBox();
            this.ApCountryLabel = new System.Windows.Forms.Label();
            this.ApCountry = new System.Windows.Forms.TextBox();
            this.ApPostalCodeLabel = new System.Windows.Forms.Label();
            this.ApPostalCode = new System.Windows.Forms.TextBox();
            this.ApAddressLabel = new System.Windows.Forms.Label();
            this.ApAddress = new System.Windows.Forms.TextBox();
            this.ApCityLabel = new System.Windows.Forms.Label();
            this.ApCity = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AirportsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AirportsDGV
            // 
            this.AirportsDGV.AllowUserToAddRows = false;
            this.AirportsDGV.AllowUserToDeleteRows = false;
            this.AirportsDGV.AllowUserToResizeColumns = false;
            this.AirportsDGV.AllowUserToResizeRows = false;
            this.AirportsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AirportsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AirportsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AirportsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.AirportsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AirportsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AirportsDGV.ColumnHeadersHeight = 25;
            this.AirportsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AirportsDGV.EnableHeadersVisualStyles = false;
            this.AirportsDGV.Location = new System.Drawing.Point(29, 250);
            this.AirportsDGV.Margin = new System.Windows.Forms.Padding(0);
            this.AirportsDGV.MultiSelect = false;
            this.AirportsDGV.Name = "AirportsDGV";
            this.AirportsDGV.ReadOnly = true;
            this.AirportsDGV.RowHeadersVisible = false;
            this.AirportsDGV.RowHeadersWidth = 52;
            this.AirportsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AirportsDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AirportsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.AirportsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AirportsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.AirportsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.AirportsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.AirportsDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AirportsDGV.RowTemplate.Height = 24;
            this.AirportsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AirportsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AirportsDGV.Size = new System.Drawing.Size(967, 371);
            this.AirportsDGV.TabIndex = 0;
            this.AirportsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AirportsDGV_CellContentClick);
            // 
            // ApID
            // 
            this.ApID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApID.Location = new System.Drawing.Point(190, 30);
            this.ApID.Name = "ApID";
            this.ApID.Size = new System.Drawing.Size(285, 39);
            this.ApID.TabIndex = 2;
            // 
            // ApIDLabel
            // 
            this.ApIDLabel.AutoSize = true;
            this.ApIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApIDLabel.ForeColor = System.Drawing.Color.Red;
            this.ApIDLabel.Location = new System.Drawing.Point(32, 34);
            this.ApIDLabel.Name = "ApIDLabel";
            this.ApIDLabel.Size = new System.Drawing.Size(135, 33);
            this.ApIDLabel.TabIndex = 3;
            this.ApIDLabel.Text = "AirportID";
            // 
            // ApNameLabel
            // 
            this.ApNameLabel.AutoSize = true;
            this.ApNameLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApNameLabel.ForeColor = System.Drawing.Color.Red;
            this.ApNameLabel.Location = new System.Drawing.Point(32, 87);
            this.ApNameLabel.Name = "ApNameLabel";
            this.ApNameLabel.Size = new System.Drawing.Size(93, 33);
            this.ApNameLabel.TabIndex = 5;
            this.ApNameLabel.Text = "Name";
            // 
            // ApName
            // 
            this.ApName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApName.Location = new System.Drawing.Point(190, 83);
            this.ApName.Name = "ApName";
            this.ApName.Size = new System.Drawing.Size(285, 39);
            this.ApName.TabIndex = 4;
            // 
            // ApCountryLabel
            // 
            this.ApCountryLabel.AutoSize = true;
            this.ApCountryLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApCountryLabel.ForeColor = System.Drawing.Color.Red;
            this.ApCountryLabel.Location = new System.Drawing.Point(32, 140);
            this.ApCountryLabel.Name = "ApCountryLabel";
            this.ApCountryLabel.Size = new System.Drawing.Size(122, 33);
            this.ApCountryLabel.TabIndex = 7;
            this.ApCountryLabel.Text = "Country";
            // 
            // ApCountry
            // 
            this.ApCountry.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApCountry.Location = new System.Drawing.Point(190, 136);
            this.ApCountry.Name = "ApCountry";
            this.ApCountry.Size = new System.Drawing.Size(285, 39);
            this.ApCountry.TabIndex = 6;
            // 
            // ApPostalCodeLabel
            // 
            this.ApPostalCodeLabel.AutoSize = true;
            this.ApPostalCodeLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApPostalCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.ApPostalCodeLabel.Location = new System.Drawing.Point(514, 87);
            this.ApPostalCodeLabel.Name = "ApPostalCodeLabel";
            this.ApPostalCodeLabel.Size = new System.Drawing.Size(176, 33);
            this.ApPostalCodeLabel.TabIndex = 13;
            this.ApPostalCodeLabel.Text = "Postal Code";
            // 
            // ApPostalCode
            // 
            this.ApPostalCode.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApPostalCode.Location = new System.Drawing.Point(705, 83);
            this.ApPostalCode.Name = "ApPostalCode";
            this.ApPostalCode.Size = new System.Drawing.Size(285, 39);
            this.ApPostalCode.TabIndex = 12;
            // 
            // ApAddressLabel
            // 
            this.ApAddressLabel.AutoSize = true;
            this.ApAddressLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApAddressLabel.ForeColor = System.Drawing.Color.Red;
            this.ApAddressLabel.Location = new System.Drawing.Point(514, 34);
            this.ApAddressLabel.Name = "ApAddressLabel";
            this.ApAddressLabel.Size = new System.Drawing.Size(125, 33);
            this.ApAddressLabel.TabIndex = 11;
            this.ApAddressLabel.Text = "Address";
            // 
            // ApAddress
            // 
            this.ApAddress.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApAddress.Location = new System.Drawing.Point(705, 30);
            this.ApAddress.Name = "ApAddress";
            this.ApAddress.Size = new System.Drawing.Size(285, 39);
            this.ApAddress.TabIndex = 10;
            // 
            // ApCityLabel
            // 
            this.ApCityLabel.AutoSize = true;
            this.ApCityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApCityLabel.ForeColor = System.Drawing.Color.Red;
            this.ApCityLabel.Location = new System.Drawing.Point(514, 140);
            this.ApCityLabel.Name = "ApCityLabel";
            this.ApCityLabel.Size = new System.Drawing.Size(68, 33);
            this.ApCityLabel.TabIndex = 9;
            this.ApCityLabel.Text = "City";
            // 
            // ApCity
            // 
            this.ApCity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApCity.Location = new System.Drawing.Point(705, 136);
            this.ApCity.Name = "ApCity";
            this.ApCity.Size = new System.Drawing.Size(285, 39);
            this.ApCity.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.AddButton.Location = new System.Drawing.Point(38, 192);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(192, 40);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DeleteButton.Location = new System.Drawing.Point(236, 192);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(184, 40);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UpdateButton.Location = new System.Drawing.Point(426, 192);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(184, 40);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClearButton.Location = new System.Drawing.Point(616, 192);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(184, 40);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SearchButton.Location = new System.Drawing.Point(806, 192);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(184, 40);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AirportsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 649);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ApPostalCodeLabel);
            this.Controls.Add(this.ApPostalCode);
            this.Controls.Add(this.ApAddressLabel);
            this.Controls.Add(this.ApAddress);
            this.Controls.Add(this.ApCityLabel);
            this.Controls.Add(this.ApCity);
            this.Controls.Add(this.ApCountryLabel);
            this.Controls.Add(this.ApCountry);
            this.Controls.Add(this.ApNameLabel);
            this.Controls.Add(this.ApName);
            this.Controls.Add(this.ApIDLabel);
            this.Controls.Add(this.ApID);
            this.Controls.Add(this.AirportsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AirportsScreen";
            this.Text = "AirportsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.AirportsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AirportsDGV;
        private System.Windows.Forms.TextBox ApID;
        private System.Windows.Forms.Label ApIDLabel;
        private System.Windows.Forms.Label ApNameLabel;
        private System.Windows.Forms.TextBox ApName;
        private System.Windows.Forms.Label ApCountryLabel;
        private System.Windows.Forms.TextBox ApCountry;
        private System.Windows.Forms.Label ApPostalCodeLabel;
        private System.Windows.Forms.TextBox ApPostalCode;
        private System.Windows.Forms.Label ApAddressLabel;
        private System.Windows.Forms.TextBox ApAddress;
        private System.Windows.Forms.Label ApCityLabel;
        private System.Windows.Forms.TextBox ApCity;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
    }
}