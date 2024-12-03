namespace Happy_Journey_Airline
{
    partial class UserMessage
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
            this.btnBack = new System.Windows.Forms.Button();
            this.gridRecMessage = new System.Windows.Forms.DataGridView();
            this.lblRecievedMessage = new System.Windows.Forms.Label();
            this.txtReciever = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblReciever = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(665, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 33);
            this.btnBack.TabIndex = 104;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // gridRecMessage
            // 
            this.gridRecMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRecMessage.Location = new System.Drawing.Point(219, 285);
            this.gridRecMessage.Name = "gridRecMessage";
            this.gridRecMessage.Size = new System.Drawing.Size(320, 150);
            this.gridRecMessage.TabIndex = 103;
            // 
            // lblRecievedMessage
            // 
            this.lblRecievedMessage.AutoSize = true;
            this.lblRecievedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecievedMessage.Location = new System.Drawing.Point(28, 285);
            this.lblRecievedMessage.Name = "lblRecievedMessage";
            this.lblRecievedMessage.Size = new System.Drawing.Size(186, 24);
            this.lblRecievedMessage.TabIndex = 102;
            this.lblRecievedMessage.Text = "Recieved Messages:";
            // 
            // txtReciever
            // 
            this.txtReciever.Location = new System.Drawing.Point(200, 99);
            this.txtReciever.Name = "txtReciever";
            this.txtReciever.Size = new System.Drawing.Size(339, 20);
            this.txtReciever.TabIndex = 101;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(429, 225);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 32);
            this.btnSend.TabIndex = 100;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // lblReciever
            // 
            this.lblReciever.AutoSize = true;
            this.lblReciever.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReciever.Location = new System.Drawing.Point(28, 94);
            this.lblReciever.Name = "lblReciever";
            this.lblReciever.Size = new System.Drawing.Size(90, 24);
            this.lblReciever.TabIndex = 99;
            this.lblReciever.Text = "Reciever:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(28, 145);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(142, 24);
            this.lblMessage.TabIndex = 98;
            this.lblMessage.Text = "Enter Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(200, 145);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(339, 74);
            this.txtMessage.TabIndex = 97;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMess.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMess.Location = new System.Drawing.Point(284, 15);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(162, 41);
            this.lblMess.TabIndex = 96;
            this.lblMess.Text = "Messages";
            // 
            // UserMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridRecMessage);
            this.Controls.Add(this.lblRecievedMessage);
            this.Controls.Add(this.txtReciever);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblReciever);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMess);
            this.Name = "UserMessage";
            this.Text = "UserMessage";
            ((System.ComponentModel.ISupportInitialize)(this.gridRecMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gridRecMessage;
        private System.Windows.Forms.Label lblRecievedMessage;
        private System.Windows.Forms.TextBox txtReciever;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblReciever;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMess;
    }
}