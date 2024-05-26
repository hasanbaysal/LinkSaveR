namespace HB.LinkSaver.Pages
{
    partial class CategoryPage
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
            listBox1 = new ListBox();
            tbUpdate = new TextBox();
            UpdateBtn = new Button();
            tbCategoryAdd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblUpdate = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(16, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tbUpdate
            // 
            tbUpdate.Location = new Point(27, 53);
            tbUpdate.Name = "tbUpdate";
            tbUpdate.PlaceholderText = "Select and Update a existing category";
            tbUpdate.Size = new Size(257, 27);
            tbUpdate.TabIndex = 1;
            // 
            // UpdateBtn
            // 
            UpdateBtn.ForeColor = SystemColors.ActiveCaptionText;
            UpdateBtn.Location = new Point(101, 86);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // tbCategoryAdd
            // 
            tbCategoryAdd.Location = new Point(23, 37);
            tbCategoryAdd.Name = "tbCategoryAdd";
            tbCategoryAdd.PlaceholderText = "Add a new category";
            tbCategoryAdd.Size = new Size(257, 27);
            tbCategoryAdd.TabIndex = 3;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(97, 84);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(104, 387);
            button2.Name = "button2";
            button2.Size = new Size(382, 42);
            button2.TabIndex = 5;
            button2.Text = "Delete Selected Category";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCategoryAdd);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(251, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 140);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Section";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblUpdate);
            groupBox2.Controls.Add(UpdateBtn);
            groupBox2.Controls.Add(tbUpdate);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(247, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 132);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Section";
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Location = new Point(27, 30);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(0, 20);
            lblUpdate.TabIndex = 3;
            // 
            // CategoryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 49);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Name = "CategoryPage";
            Size = new Size(557, 498);
            Load += CategoryPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private TextBox tbUpdate;
        private Button UpdateBtn;
        private TextBox tbCategoryAdd;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblUpdate;
    }
}
