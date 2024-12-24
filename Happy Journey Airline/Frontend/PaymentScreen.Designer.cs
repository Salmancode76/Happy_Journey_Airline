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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentScreen));
            this.lblCardType = new System.Windows.Forms.Label();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbDebit = new System.Windows.Forms.RadioButton();
            this.cardhlbl = new System.Windows.Forms.Label();
            this.txtCholder = new System.Windows.Forms.TextBox();
            this.lblCardNUm = new System.Windows.Forms.Label();
            this.txtcnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.expDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.paybtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(531, 234);
            this.lblCardType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(137, 35);
            this.lblCardType.TabIndex = 47;
            this.lblCardType.Text = "Card Type:";
            this.lblCardType.Click += new System.EventHandler(this.uNamelbl_Click);
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Checked = true;
            this.rbCredit.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredit.Location = new System.Drawing.Point(749, 234);
            this.rbCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(70, 24);
            this.rbCredit.TabIndex = 48;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit";
            this.rbCredit.UseVisualStyleBackColor = true;
            this.rbCredit.CheckedChanged += new System.EventHandler(this.rbCredit_CheckedChanged);
            // 
            // rbDebit
            // 
            this.rbDebit.AutoSize = true;
            this.rbDebit.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebit.Location = new System.Drawing.Point(863, 234);
            this.rbDebit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDebit.Name = "rbDebit";
            this.rbDebit.Size = new System.Drawing.Size(65, 24);
            this.rbDebit.TabIndex = 49;
            this.rbDebit.Text = "Debit";
            this.rbDebit.UseVisualStyleBackColor = true;
            this.rbDebit.CheckedChanged += new System.EventHandler(this.rbDebit_CheckedChanged);
            // 
            // cardhlbl
            // 
            this.cardhlbl.AutoSize = true;
            this.cardhlbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardhlbl.Location = new System.Drawing.Point(59, 145);
            this.cardhlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardhlbl.Name = "cardhlbl";
            this.cardhlbl.Size = new System.Drawing.Size(160, 35);
            this.cardhlbl.TabIndex = 50;
            this.cardhlbl.Text = "Card Holder:";
            // 
            // txtCholder
            // 
            this.txtCholder.Location = new System.Drawing.Point(244, 155);
            this.txtCholder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCholder.Name = "txtCholder";
            this.txtCholder.Size = new System.Drawing.Size(236, 22);
            this.txtCholder.TabIndex = 51;
            // 
            // lblCardNUm
            // 
            this.lblCardNUm.AutoSize = true;
            this.lblCardNUm.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNUm.Location = new System.Drawing.Point(44, 234);
            this.lblCardNUm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNUm.Name = "lblCardNUm";
            this.lblCardNUm.Size = new System.Drawing.Size(175, 35);
            this.lblCardNUm.TabIndex = 52;
            this.lblCardNUm.Text = "Card Number:";
            // 
            // txtcnum
            // 
            this.txtcnum.Location = new System.Drawing.Point(244, 244);
            this.txtcnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcnum.Name = "txtcnum";
            this.txtcnum.Size = new System.Drawing.Size(236, 22);
            this.txtcnum.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 35);
            this.label2.TabIndex = 54;
            this.label2.Text = "Expiration Date:";
            // 
            // expDatePicker
            // 
            this.expDatePicker.Location = new System.Drawing.Point(749, 155);
            this.expDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expDatePicker.Name = "expDatePicker";
            this.expDatePicker.Size = new System.Drawing.Size(236, 22);
            this.expDatePicker.TabIndex = 55;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(531, 300);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(70, 35);
            this.lbl.TabIndex = 56;
            this.lbl.Text = "CVV:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(749, 310);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(236, 22);
            this.txtCode.TabIndex = 57;
            // 
            // paybtn
            // 
            this.paybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paybtn.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybtn.Location = new System.Drawing.Point(803, 449);
            this.paybtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(172, 47);
            this.paybtn.TabIndex = 66;
            this.paybtn.Text = "Pay";
            this.paybtn.UseVisualStyleBackColor = false;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 84);
            this.panel1.TabIndex = 104;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(16, 15);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(143, 41);
            this.btnback.TabIndex = 26;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPayment.Location = new System.Drawing.Point(377, 0);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(232, 72);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.Text = "Payment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 540);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 17);
            this.panel2.TabIndex = 105;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(341, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(93, 425);
            this.lblmsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(64, 16);
            this.lblmsg.TabIndex = 138;
            this.lblmsg.Text = "message";
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paybtn);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.expDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcnum);
            this.Controls.Add(this.lblCardNUm);
            this.Controls.Add(this.txtCholder);
            this.Controls.Add(this.cardhlbl);
            this.Controls.Add(this.rbDebit);
            this.Controls.Add(this.rbCredit);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaymentScreen";
            this.Text = "PaymentScreen";
            this.Load += new System.EventHandler(this.PaymentScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbDebit;
        private System.Windows.Forms.Label cardhlbl;
        private System.Windows.Forms.TextBox txtCholder;
        private System.Windows.Forms.Label lblCardNUm;
        private System.Windows.Forms.TextBox txtcnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker expDatePicker;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblmsg;
    }
}