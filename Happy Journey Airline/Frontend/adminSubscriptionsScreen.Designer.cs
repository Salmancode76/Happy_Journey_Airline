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
            this.sublbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.SubGridView = new System.Windows.Forms.DataGridView();
            this.createbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.updateuserbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sublbl
            // 
            this.sublbl.AutoSize = true;
            this.sublbl.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sublbl.Location = new System.Drawing.Point(220, 9);
            this.sublbl.Name = "sublbl";
            this.sublbl.Size = new System.Drawing.Size(330, 41);
            this.sublbl.TabIndex = 8;
            this.sublbl.Text = "Subscription Offers";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(24, 88);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(131, 24);
            this.desclbl.TabIndex = 78;
            this.desclbl.Text = "Current Offers:";
            // 
            // SubGridView
            // 
            this.SubGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubGridView.Location = new System.Drawing.Point(28, 115);
            this.SubGridView.Name = "SubGridView";
            this.SubGridView.Size = new System.Drawing.Size(510, 261);
            this.SubGridView.TabIndex = 79;
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.Location = new System.Drawing.Point(568, 115);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(157, 32);
            this.createbtn.TabIndex = 82;
            this.createbtn.Text = "Create Subscription";
            this.createbtn.UseVisualStyleBackColor = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(568, 233);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(157, 32);
            this.Deletebtn.TabIndex = 81;
            this.Deletebtn.Text = "Delete Subscription";
            this.Deletebtn.UseVisualStyleBackColor = false;
            // 
            // updateuserbtn
            // 
            this.updateuserbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateuserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuserbtn.Location = new System.Drawing.Point(568, 344);
            this.updateuserbtn.Name = "updateuserbtn";
            this.updateuserbtn.Size = new System.Drawing.Size(157, 32);
            this.updateuserbtn.TabIndex = 80;
            this.updateuserbtn.Text = "Update Subscription";
            this.updateuserbtn.UseVisualStyleBackColor = false;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(681, 9);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 83;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // adminSubscriptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.updateuserbtn);
            this.Controls.Add(this.SubGridView);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.sublbl);
            this.Name = "adminSubscriptionsScreen";
            this.Text = "adminSubscriptionsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.SubGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sublbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.DataGridView SubGridView;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button updateuserbtn;
        private System.Windows.Forms.Button backbtn;
    }
}