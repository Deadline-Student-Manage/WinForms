// Views/FormView.Designer.cs
namespace SimpleEM.Views
{
    partial class FormView
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
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            btnAddCategory = new Button();
            lblExpenseDate = new Label();
            dtpExpenseDate = new DateTimePicker();
            lblFilterCategory = new Label();
            txtFilterCategory = new ComboBox();
            lblBudget = new Label();
            txtBudget = new TextBox();
            btnSetCategoryBudget = new Button();
            lblTypeFilter = new Label();
            lblTitle = new Label();
            listViewBudgets = new ListView();
            columnHeaderCategory = new ColumnHeader();
            columnHeaderBudget = new ColumnHeader();
            btnDeleteExpense = new Button();
            btnDeleteCategory = new Button();
            btnDelCategoryBudget = new Button();
            SuspendLayout();
            // 
            // btnAddExpenses
            // 
            btnAddExpenses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddExpenses.Location = new Point(43, 258);
            btnAddExpenses.Margin = new Padding(2);
            btnAddExpenses.Name = "btnAddExpenses";
            btnAddExpenses.Size = new Size(131, 29);
            btnAddExpenses.TabIndex = 0;
            btnAddExpenses.Text = "Thêm chi tiêu";
            btnAddExpenses.UseVisualStyleBackColor = true;
            btnAddExpenses.Click += BtnAddExpenses_Click;
            // 
            // btnFilterExpenses
            // 
            btnFilterExpenses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterExpenses.Location = new Point(723, 64);
            btnFilterExpenses.Margin = new Padding(2);
            btnFilterExpenses.Name = "btnFilterExpenses";
            btnFilterExpenses.Size = new Size(141, 34);
            btnFilterExpenses.TabIndex = 1;
            btnFilterExpenses.Text = "Lọc chi tiêu";
            btnFilterExpenses.UseVisualStyleBackColor = true;
            btnFilterExpenses.Click += BtnFilterExpenses_Click;
            // 
            // listExpenses
            // 
            listExpenses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listExpenses.FormattingEnabled = true;
            listExpenses.ItemHeight = 21;
            listExpenses.Location = new Point(43, 293);
            listExpenses.Margin = new Padding(2);
            listExpenses.Name = "listExpenses";
            listExpenses.Size = new Size(524, 193);
            listExpenses.TabIndex = 2;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(163, 112);
            txtDes.Margin = new Padding(2);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(283, 23);
            txtDes.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(163, 75);
            txtAmount.Margin = new Padding(2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(98, 23);
            txtAmount.TabIndex = 4;
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDes.Location = new Point(26, 109);
            lblDes.Margin = new Padding(2, 0, 2, 0);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(119, 21);
            lblDes.TabIndex = 5;
            lblDes.Text = "Mô tả chi tiêu:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(81, 77);
            lblAmount.Margin = new Padding(2, 0, 2, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(67, 21);
            lblAmount.TabIndex = 6;
            lblAmount.Text = "Số tiền:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(456, 206);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 30);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Tổng:";
            // 
            // lblTimePeriod
            // 
            lblTimePeriod.AutoSize = true;
            lblTimePeriod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimePeriod.Location = new Point(456, 109);
            lblTimePeriod.Margin = new Padding(2, 0, 2, 0);
            lblTimePeriod.Name = "lblTimePeriod";
            lblTimePeriod.Size = new Size(146, 21);
            lblTimePeriod.TabIndex = 8;
            lblTimePeriod.Text = "Khoảng thời gian:";
            // 
            // cmbTimePeriod
            // 
            cmbTimePeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimePeriod.FormattingEnabled = true;
            cmbTimePeriod.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng", "Năm", "Tất cả" });
            cmbTimePeriod.Location = new Point(579, 143);
            cmbTimePeriod.Margin = new Padding(2);
            cmbTimePeriod.Name = "cmbTimePeriod";
            cmbTimePeriod.Size = new Size(118, 23);
            cmbTimePeriod.TabIndex = 9;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Location = new Point(606, 109);
            dtpFilterDate.Margin = new Padding(2);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(206, 23);
            dtpFilterDate.TabIndex = 10;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(50, 175);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(92, 21);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Danh mục:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(163, 177);
            cmbCategory.Margin = new Padding(2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(118, 23);
            cmbCategory.TabIndex = 13;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCategory.Location = new Point(304, 177);
            btnAddCategory.Margin = new Padding(2);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(146, 41);
            btnAddCategory.TabIndex = 14;
            btnAddCategory.Text = "Thêm danh mục";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += BtnAddCategory_Click;
            // 
            // lblExpenseDate
            // 
            lblExpenseDate.AutoSize = true;
            lblExpenseDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpenseDate.Location = new Point(26, 141);
            lblExpenseDate.Margin = new Padding(2, 0, 2, 0);
            lblExpenseDate.Name = "lblExpenseDate";
            lblExpenseDate.Size = new Size(116, 21);
            lblExpenseDate.TabIndex = 15;
            lblExpenseDate.Text = "Ngày chi tiêu:";
            // 
            // dtpExpenseDate
            // 
            dtpExpenseDate.Location = new Point(163, 149);
            dtpExpenseDate.Margin = new Padding(2);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(209, 23);
            dtpExpenseDate.TabIndex = 16;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterCategory.Location = new Point(456, 75);
            lblFilterCategory.Margin = new Padding(2, 0, 2, 0);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(92, 21);
            lblFilterCategory.TabIndex = 12;
            lblFilterCategory.Text = "Danh mục:";
            // 
            // txtFilterCategory
            // 
            txtFilterCategory.FormattingEnabled = true;
            txtFilterCategory.Location = new Point(579, 75);
            txtFilterCategory.Margin = new Padding(2);
            txtFilterCategory.Name = "txtFilterCategory";
            txtFilterCategory.Size = new Size(118, 23);
            txtFilterCategory.TabIndex = 13;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBudget.Location = new Point(454, 173);
            lblBudget.Margin = new Padding(2, 0, 2, 0);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(94, 21);
            lblBudget.TabIndex = 12;
            lblBudget.Text = "Ngân sách:";
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(579, 175);
            txtBudget.Margin = new Padding(2);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(118, 23);
            txtBudget.TabIndex = 4;
            // 
            // btnSetCategoryBudget
            // 
            btnSetCategoryBudget.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetCategoryBudget.Location = new Point(723, 136);
            btnSetCategoryBudget.Margin = new Padding(2);
            btnSetCategoryBudget.Name = "btnSetCategoryBudget";
            btnSetCategoryBudget.Size = new Size(141, 36);
            btnSetCategoryBudget.TabIndex = 0;
            btnSetCategoryBudget.Text = "Đặt ngân sách";
            btnSetCategoryBudget.UseVisualStyleBackColor = true;
            btnSetCategoryBudget.Click += BtnSetCategoryBudget_Click;
            // 
            // lblTypeFilter
            // 
            lblTypeFilter.AutoSize = true;
            lblTypeFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypeFilter.Location = new Point(456, 141);
            lblTypeFilter.Margin = new Padding(2, 0, 2, 0);
            lblTypeFilter.Name = "lblTypeFilter";
            lblTypeFilter.Size = new Size(79, 21);
            lblTypeFilter.TabIndex = 18;
            lblTypeFilter.Text = "Lọc theo:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(293, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 37);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "QUẢN LÝ CHI TIÊU";
            // 
            // listViewBudgets
            // 
            listViewBudgets.Columns.AddRange(new ColumnHeader[] { columnHeaderCategory, columnHeaderBudget });
            listViewBudgets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listViewBudgets.Location = new Point(572, 246);
            listViewBudgets.Name = "listViewBudgets";
            listViewBudgets.Size = new Size(292, 240);
            listViewBudgets.TabIndex = 0;
            listViewBudgets.UseCompatibleStateImageBehavior = false;
            listViewBudgets.View = View.Details;
            // 
            // columnHeaderCategory
            // 
            columnHeaderCategory.Text = "Danh mục";
            columnHeaderCategory.Width = 150;
            // 
            // columnHeaderBudget
            // 
            columnHeaderBudget.Text = "Ngân sách (VNĐ)";
            columnHeaderBudget.Width = 150;
            // 
            // btnDeleteExpense
            // 
            btnDeleteExpense.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteExpense.Location = new Point(428, 258);
            btnDeleteExpense.Name = "btnDeleteExpense";
            btnDeleteExpense.Size = new Size(120, 30);
            btnDeleteExpense.TabIndex = 1;
            btnDeleteExpense.Text = "Xóa chi tiêu";
            btnDeleteExpense.UseVisualStyleBackColor = true;
            btnDeleteExpense.Click += BtnDeleteExpense_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCategory.Location = new Point(242, 258);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(130, 30);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Xóa danh mục";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += BtnDeleteCategory_Click;
            // 
            // btnDelCategoryBudget
            // 
            btnDelCategoryBudget.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelCategoryBudget.Location = new Point(723, 176);
            btnDelCategoryBudget.Margin = new Padding(2);
            btnDelCategoryBudget.Name = "btnDelCategoryBudget";
            btnDelCategoryBudget.Size = new Size(141, 36);
            btnDelCategoryBudget.TabIndex = 20;
            btnDelCategoryBudget.Text = "Xóa ngân sách";
            btnDelCategoryBudget.UseVisualStyleBackColor = true;
            btnDelCategoryBudget.Click += BtnDelCategoryBudget_Click;
            // 
            // FormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(905, 508);
            Controls.Add(lblTitle);
            Controls.Add(lblTypeFilter);
            Controls.Add(btnSetCategoryBudget);
            Controls.Add(txtBudget);
            Controls.Add(lblBudget);
            Controls.Add(txtFilterCategory);
            Controls.Add(lblFilterCategory);
            Controls.Add(dtpExpenseDate);
            Controls.Add(lblExpenseDate);
            Controls.Add(btnAddCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
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
            Controls.Add(listViewBudgets);
            Controls.Add(btnDeleteExpense);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnDelCategoryBudget);
            Margin = new Padding(2);
            Name = "FormView";
            Text = "Quản lý chi tiêu";
            FormClosing += FormView_FormClosing;
            Load += FormView_Load;
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
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblExpenseDate;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox txtFilterCategory;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Button btnSetCategoryBudget;
        private System.Windows.Forms.ListView listViewBudgets;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderBudget;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnDeleteCategory;
        private Label lblTypeFilter;
        private Label lblTitle;
        private Button btnDelCategoryBudget;
    }
}
