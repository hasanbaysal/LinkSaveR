namespace LinkSaveR
{
    partial class Update
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(305, 126);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(420, 38);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(197, 23);
            this.txtLink.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "link Data";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(420, 67);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(197, 23);
            this.txtComment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Update_FormClosed);
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label lblInfo;
        private TextBox txtLink;
        private Label label1;
        private TextBox txtComment;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}