namespace Happy_Journey_Airline
{
    partial class adminSubscriptionsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminSubscriptionsScreen));
            this.lbldesc = new System.Windows.Forms.Label();
            this.subscriptiongrid = new System.Windows.Forms.DataGridView();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubscriptionOffers = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptiongrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(32, 108);
            this.lbldesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(188, 35);
            this.lbldesc.TabIndex = 78;
            this.lbldesc.Text = "Current Offers:";
            // 
            // subscriptiongrid
            // 
            this.subscriptiongrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscriptiongrid.Location = new System.Drawing.Point(37, 142);
            this.subscriptiongrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subscriptiongrid.Name = "subscriptiongrid";
            this.subscriptiongrid.RowHeadersWidth = 51;
            this.subscriptiongrid.Size = new System.Drawing.Size(680, 321);
            this.subscriptiongrid.TabIndex = 79;
            this.subscriptiongrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubGridView_CellContentClick);
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncreate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(757, 208);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(209, 39);
            this.btncreate.TabIndex = 82;
            this.btncreate.Text = "Create Subscription";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(757, 336);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(209, 39);
            this.btnDel.TabIndex = 81;
            this.btnDel.Text = "Delete Subscription";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblSubscriptionOffers);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 76);
            this.panel1.TabIndex = 97;
            // 
            // lblSubscriptionOffers
            // 
            this.lblSubscriptionOffers.AutoSize = true;
            this.lblSubscriptionOffers.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptionOffers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubscriptionOffers.Location = new System.Drawing.Point(295, 0);
            this.lblSubscriptionOffers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubscriptionOffers.Name = "lblSubscriptionOffers";
            this.lblSubscriptionOffers.Size = new System.Drawing.Size(483, 72);
            this.lblSubscriptionOffers.TabIndex = 3;
            this.lblSubscriptionOffers.Text = "Subscription Offers";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(15, 15);
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
            this.panel2.Location = new System.Drawing.Point(1, 542);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 12);
            this.panel2.TabIndex = 98;
            // 
            // adminSubscriptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.subscriptiongrid);
            this.Controls.Add(this.lbldesc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "adminSubscriptionsScreen";
            this.Text = "adminSubscriptionsScreen";
            this.Load += new System.EventHandler(this.adminSubscriptionsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subscriptiongrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.DataGridView subscriptiongrid;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubscriptionOffers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
    }
}