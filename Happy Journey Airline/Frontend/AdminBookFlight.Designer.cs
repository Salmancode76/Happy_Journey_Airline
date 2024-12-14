namespace Happy_Journey_Airline
{
    partial class AdminBookFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookFlight));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtTraveler = new System.Windows.Forms.TextBox();
            this.lbltraveler = new System.Windows.Forms.Label();
            this.cmbFlightClass = new System.Windows.Forms.ComboBox();
            this.lblFlightClass = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtFlightno = new System.Windows.Forms.TextBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblFlightno = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblBook);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 60);
            this.panel1.TabIndex = 70;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBook.Location = new System.Drawing.Point(286, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(237, 58);
            this.lblBook.TabIndex = 3;
            this.lblBook.Text = "Book Flight";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 33);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(1, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 10);
            this.panel3.TabIndex = 100;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(573, 243);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 121;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(437, 241);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 24);
            this.lblTo.TabIndex = 120;
            this.lblTo.Text = "To:";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(183, 243);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 119;
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.Location = new System.Drawing.Point(30, 241);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(58, 24);
            this.lblfrom.TabIndex = 118;
            this.lblfrom.Text = "From:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(437, 296);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 28);
            this.lblStatus.TabIndex = 117;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(576, 296);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(197, 20);
            this.txtStatus.TabIndex = 116;
            // 
            // txtTraveler
            // 
            this.txtTraveler.Location = new System.Drawing.Point(576, 193);
            this.txtTraveler.Name = "txtTraveler";
            this.txtTraveler.Size = new System.Drawing.Size(197, 20);
            this.txtTraveler.TabIndex = 115;
            // 
            // lbltraveler
            // 
            this.lbltraveler.AutoSize = true;
            this.lbltraveler.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltraveler.Location = new System.Drawing.Point(437, 191);
            this.lbltraveler.Name = "lbltraveler";
            this.lbltraveler.Size = new System.Drawing.Size(138, 24);
            this.lbltraveler.TabIndex = 114;
            this.lbltraveler.Text = "No of Travelers:";
            // 
            // cmbFlightClass
            // 
            this.cmbFlightClass.FormattingEnabled = true;
            this.cmbFlightClass.Location = new System.Drawing.Point(576, 137);
            this.cmbFlightClass.Name = "cmbFlightClass";
            this.cmbFlightClass.Size = new System.Drawing.Size(197, 21);
            this.cmbFlightClass.TabIndex = 113;
            // 
            // lblFlightClass
            // 
            this.lblFlightClass.AutoSize = true;
            this.lblFlightClass.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightClass.Location = new System.Drawing.Point(437, 135);
            this.lblFlightClass.Name = "lblFlightClass";
            this.lblFlightClass.Size = new System.Drawing.Size(108, 24);
            this.lblFlightClass.TabIndex = 112;
            this.lblFlightClass.Text = "Flight Class:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(484, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 38);
            this.btnSearch.TabIndex = 111;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(349, 117);
            this.dataGridView1.TabIndex = 110;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(576, 79);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(197, 20);
            this.txtSeat.TabIndex = 109;
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(183, 189);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(197, 20);
            this.txtDepart.TabIndex = 108;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(183, 137);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(197, 20);
            this.txtDest.TabIndex = 107;
            // 
            // txtFlightno
            // 
            this.txtFlightno.Location = new System.Drawing.Point(183, 81);
            this.txtFlightno.Name = "txtFlightno";
            this.txtFlightno.Size = new System.Drawing.Size(197, 20);
            this.txtFlightno.TabIndex = 106;
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.Location = new System.Drawing.Point(437, 77);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(77, 24);
            this.lblSeat.TabIndex = 105;
            this.lblSeat.Text = "Seat No:";
            // 
            // lblFlightno
            // 
            this.lblFlightno.AutoSize = true;
            this.lblFlightno.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightno.Location = new System.Drawing.Point(30, 81);
            this.lblFlightno.Name = "lblFlightno";
            this.lblFlightno.Size = new System.Drawing.Size(86, 24);
            this.lblFlightno.TabIndex = 104;
            this.lblFlightno.Text = "Flight no:";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(30, 191);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(97, 24);
            this.lblDepart.TabIndex = 103;
            this.lblDepart.Text = "Departure:";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(30, 135);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(107, 24);
            this.lblDes.TabIndex = 102;
            this.lblDes.Text = "Destination:";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBook.FlatAppearance.BorderSize = 4;
            this.btnBook.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBook.Location = new System.Drawing.Point(659, 390);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(129, 38);
            this.btnBook.TabIndex = 101;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(268, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(440, 341);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 28);
            this.lblUser.TabIndex = 123;
            this.lblUser.Text = "User:";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(576, 348);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 124;
            // 
            // AdminBookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtTraveler);
            this.Controls.Add(this.lbltraveler);
            this.Controls.Add(this.cmbFlightClass);
            this.Controls.Add(this.lblFlightClass);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminBookFlight";
            this.Text = "AdminBookFlight";
            this.Load += new System.EventHandler(this.AdminBookFlight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtTraveler;
        private System.Windows.Forms.Label lbltraveler;
        private System.Windows.Forms.ComboBox cmbFlightClass;
        private System.Windows.Forms.Label lblFlightClass;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtFlightno;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblFlightno;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}