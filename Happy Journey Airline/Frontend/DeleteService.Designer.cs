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
            this.Deltitlelbl = new System.Windows.Forms.Label();
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.delbtn = new System.Windows.Forms.Button();
            this.DelServicecmb = new System.Windows.Forms.ComboBox();
            this.servicelbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            this.SuspendLayout();
            // 
            // Deltitlelbl
            // 
            this.Deltitlelbl.AutoSize = true;
            this.Deltitlelbl.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deltitlelbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Deltitlelbl.Location = new System.Drawing.Point(283, 9);
            this.Deltitlelbl.Name = "Deltitlelbl";
            this.Deltitlelbl.Size = new System.Drawing.Size(245, 41);
            this.Deltitlelbl.TabIndex = 13;
            this.Deltitlelbl.Text = "Delete Service";
            // 
            // dataGridService
            // 
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Location = new System.Drawing.Point(235, 164);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.Size = new System.Drawing.Size(355, 150);
            this.dataGridService.TabIndex = 90;
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(325, 353);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(157, 32);
            this.delbtn.TabIndex = 89;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            // 
            // DelServicecmb
            // 
            this.DelServicecmb.FormattingEnabled = true;
            this.DelServicecmb.Location = new System.Drawing.Point(312, 116);
            this.DelServicecmb.Name = "DelServicecmb";
            this.DelServicecmb.Size = new System.Drawing.Size(199, 21);
            this.DelServicecmb.TabIndex = 88;
            // 
            // servicelbl
            // 
            this.servicelbl.AutoSize = true;
            this.servicelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicelbl.Location = new System.Drawing.Point(21, 111);
            this.servicelbl.Name = "servicelbl";
            this.servicelbl.Size = new System.Drawing.Size(149, 24);
            this.servicelbl.TabIndex = 87;
            this.servicelbl.Text = "Choose Service:";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(672, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 91;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // DeleteService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridService);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.DelServicecmb);
            this.Controls.Add(this.servicelbl);
            this.Controls.Add(this.Deltitlelbl);
            this.Name = "DeleteService";
            this.Text = "DeleteService";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Deltitlelbl;
        private System.Windows.Forms.DataGridView dataGridService;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.ComboBox DelServicecmb;
        private System.Windows.Forms.Label servicelbl;
        private System.Windows.Forms.Button backbtn;
    }
}