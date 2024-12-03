namespace Happy_Journey_Airline
{
    partial class AdminServices
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
            this.serlbl = new System.Windows.Forms.Label();
            this.servicelbl = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.SubGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SubGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // serlbl
            // 
            this.serlbl.AutoSize = true;
            this.serlbl.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serlbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.serlbl.Location = new System.Drawing.Point(320, 9);
            this.serlbl.Name = "serlbl";
            this.serlbl.Size = new System.Drawing.Size(147, 41);
            this.serlbl.TabIndex = 9;
            this.serlbl.Text = "Services";
            // 
            // servicelbl
            // 
            this.servicelbl.AutoSize = true;
            this.servicelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicelbl.Location = new System.Drawing.Point(31, 89);
            this.servicelbl.Name = "servicelbl";
            this.servicelbl.Size = new System.Drawing.Size(154, 24);
            this.servicelbl.TabIndex = 79;
            this.servicelbl.Text = "Current Services:";
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.Location = new System.Drawing.Point(575, 116);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(157, 32);
            this.createbtn.TabIndex = 86;
            this.createbtn.Text = "Create Service";
            this.createbtn.UseVisualStyleBackColor = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(575, 234);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(157, 32);
            this.Deletebtn.TabIndex = 85;
            this.Deletebtn.Text = "Delete Service";
            this.Deletebtn.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(575, 345);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(157, 32);
            this.updatebtn.TabIndex = 84;
            this.updatebtn.Text = "Update Service";
            this.updatebtn.UseVisualStyleBackColor = false;
            // 
            // SubGridView
            // 
            this.SubGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubGridView.Location = new System.Drawing.Point(35, 116);
            this.SubGridView.Name = "SubGridView";
            this.SubGridView.Size = new System.Drawing.Size(510, 261);
            this.SubGridView.TabIndex = 83;
            // 
            // AdminServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.SubGridView);
            this.Controls.Add(this.servicelbl);
            this.Controls.Add(this.serlbl);
            this.Name = "AdminServices";
            this.Text = "AdminServices";
            ((System.ComponentModel.ISupportInitialize)(this.SubGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serlbl;
        private System.Windows.Forms.Label servicelbl;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.DataGridView SubGridView;
    }
}