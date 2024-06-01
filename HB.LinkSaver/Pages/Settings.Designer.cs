namespace HB.LinkSaver.Pages
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            button1 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnServer = new Button();
            lblStatus = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(17, 55);
            button1.Name = "button1";
            button1.Size = new Size(136, 68);
            button1.TabIndex = 0;
            button1.Text = "backup files";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(63, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 195);
            groupBox1.TabIndex = 1;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnServer);
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(63, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 179);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Web Server";
            // 
            // btnServer
            // 
            btnServer.ForeColor = SystemColors.ActiveCaptionText;
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
            label2.Location = new Point(153, 19);
            label2.Name = "label2";
            label2.Size = new Size(165, 157);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Settings";
            Size = new Size(487, 536);
            Load += Settings_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label lblStatus;
        private Button btnServer;
    }
}
