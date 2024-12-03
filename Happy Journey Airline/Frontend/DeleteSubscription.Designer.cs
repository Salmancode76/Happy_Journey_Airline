namespace Happy_Journey_Airline
{
    partial class DeleteSubscription
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
            this.dataGridSubs = new System.Windows.Forms.DataGridView();
            this.delbtn = new System.Windows.Forms.Button();
            this.DelSubmb = new System.Windows.Forms.ComboBox();
            this.desclbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubs)).BeginInit();
            this.SuspendLayout();
            // 
            // deluserlbl
            // 
            this.deluserlbl.AutoSize = true;
            this.deluserlbl.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluserlbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.deluserlbl.Location = new System.Drawing.Point(229, 9);
            this.deluserlbl.Name = "deluserlbl";
            this.deluserlbl.Size = new System.Drawing.Size(333, 41);
            this.deluserlbl.TabIndex = 12;
            this.deluserlbl.Text = "Delete Subscription";
            // 
            // dataGridSubs
            // 
            this.dataGridSubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubs.Location = new System.Drawing.Point(217, 150);
            this.dataGridSubs.Name = "dataGridSubs";
            this.dataGridSubs.Size = new System.Drawing.Size(355, 150);
            this.dataGridSubs.TabIndex = 86;
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(303, 341);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(157, 32);
            this.delbtn.TabIndex = 85;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            // 
            // DelSubmb
            // 
            this.DelSubmb.FormattingEnabled = true;
            this.DelSubmb.Location = new System.Drawing.Point(303, 98);
            this.DelSubmb.Name = "DelSubmb";
            this.DelSubmb.Size = new System.Drawing.Size(199, 21);
            this.DelSubmb.TabIndex = 84;
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(12, 93);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(231, 24);
            this.desclbl.TabIndex = 83;
            this.desclbl.Text = "Choose Subscription offer:";
            this.desclbl.Click += new System.EventHandler(this.desclbl_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(681, 17);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 87;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // DeleteSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridSubs);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.DelSubmb);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.deluserlbl);
            this.Name = "DeleteSubscription";
            this.Text = "DeleteSubscription";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deluserlbl;
        private System.Windows.Forms.DataGridView dataGridSubs;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.ComboBox DelSubmb;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Button backbtn;
    }
}