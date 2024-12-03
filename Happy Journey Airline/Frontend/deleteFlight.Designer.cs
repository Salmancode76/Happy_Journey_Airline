namespace Happy_Journey_Airline
{
    partial class deleteFlight
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
            this.gridFlight = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.cmbDelFlight = new System.Windows.Forms.ComboBox();
            this.lbldelFlight = new System.Windows.Forms.Label();
            this.deluserlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFlight
            // 
            this.gridFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFlight.Location = new System.Drawing.Point(217, 161);
            this.gridFlight.Name = "gridFlight";
            this.gridFlight.Size = new System.Drawing.Size(355, 150);
            this.gridFlight.TabIndex = 88;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(673, 9);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 87;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(303, 352);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(157, 32);
            this.delbtn.TabIndex = 86;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            // 
            // cmbDelFlight
            // 
            this.cmbDelFlight.FormattingEnabled = true;
            this.cmbDelFlight.Location = new System.Drawing.Point(288, 104);
            this.cmbDelFlight.Name = "cmbDelFlight";
            this.cmbDelFlight.Size = new System.Drawing.Size(199, 21);
            this.cmbDelFlight.TabIndex = 85;
            // 
            // lbldelFlight
            // 
            this.lbldelFlight.AutoSize = true;
            this.lbldelFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelFlight.Location = new System.Drawing.Point(23, 101);
            this.lbldelFlight.Name = "lbldelFlight";
            this.lbldelFlight.Size = new System.Drawing.Size(268, 24);
            this.lbldelFlight.TabIndex = 84;
            this.lbldelFlight.Text = "Choose Flight from the system:";
            // 
            // deluserlbl
            // 
            this.deluserlbl.AutoSize = true;
            this.deluserlbl.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluserlbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.deluserlbl.Location = new System.Drawing.Point(266, 9);
            this.deluserlbl.Name = "deluserlbl";
            this.deluserlbl.Size = new System.Drawing.Size(232, 41);
            this.deluserlbl.TabIndex = 83;
            this.deluserlbl.Text = "Delete Flight";
            // 
            // deleteFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridFlight);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.cmbDelFlight);
            this.Controls.Add(this.lbldelFlight);
            this.Controls.Add(this.deluserlbl);
            this.Name = "deleteFlight";
            this.Text = "deleteFlight";
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFlight;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.ComboBox cmbDelFlight;
        private System.Windows.Forms.Label lbldelFlight;
        private System.Windows.Forms.Label deluserlbl;
    }
}