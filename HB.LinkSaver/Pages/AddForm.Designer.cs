namespace HB.LinkSaver.Pages
{
    partial class AddForm
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
            tbHeader = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbLink = new TextBox();
            label4 = new Label();
            tbDescription = new RichTextBox();
            button1 = new Button();
            lblResult = new Label();
            categoryControlLb1 = new Components.CategoryControlLb();
            FlwPanel = new FlowLayoutPanel();
            textBox1 = new TextBox();
            resetBtn = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbHeader
            // 
            tbHeader.Location = new Point(99, 18);
            tbHeader.Name = "tbHeader";
            tbHeader.Size = new Size(308, 23);
            tbHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 2;
            label2.Text = "Header :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 2;
            label3.Text = "Link :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbLink
            // 
            tbLink.Location = new Point(99, 91);
            tbLink.Name = "tbLink";
            tbLink.Size = new Size(308, 23);
            tbLink.TabIndex = 1;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 2;
            label4.Text = "Description :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(99, 166);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(308, 89);
            tbDescription.TabIndex = 2;
            tbDescription.Text = "";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(229, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SaveBtn_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.FromArgb(128, 255, 128);
            lblResult.Location = new Point(121, 291);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(43, 15);
            lblResult.TabIndex = 7;
            lblResult.Text = "Succes";
            // 
            // categoryControlLb1
            // 
            categoryControlLb1.BackColor = Color.Transparent;
            categoryControlLb1.BorderStyle = BorderStyle.Fixed3D;
            categoryControlLb1.Location = new Point(423, 48);
            categoryControlLb1.Name = "categoryControlLb1";
            categoryControlLb1.Size = new Size(555, 531);
            categoryControlLb1.TabIndex = 8;
            categoryControlLb1.TabStop = false;
            categoryControlLb1.BtnHandler += categoryControlLb1_BtnHandler;
            // 
            // FlwPanel
            // 
            FlwPanel.BorderStyle = BorderStyle.Fixed3D;
            FlwPanel.Location = new Point(27, 389);
            FlwPanel.Name = "FlwPanel";
            FlwPanel.Padding = new Padding(2);
            FlwPanel.Size = new Size(380, 188);
            FlwPanel.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(423, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 10;
            textBox1.TabStop = false;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Transparent;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.ForeColor = Color.White;
            resetBtn.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            resetBtn.IconColor = Color.White;
            resetBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resetBtn.IconSize = 30;
            resetBtn.Location = new Point(652, 16);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(45, 26);
            resetBtn.TabIndex = 54;
            resetBtn.TabStop = false;
            resetBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(895, 19);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 2;
            label5.Text = "Categories";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 363);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 2;
            label1.Text = "Selected Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(987, 591);
            Controls.Add(resetBtn);
            Controls.Add(textBox1);
            Controls.Add(FlwPanel);
            Controls.Add(categoryControlLb1);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(tbDescription);
            Controls.Add(tbLink);
            Controls.Add(tbHeader);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Link Add Page (ESC to close)";
            Load += AddForm_Load;
            KeyDown += AddForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbHeader;
        private Label label2;
        private Label label3;
        private TextBox tbLink;
        private Label label4;
        private RichTextBox tbDescription;
        private Button button1;
        private Label lblResult;
        private Components.CategoryControlLb categoryControlLb1;
        private FlowLayoutPanel FlwPanel;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton resetBtn;
        private Label label5;
        private Label label1;
    }
}