namespace Happy_Journey_Airline
{
    partial class CreateService
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
            this.label1 = new System.Windows.Forms.Label();
            this.servicelbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.servicetxt = new System.Windows.Forms.TextBox();
            this.pricelbl = new System.Windows.Forms.Label();
            this.deslbl = new System.Windows.Forms.Label();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.createbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Service";
            // 
            // servicelbl
            // 
            this.servicelbl.AutoSize = true;
            this.servicelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicelbl.Location = new System.Drawing.Point(22, 97);
            this.servicelbl.Name = "servicelbl";
            this.servicelbl.Size = new System.Drawing.Size(134, 24);
            this.servicelbl.TabIndex = 3;
            this.servicelbl.Text = "Service Name:";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(681, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 26;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // servicetxt
            // 
            this.servicetxt.Location = new System.Drawing.Point(175, 97);
            this.servicetxt.Name = "servicetxt";
            this.servicetxt.Size = new System.Drawing.Size(197, 20);
            this.servicetxt.TabIndex = 27;
            this.servicetxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(22, 163);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(58, 24);
            this.pricelbl.TabIndex = 28;
            this.pricelbl.Text = "Price:";
            // 
            // deslbl
            // 
            this.deslbl.AutoSize = true;
            this.deslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deslbl.Location = new System.Drawing.Point(22, 228);
            this.deslbl.Name = "deslbl";
            this.deslbl.Size = new System.Drawing.Size(109, 24);
            this.deslbl.TabIndex = 29;
            this.deslbl.Text = "Description:";
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(166, 228);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(389, 171);
            this.descriptiontxt.TabIndex = 30;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(175, 168);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(197, 20);
            this.pricetxt.TabIndex = 31;
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.Location = new System.Drawing.Point(659, 389);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(129, 38);
            this.createbtn.TabIndex = 32;
            this.createbtn.Text = "Create";
            this.createbtn.UseVisualStyleBackColor = false;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.deslbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.servicetxt);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.servicelbl);
            this.Controls.Add(this.label1);
            this.Name = "AddService";
            this.Text = "AddService";
            this.Load += new System.EventHandler(this.AddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label servicelbl;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox servicetxt;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label deslbl;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Button createbtn;
    }
}