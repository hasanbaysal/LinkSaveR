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
            label8 = new Label();
            panel2 = new Panel();
            BtnMin = new FontAwesome.Sharp.IconButton();
            BtnClose = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            CbHeaderOrDescription = new Components.RJToggleButton();
            textBox1 = new TextBox();
            DGW = new DataGridView();
            BtnDelete = new FontAwesome.Sharp.IconButton();
            BtnOpenLink = new FontAwesome.Sharp.IconButton();
            BtnCategories = new FontAwesome.Sharp.IconButton();
            BtnSettings = new FontAwesome.Sharp.IconButton();
            BtnUpdate = new FontAwesome.Sharp.IconButton();
            BtnAdd = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            resetBtn = new FontAwesome.Sharp.IconButton();
            categoryControlLb1 = new Components.CategoryControlLb();
            richTextBox1 = new RichTextBox();
            FlwPanel = new FlowLayoutPanel();
            PnlTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGW).BeginInit();
            SuspendLayout();
            // 
            // PnlTop
            // 
            PnlTop.BackColor = Color.SteelBlue;
            PnlTop.Controls.Add(label8);
            PnlTop.Controls.Add(panel2);
            PnlTop.Controls.Add(label1);
            PnlTop.Dock = DockStyle.Top;
            PnlTop.Location = new Point(0, 0);
            PnlTop.Margin = new Padding(3, 2, 3, 2);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(1438, 26);
            PnlTop.TabIndex = 2;
            PnlTop.MouseDown += PnlTop_MouseDown;
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
            panel2.Controls.Add(BtnMin);
            panel2.Controls.Add(BtnClose);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1371, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 25);
            panel2.TabIndex = 4;
            // 
            // BtnMin
            // 
            BtnMin.BackColor = Color.SteelBlue;
            BtnMin.FlatAppearance.BorderSize = 0;
            BtnMin.FlatStyle = FlatStyle.Flat;
            BtnMin.ForeColor = Color.White;
            BtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            BtnMin.IconColor = Color.White;
            BtnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMin.IconSize = 30;
            BtnMin.Location = new Point(3, 2);
            BtnMin.Margin = new Padding(3, 2, 3, 2);
            BtnMin.Name = "BtnMin";
            BtnMin.Size = new Size(22, 21);
            BtnMin.TabIndex = 0;
            BtnMin.TabStop = false;
            BtnMin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnMin.UseVisualStyleBackColor = false;
            BtnMin.Click += BtnMin_Click;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.SteelBlue;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.White;
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            BtnClose.IconColor = Color.White;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.IconSize = 30;
            BtnClose.Location = new Point(32, 2);
            BtnClose.Margin = new Padding(3, 2, 3, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(33, 21);
            BtnClose.TabIndex = 0;
            BtnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.Size = new Size(1438, 1);
            label1.TabIndex = 0;
            // 
            // CbHeaderOrDescription
            // 
            CbHeaderOrDescription.AutoSize = true;
            CbHeaderOrDescription.Location = new Point(343, 54);
            CbHeaderOrDescription.Margin = new Padding(3, 2, 3, 2);
            CbHeaderOrDescription.MinimumSize = new Size(39, 16);
            CbHeaderOrDescription.Name = "CbHeaderOrDescription";
            CbHeaderOrDescription.OffBackColor = Color.Gray;
            CbHeaderOrDescription.OffToggleColor = Color.Gainsboro;
            CbHeaderOrDescription.OnBackColor = Color.MediumSlateBlue;
            CbHeaderOrDescription.OnToggleColor = Color.WhiteSmoke;
            CbHeaderOrDescription.Size = new Size(39, 16);
            CbHeaderOrDescription.TabIndex = 43;
            CbHeaderOrDescription.UseVisualStyleBackColor = true;
            CbHeaderOrDescription.CheckedChanged += CbHeaderOrDescription_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 49);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By Header Or Description";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 41;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // DGW
            // 
            DGW.AllowUserToAddRows = false;
            DGW.AllowUserToDeleteRows = false;
            DGW.AllowUserToResizeColumns = false;
            DGW.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 45);
            DGW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DGW.BackgroundColor = Color.FromArgb(30, 30, 30);
            DGW.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
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
            DGW.Margin = new Padding(3, 2, 3, 2);
            DGW.MultiSelect = false;
            DGW.Name = "DGW";
            DGW.ReadOnly = true;
            DGW.RowHeadersVisible = false;
            DGW.RowHeadersWidth = 51;
            DGW.RowTemplate.Height = 35;
            DGW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGW.Size = new Size(826, 588);
            DGW.TabIndex = 1;
            DGW.TabStop = false;
            DGW.CellClick += DGW_CellClick;
            DGW.CellPainting += DGW_CellPainting;
            // 
            // BtnDelete
            // 
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
            BtnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            BtnDelete.MouseLeave += BtnDelete_MouseLeave;
            BtnDelete.MouseHover += BtnDelete_MouseHover;
            // 
            // BtnOpenLink
            // 
            BtnOpenLink.BackColor = Color.Transparent;
            BtnOpenLink.FlatAppearance.BorderSize = 0;
            BtnOpenLink.FlatStyle = FlatStyle.Flat;
            BtnOpenLink.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnOpenLink.ForeColor = Color.White;
            BtnOpenLink.IconChar = FontAwesome.Sharp.IconChar.Chrome;
            BtnOpenLink.IconColor = Color.White;
            BtnOpenLink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnOpenLink.IconSize = 30;
            BtnOpenLink.Location = new Point(779, 49);
            BtnOpenLink.Margin = new Padding(3, 2, 3, 2);
            BtnOpenLink.Name = "BtnOpenLink";
            BtnOpenLink.Size = new Size(45, 26);
            BtnOpenLink.TabIndex = 37;
            BtnOpenLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOpenLink.UseVisualStyleBackColor = false;
            BtnOpenLink.Click += BtnOpenLink_Click;
            BtnOpenLink.MouseLeave += BtnDelete_MouseLeave;
            BtnOpenLink.MouseHover += BtnDelete_MouseHover;
            // 
            // BtnCategories
            // 
            BtnCategories.BackColor = Color.FromArgb(23, 162, 184);
            BtnCategories.FlatAppearance.BorderSize = 0;
            BtnCategories.FlatStyle = FlatStyle.Flat;
            BtnCategories.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnCategories.ForeColor = Color.White;
            BtnCategories.IconChar = FontAwesome.Sharp.IconChar.C;
            BtnCategories.IconColor = Color.White;
            BtnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCategories.IconSize = 30;
            BtnCategories.Location = new Point(1386, 39);
            BtnCategories.Margin = new Padding(3, 2, 3, 2);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(40, 35);
            BtnCategories.TabIndex = 36;
            BtnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCategories.UseVisualStyleBackColor = false;
            BtnCategories.Click += BtnCategories_Click;
            // 
            // BtnSettings
            // 
            BtnSettings.BackColor = Color.FromArgb(45, 64, 80);
            BtnSettings.FlatAppearance.BorderSize = 0;
            BtnSettings.FlatStyle = FlatStyle.Flat;
            BtnSettings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnSettings.ForeColor = Color.White;
            BtnSettings.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            BtnSettings.IconColor = Color.White;
            BtnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSettings.IconSize = 30;
            BtnSettings.Location = new Point(1340, 39);
            BtnSettings.Margin = new Padding(3, 2, 3, 2);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(40, 35);
            BtnSettings.TabIndex = 35;
            BtnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSettings.UseVisualStyleBackColor = false;
            BtnSettings.Click += BtnSettings_Click;
            // 
            // BtnUpdate
            // 
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
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnAdd
            // 
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
            BtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.BackColor = Color.Silver;
            label4.Location = new Point(8, 694);
            label4.Name = "label4";
            label4.Size = new Size(1446, 1);
            label4.TabIndex = 48;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(2, 117, 216);
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            resetBtn.IconColor = Color.White;
            resetBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resetBtn.IconSize = 15;
            resetBtn.Location = new Point(305, 50);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(32, 22);
            resetBtn.TabIndex = 53;
            resetBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // categoryControlLb1
            // 
            categoryControlLb1.BackColor = Color.FromArgb(50, 50, 50);
            categoryControlLb1.BorderStyle = BorderStyle.FixedSingle;
            categoryControlLb1.Location = new Point(862, 83);
            categoryControlLb1.Name = "categoryControlLb1";
            categoryControlLb1.Size = new Size(564, 342);
            categoryControlLb1.TabIndex = 54;
            categoryControlLb1.BtnHandler += categoryControlLb1_BtnHandler;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(862, 569);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(564, 101);
            richTextBox1.TabIndex = 56;
            richTextBox1.Text = "";
            // 
            // FlwPanel
            // 
            FlwPanel.AutoScroll = true;
            FlwPanel.BackColor = Color.Transparent;
            FlwPanel.BorderStyle = BorderStyle.FixedSingle;
            FlwPanel.Location = new Point(862, 447);
            FlwPanel.Margin = new Padding(3, 2, 3, 2);
            FlwPanel.Name = "FlwPanel";
            FlwPanel.Padding = new Padding(3, 2, 3, 2);
            FlwPanel.Size = new Size(564, 107);
            FlwPanel.TabIndex = 49;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1438, 698);
            Controls.Add(richTextBox1);
            Controls.Add(categoryControlLb1);
            Controls.Add(resetBtn);
            Controls.Add(label4);
            Controls.Add(CbHeaderOrDescription);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
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
        private Components.CategoryControlLb categoryControlLb1;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel FlwPanel;
    }
}
