namespace Happy_Journey_Airline.Frontend
{
    partial class viewAirports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewAirports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAirport = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.gridFlight = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdateAirport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblAirport);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 79);
            this.panel1.TabIndex = 93;
            // 
            // lblAirport
            // 
            this.lblAirport.AutoSize = true;
            this.lblAirport.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAirport.Location = new System.Drawing.Point(397, 2);
            this.lblAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirport.Name = "lblAirport";
            this.lblAirport.Size = new System.Drawing.Size(223, 72);
            this.lblAirport.TabIndex = 3;
            this.lblAirport.Text = "Airports";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 16);
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
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 12);
            this.panel2.TabIndex = 101;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(44, 119);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(210, 35);
            this.lblDesc.TabIndex = 102;
            this.lblDesc.Text = "Current Airports:";
            // 
            // gridFlight
            // 
            this.gridFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFlight.Location = new System.Drawing.Point(51, 174);
            this.gridFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridFlight.Name = "gridFlight";
            this.gridFlight.RowHeadersWidth = 51;
            this.gridFlight.Size = new System.Drawing.Size(680, 321);
            this.gridFlight.TabIndex = 103;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(739, 174);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 39);
            this.btnAdd.TabIndex = 104;
            this.btnAdd.Text = "Add Airport";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(739, 310);
            this.btndel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(209, 39);
            this.btndel.TabIndex = 105;
            this.btndel.Text = "Delete Airport";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdateAirport
            // 
            this.btnupdateAirport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdateAirport.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateAirport.Location = new System.Drawing.Point(739, 455);
            this.btnupdateAirport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdateAirport.Name = "btnupdateAirport";
            this.btnupdateAirport.Size = new System.Drawing.Size(209, 39);
            this.btnupdateAirport.TabIndex = 106;
            this.btnupdateAirport.Text = "Update Airport";
            this.btnupdateAirport.UseVisualStyleBackColor = false;
            this.btnupdateAirport.Click += new System.EventHandler(this.btnupdateFlight_Click);
            // 
            // viewAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnupdateAirport);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridFlight);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "viewAirports";
            this.Text = "viewAirports";
            this.Load += new System.EventHandler(this.viewAirports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAirport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.DataGridView gridFlight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdateAirport;
    }
}