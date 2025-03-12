namespace HB.LinkSaver.Pages
{
    partial class UpdateForm2
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
            resetBtn = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            FlwPanel = new FlowLayoutPanel();
            categoryControlLb1 = new HB.LinkSaver.Components.CategoryControlLb();
            lblResult = new Label();
            btnUpdate = new Button();
            tbDescription = new RichTextBox();
            tbLink = new TextBox();
            tbHeader = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbCategoryGroup = new HB.LinkSaver.Components.RJComboBox();
            SuspendLayout();
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
            resetBtn.Location = new Point(842, 17);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(45, 26);
            resetBtn.TabIndex = 68;
            resetBtn.TabStop = false;
            resetBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 17);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 67;
            textBox1.TabStop = false;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // FlwPanel
            // 
            FlwPanel.BorderStyle = BorderStyle.Fixed3D;
            FlwPanel.Location = new Point(25, 387);
            FlwPanel.Name = "FlwPanel";
            FlwPanel.Padding = new Padding(2);
            FlwPanel.Size = new Size(380, 188);
            FlwPanel.TabIndex = 66;
            // 
            // categoryControlLb1
            // 
            categoryControlLb1.BackColor = Color.Transparent;
            categoryControlLb1.BorderStyle = BorderStyle.Fixed3D;
            categoryControlLb1.Location = new Point(421, 46);
            categoryControlLb1.Name = "categoryControlLb1";
            categoryControlLb1.Size = new Size(555, 531);
            categoryControlLb1.TabIndex = 65;
            categoryControlLb1.TabStop = false;
            categoryControlLb1.BtnHandler += categoryControlLb1_BtnHandler;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.FromArgb(128, 255, 128);
            lblResult.Location = new Point(119, 289);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(43, 15);
            lblResult.TabIndex = 64;
            lblResult.Text = "Succes";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(227, 285);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 63;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(97, 164);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(308, 89);
            tbDescription.TabIndex = 57;
            tbDescription.Text = "";
            // 
            // tbLink
            // 
            tbLink.Location = new Point(97, 89);
            tbLink.Name = "tbLink";
            tbLink.Size = new Size(308, 23);
            tbLink.TabIndex = 56;
            // 
            // tbHeader
            // 
            tbHeader.Location = new Point(97, 16);
            tbHeader.Name = "tbHeader";
            tbHeader.Size = new Size(308, 23);
            tbHeader.TabIndex = 55;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 361);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 58;
            label1.Text = "Selected Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(893, 17);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 59;
            label5.Text = "Categories";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 164);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 60;
            label4.Text = "Description :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 89);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 61;
            label3.Text = "Link :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 16);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 62;
            label2.Text = "Header :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbCategoryGroup
            // 
            cbCategoryGroup.BackColor = Color.WhiteSmoke;
            cbCategoryGroup.BorderColor = Color.MediumSlateBlue;
            cbCategoryGroup.BorderSize = 1;
            cbCategoryGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoryGroup.Font = new Font("Segoe UI", 10F);
            cbCategoryGroup.ForeColor = Color.DimGray;
            cbCategoryGroup.IconColor = Color.MediumSlateBlue;
            cbCategoryGroup.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCategoryGroup.ListTextColor = Color.DimGray;
            cbCategoryGroup.Location = new Point(650, 13);
            cbCategoryGroup.MinimumSize = new Size(150, 15);
            cbCategoryGroup.Name = "cbCategoryGroup";
            cbCategoryGroup.Padding = new Padding(1);
            cbCategoryGroup.Size = new Size(150, 29);
            cbCategoryGroup.TabIndex = 69;
            cbCategoryGroup.Texts = "";
            cbCategoryGroup.OnSelectedIndexChanged += cbCategoryGroup_OnSelectedIndexChanged;
            // 
            // UpdateForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(987, 591);
            Controls.Add(cbCategoryGroup);
            Controls.Add(resetBtn);
            Controls.Add(textBox1);
            Controls.Add(FlwPanel);
            Controls.Add(categoryControlLb1);
            Controls.Add(lblResult);
            Controls.Add(btnUpdate);
            Controls.Add(tbDescription);
            Controls.Add(tbLink);
            Controls.Add(tbHeader);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UpdateForm2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update2";
            Load += Update2_Load;
            KeyDown += AddForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton resetBtn;
        private TextBox textBox1;
        private FlowLayoutPanel FlwPanel;
        private Components.CategoryControlLb categoryControlLb1;
        private Label lblResult;
        private Button btnUpdate;
        private RichTextBox tbDescription;
        private TextBox tbLink;
        private TextBox tbHeader;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Components.RJComboBox cbCategoryGroup;
    }
}