namespace Happy_Journey_Airline.Frontend
{
    partial class AddAirport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAirport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFlightno = new System.Windows.Forms.Label();
            this.CityCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryCB = new System.Windows.Forms.ComboBox();
            this.lblAirport = new System.Windows.Forms.Label();
            this.txtAirport = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblAddAirport);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 78);
            this.panel1.TabIndex = 71;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddAirport.Location = new System.Drawing.Point(380, 0);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(304, 72);
            this.lblAddAirport.TabIndex = 3;
            this.lblAddAirport.Text = "Add Airport";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 17);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 41);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-3, 543);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 16);
            this.panel2.TabIndex = 130;
            // 
            // lblFlightno
            // 
            this.lblFlightno.AutoSize = true;
            this.lblFlightno.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightno.Location = new System.Drawing.Point(211, 239);
            this.lblFlightno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightno.Name = "lblFlightno";
            this.lblFlightno.Size = new System.Drawing.Size(141, 32);
            this.lblFlightno.TabIndex = 131;
            this.lblFlightno.Text = "Choose City:";
            // 
            // CityCB
            // 
            this.CityCB.FormattingEnabled = true;
            this.CityCB.Location = new System.Drawing.Point(420, 247);
            this.CityCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CityCB.Name = "CityCB";
            this.CityCB.Size = new System.Drawing.Size(261, 24);
            this.CityCB.TabIndex = 132;
            this.CityCB.SelectedIndexChanged += new System.EventHandler(this.cmbFlightClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 133;
            this.label1.Text = "Country:";
            // 
            // CountryCB
            // 
            this.CountryCB.FormattingEnabled = true;
            this.CountryCB.Location = new System.Drawing.Point(420, 142);
            this.CountryCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountryCB.Name = "CountryCB";
            this.CountryCB.Size = new System.Drawing.Size(261, 24);
            this.CountryCB.TabIndex = 134;
            this.CountryCB.SelectedIndexChanged += new System.EventHandler(this.CountryCB_SelectedIndexChanged);
            // 
            // lblAirport
            // 
            this.lblAirport.AutoSize = true;
            this.lblAirport.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirport.Location = new System.Drawing.Point(220, 345);
            this.lblAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirport.Name = "lblAirport";
            this.lblAirport.Size = new System.Drawing.Size(162, 32);
            this.lblAirport.TabIndex = 136;
            this.lblAirport.Text = "Airport Name:";
            // 
            // txtAirport
            // 
            this.txtAirport.Location = new System.Drawing.Point(421, 351);
            this.txtAirport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAirport.Name = "txtAirport";
            this.txtAirport.Size = new System.Drawing.Size(261, 22);
            this.txtAirport.TabIndex = 137;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(360, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(448, 441);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 47);
            this.btnAdd.TabIndex = 138;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAirport);
            this.Controls.Add(this.lblAirport);
            this.Controls.Add(this.CountryCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityCB);
            this.Controls.Add(this.lblFlightno);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddAirport";
            this.Text = "AddAirport";
            this.Load += new System.EventHandler(this.AddAirport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFlightno;
        private System.Windows.Forms.ComboBox CityCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CountryCB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAirport;
        private System.Windows.Forms.TextBox txtAirport;
        private System.Windows.Forms.Button btnAdd;
    }
}