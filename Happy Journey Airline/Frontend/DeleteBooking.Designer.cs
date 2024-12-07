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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBooking));
            this.gridBooking = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.cmbDelBooking = new System.Windows.Forms.ComboBox();
            this.lbldes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.lblDelBooking = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooking)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridBooking
            // 
            this.gridBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooking.Location = new System.Drawing.Point(219, 182);
            this.gridBooking.Name = "gridBooking";
            this.gridBooking.Size = new System.Drawing.Size(361, 150);
            this.gridBooking.TabIndex = 88;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(320, 366);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(157, 32);
            this.btnDel.TabIndex = 86;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbDelBooking
            // 
            this.cmbDelBooking.FormattingEnabled = true;
            this.cmbDelBooking.Location = new System.Drawing.Point(258, 117);
            this.cmbDelBooking.Name = "cmbDelBooking";
            this.cmbDelBooking.Size = new System.Drawing.Size(272, 21);
            this.cmbDelBooking.TabIndex = 85;
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes.Location = new System.Drawing.Point(31, 109);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(161, 28);
            this.lbldes.TabIndex = 84;
            this.lbldes.Text = "Choose Booking:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.lblDelBooking);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 62);
            this.panel1.TabIndex = 99;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(682, 15);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 33);
            this.btnback.TabIndex = 26;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblDelBooking
            // 
            this.lblDelBooking.AutoSize = true;
            this.lblDelBooking.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDelBooking.Location = new System.Drawing.Point(3, 0);
            this.lblDelBooking.Name = "lblDelBooking";
            this.lblDelBooking.Size = new System.Drawing.Size(305, 58);
            this.lblDelBooking.TabIndex = 3;
            this.lblDelBooking.Text = "Delete Booking";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 10);
            this.panel2.TabIndex = 104;
            // 
            // DeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridBooking);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cmbDelBooking);
            this.Controls.Add(this.lbldes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteBooking";
            this.Text = "DeleteBooking";
            ((System.ComponentModel.ISupportInitialize)(this.gridBooking)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBooking;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox cmbDelBooking;
        private System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblDelBooking;
        private System.Windows.Forms.Panel panel2;
    }
}