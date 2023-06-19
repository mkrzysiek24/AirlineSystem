namespace AirlineSystem
{
    partial class EmployeesScreen
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
            this.EmployeesDGV = new System.Windows.Forms.DataGridView();
            this.EyID = new System.Windows.Forms.TextBox();
            this.EyIDLabel = new System.Windows.Forms.Label();
            this.EyNameLabel = new System.Windows.Forms.Label();
            this.EyName = new System.Windows.Forms.TextBox();
            this.EySurnameLabel = new System.Windows.Forms.Label();
            this.EySurname = new System.Windows.Forms.TextBox();
            this.EyPassportLabel = new System.Windows.Forms.Label();
            this.EyPassport = new System.Windows.Forms.TextBox();
            this.EyNationalityLabel = new System.Windows.Forms.Label();
            this.EyNationality = new System.Windows.Forms.TextBox();
            this.EyGenderLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EyPositionLabel = new System.Windows.Forms.Label();
            this.EyGender = new System.Windows.Forms.ComboBox();
            this.EyPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesDGV
            // 
            this.EmployeesDGV.AllowUserToAddRows = false;
            this.EmployeesDGV.AllowUserToDeleteRows = false;
            this.EmployeesDGV.AllowUserToResizeColumns = false;
            this.EmployeesDGV.AllowUserToResizeRows = false;
            this.EmployeesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmployeesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.EmployeesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeesDGV.ColumnHeadersHeight = 25;
            this.EmployeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeesDGV.EnableHeadersVisualStyles = false;
            this.EmployeesDGV.Location = new System.Drawing.Point(29, 249);
            this.EmployeesDGV.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeesDGV.MultiSelect = false;
            this.EmployeesDGV.Name = "EmployeesDGV";
            this.EmployeesDGV.ReadOnly = true;
            this.EmployeesDGV.RowHeadersVisible = false;
            this.EmployeesDGV.RowHeadersWidth = 52;
            this.EmployeesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeesDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EmployeesDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.EmployeesDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmployeesDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.EmployeesDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.EmployeesDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.EmployeesDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDGV.RowTemplate.Height = 24;
            this.EmployeesDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmployeesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesDGV.Size = new System.Drawing.Size(967, 372);
            this.EmployeesDGV.TabIndex = 0;
            this.EmployeesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDGV_CellContentClick);
            // 
            // EyID
            // 
            this.EyID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyID.Location = new System.Drawing.Point(190, 30);
            this.EyID.Name = "EyID";
            this.EyID.Size = new System.Drawing.Size(285, 39);
            this.EyID.TabIndex = 2;
            // 
            // EyIDLabel
            // 
            this.EyIDLabel.AutoSize = true;
            this.EyIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyIDLabel.ForeColor = System.Drawing.Color.Red;
            this.EyIDLabel.Location = new System.Drawing.Point(32, 34);
            this.EyIDLabel.Name = "EyIDLabel";
            this.EyIDLabel.Size = new System.Drawing.Size(43, 33);
            this.EyIDLabel.TabIndex = 3;
            this.EyIDLabel.Text = "ID";
            // 
            // EyNameLabel
            // 
            this.EyNameLabel.AutoSize = true;
            this.EyNameLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyNameLabel.ForeColor = System.Drawing.Color.Red;
            this.EyNameLabel.Location = new System.Drawing.Point(32, 87);
            this.EyNameLabel.Name = "EyNameLabel";
            this.EyNameLabel.Size = new System.Drawing.Size(93, 33);
            this.EyNameLabel.TabIndex = 5;
            this.EyNameLabel.Text = "Name";
            // 
            // EyName
            // 
            this.EyName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyName.Location = new System.Drawing.Point(190, 83);
            this.EyName.Name = "EyName";
            this.EyName.Size = new System.Drawing.Size(285, 39);
            this.EyName.TabIndex = 4;
            // 
            // EySurnameLabel
            // 
            this.EySurnameLabel.AutoSize = true;
            this.EySurnameLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EySurnameLabel.ForeColor = System.Drawing.Color.Red;
            this.EySurnameLabel.Location = new System.Drawing.Point(32, 140);
            this.EySurnameLabel.Name = "EySurnameLabel";
            this.EySurnameLabel.Size = new System.Drawing.Size(137, 33);
            this.EySurnameLabel.TabIndex = 7;
            this.EySurnameLabel.Text = "Surname";
            // 
            // EySurname
            // 
            this.EySurname.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EySurname.Location = new System.Drawing.Point(190, 136);
            this.EySurname.Name = "EySurname";
            this.EySurname.Size = new System.Drawing.Size(285, 39);
            this.EySurname.TabIndex = 6;
            // 
            // EyPassportLabel
            // 
            this.EyPassportLabel.AutoSize = true;
            this.EyPassportLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyPassportLabel.ForeColor = System.Drawing.Color.Red;
            this.EyPassportLabel.Location = new System.Drawing.Point(514, 87);
            this.EyPassportLabel.Name = "EyPassportLabel";
            this.EyPassportLabel.Size = new System.Drawing.Size(133, 33);
            this.EyPassportLabel.TabIndex = 13;
            this.EyPassportLabel.Text = "Passport";
            // 
            // EyPassport
            // 
            this.EyPassport.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyPassport.Location = new System.Drawing.Point(705, 83);
            this.EyPassport.Name = "EyPassport";
            this.EyPassport.Size = new System.Drawing.Size(285, 39);
            this.EyPassport.TabIndex = 12;
            // 
            // EyNationalityLabel
            // 
            this.EyNationalityLabel.AutoSize = true;
            this.EyNationalityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyNationalityLabel.ForeColor = System.Drawing.Color.Red;
            this.EyNationalityLabel.Location = new System.Drawing.Point(514, 34);
            this.EyNationalityLabel.Name = "EyNationalityLabel";
            this.EyNationalityLabel.Size = new System.Drawing.Size(159, 33);
            this.EyNationalityLabel.TabIndex = 11;
            this.EyNationalityLabel.Text = "Nationality";
            // 
            // EyNationality
            // 
            this.EyNationality.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyNationality.Location = new System.Drawing.Point(705, 30);
            this.EyNationality.Name = "EyNationality";
            this.EyNationality.Size = new System.Drawing.Size(285, 39);
            this.EyNationality.TabIndex = 10;
            // 
            // EyGenderLabel
            // 
            this.EyGenderLabel.AutoSize = true;
            this.EyGenderLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyGenderLabel.ForeColor = System.Drawing.Color.Red;
            this.EyGenderLabel.Location = new System.Drawing.Point(514, 140);
            this.EyGenderLabel.Name = "EyGenderLabel";
            this.EyGenderLabel.Size = new System.Drawing.Size(114, 33);
            this.EyGenderLabel.TabIndex = 15;
            this.EyGenderLabel.Text = "Gender";
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
            // EyPositionLabel
            // 
            this.EyPositionLabel.AutoSize = true;
            this.EyPositionLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyPositionLabel.ForeColor = System.Drawing.Color.Red;
            this.EyPositionLabel.Location = new System.Drawing.Point(32, 193);
            this.EyPositionLabel.Name = "EyPositionLabel";
            this.EyPositionLabel.Size = new System.Drawing.Size(124, 33);
            this.EyPositionLabel.TabIndex = 9;
            this.EyPositionLabel.Text = "Position";
            // 
            // EyGender
            // 
            this.EyGender.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyGender.FormattingEnabled = true;
            this.EyGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EyGender.Location = new System.Drawing.Point(705, 136);
            this.EyGender.Name = "EyGender";
            this.EyGender.Size = new System.Drawing.Size(285, 40);
            this.EyGender.TabIndex = 23;
            // 
            // EyPosition
            // 
            this.EyPosition.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EyPosition.FormattingEnabled = true;
            this.EyPosition.Items.AddRange(new object[] {
            "Pilot",
            "Cabin Crew"});
            this.EyPosition.Location = new System.Drawing.Point(190, 189);
            this.EyPosition.Name = "EyPosition";
            this.EyPosition.Size = new System.Drawing.Size(285, 40);
            this.EyPosition.TabIndex = 24;
            // 
            // EmployeesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 649);
            this.Controls.Add(this.EyPosition);
            this.Controls.Add(this.EyGender);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EyGenderLabel);
            this.Controls.Add(this.EyPassportLabel);
            this.Controls.Add(this.EyPassport);
            this.Controls.Add(this.EyNationalityLabel);
            this.Controls.Add(this.EyNationality);
            this.Controls.Add(this.EyPositionLabel);
            this.Controls.Add(this.EySurnameLabel);
            this.Controls.Add(this.EySurname);
            this.Controls.Add(this.EyNameLabel);
            this.Controls.Add(this.EyName);
            this.Controls.Add(this.EyIDLabel);
            this.Controls.Add(this.EyID);
            this.Controls.Add(this.EmployeesDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesScreen";
            this.Text = "AirportsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesDGV;
        private System.Windows.Forms.TextBox EyID;
        private System.Windows.Forms.Label EyIDLabel;
        private System.Windows.Forms.Label EyNameLabel;
        private System.Windows.Forms.TextBox EyName;
        private System.Windows.Forms.Label EySurnameLabel;
        private System.Windows.Forms.TextBox EySurname;
        private System.Windows.Forms.Label EyPassportLabel;
        private System.Windows.Forms.TextBox EyPassport;
        private System.Windows.Forms.Label EyNationalityLabel;
        private System.Windows.Forms.TextBox EyNationality;
        private System.Windows.Forms.Label EyGenderLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label EyPositionLabel;
        private System.Windows.Forms.ComboBox EyGender;
        private System.Windows.Forms.ComboBox EyPosition;
    }
}