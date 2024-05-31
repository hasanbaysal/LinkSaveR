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
            PnlTop = new Panel();
            panel2 = new Panel();
            BtnMin = new FontAwesome.Sharp.IconButton();
            BtnClose = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            PnlPage = new Panel();
            label6 = new Label();
            button1 = new Button();
            label10 = new Label();
            label5 = new Label();
            FlwPanel = new FlowLayoutPanel();
            label11 = new Label();
            LbSelectedCategories = new ListBox();
            label3 = new Label();
            CbHeaderOrDescription = new Components.RJToggleButton();
            textBox1 = new TextBox();
            DGW = new DataGridView();
            BtnDelete = new FontAwesome.Sharp.IconButton();
            BtnOpenLink = new FontAwesome.Sharp.IconButton();
            BtnCategories = new FontAwesome.Sharp.IconButton();
            BtnSettings = new FontAwesome.Sharp.IconButton();
            BtnUpdate = new FontAwesome.Sharp.IconButton();
            BtnAdd = new FontAwesome.Sharp.IconButton();
            richTextBox1 = new RichTextBox();
            btnInfo = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            PnlTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGW).BeginInit();
            SuspendLayout();
            // 
            // PnlTop
            // 
            PnlTop.Controls.Add(panel2);
            PnlTop.Controls.Add(label1);
            PnlTop.Dock = DockStyle.Top;
            PnlTop.Location = new Point(0, 0);
            PnlTop.Margin = new Padding(3, 2, 3, 2);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(429, 26);
            PnlTop.TabIndex = 2;
            PnlTop.MouseDown += PnlTop_MouseDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnMin);
            panel2.Controls.Add(BtnClose);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(362, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 25);
            panel2.TabIndex = 4;
            // 
            // BtnMin
            // 
            BtnMin.BackColor = Color.FromArgb(23, 29, 39);
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
            BtnMin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnMin.UseVisualStyleBackColor = false;
            BtnMin.Click += BtnMin_Click;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(23, 29, 39);
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
            label1.BackColor = Color.FromArgb(131, 255, 247);
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.Size = new Size(429, 1);
            label1.TabIndex = 0;
            // 
            // PnlPage
            // 
            PnlPage.BackColor = Color.FromArgb(23, 29, 39);
            PnlPage.Location = new Point(439, 61);
            PnlPage.Margin = new Padding(3, 2, 3, 2);
            PnlPage.Name = "PnlPage";
            PnlPage.Size = new Size(487, 536);
            PnlPage.TabIndex = 3;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(131, 255, 247);
            label6.Location = new Point(10, 622);
            label6.Name = "label6";
            label6.Size = new Size(937, 1);
            label6.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 117, 216);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(312, 398);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(60, 22);
            button1.TabIndex = 52;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(131, 255, 247);
            label10.Location = new Point(420, 28);
            label10.Name = "label10";
            label10.Size = new Size(1, 589);
            label10.TabIndex = 51;
            // 
            // label5
            // 
            label5.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(36, 457);
            label5.Name = "label5";
            label5.Size = new Size(248, 19);
            label5.TabIndex = 50;
            label5.Text = "Filtering Links with Multiple Category Selection";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlwPanel
            // 
            FlwPanel.AutoScroll = true;
            FlwPanel.Location = new Point(15, 560);
            FlwPanel.Margin = new Padding(3, 2, 3, 2);
            FlwPanel.Name = "FlwPanel";
            FlwPanel.Padding = new Padding(3, 2, 3, 2);
            FlwPanel.Size = new Size(400, 60);
            FlwPanel.TabIndex = 49;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(131, 255, 247);
            label11.Location = new Point(17, 388);
            label11.Name = "label11";
            label11.Size = new Size(394, 1);
            label11.TabIndex = 48;
            // 
            // LbSelectedCategories
            // 
            LbSelectedCategories.FormattingEnabled = true;
            LbSelectedCategories.ItemHeight = 15;
            LbSelectedCategories.Location = new Point(15, 478);
            LbSelectedCategories.Margin = new Padding(3, 2, 3, 2);
            LbSelectedCategories.Name = "LbSelectedCategories";
            LbSelectedCategories.Size = new Size(400, 79);
            LbSelectedCategories.TabIndex = 47;
            LbSelectedCategories.SelectedIndexChanged += LbSelectedCategories_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(26, 424);
            label3.Name = "label3";
            label3.Size = new Size(248, 19);
            label3.TabIndex = 44;
            label3.Text = "Header / Description Search Option";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CbHeaderOrDescription
            // 
            CbHeaderOrDescription.AutoSize = true;
            CbHeaderOrDescription.Location = new Point(312, 424);
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 398);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            DGW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DGW.BackgroundColor = SystemColors.ButtonHighlight;
            DGW.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGW.DefaultCellStyle = dataGridViewCellStyle3;
            DGW.Location = new Point(15, 43);
            DGW.Margin = new Padding(3, 2, 3, 2);
            DGW.Name = "DGW";
            DGW.ReadOnly = true;
            DGW.RowHeadersVisible = false;
            DGW.RowHeadersWidth = 51;
            DGW.Size = new Size(400, 141);
            DGW.TabIndex = 40;
            DGW.CellClick += DGW_CellClick;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(232, 0, 63);
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnDelete.ForeColor = Color.White;
            BtnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnDelete.IconColor = Color.White;
            BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDelete.IconSize = 30;
            BtnDelete.Location = new Point(18, 188);
            BtnDelete.Margin = new Padding(3, 2, 3, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(114, 30);
            BtnDelete.TabIndex = 38;
            BtnDelete.Text = "Delete Link";
            BtnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnOpenLink
            // 
            BtnOpenLink.BackColor = Color.FromArgb(2, 117, 216);
            BtnOpenLink.FlatAppearance.BorderSize = 0;
            BtnOpenLink.FlatStyle = FlatStyle.Flat;
            BtnOpenLink.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnOpenLink.ForeColor = Color.White;
            BtnOpenLink.IconChar = FontAwesome.Sharp.IconChar.FirefoxBrowser;
            BtnOpenLink.IconColor = Color.White;
            BtnOpenLink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnOpenLink.IconSize = 30;
            BtnOpenLink.Location = new Point(150, 230);
            BtnOpenLink.Margin = new Padding(3, 2, 3, 2);
            BtnOpenLink.Name = "BtnOpenLink";
            BtnOpenLink.Size = new Size(120, 30);
            BtnOpenLink.TabIndex = 37;
            BtnOpenLink.Text = "Go Link";
            BtnOpenLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOpenLink.UseVisualStyleBackColor = false;
            BtnOpenLink.Click += BtnOpenLink_Click;
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
            BtnCategories.Location = new Point(293, 230);
            BtnCategories.Margin = new Padding(3, 2, 3, 2);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(117, 30);
            BtnCategories.TabIndex = 36;
            BtnCategories.Text = "Categories";
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
            BtnSettings.Location = new Point(17, 230);
            BtnSettings.Margin = new Padding(3, 2, 3, 2);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(114, 30);
            BtnSettings.TabIndex = 35;
            BtnSettings.Text = "Settings";
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
            BtnUpdate.Location = new Point(295, 188);
            BtnUpdate.Margin = new Padding(3, 2, 3, 2);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(116, 30);
            BtnUpdate.TabIndex = 39;
            BtnUpdate.Text = "Update Link";
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
            BtnAdd.Location = new Point(150, 188);
            BtnAdd.Margin = new Padding(3, 2, 3, 2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(123, 30);
            BtnAdd.TabIndex = 34;
            BtnAdd.Text = "Add Link";
            BtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(18, 284);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(398, 91);
            richTextBox1.TabIndex = 53;
            richTextBox1.Text = "";
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.FromArgb(23, 29, 39);
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnInfo.ForeColor = Color.White;
            btnInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            btnInfo.IconColor = Color.White;
            btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInfo.IconSize = 30;
            btnInfo.Location = new Point(312, 445);
            btnInfo.Margin = new Padding(3, 2, 3, 2);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(37, 28);
            btnInfo.TabIndex = 36;
            btnInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(131, 255, 247);
            label2.Location = new Point(17, 274);
            label2.Name = "label2";
            label2.Size = new Size(394, 1);
            label2.TabIndex = 48;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(131, 255, 247);
            label4.Location = new Point(947, 31);
            label4.Name = "label4";
            label4.Size = new Size(1, 589);
            label4.TabIndex = 51;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(131, 255, 247);
            label7.Location = new Point(8, 28);
            label7.Name = "label7";
            label7.Size = new Size(1, 589);
            label7.TabIndex = 51;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(429, 630);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(FlwPanel);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(LbSelectedCategories);
            Controls.Add(label3);
            Controls.Add(CbHeaderOrDescription);
            Controls.Add(textBox1);
            Controls.Add(DGW);
            Controls.Add(BtnDelete);
            Controls.Add(BtnOpenLink);
            Controls.Add(btnInfo);
            Controls.Add(BtnCategories);
            Controls.Add(BtnSettings);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnAdd);
            Controls.Add(label6);
            Controls.Add(PnlPage);
            Controls.Add(PnlTop);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LinK Saver";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            PnlTop.ResumeLayout(false);
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
        private Panel PnlPage;
        private Panel panel2;
        private Label label6;
        private Button button1;
        private Label label10;
        private Label label5;
        private FlowLayoutPanel FlwPanel;
        private Label label11;
        private Label label3;
        private Components.RJToggleButton CbHeaderOrDescription;
        private TextBox textBox1;
        private DataGridView DGW;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnOpenLink;
        private FontAwesome.Sharp.IconButton BtnCategories;
        private FontAwesome.Sharp.IconButton BtnSettings;
        private FontAwesome.Sharp.IconButton BtnUpdate;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton btnInfo;
        public ListBox LbSelectedCategories;
        private Label label2;
        private Label label4;
        private Label label7;
    }
}
