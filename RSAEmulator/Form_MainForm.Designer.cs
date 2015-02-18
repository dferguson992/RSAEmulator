namespace RSAEmulator
{
    partial class Form_MainForm
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
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAuthenticated = new System.Windows.Forms.RadioButton();
            this.rdSecAuth = new System.Windows.Forms.RadioButton();
            this.rdPublic = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbES = new System.Windows.Forms.RadioButton();
            this.rbAS = new System.Windows.Forms.RadioButton();
            this.rbCS = new System.Windows.Forms.RadioButton();
            this.rbBS = new System.Windows.Forms.RadioButton();
            this.rbFS = new System.Windows.Forms.RadioButton();
            this.rbDS = new System.Windows.Forms.RadioButton();
            this.rbBR = new System.Windows.Forms.RadioButton();
            this.rbCR = new System.Windows.Forms.RadioButton();
            this.rbAR = new System.Windows.Forms.RadioButton();
            this.rbER = new System.Windows.Forms.RadioButton();
            this.rbFR = new System.Windows.Forms.RadioButton();
            this.rbDR = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(324, 12);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(222, 173);
            this.lstLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Receiver:";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(77, 18);
            this.txtSender.Name = "txtSender";
            this.txtSender.ReadOnly = true;
            this.txtSender.Size = new System.Drawing.Size(126, 20);
            this.txtSender.TabIndex = 11;
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(87, 16);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.ReadOnly = true;
            this.txtReceiver.Size = new System.Drawing.Size(120, 20);
            this.txtReceiver.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(186, 134);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(132, 49);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(77, 44);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.ReadOnly = true;
            this.txtEncrypt.Size = new System.Drawing.Size(127, 20);
            this.txtEncrypt.TabIndex = 14;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(87, 42);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.ReadOnly = true;
            this.txtDecrypt.Size = new System.Drawing.Size(120, 20);
            this.txtDecrypt.TabIndex = 15;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(186, 106);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(132, 20);
            this.txtMessage.TabIndex = 16;
            this.txtMessage.Text = "Message...";
            this.txtMessage.Click += new System.EventHandler(this.txtMessage_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAuthenticated);
            this.groupBox1.Controls.Add(this.rdSecAuth);
            this.groupBox1.Controls.Add(this.rdPublic);
            this.groupBox1.Location = new System.Drawing.Point(186, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 88);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // rdAuthenticated
            // 
            this.rdAuthenticated.AutoSize = true;
            this.rdAuthenticated.Location = new System.Drawing.Point(10, 42);
            this.rdAuthenticated.Name = "rdAuthenticated";
            this.rdAuthenticated.Size = new System.Drawing.Size(91, 17);
            this.rdAuthenticated.TabIndex = 2;
            this.rdAuthenticated.TabStop = true;
            this.rdAuthenticated.Text = "Authenticated";
            this.rdAuthenticated.UseVisualStyleBackColor = true;
            this.rdAuthenticated.CheckedChanged += new System.EventHandler(this.Encryption_Selected);
            // 
            // rdSecAuth
            // 
            this.rdSecAuth.AutoSize = true;
            this.rdSecAuth.Location = new System.Drawing.Point(10, 65);
            this.rdSecAuth.Name = "rdSecAuth";
            this.rdSecAuth.Size = new System.Drawing.Size(122, 17);
            this.rdSecAuth.TabIndex = 1;
            this.rdSecAuth.TabStop = true;
            this.rdSecAuth.Text = "Secure-Authenticate";
            this.rdSecAuth.UseVisualStyleBackColor = true;
            this.rdSecAuth.CheckedChanged += new System.EventHandler(this.Encryption_Selected);
            // 
            // rdPublic
            // 
            this.rdPublic.AutoSize = true;
            this.rdPublic.Location = new System.Drawing.Point(10, 19);
            this.rdPublic.Name = "rdPublic";
            this.rdPublic.Size = new System.Drawing.Size(75, 17);
            this.rdPublic.TabIndex = 0;
            this.rdPublic.TabStop = true;
            this.rdPublic.Text = "Public Key";
            this.rdPublic.UseVisualStyleBackColor = true;
            this.rdPublic.CheckedChanged += new System.EventHandler(this.Encryption_Selected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSender);
            this.groupBox2.Controls.Add(this.txtEncrypt);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 73);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sender Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sent:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtReceiver);
            this.groupBox3.Controls.Add(this.txtDecrypt);
            this.groupBox3.Location = new System.Drawing.Point(333, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 73);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Received:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbES);
            this.groupBox4.Controls.Add(this.rbAS);
            this.groupBox4.Controls.Add(this.rbCS);
            this.groupBox4.Controls.Add(this.rbBS);
            this.groupBox4.Controls.Add(this.rbFS);
            this.groupBox4.Controls.Add(this.rbDS);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(85, 171);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sender";
            // 
            // rbES
            // 
            this.rbES.AutoSize = true;
            this.rbES.Location = new System.Drawing.Point(6, 111);
            this.rbES.Name = "rbES";
            this.rbES.Size = new System.Drawing.Size(57, 17);
            this.rbES.TabIndex = 11;
            this.rbES.TabStop = true;
            this.rbES.Text = "User E";
            this.rbES.UseVisualStyleBackColor = true;
            this.rbES.CheckedChanged += new System.EventHandler(this.Sender_Selected);
            // 
            // rbAS
            // 
            this.rbAS.AutoSize = true;
            this.rbAS.Location = new System.Drawing.Point(6, 19);
            this.rbAS.Name = "rbAS";
            this.rbAS.Size = new System.Drawing.Size(57, 17);
            this.rbAS.TabIndex = 6;
            this.rbAS.TabStop = true;
            this.rbAS.Text = "User A";
            this.rbAS.UseVisualStyleBackColor = true;
            this.rbAS.CheckedChanged += new System.EventHandler(this.Sender_Selected);
            // 
            // rbCS
            // 
            this.rbCS.AutoSize = true;
            this.rbCS.Location = new System.Drawing.Point(6, 65);
            this.rbCS.Name = "rbCS";
            this.rbCS.Size = new System.Drawing.Size(57, 17);
            this.rbCS.TabIndex = 7;
            this.rbCS.TabStop = true;
            this.rbCS.Text = "User C";
            this.rbCS.UseVisualStyleBackColor = true;
            this.rbCS.CheckedChanged += new System.EventHandler(this.Sender_Selected);
            // 
            // rbBS
            // 
            this.rbBS.AutoSize = true;
            this.rbBS.Location = new System.Drawing.Point(6, 42);
            this.rbBS.Name = "rbBS";
            this.rbBS.Size = new System.Drawing.Size(57, 17);
            this.rbBS.TabIndex = 8;
            this.rbBS.TabStop = true;
            this.rbBS.Text = "User B";
            this.rbBS.UseVisualStyleBackColor = true;
            this.rbBS.CheckedChanged += new System.EventHandler(this.Sender_Selected);
            // 
            // rbFS
            // 
            this.rbFS.AutoSize = true;
            this.rbFS.Location = new System.Drawing.Point(6, 134);
            this.rbFS.Name = "rbFS";
            this.rbFS.Size = new System.Drawing.Size(56, 17);
            this.rbFS.TabIndex = 10;
            this.rbFS.TabStop = true;
            this.rbFS.Text = "User F";
            this.rbFS.UseVisualStyleBackColor = true;
            this.rbFS.CheckedChanged += new System.EventHandler(this.Sender_Selected);
            // 
            // rbDS
            // 
            this.rbDS.AutoSize = true;
            this.rbDS.Location = new System.Drawing.Point(6, 88);
            this.rbDS.Name = "rbDS";
            this.rbDS.Size = new System.Drawing.Size(58, 17);
            this.rbDS.TabIndex = 9;
            this.rbDS.TabStop = true;
            this.rbDS.Text = "User D";
            this.rbDS.UseVisualStyleBackColor = true;
            this.rbDS.CheckedChanged += new System.EventHandler(this.Sender_Selected);
            // 
            // rbBR
            // 
            this.rbBR.AutoSize = true;
            this.rbBR.Location = new System.Drawing.Point(6, 42);
            this.rbBR.Name = "rbBR";
            this.rbBR.Size = new System.Drawing.Size(57, 17);
            this.rbBR.TabIndex = 2;
            this.rbBR.TabStop = true;
            this.rbBR.Text = "User B";
            this.rbBR.UseVisualStyleBackColor = true;
            this.rbBR.CheckedChanged += new System.EventHandler(this.Receiver_Selected);
            // 
            // rbCR
            // 
            this.rbCR.AutoSize = true;
            this.rbCR.Location = new System.Drawing.Point(6, 65);
            this.rbCR.Name = "rbCR";
            this.rbCR.Size = new System.Drawing.Size(57, 17);
            this.rbCR.TabIndex = 1;
            this.rbCR.TabStop = true;
            this.rbCR.Text = "User C";
            this.rbCR.UseVisualStyleBackColor = true;
            this.rbCR.CheckedChanged += new System.EventHandler(this.Receiver_Selected);
            // 
            // rbAR
            // 
            this.rbAR.AutoSize = true;
            this.rbAR.Location = new System.Drawing.Point(6, 19);
            this.rbAR.Name = "rbAR";
            this.rbAR.Size = new System.Drawing.Size(57, 17);
            this.rbAR.TabIndex = 0;
            this.rbAR.TabStop = true;
            this.rbAR.Text = "User A";
            this.rbAR.UseVisualStyleBackColor = true;
            this.rbAR.CheckedChanged += new System.EventHandler(this.Receiver_Selected);
            // 
            // rbER
            // 
            this.rbER.AutoSize = true;
            this.rbER.Location = new System.Drawing.Point(6, 111);
            this.rbER.Name = "rbER";
            this.rbER.Size = new System.Drawing.Size(57, 17);
            this.rbER.TabIndex = 5;
            this.rbER.TabStop = true;
            this.rbER.Text = "User E";
            this.rbER.UseVisualStyleBackColor = true;
            this.rbER.CheckedChanged += new System.EventHandler(this.Receiver_Selected);
            // 
            // rbFR
            // 
            this.rbFR.AutoSize = true;
            this.rbFR.Location = new System.Drawing.Point(6, 134);
            this.rbFR.Name = "rbFR";
            this.rbFR.Size = new System.Drawing.Size(56, 17);
            this.rbFR.TabIndex = 4;
            this.rbFR.TabStop = true;
            this.rbFR.Text = "User F";
            this.rbFR.UseVisualStyleBackColor = true;
            this.rbFR.CheckedChanged += new System.EventHandler(this.Receiver_Selected);
            // 
            // rbDR
            // 
            this.rbDR.AutoSize = true;
            this.rbDR.Location = new System.Drawing.Point(6, 88);
            this.rbDR.Name = "rbDR";
            this.rbDR.Size = new System.Drawing.Size(58, 17);
            this.rbDR.TabIndex = 3;
            this.rbDR.TabStop = true;
            this.rbDR.Text = "User D";
            this.rbDR.UseVisualStyleBackColor = true;
            this.rbDR.CheckedChanged += new System.EventHandler(this.Receiver_Selected);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbER);
            this.groupBox5.Controls.Add(this.rbCR);
            this.groupBox5.Controls.Add(this.rbFR);
            this.groupBox5.Controls.Add(this.rbAR);
            this.groupBox5.Controls.Add(this.rbDR);
            this.groupBox5.Controls.Add(this.rbBR);
            this.groupBox5.Location = new System.Drawing.Point(103, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(77, 171);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receiver";
            // 
            // Form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 271);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Name = "Form_MainForm";
            this.Text = "RSA Emulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAuthenticated;
        private System.Windows.Forms.RadioButton rdSecAuth;
        private System.Windows.Forms.RadioButton rdPublic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbES;
        private System.Windows.Forms.RadioButton rbAS;
        private System.Windows.Forms.RadioButton rbCS;
        private System.Windows.Forms.RadioButton rbBS;
        private System.Windows.Forms.RadioButton rbFS;
        private System.Windows.Forms.RadioButton rbDS;
        private System.Windows.Forms.RadioButton rbBR;
        private System.Windows.Forms.RadioButton rbCR;
        private System.Windows.Forms.RadioButton rbAR;
        private System.Windows.Forms.RadioButton rbER;
        private System.Windows.Forms.RadioButton rbFR;
        private System.Windows.Forms.RadioButton rbDR;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

