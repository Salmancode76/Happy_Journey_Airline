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
            this.sublbl = new System.Windows.Forms.Label();
            this.uNamelbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paybtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sublbl
            // 
            this.sublbl.AutoSize = true;
            this.sublbl.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sublbl.Location = new System.Drawing.Point(260, 9);
            this.sublbl.Name = "sublbl";
            this.sublbl.Size = new System.Drawing.Size(324, 41);
            this.sublbl.TabIndex = 7;
            this.sublbl.Text = "Subscription Plans";
            // 
            // uNamelbl
            // 
            this.uNamelbl.AutoSize = true;
            this.uNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNamelbl.Location = new System.Drawing.Point(35, 78);
            this.uNamelbl.Name = "uNamelbl";
            this.uNamelbl.Size = new System.Drawing.Size(196, 24);
            this.uNamelbl.TabIndex = 48;
            this.uNamelbl.Text = "Please choose a plan:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 251);
            this.dataGridView1.TabIndex = 49;
            // 
            // paybtn
            // 
            this.paybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybtn.Location = new System.Drawing.Point(741, 381);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(129, 38);
            this.paybtn.TabIndex = 67;
            this.paybtn.Text = "Subscribe";
            this.paybtn.UseVisualStyleBackColor = false;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(763, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 68;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // UserSubscriptionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.paybtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uNamelbl);
            this.Controls.Add(this.sublbl);
            this.Name = "UserSubscriptionScreen";
            this.Text = "SubscriptionScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sublbl;
        private System.Windows.Forms.Label uNamelbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.Button backbtn;
    }
}