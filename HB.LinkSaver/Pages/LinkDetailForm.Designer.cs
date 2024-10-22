namespace HB.LinkSaver.Pages
{
    partial class LinkDetailForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            lblHeader = new Label();
            label3 = new Label();
            tbDescription = new RichTextBox();
            label4 = new Label();
            lblLİnk = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            lblCopy = new Label();
            BtnOpenLink = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(12, 296);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(836, 142);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(348, 271);
            label1.Name = "label1";
            label1.Size = new Size(169, 22);
            label1.TabIndex = 1;
            label1.Text = "CATEGORİES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(25, 36);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 1;
            label2.Text = "HEADER  : ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHeader
            // 
            lblHeader.BorderStyle = BorderStyle.FixedSingle;
            lblHeader.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblHeader.ForeColor = SystemColors.Control;
            lblHeader.Location = new Point(130, 36);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(655, 22);
            lblHeader.TabIndex = 1;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(101, 22);
            label3.TabIndex = 1;
            label3.Text = "DESCRİPTON  : ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.FromArgb(23, 29, 39);
            tbDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbDescription.ForeColor = Color.White;
            tbDescription.Location = new Point(130, 76);
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.Size = new Size(655, 101);
            tbDescription.TabIndex = 2;
            tbDescription.Text = "";
            tbDescription.TextChanged += tbDescription_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(25, 195);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 1;
            label4.Text = "LINK : ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLİnk
            // 
            lblLİnk.BorderStyle = BorderStyle.FixedSingle;
            lblLİnk.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblLİnk.ForeColor = SystemColors.Control;
            lblLİnk.Location = new Point(130, 195);
            lblLİnk.Name = "lblLİnk";
            lblLİnk.Size = new Size(655, 22);
            lblLİnk.TabIndex = 1;
            lblLİnk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ıconButton1
            // 
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.ForeColor = Color.White;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(791, 195);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(57, 25);
            ıconButton1.TabIndex = 3;
            ıconButton1.Text = "copy";
            ıconButton1.UseVisualStyleBackColor = true;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // lblCopy
            // 
            lblCopy.BorderStyle = BorderStyle.FixedSingle;
            lblCopy.ForeColor = Color.FromArgb(128, 255, 128);
            lblCopy.Location = new Point(738, 237);
            lblCopy.Name = "lblCopy";
            lblCopy.Size = new Size(100, 23);
            lblCopy.TabIndex = 4;
            lblCopy.Text = "copied";
            lblCopy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnOpenLink
            // 
            BtnOpenLink.BackColor = Color.Transparent;
            BtnOpenLink.FlatStyle = FlatStyle.Flat;
            BtnOpenLink.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BtnOpenLink.ForeColor = Color.White;
            BtnOpenLink.IconChar = FontAwesome.Sharp.IconChar.Chrome;
            BtnOpenLink.IconColor = Color.White;
            BtnOpenLink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnOpenLink.IconSize = 25;
            BtnOpenLink.Location = new Point(348, 228);
            BtnOpenLink.Margin = new Padding(3, 2, 3, 2);
            BtnOpenLink.Name = "BtnOpenLink";
            BtnOpenLink.Size = new Size(169, 32);
            BtnOpenLink.TabIndex = 38;
            BtnOpenLink.TabStop = false;
            BtnOpenLink.Text = "Open With Browser";
            BtnOpenLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOpenLink.UseVisualStyleBackColor = false;
            BtnOpenLink.Click += BtnOpenLink_Click;
            BtnOpenLink.MouseLeave += BtnOpenLink_MouseLeave;
            BtnOpenLink.MouseHover += BtnOpenLink_MouseHover;
            // 
            // LinkDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(860, 450);
            Controls.Add(BtnOpenLink);
            Controls.Add(lblCopy);
            Controls.Add(ıconButton1);
            Controls.Add(tbDescription);
            Controls.Add(lblLİnk);
            Controls.Add(lblHeader);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LinkDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Link Detail (ESC to Close)";
            Load += LinkDetailForm_Load;
            KeyDown += LinkDetailForm_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label lblHeader;
        private Label label3;
        private RichTextBox tbDescription;
        private Label label4;
        private Label lblLİnk;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private Label lblCopy;
        private FontAwesome.Sharp.IconButton BtnOpenLink;
    }
}