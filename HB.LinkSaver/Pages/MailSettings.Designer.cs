namespace HB.LinkSaver.Pages
{
    partial class MailSettings
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
            tbSenderMail = new TextBox();
            label1 = new Label();
            tbAppPass = new TextBox();
            label2 = new Label();
            tbPortNumber = new TextBox();
            label3 = new Label();
            tbSmtpServer = new TextBox();
            label4 = new Label();
            button1 = new Button();
            tbReciver = new TextBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbSenderMail
            // 
            tbSenderMail.Location = new Point(166, 49);
            tbSenderMail.Name = "tbSenderMail";
            tbSenderMail.Size = new Size(334, 23);
            tbSenderMail.TabIndex = 0;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 49);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Sender";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbAppPass
            // 
            tbAppPass.Location = new Point(166, 101);
            tbAppPass.Name = "tbAppPass";
            tbAppPass.Size = new Size(334, 23);
            tbAppPass.TabIndex = 1;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 101);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "App Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPortNumber
            // 
            tbPortNumber.Location = new Point(166, 149);
            tbPortNumber.Name = "tbPortNumber";
            tbPortNumber.Size = new Size(334, 23);
            tbPortNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 149);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            label3.Text = "Port Number";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbSmtpServer
            // 
            tbSmtpServer.Location = new Point(166, 200);
            tbSmtpServer.Name = "tbSmtpServer";
            tbSmtpServer.Size = new Size(334, 23);
            tbSmtpServer.TabIndex = 3;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 200);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 5;
            label4.Text = "Smtp Server Address";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(270, 290);
            button1.Name = "button1";
            button1.Size = new Size(142, 37);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbReciver
            // 
            tbReciver.Location = new Point(166, 248);
            tbReciver.Name = "tbReciver";
            tbReciver.Size = new Size(334, 23);
            tbReciver.TabIndex = 3;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 248);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 5;
            label5.Text = "recipient mail address";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 290);
            button2.Name = "button2";
            button2.Size = new Size(110, 37);
            button2.TabIndex = 4;
            button2.Text = "Print Config";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MailSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(525, 339);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(tbReciver);
            Controls.Add(label4);
            Controls.Add(tbSmtpServer);
            Controls.Add(label3);
            Controls.Add(tbPortNumber);
            Controls.Add(label2);
            Controls.Add(tbAppPass);
            Controls.Add(label1);
            Controls.Add(tbSenderMail);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MailSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MailSettings";
            Load += MailSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSenderMail;
        private Label label1;
        private TextBox tbAppPass;
        private Label label2;
        private TextBox tbPortNumber;
        private Label label3;
        private TextBox tbSmtpServer;
        private Label label4;
        private Button button1;
        private TextBox tbReciver;
        private Label label5;
        private Button button2;
    }
}