namespace Happy_Journey_Airline
{
    partial class DeleteBooking
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
            this.gridBooking = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.DelBookingcmb = new System.Windows.Forms.ComboBox();
            this.lbldes = new System.Windows.Forms.Label();
            this.lblDel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBooking
            // 
            this.gridBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooking.Location = new System.Drawing.Point(219, 161);
            this.gridBooking.Name = "gridBooking";
            this.gridBooking.Size = new System.Drawing.Size(355, 150);
            this.gridBooking.TabIndex = 88;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(675, 9);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 87;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(305, 352);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(157, 32);
            this.btnDel.TabIndex = 86;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // DelBookingcmb
            // 
            this.DelBookingcmb.FormattingEnabled = true;
            this.DelBookingcmb.Location = new System.Drawing.Point(290, 104);
            this.DelBookingcmb.Name = "DelBookingcmb";
            this.DelBookingcmb.Size = new System.Drawing.Size(199, 21);
            this.DelBookingcmb.TabIndex = 85;
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes.Location = new System.Drawing.Point(25, 101);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(155, 24);
            this.lbldes.TabIndex = 84;
            this.lbldes.Text = "Choose Booking:";
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDel.Location = new System.Drawing.Point(268, 9);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(266, 41);
            this.lblDel.TabIndex = 83;
            this.lblDel.Text = "Delete Booking";
            // 
            // DeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridBooking);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.DelBookingcmb);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.lblDel);
            this.Name = "DeleteBooking";
            this.Text = "DeleteBooking";
            ((System.ComponentModel.ISupportInitialize)(this.gridBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBooking;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox DelBookingcmb;
        private System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.Label lblDel;
    }
}