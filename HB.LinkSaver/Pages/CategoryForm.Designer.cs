namespace HB.LinkSaver.Pages
{
    partial class CategoryForm
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
            groupBox2 = new GroupBox();
            lblUpdate = new Label();
            UpdateBtn = new Button();
            tbUpdate = new TextBox();
            groupBox1 = new GroupBox();
            tbCategoryAdd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblUpdate);
            groupBox2.Controls.Add(UpdateBtn);
            groupBox2.Controls.Add(tbUpdate);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(214, 182);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(299, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Section";
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Location = new Point(24, 21);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(0, 15);
            lblUpdate.TabIndex = 0;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.ForeColor = SystemColors.ButtonFace;
            UpdateBtn.Location = new Point(88, 64);
            UpdateBtn.Margin = new Padding(3, 2, 3, 2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(82, 22);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // tbUpdate
            // 
            tbUpdate.Location = new Point(24, 40);
            tbUpdate.Margin = new Padding(3, 2, 3, 2);
            tbUpdate.Name = "tbUpdate";
            tbUpdate.PlaceholderText = "Select and Update a existing category";
            tbUpdate.Size = new Size(259, 23);
            tbUpdate.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCategoryAdd);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(214, 32);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(299, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Section";
            // 
            // tbCategoryAdd
            // 
            tbCategoryAdd.Location = new Point(24, 31);
            tbCategoryAdd.Margin = new Padding(3, 2, 3, 2);
            tbCategoryAdd.Name = "tbCategoryAdd";
            tbCategoryAdd.PlaceholderText = "Add a new category";
            tbCategoryAdd.Size = new Size(259, 23);
            tbCategoryAdd.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(113, 66);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(238, 359);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(238, 32);
            button2.TabIndex = 2;
            button2.Text = "Delete Selected Category";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 22);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(193, 394);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(525, 480);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label lblUpdate;
        private Button UpdateBtn;
        private TextBox tbUpdate;
        private GroupBox groupBox1;
        private TextBox tbCategoryAdd;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
    }
}