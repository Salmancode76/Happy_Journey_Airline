namespace Happy_Journey_Airline.Frontend
{
    partial class BookFlightNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookFlightNew));
            this.CountryDepartureCMB = new System.Windows.Forms.ComboBox();
            this.CountryDistCMD = new System.Windows.Forms.ComboBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countydeparttxt = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.dateDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.dateDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dateArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dateArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCreateFlight = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            this.cmbDeparture = new System.Windows.Forms.ComboBox();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.pricelbl = new System.Windows.Forms.Label();
            this.Deptlbl = new System.Windows.Forms.Label();
            this.destlbl = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.capacitylbl = new System.Windows.Forms.Label();
            this.FlightNolbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryDepartureCMB
            // 
            this.CountryDepartureCMB.FormattingEnabled = true;
            this.CountryDepartureCMB.Location = new System.Drawing.Point(605, 110);
            this.CountryDepartureCMB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryDepartureCMB.Name = "CountryDepartureCMB";
            this.CountryDepartureCMB.Size = new System.Drawing.Size(168, 21);
            this.CountryDepartureCMB.TabIndex = 148;
            // 
            // CountryDistCMD
            // 
            this.CountryDistCMD.FormattingEnabled = true;
            this.CountryDistCMD.Location = new System.Drawing.Point(605, 157);
            this.CountryDistCMD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryDistCMD.Name = "CountryDistCMD";
            this.CountryDistCMD.Size = new System.Drawing.Size(168, 21);
            this.CountryDistCMD.TabIndex = 147;
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(152, 157);
            this.cmbDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(207, 21);
            this.cmbDestination.TabIndex = 146;
            this.cmbDestination.SelectedIndexChanged += new System.EventHandler(this.cmbDestination_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 145;
            this.label1.Text = "Country of Distination:";
            // 
            // countydeparttxt
            // 
            this.countydeparttxt.AutoSize = true;
            this.countydeparttxt.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countydeparttxt.Location = new System.Drawing.Point(401, 102);
            this.countydeparttxt.Name = "countydeparttxt";
            this.countydeparttxt.Size = new System.Drawing.Size(209, 28);
            this.countydeparttxt.TabIndex = 144;
            this.countydeparttxt.Text = "Country of Departure:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(487, 258);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(197, 21);
            this.cmbStatus.TabIndex = 143;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 142;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(-74, 349);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 28);
            this.lblErrorMessage.TabIndex = 141;
            // 
            // dateDepartureTime
            // 
            this.dateDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateDepartureTime.Location = new System.Drawing.Point(559, 336);
            this.dateDepartureTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDepartureTime.Name = "dateDepartureTime";
            this.dateDepartureTime.Size = new System.Drawing.Size(167, 20);
            this.dateDepartureTime.TabIndex = 140;
            // 
            // dateDepartureDate
            // 
            this.dateDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDepartureDate.Location = new System.Drawing.Point(176, 338);
            this.dateDepartureDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDepartureDate.Name = "dateDepartureDate";
            this.dateDepartureDate.Size = new System.Drawing.Size(197, 20);
            this.dateDepartureDate.TabIndex = 139;
            // 
            // dateArrivalDate
            // 
            this.dateArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateArrivalDate.Location = new System.Drawing.Point(176, 410);
            this.dateArrivalDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateArrivalDate.Name = "dateArrivalDate";
            this.dateArrivalDate.Size = new System.Drawing.Size(168, 20);
            this.dateArrivalDate.TabIndex = 138;
            // 
            // dateArrivalTime
            // 
            this.dateArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateArrivalTime.Location = new System.Drawing.Point(552, 420);
            this.dateArrivalTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateArrivalTime.Name = "dateArrivalTime";
            this.dateArrivalTime.Size = new System.Drawing.Size(168, 20);
            this.dateArrivalTime.TabIndex = 137;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(27, 330);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(154, 28);
            this.lblDepartureDate.TabIndex = 136;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(23, 401);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(126, 28);
            this.lblArrivalDate.TabIndex = 135;
            this.lblArrivalDate.Text = "Arrival Date:";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(401, 410);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(131, 28);
            this.lblArrivalTime.TabIndex = 134;
            this.lblArrivalTime.Text = "Arrival Time:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblCreateFlight);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 64);
            this.panel1.TabIndex = 132;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 33);
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
            this.lblCreateFlight.Location = new System.Drawing.Point(281, 0);
            this.lblCreateFlight.Name = "lblCreateFlight";
            this.lblCreateFlight.Size = new System.Drawing.Size(237, 58);
            this.lblCreateFlight.TabIndex = 3;
            this.lblCreateFlight.Text = "Book Flight";
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(401, 249);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(74, 28);
            this.statuslbl.TabIndex = 131;
            this.statuslbl.Text = "Status:";
            // 
            // cmbDeparture
            // 
            this.cmbDeparture.DropDownWidth = 221;
            this.cmbDeparture.FormattingEnabled = true;
            this.cmbDeparture.Location = new System.Drawing.Point(152, 110);
            this.cmbDeparture.Name = "cmbDeparture";
            this.cmbDeparture.Size = new System.Drawing.Size(207, 21);
            this.cmbDeparture.TabIndex = 130;
            this.cmbDeparture.SelectedIndexChanged += new System.EventHandler(this.cmbDeparture_SelectedIndexChanged);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(401, 327);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(159, 28);
            this.lblDepartureTime.TabIndex = 129;
            this.lblDepartureTime.Text = "Departure Time:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(643, 464);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(129, 38);
            this.btnCreate.TabIndex = 128;
            this.btnCreate.Text = "Book";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(176, 269);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(167, 20);
            this.txtPrice.TabIndex = 127;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(27, 258);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(120, 28);
            this.pricelbl.TabIndex = 126;
            this.pricelbl.Text = "Flight Price:";
            // 
            // Deptlbl
            // 
            this.Deptlbl.AutoSize = true;
            this.Deptlbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deptlbl.Location = new System.Drawing.Point(23, 110);
            this.Deptlbl.Name = "Deptlbl";
            this.Deptlbl.Size = new System.Drawing.Size(109, 28);
            this.Deptlbl.TabIndex = 125;
            this.Deptlbl.Text = "Departure:";
            // 
            // destlbl
            // 
            this.destlbl.AutoSize = true;
            this.destlbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destlbl.Location = new System.Drawing.Point(23, 149);
            this.destlbl.Name = "destlbl";
            this.destlbl.Size = new System.Drawing.Size(122, 28);
            this.destlbl.TabIndex = 124;
            this.destlbl.Text = "Destination:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(490, 206);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(169, 20);
            this.txtCapacity.TabIndex = 123;
            // 
            // capacitylbl
            // 
            this.capacitylbl.AutoSize = true;
            this.capacitylbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacitylbl.Location = new System.Drawing.Point(401, 196);
            this.capacitylbl.Name = "capacitylbl";
            this.capacitylbl.Size = new System.Drawing.Size(94, 28);
            this.capacitylbl.TabIndex = 122;
            this.capacitylbl.Text = "Capacity:";
            // 
            // FlightNolbl
            // 
            this.FlightNolbl.AutoSize = true;
            this.FlightNolbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightNolbl.Location = new System.Drawing.Point(27, 206);
            this.FlightNolbl.Name = "FlightNolbl";
            this.FlightNolbl.Size = new System.Drawing.Size(101, 28);
            this.FlightNolbl.TabIndex = 121;
            this.FlightNolbl.Text = "Flight No:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(-4, 517);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 10);
            this.panel3.TabIndex = 149;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(258, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // BookFlightNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(790, 528);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CountryDepartureCMB);
            this.Controls.Add(this.CountryDistCMD);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countydeparttxt);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statuslbl);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookFlightNew";
            this.Text = "BookFlight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryDepartureCMB;
        private System.Windows.Forms.ComboBox CountryDistCMD;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countydeparttxt;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.DateTimePicker dateDepartureTime;
        private System.Windows.Forms.DateTimePicker dateDepartureDate;
        private System.Windows.Forms.DateTimePicker dateArrivalDate;
        private System.Windows.Forms.DateTimePicker dateArrivalTime;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCreateFlight;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.ComboBox cmbDeparture;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label Deptlbl;
        private System.Windows.Forms.Label destlbl;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label capacitylbl;
        private System.Windows.Forms.Label FlightNolbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}