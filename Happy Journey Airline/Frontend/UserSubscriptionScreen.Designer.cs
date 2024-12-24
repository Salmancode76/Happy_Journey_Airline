namespace Happy_Journey_Airline
{
    partial class UserSubscriptionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSubscriptionScreen));
            this.lbldesc = new System.Windows.Forms.Label();
            this.subscriptionGrid = new System.Windows.Forms.DataGridView();
            this.subscribeBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubscriptions = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(47, 96);
            this.lbldesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(254, 35);
            this.lbldesc.TabIndex = 48;
            this.lbldesc.Text = "Please choose a plan:";
            // 
            // subscriptionGrid
            // 
            this.subscriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscriptionGrid.Location = new System.Drawing.Point(53, 149);
            this.subscriptionGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subscriptionGrid.Name = "subscriptionGrid";
            this.subscriptionGrid.RowHeadersWidth = 51;
            this.subscriptionGrid.Size = new System.Drawing.Size(772, 286);
            this.subscriptionGrid.TabIndex = 49;
            this.subscriptionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // subscribeBttn
            // 
            this.subscribeBttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subscribeBttn.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscribeBttn.Location = new System.Drawing.Point(840, 457);
            this.subscribeBttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subscribeBttn.Name = "subscribeBttn";
            this.subscribeBttn.Size = new System.Drawing.Size(172, 47);
            this.subscribeBttn.TabIndex = 67;
            this.subscribeBttn.Text = "Subscribe";
            this.subscribeBttn.UseVisualStyleBackColor = false;
            this.subscribeBttn.Click += new System.EventHandler(this.subscribeBttn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblSubscriptions);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 76);
            this.panel1.TabIndex = 89;
            // 
            // lblSubscriptions
            // 
            this.lblSubscriptions.AutoSize = true;
            this.lblSubscriptions.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubscriptions.Location = new System.Drawing.Point(312, 5);
            this.lblSubscriptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubscriptions.Name = "lblSubscriptions";
            this.lblSubscriptions.Size = new System.Drawing.Size(464, 72);
            this.lblSubscriptions.TabIndex = 3;
            this.lblSubscriptions.Text = "Subscription Plans";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(16, 20);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(143, 41);
            this.backbtn.TabIndex = 87;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 544);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 12);
            this.panel2.TabIndex = 90;
            // 
            // UserSubscriptionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.subscribeBttn);
            this.Controls.Add(this.subscriptionGrid);
            this.Controls.Add(this.lbldesc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserSubscriptionScreen";
            this.Text = "SubscriptionScreen";
            this.Load += new System.EventHandler(this.UserSubscriptionScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.DataGridView subscriptionGrid;
        private System.Windows.Forms.Button subscribeBttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubscriptions;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Panel panel2;
    }
}