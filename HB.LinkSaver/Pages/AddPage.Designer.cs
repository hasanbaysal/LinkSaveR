namespace HB.LinkSaver.Pages
{
    partial class AddPage
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
            RtbDescription = new RichTextBox();
            TbLink = new TextBox();
            TbHeader = new TextBox();
            BtnSave = new Button();
            panel1 = new Panel();
            LbCategories = new ListBox();
            button1 = new Button();
            label5 = new Label();
            BtnUpdate = new Button();
            lblPageInfo = new Label();
            SuspendLayout();
            // 
            // RtbDescription
            // 
            RtbDescription.Location = new Point(157, 344);
            RtbDescription.Margin = new Padding(3, 2, 3, 2);
            RtbDescription.Name = "RtbDescription";
            RtbDescription.Size = new Size(311, 91);
            RtbDescription.TabIndex = 16;
            RtbDescription.Text = "";
            // 
            // TbLink
            // 
            TbLink.Location = new Point(157, 279);
            TbLink.Margin = new Padding(3, 2, 3, 2);
            TbLink.Name = "TbLink";
            TbLink.PlaceholderText = "Link - Must Be Uniqueue";
            TbLink.Size = new Size(311, 23);
            TbLink.TabIndex = 14;
            // 
            // TbHeader
            // 
            TbHeader.Location = new Point(157, 208);
            TbHeader.Margin = new Padding(3, 2, 3, 2);
            TbHeader.Name = "TbHeader";
            TbHeader.PlaceholderText = "Header - Must Be Uniqueue";
            TbHeader.Size = new Size(311, 23);
            TbHeader.TabIndex = 15;
            // 
            // BtnSave
            // 
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(199, 490);
            BtnSave.Margin = new Padding(3, 2, 3, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(82, 22);
            BtnSave.TabIndex = 13;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 39, 49);
            panel1.Location = new Point(157, 100);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 94);
            panel1.TabIndex = 12;
            // 
            // LbCategories
            // 
            LbCategories.FormattingEnabled = true;
            LbCategories.ItemHeight = 15;
            LbCategories.Location = new Point(20, 56);
            LbCategories.Margin = new Padding(3, 2, 3, 2);
            LbCategories.Name = "LbCategories";
            LbCategories.Size = new Size(132, 409);
            LbCategories.TabIndex = 11;
            LbCategories.SelectedIndexChanged += LbCategories_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(286, 490);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 13;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(199, 66);
            label5.Name = "label5";
            label5.Size = new Size(248, 19);
            label5.TabIndex = 17;
            label5.Text = "Selected Categories";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(111, 490);
            BtnUpdate.Margin = new Padding(3, 2, 3, 2);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(82, 22);
            BtnUpdate.TabIndex = 13;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPageInfo.ForeColor = Color.White;
            lblPageInfo.Location = new Point(165, 14);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(177, 25);
            lblPageInfo.TabIndex = 8;
            lblPageInfo.Text = "Add a New Record";
            // 
            // AddPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            Controls.Add(lblPageInfo);
            Controls.Add(label5);
            Controls.Add(RtbDescription);
            Controls.Add(TbLink);
            Controls.Add(TbHeader);
            Controls.Add(button1);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnSave);
            Controls.Add(panel1);
            Controls.Add(LbCategories);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddPage";
            Size = new Size(487, 536);
            Load += AddPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RtbDescription;
        private TextBox TbLink;
        private TextBox TbHeader;
        private Button BtnSave;
        private Panel panel1;
        public ListBox LbCategories;
        private Button button1;
        private Label label5;
        private Button BtnUpdate;
        private Label lblPageInfo;
    }
}
