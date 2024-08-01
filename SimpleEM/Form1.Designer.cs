namespace SimpleEM
{
    partial class Form1
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
            lblExpenses = new Label();
            txtDes = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            dtpExpenseDate = new DateTimePicker();
            btnAddExpenses = new Button();
            listExpenses = new ListBox();
            lblTotal = new Label();
            cmbTimePeriod = new ComboBox();
            btnFilterExpenses = new Button();
            dtpFilterDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            cmbFilterCategory = new ComboBox();
            btnAddCategory = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // lblExpenses
            // 
            lblExpenses.AutoSize = true;
            lblExpenses.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpenses.Location = new Point(26, 72);
            lblExpenses.Name = "lblExpenses";
            lblExpenses.Size = new Size(81, 17);
            lblExpenses.TabIndex = 0;
            lblExpenses.Text = "Tên chi tiêu";
            lblExpenses.Click += label1_Click;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(179, 72);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(598, 23);
            txtDes.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(26, 148);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(57, 17);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Gía tiền";
            lblAmount.Click += label2_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(179, 141);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(133, 23);
            txtAmount.TabIndex = 3;
            // 
            // dtpExpenseDate
            // 
            dtpExpenseDate.Location = new Point(179, 168);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(200, 23);
            dtpExpenseDate.TabIndex = 4;
            // 
            // btnAddExpenses
            // 
            btnAddExpenses.Location = new Point(179, 199);
            btnAddExpenses.Name = "btnAddExpenses";
            btnAddExpenses.Size = new Size(70, 67);
            btnAddExpenses.TabIndex = 4;
            btnAddExpenses.Text = "THÊM";
            btnAddExpenses.UseVisualStyleBackColor = true;
            btnAddExpenses.Click += btnAddExpenses_Click;
            // 
            // listExpenses
            // 
            listExpenses.FormattingEnabled = true;
            listExpenses.ItemHeight = 15;
            listExpenses.Location = new Point(490, 111);
            listExpenses.Name = "listExpenses";
            listExpenses.Size = new Size(344, 349);
            listExpenses.TabIndex = 5;
            listExpenses.SelectedIndexChanged += listExpenses_SelectedIndexChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(26, 443);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 17);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Tổng";
            // 
            // cmbTimePeriod
            // 
            cmbTimePeriod.FormattingEnabled = true;
            cmbTimePeriod.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng" });
            cmbTimePeriod.Location = new Point(185, 296);
            cmbTimePeriod.Name = "cmbTimePeriod";
            cmbTimePeriod.Size = new Size(133, 23);
            cmbTimePeriod.TabIndex = 7;
            cmbTimePeriod.SelectedIndexChanged += cmbTimePeriod_SelectedIndexChanged;
            // 
            // btnFilterExpenses
            // 
            btnFilterExpenses.Location = new Point(385, 280);
            btnFilterExpenses.Name = "btnFilterExpenses";
            btnFilterExpenses.Size = new Size(75, 23);
            btnFilterExpenses.TabIndex = 8;
            btnFilterExpenses.Text = "Lọc";
            btnFilterExpenses.UseVisualStyleBackColor = true;
            btnFilterExpenses.Click += btnFilterExpenses_Click;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Location = new Point(182, 334);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(200, 23);
            dtpFilterDate.TabIndex = 9;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(179, 111);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 23);
            cmbCategory.TabIndex = 10;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Location = new Point(182, 373);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(200, 23);
            cmbFilterCategory.TabIndex = 10;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(385, 110);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 23);
            btnAddCategory.TabIndex = 11;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 176);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 10;
            label2.Text = "Ngày chi tiêu";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 302);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 11;
            label3.Text = "Bộ lọc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 19);
            label1.Name = "label1";
            label1.Size = new Size(300, 39);
            label1.TabIndex = 12;
            label1.Text = "QUẢN LÝ CHI TIÊU";
            label1.Click += label1_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 302);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 14;
            label5.Text = "Lọc theo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(60, 334);
            label6.Name = "label6";
            label6.Size = new Size(116, 17);
            label6.TabIndex = 15;
            label6.Text = "Khoảng ngày lọc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 375);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 16;
            label4.Text = "Danh mục lọc:";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 117);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 17;
            label7.Text = "Danh mục";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 488);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(listExpenses);
            Controls.Add(btnAddExpenses);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtDes);
            Controls.Add(lblExpenses);
            Controls.Add(cmbTimePeriod);
            Controls.Add(btnFilterExpenses);
            Controls.Add(dtpFilterDate);
            Controls.Add(dtpExpenseDate);
            Controls.Add(cmbFilterCategory);
            Controls.Add(cmbCategory);
            Controls.Add(btnAddCategory);
            Name = "Form1";
            Text = "Quản lý chi tiêu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExpenses;
        private TextBox txtDes;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnAddExpenses;
        private ListBox listExpenses;
        private Label lblTotal;
        private ComboBox cmbTimePeriod;
        private Button btnFilterExpenses;
        private DateTimePicker dtpExpenseDate;
        private DateTimePicker dtpFilterDate;
        private ComboBox cmbCategory;
        private ComboBox cmbFilterCategory;
        private Button btnAddCategory;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
    }
}