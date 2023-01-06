using System.Windows.Forms;

namespace LinkSaveR
{
    partial class LinkSaver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnclose = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntsil = new FontAwesome.Sharp.IconButton();
            this.GoLink = new FontAwesome.Sharp.IconButton();
            this.BtnEkle = new FontAwesome.Sharp.IconButton();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 32);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 30;
            this.btnMin.Location = new System.Drawing.Point(750, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 32);
            this.btnMin.TabIndex = 12;
            this.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnclose.IconColor = System.Drawing.Color.White;
            this.btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclose.IconSize = 30;
            this.btnclose.Location = new System.Drawing.Point(800, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(50, 32);
            this.btnclose.TabIndex = 11;
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(850, 263);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblCopy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bntsil);
            this.groupBox1.Controls.Add(this.GoLink);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Location = new System.Drawing.Point(0, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 182);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Link ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "category settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.Location = new System.Drawing.Point(701, 129);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(143, 44);
            this.lblCopy.TabIndex = 13;
            this.lblCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(542, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search Option";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(542, 141);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 23);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(517, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Category";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(596, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Description";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(96, 112);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(314, 61);
            this.txtDescription.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(283, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add or select an existing  category\r\n-choose just one-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntsil
            // 
            this.bntsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bntsil.FlatAppearance.BorderSize = 0;
            this.bntsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsil.ForeColor = System.Drawing.Color.White;
            this.bntsil.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.bntsil.IconColor = System.Drawing.Color.White;
            this.bntsil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntsil.IconSize = 30;
            this.bntsil.Location = new System.Drawing.Point(686, 78);
            this.bntsil.Name = "bntsil";
            this.bntsil.Size = new System.Drawing.Size(164, 44);
            this.bntsil.TabIndex = 4;
            this.bntsil.Text = "Select and Delete";
            this.bntsil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntsil.UseVisualStyleBackColor = false;
            this.bntsil.Click += new System.EventHandler(this.bntsil_Click);
            // 
            // GoLink
            // 
            this.GoLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.GoLink.FlatAppearance.BorderSize = 0;
            this.GoLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoLink.ForeColor = System.Drawing.Color.White;
            this.GoLink.IconChar = FontAwesome.Sharp.IconChar.FirefoxBrowser;
            this.GoLink.IconColor = System.Drawing.Color.White;
            this.GoLink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GoLink.IconSize = 30;
            this.GoLink.Location = new System.Drawing.Point(686, 22);
            this.GoLink.Name = "GoLink";
            this.GoLink.Size = new System.Drawing.Size(164, 44);
            this.GoLink.TabIndex = 4;
            this.GoLink.Text = "select and open with your browser";
            this.GoLink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GoLink.UseVisualStyleBackColor = false;
            this.GoLink.Click += new System.EventHandler(this.GoLink_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.BtnEkle.FlatAppearance.BorderSize = 0;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.ForeColor = System.Drawing.Color.White;
            this.BtnEkle.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnEkle.IconColor = System.Drawing.Color.White;
            this.BtnEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEkle.IconSize = 30;
            this.BtnEkle.Location = new System.Drawing.Point(518, 21);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(162, 44);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.Text = "Add Link";
            this.BtnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(96, 83);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(172, 23);
            this.txtCategory.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(96, 22);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(314, 23);
            this.txtLink.TabIndex = 0;
            // 
            // LinkSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(850, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LinkSaver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LinkSaver_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LinkSaver_FormClosed);
            this.Load += new System.EventHandler(this.LinkSaver_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnclose;
        private FontAwesome.Sharp.IconButton btnMin;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton BtnEkle;
        private TextBox txtCategory;
        private ComboBox comboBox1;
        private TextBox txtLink;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtDescription;
        private FontAwesome.Sharp.IconButton GoLink;
        private FontAwesome.Sharp.IconButton bntsil;
        private TextBox txtSearch;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private Label lblCopy;
        private Button button1;
    }
}