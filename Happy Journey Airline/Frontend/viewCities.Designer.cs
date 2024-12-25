namespace Happy_Journey_Airline.Frontend
{
    partial class viewCities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewCities));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCities = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.gridFlight = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdateCity = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblCities);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 84);
            this.panel1.TabIndex = 93;
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCities.Location = new System.Drawing.Point(433, 0);
            this.lblCities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(162, 72);
            this.lblCities.TabIndex = 3;
            this.lblCities.Text = "Cities";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 15);
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
            this.panel2.TabIndex = 102;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(52, 130);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(182, 35);
            this.lblDesc.TabIndex = 103;
            this.lblDesc.Text = "Current Cities:";
            // 
            // gridFlight
            // 
            this.gridFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFlight.Location = new System.Drawing.Point(59, 169);
            this.gridFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridFlight.Name = "gridFlight";
            this.gridFlight.RowHeadersWidth = 51;
            this.gridFlight.Size = new System.Drawing.Size(680, 321);
            this.gridFlight.TabIndex = 104;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(747, 169);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 39);
            this.btnAdd.TabIndex = 105;
            this.btnAdd.Text = "Add City";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(747, 303);
            this.btndel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(209, 39);
            this.btndel.TabIndex = 106;
            this.btndel.Text = "Delete City";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdateCity
            // 
            this.btnupdateCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdateCity.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateCity.Location = new System.Drawing.Point(747, 450);
            this.btnupdateCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdateCity.Name = "btnupdateCity";
            this.btnupdateCity.Size = new System.Drawing.Size(209, 39);
            this.btnupdateCity.TabIndex = 107;
            this.btnupdateCity.Text = "Update City";
            this.btnupdateCity.UseVisualStyleBackColor = false;
            this.btnupdateCity.Click += new System.EventHandler(this.btnupdateFlight_Click);
            // 
            // viewCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnupdateCity);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridFlight);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "viewCities";
            this.Text = "viewCities";
            this.Load += new System.EventHandler(this.viewCities_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.DataGridView gridFlight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdateCity;
    }
}