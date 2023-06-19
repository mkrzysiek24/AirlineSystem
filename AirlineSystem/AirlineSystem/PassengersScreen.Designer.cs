namespace AirlineSystem
{
    partial class PassengersScreen
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
            this.PassengersDGV = new System.Windows.Forms.DataGridView();
            this.PsID = new System.Windows.Forms.TextBox();
            this.PsIDLabel = new System.Windows.Forms.Label();
            this.PsNameLabel = new System.Windows.Forms.Label();
            this.PsName = new System.Windows.Forms.TextBox();
            this.PsSurnameLabel = new System.Windows.Forms.Label();
            this.PsSurname = new System.Windows.Forms.TextBox();
            this.PsPassportLabel = new System.Windows.Forms.Label();
            this.PsPassport = new System.Windows.Forms.TextBox();
            this.PsNationalityLabel = new System.Windows.Forms.Label();
            this.PsNationality = new System.Windows.Forms.TextBox();
            this.PsDateLabel = new System.Windows.Forms.Label();
            this.PsGenderLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PsGender = new System.Windows.Forms.ComboBox();
            this.PsDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PassengersDGV
            // 
            this.PassengersDGV.AllowUserToAddRows = false;
            this.PassengersDGV.AllowUserToDeleteRows = false;
            this.PassengersDGV.AllowUserToResizeColumns = false;
            this.PassengersDGV.AllowUserToResizeRows = false;
            this.PassengersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PassengersDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PassengersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassengersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.PassengersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PassengersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PassengersDGV.ColumnHeadersHeight = 25;
            this.PassengersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PassengersDGV.EnableHeadersVisualStyles = false;
            this.PassengersDGV.Location = new System.Drawing.Point(29, 250);
            this.PassengersDGV.Margin = new System.Windows.Forms.Padding(0);
            this.PassengersDGV.MultiSelect = false;
            this.PassengersDGV.Name = "PassengersDGV";
            this.PassengersDGV.ReadOnly = true;
            this.PassengersDGV.RowHeadersVisible = false;
            this.PassengersDGV.RowHeadersWidth = 52;
            this.PassengersDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PassengersDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PassengersDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.PassengersDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassengersDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.PassengersDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.PassengersDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.PassengersDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PassengersDGV.RowTemplate.Height = 24;
            this.PassengersDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PassengersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PassengersDGV.Size = new System.Drawing.Size(967, 371);
            this.PassengersDGV.TabIndex = 0;
            this.PassengersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AirportsDGV_CellContentClick);
            // 
            // PsID
            // 
            this.PsID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsID.Location = new System.Drawing.Point(190, 30);
            this.PsID.Name = "PsID";
            this.PsID.Size = new System.Drawing.Size(285, 39);
            this.PsID.TabIndex = 2;
            // 
            // PsIDLabel
            // 
            this.PsIDLabel.AutoSize = true;
            this.PsIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsIDLabel.ForeColor = System.Drawing.Color.Red;
            this.PsIDLabel.Location = new System.Drawing.Point(32, 34);
            this.PsIDLabel.Name = "PsIDLabel";
            this.PsIDLabel.Size = new System.Drawing.Size(43, 33);
            this.PsIDLabel.TabIndex = 3;
            this.PsIDLabel.Text = "ID";
            // 
            // PsNameLabel
            // 
            this.PsNameLabel.AutoSize = true;
            this.PsNameLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsNameLabel.ForeColor = System.Drawing.Color.Red;
            this.PsNameLabel.Location = new System.Drawing.Point(32, 87);
            this.PsNameLabel.Name = "PsNameLabel";
            this.PsNameLabel.Size = new System.Drawing.Size(93, 33);
            this.PsNameLabel.TabIndex = 5;
            this.PsNameLabel.Text = "Name";
            // 
            // PsName
            // 
            this.PsName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsName.Location = new System.Drawing.Point(190, 83);
            this.PsName.Name = "PsName";
            this.PsName.Size = new System.Drawing.Size(285, 39);
            this.PsName.TabIndex = 4;
            // 
            // PsSurnameLabel
            // 
            this.PsSurnameLabel.AutoSize = true;
            this.PsSurnameLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsSurnameLabel.ForeColor = System.Drawing.Color.Red;
            this.PsSurnameLabel.Location = new System.Drawing.Point(32, 140);
            this.PsSurnameLabel.Name = "PsSurnameLabel";
            this.PsSurnameLabel.Size = new System.Drawing.Size(137, 33);
            this.PsSurnameLabel.TabIndex = 7;
            this.PsSurnameLabel.Text = "Surname";
            // 
            // PsSurname
            // 
            this.PsSurname.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsSurname.Location = new System.Drawing.Point(190, 136);
            this.PsSurname.Name = "PsSurname";
            this.PsSurname.Size = new System.Drawing.Size(285, 39);
            this.PsSurname.TabIndex = 6;
            // 
            // PsPassportLabel
            // 
            this.PsPassportLabel.AutoSize = true;
            this.PsPassportLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsPassportLabel.ForeColor = System.Drawing.Color.Red;
            this.PsPassportLabel.Location = new System.Drawing.Point(514, 87);
            this.PsPassportLabel.Name = "PsPassportLabel";
            this.PsPassportLabel.Size = new System.Drawing.Size(133, 33);
            this.PsPassportLabel.TabIndex = 13;
            this.PsPassportLabel.Text = "Passport";
            // 
            // PsPassport
            // 
            this.PsPassport.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsPassport.Location = new System.Drawing.Point(705, 83);
            this.PsPassport.Name = "PsPassport";
            this.PsPassport.Size = new System.Drawing.Size(285, 39);
            this.PsPassport.TabIndex = 12;
            // 
            // PsNationalityLabel
            // 
            this.PsNationalityLabel.AutoSize = true;
            this.PsNationalityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsNationalityLabel.ForeColor = System.Drawing.Color.Red;
            this.PsNationalityLabel.Location = new System.Drawing.Point(514, 34);
            this.PsNationalityLabel.Name = "PsNationalityLabel";
            this.PsNationalityLabel.Size = new System.Drawing.Size(159, 33);
            this.PsNationalityLabel.TabIndex = 11;
            this.PsNationalityLabel.Text = "Nationality";
            // 
            // PsNationality
            // 
            this.PsNationality.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsNationality.Location = new System.Drawing.Point(705, 30);
            this.PsNationality.Name = "PsNationality";
            this.PsNationality.Size = new System.Drawing.Size(285, 39);
            this.PsNationality.TabIndex = 10;
            // 
            // PsDateLabel
            // 
            this.PsDateLabel.AutoSize = true;
            this.PsDateLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsDateLabel.ForeColor = System.Drawing.Color.Red;
            this.PsDateLabel.Location = new System.Drawing.Point(32, 193);
            this.PsDateLabel.Name = "PsDateLabel";
            this.PsDateLabel.Size = new System.Drawing.Size(128, 33);
            this.PsDateLabel.TabIndex = 9;
            this.PsDateLabel.Text = "Birthday";
            // 
            // PsGenderLabel
            // 
            this.PsGenderLabel.AutoSize = true;
            this.PsGenderLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsGenderLabel.ForeColor = System.Drawing.Color.Red;
            this.PsGenderLabel.Location = new System.Drawing.Point(514, 140);
            this.PsGenderLabel.Name = "PsGenderLabel";
            this.PsGenderLabel.Size = new System.Drawing.Size(114, 33);
            this.PsGenderLabel.TabIndex = 15;
            this.PsGenderLabel.Text = "Gender";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.AddButton.Location = new System.Drawing.Point(511, 189);
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
            this.DeleteButton.Location = new System.Drawing.Point(608, 189);
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
            this.UpdateButton.Location = new System.Drawing.Point(705, 189);
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
            this.ClearButton.Location = new System.Drawing.Point(802, 189);
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
            this.SearchButton.Location = new System.Drawing.Point(899, 189);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(91, 40);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PsGender
            // 
            this.PsGender.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsGender.FormattingEnabled = true;
            this.PsGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PsGender.Location = new System.Drawing.Point(705, 135);
            this.PsGender.Name = "PsGender";
            this.PsGender.Size = new System.Drawing.Size(285, 40);
            this.PsGender.TabIndex = 22;
            // 
            // PsDate
            // 
            this.PsDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PsDate.Location = new System.Drawing.Point(190, 189);
            this.PsDate.Name = "PsDate";
            this.PsDate.Size = new System.Drawing.Size(285, 39);
            this.PsDate.TabIndex = 21;
            this.PsDate.Value = new System.DateTime(1859, 2, 2, 0, 0, 0, 0);
            // 
            // PassengersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 649);
            this.Controls.Add(this.PsGender);
            this.Controls.Add(this.PsDate);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PsGenderLabel);
            this.Controls.Add(this.PsPassportLabel);
            this.Controls.Add(this.PsPassport);
            this.Controls.Add(this.PsNationalityLabel);
            this.Controls.Add(this.PsNationality);
            this.Controls.Add(this.PsDateLabel);
            this.Controls.Add(this.PsSurnameLabel);
            this.Controls.Add(this.PsSurname);
            this.Controls.Add(this.PsNameLabel);
            this.Controls.Add(this.PsName);
            this.Controls.Add(this.PsIDLabel);
            this.Controls.Add(this.PsID);
            this.Controls.Add(this.PassengersDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassengersScreen";
            this.Text = "AirportsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.PassengersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PassengersDGV;
        private System.Windows.Forms.TextBox PsID;
        private System.Windows.Forms.Label PsIDLabel;
        private System.Windows.Forms.Label PsNameLabel;
        private System.Windows.Forms.TextBox PsName;
        private System.Windows.Forms.Label PsSurnameLabel;
        private System.Windows.Forms.TextBox PsSurname;
        private System.Windows.Forms.Label PsPassportLabel;
        private System.Windows.Forms.TextBox PsPassport;
        private System.Windows.Forms.Label PsNationalityLabel;
        private System.Windows.Forms.TextBox PsNationality;
        private System.Windows.Forms.Label PsDateLabel;
        private System.Windows.Forms.Label PsGenderLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox PsGender;
        private System.Windows.Forms.DateTimePicker PsDate;
    }
}