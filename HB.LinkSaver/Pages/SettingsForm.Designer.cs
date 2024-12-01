namespace HB.LinkSaver.Pages
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            groupBox3 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnServer = new Button();
            lblStatus = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblCount = new Label();
            label1 = new Label();
            backupBtn = new Button();
            groupBox4 = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            lblInfo = new Label();
            groupBox5 = new GroupBox();
            MailHtml = new Button();
            btnHtmlGenerator = new Button();
            lblMailHtmlInfo = new Label();
            label5 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label3);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(18, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 126);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Load Backup";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(17, 32);
            button2.Name = "button2";
            button2.Size = new Size(102, 68);
            button2.TabIndex = 0;
            button2.TabStop = false;
            button2.Text = "import backup folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(140, 33);
            label3.Name = "label3";
            label3.Size = new Size(171, 67);
            label3.TabIndex = 1;
            label3.Text = "select your files to upload your backups";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnServer);
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(390, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 322);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Web Server";
            // 
            // btnServer
            // 
            btnServer.FlatStyle = FlatStyle.Flat;
            btnServer.ForeColor = SystemColors.ButtonFace;
            btnServer.Location = new Point(93, 37);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(146, 68);
            btnServer.TabIndex = 3;
            btnServer.TabStop = false;
            btnServer.Text = "button2";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(37, 130);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(265, 26);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "lblStatus";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(17, 156);
            label2.Name = "label2";
            label2.Size = new Size(307, 140);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCount);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(backupBtn);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 182);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Backup";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.ForeColor = Color.FromArgb(128, 255, 128);
            lblCount.Location = new Point(6, 40);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(53, 15);
            lblCount.TabIndex = 2;
            lblCount.Text = "lblCount";
            // 
            // label1
            // 
            label1.Location = new Point(19, 93);
            label1.Name = "label1";
            label1.Size = new Size(300, 71);
            label1.TabIndex = 1;
            label1.Text = "Since the application does not use a remote database, local files can be lost and corrupted. you can back up your files and return to any moment if you want.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backupBtn
            // 
            backupBtn.FlatStyle = FlatStyle.Flat;
            backupBtn.ForeColor = SystemColors.ButtonFace;
            backupBtn.Location = new Point(180, 22);
            backupBtn.Name = "backupBtn";
            backupBtn.Size = new Size(108, 68);
            backupBtn.TabIndex = 0;
            backupBtn.TabStop = false;
            backupBtn.Text = "backup files";
            backupBtn.UseVisualStyleBackColor = true;
            backupBtn.Click += backupBtn_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(lblInfo);
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(18, 343);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(334, 228);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mail Backup";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(128, 255, 128);
            button3.Location = new Point(68, 129);
            button3.Name = "button3";
            button3.Size = new Size(214, 42);
            button3.TabIndex = 0;
            button3.TabStop = false;
            button3.Text = "Mail Config Settings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(17, 35);
            button1.Name = "button1";
            button1.Size = new Size(102, 67);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "Send Backup To Mail";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblInfo
            // 
            lblInfo.ForeColor = Color.FromArgb(128, 255, 128);
            lblInfo.Location = new Point(105, 188);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(127, 22);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Sending";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(MailHtml);
            groupBox5.Controls.Add(btnHtmlGenerator);
            groupBox5.Controls.Add(lblMailHtmlInfo);
            groupBox5.Controls.Add(label5);
            groupBox5.ForeColor = SystemColors.ButtonHighlight;
            groupBox5.Location = new Point(390, 343);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(340, 228);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Html Backup";
            // 
            // MailHtml
            // 
            MailHtml.FlatStyle = FlatStyle.Flat;
            MailHtml.ForeColor = Color.FromArgb(128, 255, 128);
            MailHtml.Location = new Point(69, 129);
            MailHtml.Name = "MailHtml";
            MailHtml.Size = new Size(214, 42);
            MailHtml.TabIndex = 0;
            MailHtml.TabStop = false;
            MailHtml.Text = "Send Mail as Html Backup File";
            MailHtml.UseVisualStyleBackColor = true;
            MailHtml.Click += MailHtml_Click;
            // 
            // btnHtmlGenerator
            // 
            btnHtmlGenerator.FlatStyle = FlatStyle.Flat;
            btnHtmlGenerator.Location = new Point(17, 39);
            btnHtmlGenerator.Name = "btnHtmlGenerator";
            btnHtmlGenerator.Size = new Size(117, 57);
            btnHtmlGenerator.TabIndex = 0;
            btnHtmlGenerator.TabStop = false;
            btnHtmlGenerator.Text = "Html Backup";
            btnHtmlGenerator.UseVisualStyleBackColor = true;
            btnHtmlGenerator.Click += btnHtmlGenerator_Click;
            // 
            // lblMailHtmlInfo
            // 
            lblMailHtmlInfo.ForeColor = Color.FromArgb(128, 255, 128);
            lblMailHtmlInfo.Location = new Point(112, 188);
            lblMailHtmlInfo.Name = "lblMailHtmlInfo";
            lblMailHtmlInfo.Size = new Size(127, 22);
            lblMailHtmlInfo.TabIndex = 1;
            lblMailHtmlInfo.Text = "Sending";
            lblMailHtmlInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(140, 23);
            label5.Name = "label5";
            label5.Size = new Size(171, 88);
            label5.TabIndex = 1;
            label5.Text = "back up all your data in html";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(747, 585);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings Page (ESC to Close)";
            Load += SettingsForm_Load;
            KeyDown += SettingsForm_KeyDown;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button button2;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnServer;
        private Label lblStatus;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private Button backupBtn;
        private GroupBox groupBox4;
        private Button button1;
        private Button button3;
        private Label lblInfo;
        private GroupBox groupBox5;
        private Button btnHtmlGenerator;
        private Label label5;
        private Button MailHtml;
        private Label lblMailHtmlInfo;
        private Label lblCount;
    }
}