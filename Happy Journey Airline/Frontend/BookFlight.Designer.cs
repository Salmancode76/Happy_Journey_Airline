namespace Happy_Journey_Airline
{
    partial class BookFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookFlight));
            this.btnBook = new System.Windows.Forms.Button();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblFlightno = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.txtFlightno = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.flightGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFlightClass = new System.Windows.Forms.Label();
            this.cmbFlightClass = new System.Windows.Forms.ComboBox();
            this.lbltraveler = new System.Windows.Forms.Label();
            this.txtTraveler = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.destDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.departDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblfrom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBook = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flightGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBook.FlatAppearance.BorderSize = 4;
            this.btnBook.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBook.Location = new System.Drawing.Point(591, 382);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(129, 38);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(32, 142);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(107, 24);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "Destination:";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(32, 198);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(97, 24);
            this.lblDepart.TabIndex = 4;
            this.lblDepart.Text = "Departure:";
            // 
            // lblFlightno
            // 
            this.lblFlightno.AutoSize = true;
            this.lblFlightno.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightno.Location = new System.Drawing.Point(32, 88);
            this.lblFlightno.Name = "lblFlightno";
            this.lblFlightno.Size = new System.Drawing.Size(86, 24);
            this.lblFlightno.TabIndex = 6;
            this.lblFlightno.Text = "Flight no:";
            this.lblFlightno.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.Location = new System.Drawing.Point(439, 84);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(77, 24);
            this.lblSeat.TabIndex = 8;
            this.lblSeat.Text = "Seat No:";
            this.lblSeat.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtFlightno
            // 
            this.txtFlightno.Location = new System.Drawing.Point(185, 88);
            this.txtFlightno.Name = "txtFlightno";
            this.txtFlightno.Size = new System.Drawing.Size(197, 20);
            this.txtFlightno.TabIndex = 10;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(185, 144);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(197, 20);
            this.txtDest.TabIndex = 13;
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(185, 196);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(197, 20);
            this.txtDepart.TabIndex = 15;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(578, 86);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(197, 20);
            this.txtSeat.TabIndex = 17;
            // 
            // flightGridView
            // 
            this.flightGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightGridView.Location = new System.Drawing.Point(36, 308);
            this.flightGridView.Name = "flightGridView";
            this.flightGridView.RowHeadersWidth = 51;
            this.flightGridView.Size = new System.Drawing.Size(349, 112);
            this.flightGridView.TabIndex = 23;
            this.flightGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(443, 382);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 38);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 33);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFlightClass
            // 
            this.lblFlightClass.AutoSize = true;
            this.lblFlightClass.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightClass.Location = new System.Drawing.Point(439, 142);
            this.lblFlightClass.Name = "lblFlightClass";
            this.lblFlightClass.Size = new System.Drawing.Size(108, 24);
            this.lblFlightClass.TabIndex = 26;
            this.lblFlightClass.Text = "Flight Class:";
            // 
            // cmbFlightClass
            // 
            this.cmbFlightClass.FormattingEnabled = true;
            this.cmbFlightClass.Location = new System.Drawing.Point(578, 144);
            this.cmbFlightClass.Name = "cmbFlightClass";
            this.cmbFlightClass.Size = new System.Drawing.Size(197, 21);
            this.cmbFlightClass.TabIndex = 27;
            // 
            // lbltraveler
            // 
            this.lbltraveler.AutoSize = true;
            this.lbltraveler.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltraveler.Location = new System.Drawing.Point(439, 198);
            this.lbltraveler.Name = "lbltraveler";
            this.lbltraveler.Size = new System.Drawing.Size(138, 24);
            this.lbltraveler.TabIndex = 28;
            this.lbltraveler.Text = "No of Travelers:";
            this.lbltraveler.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTraveler
            // 
            this.txtTraveler.Location = new System.Drawing.Point(578, 200);
            this.txtTraveler.Name = "txtTraveler";
            this.txtTraveler.Size = new System.Drawing.Size(197, 20);
            this.txtTraveler.TabIndex = 29;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(578, 303);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(197, 20);
            this.txtStatus.TabIndex = 37;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(439, 303);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 28);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "Status:";
            // 
            // destDatePicker
            // 
            this.destDatePicker.Location = new System.Drawing.Point(575, 250);
            this.destDatePicker.Name = "destDatePicker";
            this.destDatePicker.Size = new System.Drawing.Size(200, 20);
            this.destDatePicker.TabIndex = 68;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(439, 248);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 24);
            this.lblTo.TabIndex = 67;
            this.lblTo.Text = "To:";
            // 
            // departDatePicker
            // 
            this.departDatePicker.Location = new System.Drawing.Point(185, 250);
            this.departDatePicker.Name = "departDatePicker";
            this.departDatePicker.Size = new System.Drawing.Size(200, 20);
            this.departDatePicker.TabIndex = 66;
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.Location = new System.Drawing.Point(32, 248);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(58, 24);
            this.lblfrom.TabIndex = 65;
            this.lblfrom.Text = "From:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblBook);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 60);
            this.panel1.TabIndex = 69;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBook.Location = new System.Drawing.Point(283, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(237, 58);
            this.lblBook.TabIndex = 3;
            this.lblBook.Text = "Book Flight";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-4, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 27);
            this.panel2.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(-4, 437);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 19);
            this.panel3.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(270, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // BookFlight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.destDatePicker);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.departDatePicker);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtTraveler);
            this.Controls.Add(this.lbltraveler);
            this.Controls.Add(this.cmbFlightClass);
            this.Controls.Add(this.lblFlightClass);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.flightGridView);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtFlightno);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.lblFlightno);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 1000);
            this.Name = "BookFlight";
            this.Text = "BookFlight";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblFlightno;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.TextBox txtFlightno;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.DataGridView flightGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFlightClass;
        private System.Windows.Forms.ComboBox cmbFlightClass;
        private System.Windows.Forms.Label lbltraveler;
        private System.Windows.Forms.TextBox txtTraveler;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker destDatePicker;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker departDatePicker;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

