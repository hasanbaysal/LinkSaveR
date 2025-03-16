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
            lblResultUpdate = new Label();
            lblUpdate = new Label();
            UpdateBtn = new Button();
            tbUpdate = new TextBox();
            groupBox1 = new GroupBox();
            lblResultAdd = new Label();
            tbCategoryAdd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            lblDeleteResult = new Label();
            groupBox3 = new GroupBox();
            lblCategoryGroupNameStatus = new Label();
            tbCategoryGroup = new TextBox();
            btnAddCategoryGroup = new Button();
            cbCategoryGroupNames = new HB.LinkSaver.Components.RJComboBox();
            btnDelGroup = new Button();
            groupBox4 = new GroupBox();
            lblCateGroupNameUpdateStatus = new Label();
            tbCategoryGroupNameUpdate = new TextBox();
            btnUpdateCategoryName = new Button();
            lblOldCategoryName = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblResultUpdate);
            groupBox2.Controls.Add(lblUpdate);
            groupBox2.Controls.Add(UpdateBtn);
            groupBox2.Controls.Add(tbUpdate);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(314, 460);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(299, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Category Section";
            // 
            // lblResultUpdate
            // 
            lblResultUpdate.AutoSize = true;
            lblResultUpdate.ForeColor = Color.FromArgb(128, 255, 128);
            lblResultUpdate.Location = new Point(24, 71);
            lblResultUpdate.Name = "lblResultUpdate";
            lblResultUpdate.Size = new Size(43, 15);
            lblResultUpdate.TabIndex = 8;
            lblResultUpdate.Text = "Succes";
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
            UpdateBtn.Location = new Point(113, 67);
            UpdateBtn.Margin = new Padding(3, 2, 3, 2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(82, 22);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "UPDATE";
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
            tbUpdate.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultAdd);
            groupBox1.Controls.Add(tbCategoryAdd);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(314, 336);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(299, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Category Section";
            // 
            // lblResultAdd
            // 
            lblResultAdd.AutoSize = true;
            lblResultAdd.ForeColor = Color.FromArgb(128, 255, 128);
            lblResultAdd.Location = new Point(24, 73);
            lblResultAdd.Name = "lblResultAdd";
            lblResultAdd.Size = new Size(43, 15);
            lblResultAdd.TabIndex = 8;
            lblResultAdd.Text = "Succes";
            // 
            // tbCategoryAdd
            // 
            tbCategoryAdd.Location = new Point(24, 31);
            tbCategoryAdd.Margin = new Padding(3, 2, 3, 2);
            tbCategoryAdd.Name = "tbCategoryAdd";
            tbCategoryAdd.PlaceholderText = "Add a new category";
            tbCategoryAdd.Size = new Size(259, 23);
            tbCategoryAdd.TabIndex = 0;
            tbCategoryAdd.TabStop = false;
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
            button2.Location = new Point(338, 573);
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
            listBox1.BackColor = Color.FromArgb(23, 29, 39);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(17, 105);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 499);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblDeleteResult
            // 
            lblDeleteResult.AutoSize = true;
            lblDeleteResult.ForeColor = Color.FromArgb(128, 255, 128);
            lblDeleteResult.Location = new Point(436, 621);
            lblDeleteResult.Name = "lblDeleteResult";
            lblDeleteResult.Size = new Size(43, 15);
            lblDeleteResult.TabIndex = 8;
            lblDeleteResult.Text = "Succes";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblCategoryGroupNameStatus);
            groupBox3.Controls.Add(tbCategoryGroup);
            groupBox3.Controls.Add(btnAddCategoryGroup);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(314, 227);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(299, 105);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Category Group Section";
            // 
            // lblCategoryGroupNameStatus
            // 
            lblCategoryGroupNameStatus.AutoSize = true;
            lblCategoryGroupNameStatus.ForeColor = Color.FromArgb(128, 255, 128);
            lblCategoryGroupNameStatus.Location = new Point(24, 73);
            lblCategoryGroupNameStatus.Name = "lblCategoryGroupNameStatus";
            lblCategoryGroupNameStatus.Size = new Size(43, 15);
            lblCategoryGroupNameStatus.TabIndex = 8;
            lblCategoryGroupNameStatus.Text = "Succes";
            // 
            // tbCategoryGroup
            // 
            tbCategoryGroup.Location = new Point(24, 31);
            tbCategoryGroup.Margin = new Padding(3, 2, 3, 2);
            tbCategoryGroup.Name = "tbCategoryGroup";
            tbCategoryGroup.PlaceholderText = "Add a new category group";
            tbCategoryGroup.Size = new Size(259, 23);
            tbCategoryGroup.TabIndex = 0;
            tbCategoryGroup.TabStop = false;
            // 
            // btnAddCategoryGroup
            // 
            btnAddCategoryGroup.FlatStyle = FlatStyle.Flat;
            btnAddCategoryGroup.ForeColor = SystemColors.ButtonFace;
            btnAddCategoryGroup.Location = new Point(113, 66);
            btnAddCategoryGroup.Margin = new Padding(3, 2, 3, 2);
            btnAddCategoryGroup.Name = "btnAddCategoryGroup";
            btnAddCategoryGroup.Size = new Size(82, 22);
            btnAddCategoryGroup.TabIndex = 1;
            btnAddCategoryGroup.Text = "ADD";
            btnAddCategoryGroup.UseVisualStyleBackColor = true;
            btnAddCategoryGroup.Click += btnAddCategoryGroup_Click;
            // 
            // cbCategoryGroupNames
            // 
            cbCategoryGroupNames.BackColor = Color.WhiteSmoke;
            cbCategoryGroupNames.BorderColor = Color.MediumSlateBlue;
            cbCategoryGroupNames.BorderSize = 1;
            cbCategoryGroupNames.DropDownStyle = ComboBoxStyle.DropDown;
            cbCategoryGroupNames.Font = new Font("Segoe UI", 10F);
            cbCategoryGroupNames.ForeColor = Color.DimGray;
            cbCategoryGroupNames.IconColor = Color.MediumSlateBlue;
            cbCategoryGroupNames.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCategoryGroupNames.ListTextColor = Color.DimGray;
            cbCategoryGroupNames.Location = new Point(52, 50);
            cbCategoryGroupNames.MinimumSize = new Size(200, 30);
            cbCategoryGroupNames.Name = "cbCategoryGroupNames";
            cbCategoryGroupNames.Padding = new Padding(1);
            cbCategoryGroupNames.Size = new Size(200, 30);
            cbCategoryGroupNames.TabIndex = 10;
            cbCategoryGroupNames.Texts = "";
            cbCategoryGroupNames.OnSelectedIndexChanged += cbCategoryGroupNames_OnSelectedIndexChanged;
            // 
            // btnDelGroup
            // 
            btnDelGroup.FlatStyle = FlatStyle.Flat;
            btnDelGroup.ForeColor = SystemColors.ButtonFace;
            btnDelGroup.Location = new Point(342, 50);
            btnDelGroup.Margin = new Padding(3, 2, 3, 2);
            btnDelGroup.Name = "btnDelGroup";
            btnDelGroup.Size = new Size(238, 32);
            btnDelGroup.TabIndex = 2;
            btnDelGroup.Text = "Delete Curent Category Group";
            btnDelGroup.UseVisualStyleBackColor = true;
            btnDelGroup.Click += btnDelGroup_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblOldCategoryName);
            groupBox4.Controls.Add(lblCateGroupNameUpdateStatus);
            groupBox4.Controls.Add(tbCategoryGroupNameUpdate);
            groupBox4.Controls.Add(btnUpdateCategoryName);
            groupBox4.ForeColor = SystemColors.ButtonFace;
            groupBox4.Location = new Point(314, 100);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(299, 111);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Update Category Group Section";
            // 
            // lblCateGroupNameUpdateStatus
            // 
            lblCateGroupNameUpdateStatus.AutoSize = true;
            lblCateGroupNameUpdateStatus.ForeColor = Color.FromArgb(128, 255, 128);
            lblCateGroupNameUpdateStatus.Location = new Point(24, 80);
            lblCateGroupNameUpdateStatus.Name = "lblCateGroupNameUpdateStatus";
            lblCateGroupNameUpdateStatus.Size = new Size(43, 15);
            lblCateGroupNameUpdateStatus.TabIndex = 8;
            lblCateGroupNameUpdateStatus.Text = "Succes";
            // 
            // tbCategoryGroupNameUpdate
            // 
            tbCategoryGroupNameUpdate.Location = new Point(24, 31);
            tbCategoryGroupNameUpdate.Margin = new Padding(3, 2, 3, 2);
            tbCategoryGroupNameUpdate.Name = "tbCategoryGroupNameUpdate";
            tbCategoryGroupNameUpdate.PlaceholderText = "Select and Update a existing category group";
            tbCategoryGroupNameUpdate.Size = new Size(259, 23);
            tbCategoryGroupNameUpdate.TabIndex = 0;
            tbCategoryGroupNameUpdate.TabStop = false;
            // 
            // btnUpdateCategoryName
            // 
            btnUpdateCategoryName.FlatStyle = FlatStyle.Flat;
            btnUpdateCategoryName.ForeColor = SystemColors.ButtonFace;
            btnUpdateCategoryName.Location = new Point(113, 80);
            btnUpdateCategoryName.Margin = new Padding(3, 2, 3, 2);
            btnUpdateCategoryName.Name = "btnUpdateCategoryName";
            btnUpdateCategoryName.Size = new Size(82, 22);
            btnUpdateCategoryName.TabIndex = 1;
            btnUpdateCategoryName.Text = "UPDATE";
            btnUpdateCategoryName.UseVisualStyleBackColor = true;
            btnUpdateCategoryName.Click += btnUpdateCategoryName_Click;
            // 
            // lblOldCategoryName
            // 
            lblOldCategoryName.AutoSize = true;
            lblOldCategoryName.Location = new Point(24, 56);
            lblOldCategoryName.Name = "lblOldCategoryName";
            lblOldCategoryName.Size = new Size(0, 15);
            lblOldCategoryName.TabIndex = 9;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(638, 647);
            Controls.Add(cbCategoryGroupNames);
            Controls.Add(lblDeleteResult);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnDelGroup);
            Controls.Add(button2);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Category Page (ESC to Close)";
            Load += CategoryForm_Load;
            KeyDown += CategoryForm_KeyDown;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblResultUpdate;
        private Label lblResultAdd;
        private Label lblDeleteResult;
        private GroupBox groupBox3;
        private Label lblCategoryGroupNameStatus;
        private TextBox tbCategoryGroup;
        private Button btnAddCategoryGroup;
        private Components.RJComboBox cbCategoryGroupNames;
        private Button btnDelGroup;
        private GroupBox groupBox4;
        private Label lblCateGroupNameUpdateStatus;
        private TextBox tbCategoryGroupNameUpdate;
        private Button btnUpdateCategoryName;
        private Label lblOldCategoryName;
    }
}