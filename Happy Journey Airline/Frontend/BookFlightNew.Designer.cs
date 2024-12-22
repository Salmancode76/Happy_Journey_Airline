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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryDepartureCMB
            // 
            this.CountryDepartureCMB.FormattingEnabled = true;
            this.CountryDepartureCMB.Location = new System.Drawing.Point(807, 136);
            this.CountryDepartureCMB.Name = "CountryDepartureCMB";
            this.CountryDepartureCMB.Size = new System.Drawing.Size(222, 24);
            this.CountryDepartureCMB.TabIndex = 148;
            // 
            // CountryDistCMD
            // 
            this.CountryDistCMD.FormattingEnabled = true;
            this.CountryDistCMD.Location = new System.Drawing.Point(807, 193);
            this.CountryDistCMD.Name = "CountryDistCMD";
            this.CountryDistCMD.Size = new System.Drawing.Size(222, 24);
            this.CountryDistCMD.TabIndex = 147;
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(202, 193);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(275, 24);
            this.cmbDestination.TabIndex = 146;
            this.cmbDestination.SelectedIndexChanged += new System.EventHandler(this.cmbDestination_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 35);
            this.label1.TabIndex = 145;
            this.label1.Text = "Country of Distination:";
            // 
            // countydeparttxt
            // 
            this.countydeparttxt.AutoSize = true;
            this.countydeparttxt.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countydeparttxt.Location = new System.Drawing.Point(535, 125);
            this.countydeparttxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countydeparttxt.Name = "countydeparttxt";
            this.countydeparttxt.Size = new System.Drawing.Size(264, 35);
            this.countydeparttxt.TabIndex = 144;
            this.countydeparttxt.Text = "Country of Departure:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(649, 318);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(261, 24);
            this.cmbStatus.TabIndex = 143;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 255);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 142;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(-98, 429);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 35);
            this.lblErrorMessage.TabIndex = 141;
            // 
            // dateDepartureTime
            // 
            this.dateDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateDepartureTime.Location = new System.Drawing.Point(745, 413);
            this.dateDepartureTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDepartureTime.Name = "dateDepartureTime";
            this.dateDepartureTime.Size = new System.Drawing.Size(221, 22);
            this.dateDepartureTime.TabIndex = 140;
            // 
            // dateDepartureDate
            // 
            this.dateDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDepartureDate.Location = new System.Drawing.Point(235, 416);
            this.dateDepartureDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDepartureDate.Name = "dateDepartureDate";
            this.dateDepartureDate.Size = new System.Drawing.Size(261, 22);
            this.dateDepartureDate.TabIndex = 139;
            // 
            // dateArrivalDate
            // 
            this.dateArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateArrivalDate.Location = new System.Drawing.Point(235, 504);
            this.dateArrivalDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateArrivalDate.Name = "dateArrivalDate";
            this.dateArrivalDate.Size = new System.Drawing.Size(222, 22);
            this.dateArrivalDate.TabIndex = 138;
            // 
            // dateArrivalTime
            // 
            this.dateArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateArrivalTime.Location = new System.Drawing.Point(736, 517);
            this.dateArrivalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateArrivalTime.Name = "dateArrivalTime";
            this.dateArrivalTime.Size = new System.Drawing.Size(222, 22);
            this.dateArrivalTime.TabIndex = 137;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(36, 406);
            this.lblDepartureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(197, 35);
            this.lblDepartureDate.TabIndex = 136;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(31, 494);
            this.lblArrivalDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(161, 35);
            this.lblArrivalDate.TabIndex = 135;
            this.lblArrivalDate.Text = "Arrival Date:";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(535, 504);
            this.lblArrivalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(167, 35);
            this.lblArrivalTime.TabIndex = 134;
            this.lblArrivalTime.Text = "Arrival Time:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblCreateFlight);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 79);
            this.panel1.TabIndex = 132;
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
            this.lblCreateFlight.Size = new System.Drawing.Size(297, 72);
            this.lblCreateFlight.TabIndex = 3;
            this.lblCreateFlight.Text = "Book Flight";
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(535, 307);
            this.statuslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(92, 35);
            this.statuslbl.TabIndex = 131;
            this.statuslbl.Text = "Status:";
            // 
            // cmbDeparture
            // 
            this.cmbDeparture.DropDownWidth = 221;
            this.cmbDeparture.FormattingEnabled = true;
            this.cmbDeparture.Location = new System.Drawing.Point(202, 136);
            this.cmbDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDeparture.Name = "cmbDeparture";
            this.cmbDeparture.Size = new System.Drawing.Size(275, 24);
            this.cmbDeparture.TabIndex = 130;
            this.cmbDeparture.SelectedIndexChanged += new System.EventHandler(this.cmbDeparture_SelectedIndexChanged);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(535, 403);
            this.lblDepartureTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(203, 35);
            this.lblDepartureTime.TabIndex = 129;
            this.lblDepartureTime.Text = "Departure Time:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(857, 571);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 47);
            this.btnCreate.TabIndex = 128;
            this.btnCreate.Text = "Book";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(235, 331);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(221, 22);
            this.txtPrice.TabIndex = 127;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(36, 318);
            this.pricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(153, 35);
            this.pricelbl.TabIndex = 126;
            this.pricelbl.Text = "Flight Price:";
            // 
            // Deptlbl
            // 
            this.Deptlbl.AutoSize = true;
            this.Deptlbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deptlbl.Location = new System.Drawing.Point(31, 136);
            this.Deptlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Deptlbl.Name = "Deptlbl";
            this.Deptlbl.Size = new System.Drawing.Size(138, 35);
            this.Deptlbl.TabIndex = 125;
            this.Deptlbl.Text = "Departure:";
            // 
            // destlbl
            // 
            this.destlbl.AutoSize = true;
            this.destlbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destlbl.Location = new System.Drawing.Point(31, 183);
            this.destlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destlbl.Name = "destlbl";
            this.destlbl.Size = new System.Drawing.Size(154, 35);
            this.destlbl.TabIndex = 124;
            this.destlbl.Text = "Destination:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(653, 253);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(224, 22);
            this.txtCapacity.TabIndex = 123;
            // 
            // capacitylbl
            // 
            this.capacitylbl.AutoSize = true;
            this.capacitylbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacitylbl.Location = new System.Drawing.Point(535, 241);
            this.capacitylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capacitylbl.Name = "capacitylbl";
            this.capacitylbl.Size = new System.Drawing.Size(119, 35);
            this.capacitylbl.TabIndex = 122;
            this.capacitylbl.Text = "Capacity:";
            // 
            // FlightNolbl
            // 
            this.FlightNolbl.AutoSize = true;
            this.FlightNolbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightNolbl.Location = new System.Drawing.Point(36, 253);
            this.FlightNolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FlightNolbl.Name = "FlightNolbl";
            this.FlightNolbl.Size = new System.Drawing.Size(127, 35);
            this.FlightNolbl.TabIndex = 121;
            this.FlightNolbl.Text = "Flight No:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(385, 285);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // BookFlightNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 650);
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
    }
}