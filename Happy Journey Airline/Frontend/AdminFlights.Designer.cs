namespace Happy_Journey_Airline
{
    partial class AdminFlights
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
            this.lblFlights = new System.Windows.Forms.Label();
            this.lblFl = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdateFlight = new System.Windows.Forms.Button();
            this.gridFlight = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFlights
            // 
            this.lblFlights.AutoSize = true;
            this.lblFlights.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlights.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFlights.Location = new System.Drawing.Point(335, 9);
            this.lblFlights.Name = "lblFlights";
            this.lblFlights.Size = new System.Drawing.Size(134, 41);
            this.lblFlights.TabIndex = 11;
            this.lblFlights.Text = "Flights";
            // 
            // lblFl
            // 
            this.lblFl.AutoSize = true;
            this.lblFl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFl.Location = new System.Drawing.Point(30, 75);
            this.lblFl.Name = "lblFl";
            this.lblFl.Size = new System.Drawing.Size(137, 24);
            this.lblFl.TabIndex = 82;
            this.lblFl.Text = "Current Flights:";
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(563, 114);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(157, 32);
            this.btncreate.TabIndex = 81;
            this.btncreate.Text = "Create Flight";
            this.btncreate.UseVisualStyleBackColor = false;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(563, 232);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(157, 32);
            this.btndel.TabIndex = 80;
            this.btndel.Text = "Delete Flight";
            this.btndel.UseVisualStyleBackColor = false;
            // 
            // btnupdateFlight
            // 
            this.btnupdateFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdateFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateFlight.Location = new System.Drawing.Point(563, 343);
            this.btnupdateFlight.Name = "btnupdateFlight";
            this.btnupdateFlight.Size = new System.Drawing.Size(157, 32);
            this.btnupdateFlight.TabIndex = 79;
            this.btnupdateFlight.Text = "Update Flight";
            this.btnupdateFlight.UseVisualStyleBackColor = false;
            // 
            // gridFlight
            // 
            this.gridFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFlight.Location = new System.Drawing.Point(34, 114);
            this.gridFlight.Name = "gridFlight";
            this.gridFlight.Size = new System.Drawing.Size(510, 261);
            this.gridFlight.TabIndex = 78;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(681, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 83;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // AdminFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.lblFl);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdateFlight);
            this.Controls.Add(this.gridFlight);
            this.Controls.Add(this.lblFlights);
            this.Name = "AdminFlights";
            this.Text = "AdminFlights";
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlights;
        private System.Windows.Forms.Label lblFl;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdateFlight;
        private System.Windows.Forms.DataGridView gridFlight;
        private System.Windows.Forms.Button backbtn;
    }
}