namespace HB.LinkSaver.Pages
{
    partial class AddForm
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
            lbCategories = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            tbHeader = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbLink = new TextBox();
            label4 = new Label();
            tbDescription = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbCategories
            // 
            lbCategories.BackColor = Color.FromArgb(23, 29, 39);
            lbCategories.ForeColor = Color.White;
            lbCategories.FormattingEnabled = true;
            lbCategories.ItemHeight = 15;
            lbCategories.Location = new Point(12, 12);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(144, 334);
            lbCategories.TabIndex = 0;
            lbCategories.TabStop = false;
            lbCategories.SelectedIndexChanged += lbCategories_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(181, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(212, 259);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 2;
            label1.Text = "Add or Remove Categories";
            // 
            // tbHeader
            // 
            tbHeader.Location = new Point(146, 364);
            tbHeader.Name = "tbHeader";
            tbHeader.Size = new Size(276, 23);
            tbHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 364);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 2;
            label2.Text = "Header :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 405);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 2;
            label3.Text = "Link :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbLink
            // 
            tbLink.Location = new Point(146, 405);
            tbLink.Name = "tbLink";
            tbLink.Size = new Size(276, 23);
            tbLink.TabIndex = 1;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 452);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 2;
            label4.Text = "Description :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(146, 452);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(276, 89);
            tbDescription.TabIndex = 2;
            tbDescription.Text = "";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(246, 552);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 39);
            ClientSize = new Size(451, 587);
            Controls.Add(button1);
            Controls.Add(tbDescription);
            Controls.Add(tbLink);
            Controls.Add(tbHeader);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbCategories);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddForm";
            Text = "Link Add Page";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCategories;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox tbHeader;
        private Label label2;
        private Label label3;
        private TextBox tbLink;
        private Label label4;
        private RichTextBox tbDescription;
        private Button button1;
    }
}