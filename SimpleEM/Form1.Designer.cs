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
            btnAddExpenses = new Button();
            btnFilterExpenses = new Button();
            listExpenses = new ListBox();
            txtDes = new TextBox();
            txtAmount = new TextBox();
            lblDes = new Label();
            lblAmount = new Label();
            lblTotal = new Label();
            lblTimePeriod = new Label();
            cmbTimePeriod = new ComboBox();
            dtpFilterDate = new DateTimePicker();
            lblFilterDate = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            btnAddCategory = new Button();
            lblExpenseDate = new Label();
            dtpExpenseDate = new DateTimePicker();
            chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblFilterCategory = new Label();
            cmbFilterCategory = new ComboBox();
            lblBudget = new Label();
            txtBudget = new TextBox();
            btnSetCategoryBudget = new Button();
            lblTypeFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)chartExpenses).BeginInit();
            SuspendLayout();
            // 
            // btnAddExpenses
            // 
            btnAddExpenses.Location = new Point(26, 144);
            btnAddExpenses.Margin = new Padding(2);
            btnAddExpenses.Name = "btnAddExpenses";
            btnAddExpenses.Size = new Size(98, 23);
            btnAddExpenses.TabIndex = 0;
            btnAddExpenses.Text = "Thêm chi tiêu";
            btnAddExpenses.UseVisualStyleBackColor = true;
            btnAddExpenses.Click += btnAddExpenses_Click;
            // 
            // btnFilterExpenses
            // 
            btnFilterExpenses.Location = new Point(654, 11);
            btnFilterExpenses.Margin = new Padding(2);
            btnFilterExpenses.Name = "btnFilterExpenses";
            btnFilterExpenses.Size = new Size(122, 23);
            btnFilterExpenses.TabIndex = 1;
            btnFilterExpenses.Text = "Lọc chi tiêu";
            btnFilterExpenses.UseVisualStyleBackColor = true;
            btnFilterExpenses.Click += btnFilterExpenses_Click;
            // 
            // listExpenses
            // 
            listExpenses.FormattingEnabled = true;
            listExpenses.ItemHeight = 15;
            listExpenses.Location = new Point(26, 189);
            listExpenses.Margin = new Padding(2);
            listExpenses.Name = "listExpenses";
            listExpenses.Size = new Size(359, 199);
            listExpenses.TabIndex = 2;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(123, 16);
            txtDes.Margin = new Padding(2);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(98, 23);
            txtDes.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(123, 49);
            txtAmount.Margin = new Padding(2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(98, 23);
            txtAmount.TabIndex = 4;
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.Location = new Point(23, 19);
            lblDes.Margin = new Padding(2, 0, 2, 0);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(83, 15);
            lblDes.TabIndex = 5;
            lblDes.Text = "Mô tả chi tiêu:";
            lblDes.Click += label1_Click_2;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(26, 52);
            lblAmount.Margin = new Padding(2, 0, 2, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(46, 15);
            lblAmount.TabIndex = 6;
            lblAmount.Text = "Số tiền:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(409, 112);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(37, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Tổng:";
            // 
            // lblTimePeriod
            // 
            lblTimePeriod.AutoSize = true;
            lblTimePeriod.Location = new Point(406, 52);
            lblTimePeriod.Margin = new Padding(2, 0, 2, 0);
            lblTimePeriod.Name = "lblTimePeriod";
            lblTimePeriod.Size = new Size(101, 15);
            lblTimePeriod.TabIndex = 8;
            lblTimePeriod.Text = "Khoảng thời gian:";
            // 
            // cmbTimePeriod
            // 
            cmbTimePeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimePeriod.FormattingEnabled = true;
            cmbTimePeriod.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng" });
            cmbTimePeriod.Location = new Point(514, 144);
            cmbTimePeriod.Margin = new Padding(2);
            cmbTimePeriod.Name = "cmbTimePeriod";
            cmbTimePeriod.Size = new Size(118, 23);
            cmbTimePeriod.TabIndex = 9;
            cmbTimePeriod.SelectedIndexChanged += cmbTimePeriod_SelectedIndexChanged;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Location = new Point(523, 44);
            dtpFilterDate.Margin = new Padding(2);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(195, 23);
            dtpFilterDate.TabIndex = 10;
            // 
            // lblFilterDate
            // 
            lblFilterDate.AutoSize = true;
            lblFilterDate.Location = new Point(409, 86);
            lblFilterDate.Margin = new Padding(2, 0, 2, 0);
            lblFilterDate.Name = "lblFilterDate";
            lblFilterDate.Size = new Size(57, 15);
            lblFilterDate.TabIndex = 11;
            lblFilterDate.Text = "Ngày lọc:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(26, 86);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 15);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Danh mục:";
            lblCategory.Click += label1_Click_1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(123, 83);
            cmbCategory.Margin = new Padding(2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(118, 23);
            cmbCategory.TabIndex = 13;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(259, 82);
            btnAddCategory.Margin = new Padding(2);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(135, 23);
            btnAddCategory.TabIndex = 14;
            btnAddCategory.Text = "Thêm danh mục";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // lblExpenseDate
            // 
            lblExpenseDate.AutoSize = true;
            lblExpenseDate.Location = new Point(26, 112);
            lblExpenseDate.Margin = new Padding(2, 0, 2, 0);
            lblExpenseDate.Name = "lblExpenseDate";
            lblExpenseDate.Size = new Size(80, 15);
            lblExpenseDate.TabIndex = 15;
            lblExpenseDate.Text = "Ngày chi tiêu:";
            // 
            // dtpExpenseDate
            // 
            dtpExpenseDate.Location = new Point(123, 112);
            dtpExpenseDate.Margin = new Padding(2);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(195, 23);
            dtpExpenseDate.TabIndex = 16;
            // 
            // chartExpenses
            // 
            chartExpenses.Location = new Point(473, 205);
            chartExpenses.Margin = new Padding(2);
            chartExpenses.Name = "chartExpenses";
            chartExpenses.Size = new Size(236, 183);
            chartExpenses.TabIndex = 17;
            chartExpenses.Text = "chartExpenses";
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Location = new Point(409, 16);
            lblFilterCategory.Margin = new Padding(2, 0, 2, 0);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(65, 15);
            lblFilterCategory.TabIndex = 12;
            lblFilterCategory.Text = "Danh mục:";
            lblFilterCategory.Click += label1_Click_1;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Location = new Point(514, 13);
            cmbFilterCategory.Margin = new Padding(2);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(118, 23);
            cmbFilterCategory.TabIndex = 13;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(409, 86);
            lblBudget.Margin = new Padding(2, 0, 2, 0);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(66, 15);
            lblBudget.TabIndex = 12;
            lblBudget.Text = "Ngân sách:";
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(514, 87);
            txtBudget.Margin = new Padding(2);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(98, 23);
            txtBudget.TabIndex = 4;
            // 
            // btnSetCategoryBudget
            // 
            btnSetCategoryBudget.Location = new Point(654, 86);
            btnSetCategoryBudget.Margin = new Padding(2);
            btnSetCategoryBudget.Name = "btnSetCategoryBudget";
            btnSetCategoryBudget.Size = new Size(98, 23);
            btnSetCategoryBudget.TabIndex = 0;
            btnSetCategoryBudget.Text = "Đặt ngân sách";
            btnSetCategoryBudget.UseVisualStyleBackColor = true;
            btnSetCategoryBudget.Click += btnSetCategoryBudget_Click;
            // 
            // lblTypeFilter
            // 
            lblTypeFilter.AutoSize = true;
            lblTypeFilter.Location = new Point(410, 152);
            lblTypeFilter.Margin = new Padding(2, 0, 2, 0);
            lblTypeFilter.Name = "lblTypeFilter";
            lblTypeFilter.Size = new Size(56, 15);
            lblTypeFilter.TabIndex = 18;
            lblTypeFilter.Text = "Lọc theo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 611);
            Controls.Add(lblTypeFilter);
            Controls.Add(btnSetCategoryBudget);
            Controls.Add(txtBudget);
            Controls.Add(lblBudget);
            Controls.Add(cmbFilterCategory);
            Controls.Add(lblFilterCategory);
            Controls.Add(chartExpenses);
            Controls.Add(dtpExpenseDate);
            Controls.Add(lblExpenseDate);
            Controls.Add(btnAddCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblFilterDate);
            Controls.Add(dtpFilterDate);
            Controls.Add(cmbTimePeriod);
            Controls.Add(lblTimePeriod);
            Controls.Add(lblTotal);
            Controls.Add(lblAmount);
            Controls.Add(lblDes);
            Controls.Add(txtAmount);
            Controls.Add(txtDes);
            Controls.Add(listExpenses);
            Controls.Add(btnFilterExpenses);
            Controls.Add(btnAddExpenses);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Quản lý chi tiêu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chartExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddExpenses;
        private System.Windows.Forms.Button btnFilterExpenses;
        private System.Windows.Forms.ListBox listExpenses;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTimePeriod;
        private System.Windows.Forms.ComboBox cmbTimePeriod;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblFilterDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblExpenseDate;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Button btnSetCategoryBudget;
        private Label lblTypeFilter;
    }
}
