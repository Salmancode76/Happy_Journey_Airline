namespace Happy_Journey_Airline
{
    partial class CreateFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFlight));
            this.capacitylbl = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.destlbl = new System.Windows.Forms.Label();
            this.Deptlbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.FlightNolbl = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCreateFlight = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.dateArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dateArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dateDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dateDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.cmbDeparture = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // capacitylbl
            // 
            this.capacitylbl.AutoSize = true;
            this.capacitylbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacitylbl.Location = new System.Drawing.Point(32, 182);
            this.capacitylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capacitylbl.Name = "capacitylbl";
            this.capacitylbl.Size = new System.Drawing.Size(119, 35);
            this.capacitylbl.TabIndex = 3;
            this.capacitylbl.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(236, 194);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(261, 22);
            this.txtCapacity.TabIndex = 12;
            // 
            // destlbl
            // 
            this.destlbl.AutoSize = true;
            this.destlbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destlbl.Location = new System.Drawing.Point(32, 260);
            this.destlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destlbl.Name = "destlbl";
            this.destlbl.Size = new System.Drawing.Size(154, 35);
            this.destlbl.TabIndex = 13;
            this.destlbl.Text = "Destination:";
            // 
            // Deptlbl
            // 
            this.Deptlbl.AutoSize = true;
            this.Deptlbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deptlbl.Location = new System.Drawing.Point(544, 111);
            this.Deptlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Deptlbl.Name = "Deptlbl";
            this.Deptlbl.Size = new System.Drawing.Size(138, 35);
            this.Deptlbl.TabIndex = 15;
            this.Deptlbl.Text = "Departure:";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(544, 183);
            this.pricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(153, 35);
            this.pricelbl.TabIndex = 17;
            this.pricelbl.Text = "Flight Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(757, 196);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(261, 22);
            this.txtPrice.TabIndex = 18;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(867, 472);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 47);
            this.btnCreate.TabIndex = 25;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(544, 260);
            this.lblDepartureTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(203, 35);
            this.lblDepartureTime.TabIndex = 26;
            this.lblDepartureTime.Text = "Departure Time:";
            // 
            // FlightNolbl
            // 
            this.FlightNolbl.AutoSize = true;
            this.FlightNolbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightNolbl.Location = new System.Drawing.Point(32, 110);
            this.FlightNolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FlightNolbl.Name = "FlightNolbl";
            this.FlightNolbl.Size = new System.Drawing.Size(127, 35);
            this.FlightNolbl.TabIndex = 1;
            this.FlightNolbl.Text = "Flight No:";
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(32, 340);
            this.statuslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(92, 35);
            this.statuslbl.TabIndex = 35;
            this.statuslbl.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblCreateFlight);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 79);
            this.panel1.TabIndex = 70;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(17, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 41);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCreateFlight
            // 
            this.lblCreateFlight.AutoSize = true;
            this.lblCreateFlight.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateFlight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateFlight.Location = new System.Drawing.Point(375, 0);
            this.lblCreateFlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateFlight.Name = "lblCreateFlight";
            this.lblCreateFlight.Size = new System.Drawing.Size(333, 72);
            this.lblCreateFlight.TabIndex = 3;
            this.lblCreateFlight.Text = "Create Flight";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-1, 543);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 20);
            this.panel2.TabIndex = 98;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(386, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(546, 337);
            this.lblArrivalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(167, 35);
            this.lblArrivalTime.TabIndex = 103;
            this.lblArrivalTime.Text = "Arrival Time:";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(546, 416);
            this.lblArrivalDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(161, 35);
            this.lblArrivalDate.TabIndex = 104;
            this.lblArrivalDate.Text = "Arrival Date:";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(32, 419);
            this.lblDepartureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(197, 35);
            this.lblDepartureDate.TabIndex = 105;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // dateArrivalTime
            // 
            this.dateArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateArrivalTime.Location = new System.Drawing.Point(757, 347);
            this.dateArrivalTime.Name = "dateArrivalTime";
            this.dateArrivalTime.Size = new System.Drawing.Size(261, 22);
            this.dateArrivalTime.TabIndex = 106;
            // 
            // dateArrivalDate
            // 
            this.dateArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateArrivalDate.Location = new System.Drawing.Point(757, 426);
            this.dateArrivalDate.Name = "dateArrivalDate";
            this.dateArrivalDate.Size = new System.Drawing.Size(261, 22);
            this.dateArrivalDate.TabIndex = 107;
            // 
            // dateDepartureDate
            // 
            this.dateDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDepartureDate.Location = new System.Drawing.Point(236, 429);
            this.dateDepartureDate.Name = "dateDepartureDate";
            this.dateDepartureDate.Size = new System.Drawing.Size(261, 22);
            this.dateDepartureDate.TabIndex = 108;
            // 
            // dateDepartureTime
            // 
            this.dateDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateDepartureTime.Location = new System.Drawing.Point(756, 270);
            this.dateDepartureTime.Name = "dateDepartureTime";
            this.dateDepartureTime.Size = new System.Drawing.Size(261, 22);
            this.dateDepartureTime.TabIndex = 109;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(32, 484);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 35);
            this.lblErrorMessage.TabIndex = 110;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 22);
            this.textBox1.TabIndex = 111;
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(236, 271);
            this.cmbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(300, 24);
            this.cmbDestination.TabIndex = 33;
            // 
            // cmbDeparture
            // 
            this.cmbDeparture.FormattingEnabled = true;
            this.cmbDeparture.Location = new System.Drawing.Point(757, 122);
            this.cmbDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDeparture.Name = "cmbDeparture";
            this.cmbDeparture.Size = new System.Drawing.Size(261, 24);
            this.cmbDeparture.TabIndex = 32;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(236, 349);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(261, 24);
            this.cmbStatus.TabIndex = 112;
            // 
            // CreateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.dateDepartureTime);
            this.Controls.Add(this.dateDepartureDate);
            this.Controls.Add(this.dateArrivalDate);
            this.Controls.Add(this.dateArrivalTime);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.cmbDeparture);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.Deptlbl);
            this.Controls.Add(this.destlbl);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.capacitylbl);
            this.Controls.Add(this.FlightNolbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateFlight";
            this.Text = "CreateFlight";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label capacitylbl;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label destlbl;
        private System.Windows.Forms.Label Deptlbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label FlightNolbl;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateFlight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.DateTimePicker dateArrivalTime;
        private System.Windows.Forms.DateTimePicker dateArrivalDate;
        private System.Windows.Forms.DateTimePicker dateDepartureDate;
        private System.Windows.Forms.DateTimePicker dateDepartureTime;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.ComboBox cmbDeparture;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}