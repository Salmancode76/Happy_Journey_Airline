namespace Happy_Journey_Airline
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            this.desclbl = new System.Windows.Forms.Label();
            this.btnusers = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnmessage = new System.Windows.Forms.Button();
            this.btnbooking = new System.Windows.Forms.Button();
            this.btnservices = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subscribersScreen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(63, 96);
            this.desclbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(405, 43);
            this.desclbl.TabIndex = 49;
            this.desclbl.Text = "Welcome to the Dashboard.";
            // 
            // btnusers
            // 
            this.btnusers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnusers.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusers.Location = new System.Drawing.Point(71, 193);
            this.btnusers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(209, 39);
            this.btnusers.TabIndex = 68;
            this.btnusers.Text = "View Users";
            this.btnusers.UseVisualStyleBackColor = false;
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSub.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(408, 193);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(209, 39);
            this.btnSub.TabIndex = 69;
            this.btnSub.Text = "View Subscriptions";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnFlights
            // 
            this.btnFlights.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFlights.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.Location = new System.Drawing.Point(408, 289);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(209, 39);
            this.btnFlights.TabIndex = 70;
            this.btnFlights.Text = "View Flights";
            this.btnFlights.UseVisualStyleBackColor = false;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // btnmessage
            // 
            this.btnmessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmessage.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmessage.Location = new System.Drawing.Point(71, 289);
            this.btnmessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(209, 39);
            this.btnmessage.TabIndex = 71;
            this.btnmessage.Text = "View Messages";
            this.btnmessage.UseVisualStyleBackColor = false;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // btnbooking
            // 
            this.btnbooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbooking.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooking.Location = new System.Drawing.Point(729, 289);
            this.btnbooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(209, 39);
            this.btnbooking.TabIndex = 72;
            this.btnbooking.Text = "View Bookings";
            this.btnbooking.UseVisualStyleBackColor = false;
            this.btnbooking.Click += new System.EventHandler(this.bookingbtn_Click);
            // 
            // btnservices
            // 
            this.btnservices.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnservices.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservices.Location = new System.Drawing.Point(729, 193);
            this.btnservices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnservices.Name = "btnservices";
            this.btnservices.Size = new System.Drawing.Size(209, 39);
            this.btnservices.TabIndex = 73;
            this.btnservices.Text = "View Services";
            this.btnservices.UseVisualStyleBackColor = false;
            this.btnservices.Click += new System.EventHandler(this.btnservices_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 74);
            this.panel1.TabIndex = 92;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDashboard.Location = new System.Drawing.Point(397, 2);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(280, 72);
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "Dashboard";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(19, 16);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 41);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-3, 542);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 12);
            this.panel2.TabIndex = 94;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddAirport.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAirport.Location = new System.Drawing.Point(71, 387);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(209, 39);
            this.btnAddAirport.TabIndex = 95;
            this.btnAddAirport.Text = "View Airports";
            this.btnAddAirport.UseVisualStyleBackColor = false;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCountry.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCountry.Location = new System.Drawing.Point(408, 387);
            this.btnAddCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(209, 39);
            this.btnAddCountry.TabIndex = 96;
            this.btnAddCountry.Text = "View Countries";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnCity
            // 
            this.btnCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCity.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCity.Location = new System.Drawing.Point(729, 387);
            this.btnCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(209, 39);
            this.btnCity.TabIndex = 97;
            this.btnCity.Text = "View Cities";
            this.btnCity.UseVisualStyleBackColor = false;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(382, 175);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // subscribersScreen
            // 
            this.subscribersScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subscribersScreen.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscribersScreen.Location = new System.Drawing.Point(71, 478);
            this.subscribersScreen.Margin = new System.Windows.Forms.Padding(4);
            this.subscribersScreen.Name = "subscribersScreen";
            this.subscribersScreen.Size = new System.Drawing.Size(209, 39);
            this.subscribersScreen.TabIndex = 98;
            this.subscribersScreen.Text = "View Subscribers";
            this.subscribersScreen.UseVisualStyleBackColor = false;
            this.subscribersScreen.Click += new System.EventHandler(this.subscribersScreen_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.subscribersScreen);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnservices);
            this.Controls.Add(this.btnbooking);
            this.Controls.Add(this.btnmessage);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnusers);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "adminDashboard";
            this.Text = "adminDashboard";
            this.Load += new System.EventHandler(this.adminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Button btnusers;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Button btnservices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Button subscribersScreen;
    }
}