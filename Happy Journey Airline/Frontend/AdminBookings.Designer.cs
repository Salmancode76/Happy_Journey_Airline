﻿namespace Happy_Journey_Airline
{
    partial class AdminBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookings));
            this.lbdesc = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdateFlight = new System.Windows.Forms.Button();
            this.gridBookings = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBookings = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbdesc
            // 
            this.lbdesc.AutoSize = true;
            this.lbdesc.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdesc.Location = new System.Drawing.Point(21, 89);
            this.lbdesc.Name = "lbdesc";
            this.lbdesc.Size = new System.Drawing.Size(176, 28);
            this.lbdesc.TabIndex = 89;
            this.lbdesc.Text = "Current Bookings:";
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(554, 191);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(157, 32);
            this.btndel.TabIndex = 87;
            this.btndel.Text = "Delete Booking";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdateFlight
            // 
            this.btnupdateFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdateFlight.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateFlight.Location = new System.Drawing.Point(554, 332);
            this.btnupdateFlight.Name = "btnupdateFlight";
            this.btnupdateFlight.Size = new System.Drawing.Size(157, 32);
            this.btnupdateFlight.TabIndex = 86;
            this.btnupdateFlight.Text = "Update Booking";
            this.btnupdateFlight.UseVisualStyleBackColor = false;
            this.btnupdateFlight.Click += new System.EventHandler(this.btnupdateFlight_Click);
            // 
            // gridBookings
            // 
            this.gridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookings.Location = new System.Drawing.Point(25, 128);
            this.gridBookings.Name = "gridBookings";
            this.gridBookings.RowHeadersWidth = 51;
            this.gridBookings.Size = new System.Drawing.Size(510, 261);
            this.gridBookings.TabIndex = 85;
            this.gridBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookings_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblBookings);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 62);
            this.panel1.TabIndex = 91;
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookings.Location = new System.Drawing.Point(300, 0);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(194, 58);
            this.lblBookings.TabIndex = 3;
            this.lblBookings.Text = "Bookings";
            this.lblBookings.Click += new System.EventHandler(this.lblBokflight_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 33);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-4, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 17);
            this.panel2.TabIndex = 92;
            // 
            // AdminBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbdesc);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdateFlight);
            this.Controls.Add(this.gridBookings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminBookings";
            this.Text = "AdminBookings";
            this.Load += new System.EventHandler(this.AdminBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbdesc;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdateFlight;
        private System.Windows.Forms.DataGridView gridBookings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
    }
}