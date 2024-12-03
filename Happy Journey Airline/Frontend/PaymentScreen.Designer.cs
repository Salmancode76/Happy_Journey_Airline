namespace Happy_Journey_Airline
{
    partial class PaymentScreen
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
            this.createutxt = new System.Windows.Forms.Label();
            this.uNamelbl = new System.Windows.Forms.Label();
            this.creditrb = new System.Windows.Forms.RadioButton();
            this.debitrb = new System.Windows.Forms.RadioButton();
            this.cardhlbl = new System.Windows.Forms.Label();
            this.choldertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cnumbertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.acctxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.paybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createutxt
            // 
            this.createutxt.AutoSize = true;
            this.createutxt.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createutxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.createutxt.Location = new System.Drawing.Point(316, 9);
            this.createutxt.Name = "createutxt";
            this.createutxt.Size = new System.Drawing.Size(160, 41);
            this.createutxt.TabIndex = 6;
            this.createutxt.Text = "Payment";
            // 
            // uNamelbl
            // 
            this.uNamelbl.AutoSize = true;
            this.uNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNamelbl.Location = new System.Drawing.Point(34, 92);
            this.uNamelbl.Name = "uNamelbl";
            this.uNamelbl.Size = new System.Drawing.Size(103, 24);
            this.uNamelbl.TabIndex = 47;
            this.uNamelbl.Text = "Card Type:";
            this.uNamelbl.Click += new System.EventHandler(this.uNamelbl_Click);
            // 
            // creditrb
            // 
            this.creditrb.AutoSize = true;
            this.creditrb.Checked = true;
            this.creditrb.Location = new System.Drawing.Point(184, 98);
            this.creditrb.Name = "creditrb";
            this.creditrb.Size = new System.Drawing.Size(52, 17);
            this.creditrb.TabIndex = 48;
            this.creditrb.TabStop = true;
            this.creditrb.Text = "Credit";
            this.creditrb.UseVisualStyleBackColor = true;
            // 
            // debitrb
            // 
            this.debitrb.AutoSize = true;
            this.debitrb.Location = new System.Drawing.Point(256, 98);
            this.debitrb.Name = "debitrb";
            this.debitrb.Size = new System.Drawing.Size(50, 17);
            this.debitrb.TabIndex = 49;
            this.debitrb.Text = "Debit";
            this.debitrb.UseVisualStyleBackColor = true;
            // 
            // cardhlbl
            // 
            this.cardhlbl.AutoSize = true;
            this.cardhlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardhlbl.Location = new System.Drawing.Point(34, 137);
            this.cardhlbl.Name = "cardhlbl";
            this.cardhlbl.Size = new System.Drawing.Size(117, 24);
            this.cardhlbl.TabIndex = 50;
            this.cardhlbl.Text = "Card Holder:";
            // 
            // choldertxt
            // 
            this.choldertxt.Location = new System.Drawing.Point(173, 142);
            this.choldertxt.Name = "choldertxt";
            this.choldertxt.Size = new System.Drawing.Size(178, 20);
            this.choldertxt.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Card Number:";
            // 
            // cnumbertxt
            // 
            this.cnumbertxt.Location = new System.Drawing.Point(173, 186);
            this.cnumbertxt.Name = "cnumbertxt";
            this.cnumbertxt.Size = new System.Drawing.Size(178, 20);
            this.cnumbertxt.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Expiration Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "CVV:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Account Number:";
            // 
            // acctxt
            // 
            this.acctxt.Location = new System.Drawing.Point(543, 98);
            this.acctxt.Name = "acctxt";
            this.acctxt.Size = new System.Drawing.Size(178, 20);
            this.acctxt.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 63;
            this.label6.Text = "Email:";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(543, 147);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(178, 20);
            this.emailtxt.TabIndex = 64;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(739, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 65;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // paybtn
            // 
            this.paybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybtn.Location = new System.Drawing.Point(717, 400);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(129, 38);
            this.paybtn.TabIndex = 66;
            this.paybtn.Text = "Pay";
            this.paybtn.UseVisualStyleBackColor = false;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.paybtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.acctxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cnumbertxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choldertxt);
            this.Controls.Add(this.cardhlbl);
            this.Controls.Add(this.debitrb);
            this.Controls.Add(this.creditrb);
            this.Controls.Add(this.uNamelbl);
            this.Controls.Add(this.createutxt);
            this.Name = "PaymentScreen";
            this.Text = "PaymentScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createutxt;
        private System.Windows.Forms.Label uNamelbl;
        private System.Windows.Forms.RadioButton creditrb;
        private System.Windows.Forms.RadioButton debitrb;
        private System.Windows.Forms.Label cardhlbl;
        private System.Windows.Forms.TextBox choldertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cnumbertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox acctxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button paybtn;
    }
}