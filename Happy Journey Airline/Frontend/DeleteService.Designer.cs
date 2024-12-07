namespace Happy_Journey_Airline
{
    partial class DeleteService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteService));
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.btndel = new System.Windows.Forms.Button();
            this.cmbDel = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.lblDelFlight = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridService
            // 
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Location = new System.Drawing.Point(235, 164);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.Size = new System.Drawing.Size(355, 150);
            this.dataGridService.TabIndex = 90;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(325, 353);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(157, 32);
            this.btndel.TabIndex = 89;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // cmbDel
            // 
            this.cmbDel.FormattingEnabled = true;
            this.cmbDel.Location = new System.Drawing.Point(312, 116);
            this.cmbDel.Name = "cmbDel";
            this.cmbDel.Size = new System.Drawing.Size(199, 21);
            this.cmbDel.TabIndex = 88;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(21, 111);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(153, 28);
            this.lblService.TabIndex = 87;
            this.lblService.Text = "Choose Service:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.lblDelFlight);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 61);
            this.panel1.TabIndex = 101;
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
            // lblDelFlight
            // 
            this.lblDelFlight.AutoSize = true;
            this.lblDelFlight.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelFlight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDelFlight.Location = new System.Drawing.Point(3, 0);
            this.lblDelFlight.Name = "lblDelFlight";
            this.lblDelFlight.Size = new System.Drawing.Size(292, 58);
            this.lblDelFlight.TabIndex = 3;
            this.lblDelFlight.Text = "Delete Service";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-2, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 10);
            this.panel2.TabIndex = 106;
            // 
            // DeleteService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridService);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.cmbDel);
            this.Controls.Add(this.lblService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteService";
            this.Text = "DeleteService";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridService;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.ComboBox cmbDel;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblDelFlight;
        private System.Windows.Forms.Panel panel2;
    }
}