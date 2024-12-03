namespace Happy_Journey_Airline
{
    partial class DeleteUser
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
            this.deluserlbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.DelUsercmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deluserlbl
            // 
            this.deluserlbl.AutoSize = true;
            this.deluserlbl.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluserlbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.deluserlbl.Location = new System.Drawing.Point(274, 9);
            this.deluserlbl.Name = "deluserlbl";
            this.deluserlbl.Size = new System.Drawing.Size(204, 41);
            this.deluserlbl.TabIndex = 11;
            this.deluserlbl.Text = "Delete User";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(31, 101);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(259, 24);
            this.desclbl.TabIndex = 78;
            this.desclbl.Text = "Choose user from the system:";
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(311, 352);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(157, 32);
            this.delbtn.TabIndex = 80;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(681, 9);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 81;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // DelUsercmb
            // 
            this.DelUsercmb.FormattingEnabled = true;
            this.DelUsercmb.Location = new System.Drawing.Point(296, 104);
            this.DelUsercmb.Name = "DelUsercmb";
            this.DelUsercmb.Size = new System.Drawing.Size(199, 21);
            this.DelUsercmb.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 150);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.DelUsercmb);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.deluserlbl);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deluserlbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ComboBox DelUsercmb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}