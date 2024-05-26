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
            SuspendLayout();
            // 
            // RtbDescription
            // 
            RtbDescription.Location = new Point(179, 259);
            RtbDescription.Name = "RtbDescription";
            RtbDescription.Size = new Size(355, 120);
            RtbDescription.TabIndex = 16;
            RtbDescription.Text = "";
            // 
            // TbLink
            // 
            TbLink.Location = new Point(179, 226);
            TbLink.Name = "TbLink";
            TbLink.PlaceholderText = "Link - Must Be Uniqueue";
            TbLink.Size = new Size(355, 27);
            TbLink.TabIndex = 14;
            // 
            // TbHeader
            // 
            TbHeader.Location = new Point(179, 193);
            TbHeader.Name = "TbHeader";
            TbHeader.PlaceholderText = "Header - Must Be Uniqueue";
            TbHeader.Size = new Size(355, 27);
            TbHeader.TabIndex = 15;
            // 
            // BtnSave
            // 
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(236, 400);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 29);
            BtnSave.TabIndex = 13;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 39, 49);
            panel1.Location = new Point(179, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 126);
            panel1.TabIndex = 12;
            // 
            // LbCategories
            // 
            LbCategories.FormattingEnabled = true;
            LbCategories.Location = new Point(23, 15);
            LbCategories.Name = "LbCategories";
            LbCategories.Size = new Size(150, 364);
            LbCategories.TabIndex = 11;
            LbCategories.SelectedIndexChanged += LbCategories_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(350, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(212, 9);
            label5.Name = "label5";
            label5.Size = new Size(283, 25);
            label5.TabIndex = 17;
            label5.Text = "Selected Categories";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(118, 400);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 29);
            BtnUpdate.TabIndex = 13;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // AddPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 49);
            Controls.Add(label5);
            Controls.Add(RtbDescription);
            Controls.Add(TbLink);
            Controls.Add(TbHeader);
            Controls.Add(button1);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnSave);
            Controls.Add(panel1);
            Controls.Add(LbCategories);
            Name = "AddPage";
            Size = new Size(557, 498);
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
        private ListBox LbCategories;
        private Button button1;
        private Label label5;
        private Button BtnUpdate;
    }
}
