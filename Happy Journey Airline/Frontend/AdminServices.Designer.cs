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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminServices));
            this.lblService = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SubGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSrvices = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SubGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(31, 89);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(168, 28);
            this.lblService.TabIndex = 79;
            this.lblService.Text = "Current Services:";
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncreate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(575, 116);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(157, 32);
            this.btncreate.TabIndex = 86;
            this.btncreate.Text = "Create Service";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(575, 234);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(157, 32);
            this.btnDel.TabIndex = 85;
            this.btnDel.Text = "Delete Service";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(575, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 32);
            this.btnUpdate.TabIndex = 84;
            this.btnUpdate.Text = "Update Service";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SubGridView
            // 
            this.SubGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubGridView.Location = new System.Drawing.Point(35, 116);
            this.SubGridView.Name = "SubGridView";
            this.SubGridView.RowHeadersWidth = 51;
            this.SubGridView.Size = new System.Drawing.Size(510, 261);
            this.SubGridView.TabIndex = 83;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblSrvices);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 61);
            this.panel1.TabIndex = 97;
            // 
            // lblSrvices
            // 
            this.lblSrvices.AutoSize = true;
            this.lblSrvices.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSrvices.Location = new System.Drawing.Point(289, 0);
            this.lblSrvices.Name = "lblSrvices";
            this.lblSrvices.Size = new System.Drawing.Size(181, 58);
            this.lblSrvices.TabIndex = 3;
            this.lblSrvices.Text = "Services";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 33);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 18);
            this.panel2.TabIndex = 98;
            // 
            // AdminServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.SubGridView);
            this.Controls.Add(this.lblService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminServices";
            this.Text = "AdminServices";
            this.Load += new System.EventHandler(this.AdminServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView SubGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSrvices;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
    }
}