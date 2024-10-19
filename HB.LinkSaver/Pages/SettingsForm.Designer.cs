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
            label1 = new Label();
            backupBtn = new Button();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label3);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(55, 457);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 86);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Load Back Up";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(17, 22);
            button2.Name = "button2";
            button2.Size = new Size(102, 47);
            button2.TabIndex = 0;
            button2.Text = "import backup folder";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(191, 22);
            label3.Name = "label3";
            label3.Size = new Size(127, 50);
            label3.TabIndex = 1;
            label3.Text = "This feature is not ready yet";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnServer);
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(55, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 179);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Web Server";
            // 
            // btnServer
            // 
            btnServer.FlatStyle = FlatStyle.Flat;
            btnServer.ForeColor = SystemColors.ButtonFace;
            btnServer.Location = new Point(17, 64);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(102, 73);
            btnServer.TabIndex = 3;
            btnServer.Text = "button2";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(29, 32);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "lblStatus";
            // 
            // label2
            // 
            label2.Location = new Point(169, 19);
            label2.Name = "label2";
            label2.Size = new Size(165, 157);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(backupBtn);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(55, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 195);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Back up";
            // 
            // label1
            // 
            label1.Location = new Point(177, 29);
            label1.Name = "label1";
            label1.Size = new Size(157, 142);
            label1.TabIndex = 1;
            label1.Text = "Since the application does not use a remote database, local files can be lost and corrupted. you can back up your files and return to any moment if you want.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backupBtn
            // 
            backupBtn.FlatStyle = FlatStyle.Flat;
            backupBtn.ForeColor = SystemColors.ButtonFace;
            backupBtn.Location = new Point(17, 55);
            backupBtn.Name = "backupBtn";
            backupBtn.Size = new Size(136, 68);
            backupBtn.TabIndex = 0;
            backupBtn.Text = "backup files";
            backupBtn.UseVisualStyleBackColor = true;
            backupBtn.Click += backupBtn_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(451, 587);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
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
    }
}