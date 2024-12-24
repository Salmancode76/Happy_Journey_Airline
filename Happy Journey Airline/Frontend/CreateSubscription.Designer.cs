namespace Happy_Journey_Airline
{
    partial class CreateSubscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSubscription));
            this.destxt = new System.Windows.Forms.TextBox();
            this.deslbl = new System.Windows.Forms.Label();
            this.subPricetxt = new System.Windows.Forms.TextBox();
            this.subPricelbl = new System.Windows.Forms.Label();
            this.subNametxt = new System.Windows.Forms.TextBox();
            this.subnamelbl = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCreateSub = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // destxt
            // 
            this.destxt.Location = new System.Drawing.Point(307, 373);
            this.destxt.Margin = new System.Windows.Forms.Padding(4);
            this.destxt.Multiline = true;
            this.destxt.Name = "destxt";
            this.destxt.Size = new System.Drawing.Size(432, 131);
            this.destxt.TabIndex = 94;
            // 
            // deslbl
            // 
            this.deslbl.AutoSize = true;
            this.deslbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deslbl.Location = new System.Drawing.Point(48, 361);
            this.deslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deslbl.Name = "deslbl";
            this.deslbl.Size = new System.Drawing.Size(153, 35);
            this.deslbl.TabIndex = 93;
            this.deslbl.Text = "Description:";
            // 
            // subPricetxt
            // 
            this.subPricetxt.Location = new System.Drawing.Point(307, 194);
            this.subPricetxt.Margin = new System.Windows.Forms.Padding(4);
            this.subPricetxt.Name = "subPricetxt";
            this.subPricetxt.Size = new System.Drawing.Size(261, 22);
            this.subPricetxt.TabIndex = 92;
            this.subPricetxt.TextChanged += new System.EventHandler(this.subPricetxt_TextChanged);
            // 
            // subPricelbl
            // 
            this.subPricelbl.AutoSize = true;
            this.subPricelbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subPricelbl.Location = new System.Drawing.Point(48, 182);
            this.subPricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subPricelbl.Name = "subPricelbl";
            this.subPricelbl.Size = new System.Drawing.Size(228, 35);
            this.subPricelbl.TabIndex = 91;
            this.subPricelbl.Text = "Subscription Price:";
            // 
            // subNametxt
            // 
            this.subNametxt.Location = new System.Drawing.Point(307, 124);
            this.subNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.subNametxt.Name = "subNametxt";
            this.subNametxt.Size = new System.Drawing.Size(261, 22);
            this.subNametxt.TabIndex = 88;
            // 
            // subnamelbl
            // 
            this.subnamelbl.AutoSize = true;
            this.subnamelbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnamelbl.Location = new System.Drawing.Point(48, 112);
            this.subnamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subnamelbl.Name = "subnamelbl";
            this.subnamelbl.Size = new System.Drawing.Size(236, 35);
            this.subnamelbl.TabIndex = 87;
            this.subnamelbl.Text = "Subscription Name:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(851, 476);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 47);
            this.btnCreate.TabIndex = 95;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblCreateSub);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 79);
            this.panel1.TabIndex = 97;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 41);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCreateSub
            // 
            this.lblCreateSub.AutoSize = true;
            this.lblCreateSub.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateSub.Location = new System.Drawing.Point(307, 0);
            this.lblCreateSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateSub.Name = "lblCreateSub";
            this.lblCreateSub.Size = new System.Drawing.Size(491, 72);
            this.lblCreateSub.TabIndex = 3;
            this.lblCreateSub.Text = "Create Subscription";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 544);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 12);
            this.panel2.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 35);
            this.label1.TabIndex = 104;
            this.label1.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 35);
            this.label2.TabIndex = 105;
            this.label2.Text = "Start Date:";
            // 
            // datestart
            // 
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datestart.Location = new System.Drawing.Point(307, 257);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(261, 22);
            this.datestart.TabIndex = 106;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(307, 319);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(261, 22);
            this.dateEnd.TabIndex = 107;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(307, 154);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 108;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.ForeColor = System.Drawing.Color.Red;
            this.lblEnd.Location = new System.Drawing.Point(307, 348);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 16);
            this.lblEnd.TabIndex = 109;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.ForeColor = System.Drawing.Color.Red;
            this.lblStart.Location = new System.Drawing.Point(307, 291);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(0, 16);
            this.lblStart.TabIndex = 110;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(307, 225);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 111;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.Red;
            this.lblDesc.Location = new System.Drawing.Point(304, 510);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 16);
            this.lblDesc.TabIndex = 112;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(366, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // CreateSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.datestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.destxt);
            this.Controls.Add(this.deslbl);
            this.Controls.Add(this.subPricetxt);
            this.Controls.Add(this.subPricelbl);
            this.Controls.Add(this.subNametxt);
            this.Controls.Add(this.subnamelbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateSubscription";
            this.Text = "CreateSubscription";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox destxt;
        private System.Windows.Forms.Label deslbl;
        private System.Windows.Forms.TextBox subPricetxt;
        private System.Windows.Forms.Label subPricelbl;
        private System.Windows.Forms.TextBox subNametxt;
        private System.Windows.Forms.Label subnamelbl;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCreateSub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDesc;
    }
}