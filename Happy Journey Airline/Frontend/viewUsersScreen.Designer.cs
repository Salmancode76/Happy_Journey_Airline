namespace Happy_Journey_Airline
{
    partial class viewUsersScreen
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
            this.userlbl = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.updateuserbtn = new System.Windows.Forms.Button();
            this.DeleteUserbtn = new System.Windows.Forms.Button();
            this.createUserbtn = new System.Windows.Forms.Button();
            this.desclbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.userlbl.Location = new System.Drawing.Point(303, 9);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(106, 41);
            this.userlbl.TabIndex = 10;
            this.userlbl.Text = "Users";
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(31, 132);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(510, 261);
            this.userGridView.TabIndex = 11;
            // 
            // updateuserbtn
            // 
            this.updateuserbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateuserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuserbtn.Location = new System.Drawing.Point(560, 361);
            this.updateuserbtn.Name = "updateuserbtn";
            this.updateuserbtn.Size = new System.Drawing.Size(157, 32);
            this.updateuserbtn.TabIndex = 74;
            this.updateuserbtn.Text = "Update User";
            this.updateuserbtn.UseVisualStyleBackColor = false;
            // 
            // DeleteUserbtn
            // 
            this.DeleteUserbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteUserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserbtn.Location = new System.Drawing.Point(560, 250);
            this.DeleteUserbtn.Name = "DeleteUserbtn";
            this.DeleteUserbtn.Size = new System.Drawing.Size(157, 32);
            this.DeleteUserbtn.TabIndex = 75;
            this.DeleteUserbtn.Text = "Delete User";
            this.DeleteUserbtn.UseVisualStyleBackColor = false;
            // 
            // createUserbtn
            // 
            this.createUserbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createUserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserbtn.Location = new System.Drawing.Point(560, 132);
            this.createUserbtn.Name = "createUserbtn";
            this.createUserbtn.Size = new System.Drawing.Size(157, 32);
            this.createUserbtn.TabIndex = 76;
            this.createUserbtn.Text = "Create User";
            this.createUserbtn.UseVisualStyleBackColor = false;
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(27, 93);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(130, 24);
            this.desclbl.TabIndex = 77;
            this.desclbl.Text = "Current Users:";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(681, 9);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 78;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // viewUsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.createUserbtn);
            this.Controls.Add(this.DeleteUserbtn);
            this.Controls.Add(this.updateuserbtn);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.userlbl);
            this.Name = "viewUsersScreen";
            this.Text = "viewUsersScreen";
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button updateuserbtn;
        private System.Windows.Forms.Button DeleteUserbtn;
        private System.Windows.Forms.Button createUserbtn;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Button backbtn;
    }
}