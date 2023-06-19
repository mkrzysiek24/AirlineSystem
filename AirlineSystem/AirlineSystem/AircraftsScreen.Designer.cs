namespace AirlineSystem
{
    partial class AircraftsScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AircraftsDGV = new System.Windows.Forms.DataGridView();
            this.ArID = new System.Windows.Forms.TextBox();
            this.ArIDLabel = new System.Windows.Forms.Label();
            this.ArModelLabel = new System.Windows.Forms.Label();
            this.ArModel = new System.Windows.Forms.TextBox();
            this.ArProdcuerLabel = new System.Windows.Forms.Label();
            this.ArProducer = new System.Windows.Forms.TextBox();
            this.ArCapacityLabel = new System.Windows.Forms.Label();
            this.ArCapacity = new System.Windows.Forms.TextBox();
            this.ArRangeLabel = new System.Windows.Forms.Label();
            this.ArRange = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ArCabinCrewLabel = new System.Windows.Forms.Label();
            this.ArPilotLabel = new System.Windows.Forms.Label();
            this.ArSurnameCrew = new System.Windows.Forms.TextBox();
            this.ArSurnamePilot = new System.Windows.Forms.TextBox();
            this.ArIDCrew = new System.Windows.Forms.ComboBox();
            this.ArIDPilot = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AircraftsDGV
            // 
            this.AircraftsDGV.AllowUserToAddRows = false;
            this.AircraftsDGV.AllowUserToDeleteRows = false;
            this.AircraftsDGV.AllowUserToResizeColumns = false;
            this.AircraftsDGV.AllowUserToResizeRows = false;
            this.AircraftsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AircraftsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AircraftsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AircraftsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.AircraftsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AircraftsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AircraftsDGV.ColumnHeadersHeight = 25;
            this.AircraftsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AircraftsDGV.EnableHeadersVisualStyles = false;
            this.AircraftsDGV.Location = new System.Drawing.Point(29, 249);
            this.AircraftsDGV.Margin = new System.Windows.Forms.Padding(0);
            this.AircraftsDGV.MultiSelect = false;
            this.AircraftsDGV.Name = "AircraftsDGV";
            this.AircraftsDGV.ReadOnly = true;
            this.AircraftsDGV.RowHeadersVisible = false;
            this.AircraftsDGV.RowHeadersWidth = 52;
            this.AircraftsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AircraftsDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AircraftsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.AircraftsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AircraftsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.AircraftsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.AircraftsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.AircraftsDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AircraftsDGV.RowTemplate.Height = 24;
            this.AircraftsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AircraftsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AircraftsDGV.Size = new System.Drawing.Size(967, 372);
            this.AircraftsDGV.TabIndex = 0;
            this.AircraftsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AircraftsDGV_CellContentClick);
            // 
            // ArID
            // 
            this.ArID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArID.Location = new System.Drawing.Point(207, 30);
            this.ArID.Name = "ArID";
            this.ArID.Size = new System.Drawing.Size(268, 39);
            this.ArID.TabIndex = 2;
            // 
            // ArIDLabel
            // 
            this.ArIDLabel.AutoSize = true;
            this.ArIDLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArIDLabel.ForeColor = System.Drawing.Color.Red;
            this.ArIDLabel.Location = new System.Drawing.Point(32, 34);
            this.ArIDLabel.Name = "ArIDLabel";
            this.ArIDLabel.Size = new System.Drawing.Size(142, 33);
            this.ArIDLabel.TabIndex = 3;
            this.ArIDLabel.Text = "AircraftID";
            // 
            // ArModelLabel
            // 
            this.ArModelLabel.AutoSize = true;
            this.ArModelLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArModelLabel.ForeColor = System.Drawing.Color.Red;
            this.ArModelLabel.Location = new System.Drawing.Point(32, 87);
            this.ArModelLabel.Name = "ArModelLabel";
            this.ArModelLabel.Size = new System.Drawing.Size(98, 33);
            this.ArModelLabel.TabIndex = 5;
            this.ArModelLabel.Text = "Model";
            // 
            // ArModel
            // 
            this.ArModel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArModel.Location = new System.Drawing.Point(207, 83);
            this.ArModel.Name = "ArModel";
            this.ArModel.Size = new System.Drawing.Size(268, 39);
            this.ArModel.TabIndex = 4;
            // 
            // ArProdcuerLabel
            // 
            this.ArProdcuerLabel.AutoSize = true;
            this.ArProdcuerLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArProdcuerLabel.ForeColor = System.Drawing.Color.Red;
            this.ArProdcuerLabel.Location = new System.Drawing.Point(32, 140);
            this.ArProdcuerLabel.Name = "ArProdcuerLabel";
            this.ArProdcuerLabel.Size = new System.Drawing.Size(138, 33);
            this.ArProdcuerLabel.TabIndex = 7;
            this.ArProdcuerLabel.Text = "Producer";
            // 
            // ArProducer
            // 
            this.ArProducer.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArProducer.Location = new System.Drawing.Point(207, 136);
            this.ArProducer.Name = "ArProducer";
            this.ArProducer.Size = new System.Drawing.Size(268, 39);
            this.ArProducer.TabIndex = 6;
            // 
            // ArCapacityLabel
            // 
            this.ArCapacityLabel.AutoSize = true;
            this.ArCapacityLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArCapacityLabel.ForeColor = System.Drawing.Color.Red;
            this.ArCapacityLabel.Location = new System.Drawing.Point(514, 34);
            this.ArCapacityLabel.Name = "ArCapacityLabel";
            this.ArCapacityLabel.Size = new System.Drawing.Size(133, 33);
            this.ArCapacityLabel.TabIndex = 11;
            this.ArCapacityLabel.Text = "Capacity";
            // 
            // ArCapacity
            // 
            this.ArCapacity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArCapacity.Location = new System.Drawing.Point(705, 30);
            this.ArCapacity.Name = "ArCapacity";
            this.ArCapacity.Size = new System.Drawing.Size(285, 39);
            this.ArCapacity.TabIndex = 10;
            // 
            // ArRangeLabel
            // 
            this.ArRangeLabel.AutoSize = true;
            this.ArRangeLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArRangeLabel.ForeColor = System.Drawing.Color.Red;
            this.ArRangeLabel.Location = new System.Drawing.Point(32, 193);
            this.ArRangeLabel.Name = "ArRangeLabel";
            this.ArRangeLabel.Size = new System.Drawing.Size(169, 33);
            this.ArRangeLabel.TabIndex = 15;
            this.ArRangeLabel.Text = "Range (km)";
            // 
            // ArRange
            // 
            this.ArRange.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArRange.Location = new System.Drawing.Point(207, 189);
            this.ArRange.Name = "ArRange";
            this.ArRange.Size = new System.Drawing.Size(268, 39);
            this.ArRange.TabIndex = 14;
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
            // ArCabinCrewLabel
            // 
            this.ArCabinCrewLabel.AutoSize = true;
            this.ArCabinCrewLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArCabinCrewLabel.ForeColor = System.Drawing.Color.Red;
            this.ArCabinCrewLabel.Location = new System.Drawing.Point(514, 87);
            this.ArCabinCrewLabel.Name = "ArCabinCrewLabel";
            this.ArCabinCrewLabel.Size = new System.Drawing.Size(163, 33);
            this.ArCabinCrewLabel.TabIndex = 13;
            this.ArCabinCrewLabel.Text = "CabinCrew";
            // 
            // ArPilotLabel
            // 
            this.ArPilotLabel.AutoSize = true;
            this.ArPilotLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArPilotLabel.ForeColor = System.Drawing.Color.Red;
            this.ArPilotLabel.Location = new System.Drawing.Point(514, 140);
            this.ArPilotLabel.Name = "ArPilotLabel";
            this.ArPilotLabel.Size = new System.Drawing.Size(75, 33);
            this.ArPilotLabel.TabIndex = 9;
            this.ArPilotLabel.Text = "Pilot";
            // 
            // ArSurnameCrew
            // 
            this.ArSurnameCrew.Enabled = false;
            this.ArSurnameCrew.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArSurnameCrew.Location = new System.Drawing.Point(777, 83);
            this.ArSurnameCrew.Name = "ArSurnameCrew";
            this.ArSurnameCrew.Size = new System.Drawing.Size(213, 39);
            this.ArSurnameCrew.TabIndex = 21;
            // 
            // ArSurnamePilot
            // 
            this.ArSurnamePilot.Enabled = false;
            this.ArSurnamePilot.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArSurnamePilot.Location = new System.Drawing.Point(777, 136);
            this.ArSurnamePilot.Name = "ArSurnamePilot";
            this.ArSurnamePilot.Size = new System.Drawing.Size(213, 39);
            this.ArSurnamePilot.TabIndex = 22;
            // 
            // ArIDCrew
            // 
            this.ArIDCrew.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArIDCrew.FormattingEnabled = true;
            this.ArIDCrew.Location = new System.Drawing.Point(705, 83);
            this.ArIDCrew.Name = "ArIDCrew";
            this.ArIDCrew.Size = new System.Drawing.Size(66, 40);
            this.ArIDCrew.TabIndex = 23;
            this.ArIDCrew.SelectedIndexChanged += new System.EventHandler(this.ArIDCrew_SelectedIndexChanged);
            // 
            // ArIDPilot
            // 
            this.ArIDPilot.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArIDPilot.FormattingEnabled = true;
            this.ArIDPilot.Location = new System.Drawing.Point(705, 136);
            this.ArIDPilot.Name = "ArIDPilot";
            this.ArIDPilot.Size = new System.Drawing.Size(66, 40);
            this.ArIDPilot.TabIndex = 24;
            this.ArIDPilot.SelectedIndexChanged += new System.EventHandler(this.ArIDPilot_SelectedIndexChanged);
            // 
            // AircraftsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 649);
            this.Controls.Add(this.ArIDPilot);
            this.Controls.Add(this.ArIDCrew);
            this.Controls.Add(this.ArSurnamePilot);
            this.Controls.Add(this.ArSurnameCrew);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ArCabinCrewLabel);
            this.Controls.Add(this.ArCapacityLabel);
            this.Controls.Add(this.ArCapacity);
            this.Controls.Add(this.ArPilotLabel);
            this.Controls.Add(this.ArProdcuerLabel);
            this.Controls.Add(this.ArProducer);
            this.Controls.Add(this.ArModelLabel);
            this.Controls.Add(this.ArModel);
            this.Controls.Add(this.ArIDLabel);
            this.Controls.Add(this.ArID);
            this.Controls.Add(this.AircraftsDGV);
            this.Controls.Add(this.ArRangeLabel);
            this.Controls.Add(this.ArRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AircraftsScreen";
            this.Text = "AirportsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.AircraftsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AircraftsDGV;
        private System.Windows.Forms.TextBox ArID;
        private System.Windows.Forms.Label ArIDLabel;
        private System.Windows.Forms.Label ArModelLabel;
        private System.Windows.Forms.TextBox ArModel;
        private System.Windows.Forms.Label ArProdcuerLabel;
        private System.Windows.Forms.TextBox ArProducer;
        private System.Windows.Forms.Label ArCapacityLabel;
        private System.Windows.Forms.TextBox ArCapacity;
        private System.Windows.Forms.Label ArRangeLabel;
        private System.Windows.Forms.TextBox ArRange;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ArCabinCrewLabel;
        private System.Windows.Forms.Label ArPilotLabel;
        private System.Windows.Forms.TextBox ArSurnameCrew;
        private System.Windows.Forms.TextBox ArSurnamePilot;
        private System.Windows.Forms.ComboBox ArIDCrew;
        private System.Windows.Forms.ComboBox ArIDPilot;
    }

}