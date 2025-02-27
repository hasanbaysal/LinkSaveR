namespace HB.LinkSaver
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PnlTop = new Panel();
            BtnMin = new FontAwesome.Sharp.IconButton();
            btnStatusInfo = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            panel2 = new Panel();
            BtnClose = new FontAwesome.Sharp.IconButton();
            togleSizeBtn = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            CbHeaderOrDescription = new HB.LinkSaver.Components.RJToggleButton();
            tbLinkSearch = new TextBox();
            DGW = new DataGridView();
            BtnDelete = new FontAwesome.Sharp.IconButton();
            BtnOpenLink = new FontAwesome.Sharp.IconButton();
            BtnCategories = new FontAwesome.Sharp.IconButton();
            BtnSettings = new FontAwesome.Sharp.IconButton();
            BtnUpdate = new FontAwesome.Sharp.IconButton();
            BtnAdd = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            resetBtn = new FontAwesome.Sharp.IconButton();
            CategoryControlPanel = new HB.LinkSaver.Components.CategoryControlLb();
            tbDescription = new RichTextBox();
            FlwPanel = new FlowLayoutPanel();
            tbCategorySearch = new TextBox();
            lblSearchOption = new Label();
            PnlTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGW).BeginInit();
            SuspendLayout();
            // 
            // PnlTop
            // 
            PnlTop.BackColor = Color.SteelBlue;
            PnlTop.Controls.Add(BtnMin);
            PnlTop.Controls.Add(btnStatusInfo);
            PnlTop.Controls.Add(label8);
            PnlTop.Controls.Add(panel2);
            PnlTop.Controls.Add(label1);
            PnlTop.Dock = DockStyle.Top;
            PnlTop.Location = new Point(0, 0);
            PnlTop.Margin = new Padding(3, 2, 3, 2);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(1438, 30);
            PnlTop.TabIndex = 2;
            PnlTop.MouseDown += PnlTop_MouseDown;
            // 
            // BtnMin
            // 
            BtnMin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnMin.BackColor = Color.SteelBlue;
            BtnMin.FlatAppearance.BorderSize = 0;
            BtnMin.FlatStyle = FlatStyle.Flat;
            BtnMin.ForeColor = Color.White;
            BtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            BtnMin.IconColor = Color.White;
            BtnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMin.IconSize = 30;
            BtnMin.Location = new Point(1340, 2);
            BtnMin.Margin = new Padding(3, 2, 3, 2);
            BtnMin.Name = "BtnMin";
            BtnMin.Size = new Size(22, 27);
            BtnMin.TabIndex = 0;
            BtnMin.TabStop = false;
            BtnMin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnMin.UseVisualStyleBackColor = false;
            BtnMin.Click += BtnMin_Click;
            // 
            // btnStatusInfo
            // 
            btnStatusInfo.FlatAppearance.BorderSize = 0;
            btnStatusInfo.FlatStyle = FlatStyle.Flat;
            btnStatusInfo.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            btnStatusInfo.IconColor = Color.Black;
            btnStatusInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStatusInfo.IconSize = 40;
            btnStatusInfo.Location = new Point(90, 3);
            btnStatusInfo.Name = "btnStatusInfo";
            btnStatusInfo.Size = new Size(30, 24);
            btnStatusInfo.TabIndex = 6;
            btnStatusInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatusInfo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(8, 3);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 5;
            label8.Text = "LinkSaver";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnClose);
            panel2.Controls.Add(togleSizeBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1371, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 29);
            panel2.TabIndex = 4;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnClose.BackColor = Color.SteelBlue;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.White;
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            BtnClose.IconColor = Color.White;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.IconSize = 30;
            BtnClose.Location = new Point(31, 0);
            BtnClose.Margin = new Padding(3, 2, 3, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(33, 27);
            BtnClose.TabIndex = 0;
            BtnClose.TabStop = false;
            BtnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // togleSizeBtn
            // 
            togleSizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            togleSizeBtn.BackColor = Color.SteelBlue;
            togleSizeBtn.FlatAppearance.BorderSize = 0;
            togleSizeBtn.FlatStyle = FlatStyle.Flat;
            togleSizeBtn.ForeColor = Color.White;
            togleSizeBtn.IconChar = FontAwesome.Sharp.IconChar.Expand;
            togleSizeBtn.IconColor = Color.White;
            togleSizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            togleSizeBtn.IconSize = 30;
            togleSizeBtn.Location = new Point(3, 3);
            togleSizeBtn.Margin = new Padding(3, 2, 3, 2);
            togleSizeBtn.Name = "togleSizeBtn";
            togleSizeBtn.Size = new Size(22, 27);
            togleSizeBtn.TabIndex = 0;
            togleSizeBtn.TabStop = false;
            togleSizeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            togleSizeBtn.UseVisualStyleBackColor = false;
            togleSizeBtn.Click += togleSizeBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 29);
            label1.Name = "label1";
            label1.Size = new Size(1438, 1);
            label1.TabIndex = 0;
            // 
            // CbHeaderOrDescription
            // 
            CbHeaderOrDescription.AutoSize = true;
            CbHeaderOrDescription.Location = new Point(314, 58);
            CbHeaderOrDescription.Margin = new Padding(3, 2, 3, 2);
            CbHeaderOrDescription.MinimumSize = new Size(39, 16);
            CbHeaderOrDescription.Name = "CbHeaderOrDescription";
            CbHeaderOrDescription.OffBackColor = Color.Gray;
            CbHeaderOrDescription.OffToggleColor = Color.Gainsboro;
            CbHeaderOrDescription.OnBackColor = Color.SteelBlue;
            CbHeaderOrDescription.OnToggleColor = Color.WhiteSmoke;
            CbHeaderOrDescription.Size = new Size(39, 16);
            CbHeaderOrDescription.TabIndex = 43;
            CbHeaderOrDescription.TabStop = false;
            CbHeaderOrDescription.UseVisualStyleBackColor = true;
            CbHeaderOrDescription.CheckedChanged += CbHeaderOrDescription_CheckedChanged;
            // 
            // tbLinkSearch
            // 
            tbLinkSearch.Location = new Point(12, 54);
            tbLinkSearch.Margin = new Padding(3, 2, 3, 2);
            tbLinkSearch.Name = "tbLinkSearch";
            tbLinkSearch.PlaceholderText = "Search By Header Or Description";
            tbLinkSearch.Size = new Size(280, 23);
            tbLinkSearch.TabIndex = 41;
            tbLinkSearch.TabStop = false;
            tbLinkSearch.KeyUp += textBox1_KeyUp;
            // 
            // DGW
            // 
            DGW.AllowUserToAddRows = false;
            DGW.AllowUserToDeleteRows = false;
            DGW.AllowUserToResizeColumns = false;
            DGW.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 45);
            DGW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DGW.BackgroundColor = Color.FromArgb(30, 30, 30);
            DGW.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGW.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(5, 10, 5, 10);
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGW.DefaultCellStyle = dataGridViewCellStyle3;
            DGW.EnableHeadersVisualStyles = false;
            DGW.GridColor = Color.FromArgb(60, 60, 60);
            DGW.Location = new Point(12, 83);
            DGW.MultiSelect = false;
            DGW.Name = "DGW";
            DGW.ReadOnly = true;
            DGW.RowHeadersVisible = false;
            DGW.RowHeadersWidth = 51;
            DGW.RowTemplate.Height = 35;
            DGW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGW.Size = new Size(826, 680);
            DGW.StandardTab = true;
            DGW.TabIndex = 1;
            DGW.TabStop = false;
            DGW.CellClick += DGW_CellClick;
            DGW.CellDoubleClick += DGW_CellDoubleClick;
            DGW.CellPainting += DGW_CellPainting;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.Transparent;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnDelete.ForeColor = Color.White;
            BtnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnDelete.IconColor = Color.White;
            BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDelete.IconSize = 30;
            BtnDelete.Location = new Point(728, 48);
            BtnDelete.Margin = new Padding(3, 2, 3, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(45, 26);
            BtnDelete.TabIndex = 38;
            BtnDelete.TabStop = false;
            BtnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            BtnDelete.MouseLeave += BtnDelete_MouseLeave;
            BtnDelete.MouseHover += BtnDelete_MouseHover;
            // 
            // BtnOpenLink
            // 
            BtnOpenLink.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnOpenLink.BackColor = Color.Transparent;
            BtnOpenLink.FlatAppearance.BorderSize = 0;
            BtnOpenLink.FlatStyle = FlatStyle.Flat;
            BtnOpenLink.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnOpenLink.ForeColor = Color.White;
            BtnOpenLink.IconChar = FontAwesome.Sharp.IconChar.Chrome;
            BtnOpenLink.IconColor = Color.White;
            BtnOpenLink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnOpenLink.IconSize = 30;
            BtnOpenLink.Location = new Point(779, 48);
            BtnOpenLink.Margin = new Padding(3, 2, 3, 2);
            BtnOpenLink.Name = "BtnOpenLink";
            BtnOpenLink.Size = new Size(45, 26);
            BtnOpenLink.TabIndex = 37;
            BtnOpenLink.TabStop = false;
            BtnOpenLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOpenLink.UseVisualStyleBackColor = false;
            BtnOpenLink.Click += BtnOpenLink_Click;
            BtnOpenLink.MouseLeave += BtnDelete_MouseLeave;
            BtnOpenLink.MouseHover += BtnDelete_MouseHover;
            // 
            // BtnCategories
            // 
            BtnCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCategories.BackColor = Color.FromArgb(23, 162, 184);
            BtnCategories.FlatAppearance.BorderSize = 0;
            BtnCategories.FlatStyle = FlatStyle.Flat;
            BtnCategories.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnCategories.ForeColor = Color.White;
            BtnCategories.IconChar = FontAwesome.Sharp.IconChar.C;
            BtnCategories.IconColor = Color.White;
            BtnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCategories.IconSize = 30;
            BtnCategories.Location = new Point(1340, 39);
            BtnCategories.Margin = new Padding(3, 2, 3, 2);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(40, 35);
            BtnCategories.TabIndex = 36;
            BtnCategories.TabStop = false;
            BtnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCategories.UseVisualStyleBackColor = false;
            BtnCategories.Click += BtnCategories_Click;
            // 
            // BtnSettings
            // 
            BtnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSettings.BackColor = Color.FromArgb(45, 64, 80);
            BtnSettings.FlatAppearance.BorderSize = 0;
            BtnSettings.FlatStyle = FlatStyle.Flat;
            BtnSettings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSettings.ForeColor = Color.White;
            BtnSettings.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            BtnSettings.IconColor = Color.White;
            BtnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSettings.IconSize = 30;
            BtnSettings.Location = new Point(1386, 40);
            BtnSettings.Margin = new Padding(3, 2, 3, 2);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(40, 35);
            BtnSettings.TabIndex = 35;
            BtnSettings.TabStop = false;
            BtnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSettings.UseVisualStyleBackColor = false;
            BtnSettings.Click += BtnSettings_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUpdate.BackColor = Color.FromArgb(209, 84, 0);
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnUpdate.IconColor = Color.White;
            BtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUpdate.IconSize = 30;
            BtnUpdate.Location = new Point(1294, 39);
            BtnUpdate.Margin = new Padding(3, 2, 3, 2);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(40, 35);
            BtnUpdate.TabIndex = 39;
            BtnUpdate.TabStop = false;
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdd.BackColor = Color.FromArgb(92, 184, 92);
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnAdd.ForeColor = Color.White;
            BtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            BtnAdd.IconColor = Color.White;
            BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAdd.IconSize = 30;
            BtnAdd.Location = new Point(1248, 39);
            BtnAdd.Margin = new Padding(3, 2, 3, 2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(40, 35);
            BtnAdd.TabIndex = 34;
            BtnAdd.TabStop = false;
            BtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Silver;
            label4.Location = new Point(8, 771);
            label4.Name = "label4";
            label4.Size = new Size(1446, 1);
            label4.TabIndex = 48;
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetBtn.BackColor = Color.Transparent;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.ForeColor = Color.White;
            resetBtn.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            resetBtn.IconColor = Color.White;
            resetBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resetBtn.IconSize = 30;
            resetBtn.Location = new Point(677, 48);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(45, 26);
            resetBtn.TabIndex = 53;
            resetBtn.TabStop = false;
            resetBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            resetBtn.MouseLeave += BtnDelete_MouseLeave;
            resetBtn.MouseHover += BtnDelete_MouseHover;
            // 
            // CategoryControlPanel
            // 
            CategoryControlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CategoryControlPanel.BackColor = Color.Transparent;
            CategoryControlPanel.BorderStyle = BorderStyle.FixedSingle;
            CategoryControlPanel.Location = new Point(862, 83);
            CategoryControlPanel.Name = "CategoryControlPanel";
            CategoryControlPanel.Size = new Size(564, 443);
            CategoryControlPanel.TabIndex = 54;
            CategoryControlPanel.TabStop = false;
            CategoryControlPanel.BtnHandler += categoryControlLb1_BtnHandler;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbDescription.BackColor = Color.FromArgb(30, 30, 30);
            tbDescription.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbDescription.ForeColor = Color.White;
            tbDescription.Location = new Point(862, 653);
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.Size = new Size(564, 101);
            tbDescription.TabIndex = 56;
            tbDescription.TabStop = false;
            tbDescription.Text = "";
            tbDescription.MouseLeave += tbDescription_MouseLeave;
            tbDescription.MouseHover += tbDescription_MouseHover;
            // 
            // FlwPanel
            // 
            FlwPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FlwPanel.AutoScroll = true;
            FlwPanel.BackColor = Color.Transparent;
            FlwPanel.BorderStyle = BorderStyle.FixedSingle;
            FlwPanel.Location = new Point(862, 541);
            FlwPanel.Margin = new Padding(3, 2, 3, 2);
            FlwPanel.Name = "FlwPanel";
            FlwPanel.Padding = new Padding(3, 2, 3, 2);
            FlwPanel.Size = new Size(564, 107);
            FlwPanel.TabIndex = 49;
            // 
            // tbCategorySearch
            // 
            tbCategorySearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCategorySearch.Location = new Point(862, 54);
            tbCategorySearch.Margin = new Padding(3, 2, 3, 2);
            tbCategorySearch.Name = "tbCategorySearch";
            tbCategorySearch.PlaceholderText = "Search Category";
            tbCategorySearch.Size = new Size(221, 23);
            tbCategorySearch.TabIndex = 41;
            tbCategorySearch.TabStop = false;
            tbCategorySearch.KeyUp += textBox2_KeyUp;
            // 
            // lblSearchOption
            // 
            lblSearchOption.AutoSize = true;
            lblSearchOption.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSearchOption.ForeColor = SystemColors.ButtonHighlight;
            lblSearchOption.Location = new Point(314, 39);
            lblSearchOption.Name = "lblSearchOption";
            lblSearchOption.Size = new Size(44, 13);
            lblSearchOption.TabIndex = 5;
            lblSearchOption.Text = "Header";
            lblSearchOption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1438, 775);
            Controls.Add(CategoryControlPanel);
            Controls.Add(tbDescription);
            Controls.Add(lblSearchOption);
            Controls.Add(resetBtn);
            Controls.Add(label4);
            Controls.Add(CbHeaderOrDescription);
            Controls.Add(tbCategorySearch);
            Controls.Add(tbLinkSearch);
            Controls.Add(DGW);
            Controls.Add(BtnDelete);
            Controls.Add(BtnOpenLink);
            Controls.Add(BtnCategories);
            Controls.Add(BtnSettings);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnAdd);
            Controls.Add(PnlTop);
            Controls.Add(FlwPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LinK Saver";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            Paint += MainForm_Paint;
            KeyDown += MainForm_KeyDown;
            PnlTop.ResumeLayout(false);
            PnlTop.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PnlTop;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMin;
        private Panel panel2;
        private Components.RJToggleButton CbHeaderOrDescription;
        private TextBox tbLinkSearch;
        private DataGridView DGW;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnOpenLink;
        private FontAwesome.Sharp.IconButton BtnCategories;
        private FontAwesome.Sharp.IconButton BtnSettings;
        private FontAwesome.Sharp.IconButton BtnUpdate;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private Label label8;
        private Label label4;
        private FontAwesome.Sharp.IconButton resetBtn;
        private Components.CategoryControlLb CategoryControlPanel;
        private RichTextBox tbDescription;
        private FlowLayoutPanel FlwPanel;
        private TextBox tbCategorySearch;
        private FontAwesome.Sharp.IconButton btnStatusInfo;
        private FontAwesome.Sharp.IconButton togleSizeBtn;
        private Label lblSearchOption;
    }
}
