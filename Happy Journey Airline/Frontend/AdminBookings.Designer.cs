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
            this.lblFl = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdateFlight = new System.Windows.Forms.Button();
            this.gridBookings = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFl
            // 
            this.lblFl.AutoSize = true;
            this.lblFl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFl.Location = new System.Drawing.Point(21, 89);
            this.lblFl.Name = "lblFl";
            this.lblFl.Size = new System.Drawing.Size(176, 28);
            this.lblFl.TabIndex = 89;
            this.lblFl.Text = "Current Bookings:";
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncreate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(554, 128);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(157, 32);
            this.btncreate.TabIndex = 88;
            this.btncreate.Text = "Create Booking";
            this.btncreate.UseVisualStyleBackColor = false;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(554, 236);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(157, 32);
            this.btndel.TabIndex = 87;
            this.btndel.Text = "Delete Booking";
            this.btndel.UseVisualStyleBackColor = false;
            // 
            // btnupdateFlight
            // 
            this.btnupdateFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdateFlight.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateFlight.Location = new System.Drawing.Point(554, 357);
            this.btnupdateFlight.Name = "btnupdateFlight";
            this.btnupdateFlight.Size = new System.Drawing.Size(157, 32);
            this.btnupdateFlight.TabIndex = 86;
            this.btnupdateFlight.Text = "Update Booking";
            this.btnupdateFlight.UseVisualStyleBackColor = false;
            // 
            // gridBookings
            // 
            this.gridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookings.Location = new System.Drawing.Point(25, 128);
            this.gridBookings.Name = "gridBookings";
            this.gridBookings.Size = new System.Drawing.Size(510, 261);
            this.gridBookings.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 62);
            this.panel1.TabIndex = 91;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(237, 58);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Book Flight";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(670, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-4, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 17);
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
            this.Controls.Add(this.lblFl);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdateFlight);
            this.Controls.Add(this.gridBookings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminBookings";
            this.Text = "AdminBookings";
            ((System.ComponentModel.ISupportInitialize)(this.gridBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFl;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdateFlight;
        private System.Windows.Forms.DataGridView gridBookings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}