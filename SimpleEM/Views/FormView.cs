// Views/FormView.cs
using SimpleEM.Controllers;
using SimpleEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleEM.Views
{
    public partial class FormView : Form
    {
        private ExpenseController expenseController;
        private HashSet<string> alertedCategories = new HashSet<string>();

        private readonly List<string> predefinedCategories = new List<string>()
        {
            "Ăn uống", "Ở", "Đi lại", "Hóa đơn tiện ích", "Trả nợ",
            "Tiết kiệm", "Dự phòng", "Du lịch", "Giải trí", "Mua sắm"
        };

        public FormView()
        {
            InitializeComponent();
            expenseController = new ExpenseController();

            cmbCategory.Items.AddRange(predefinedCategories.ToArray());
            txtFilterCategory.Items.AddRange(predefinedCategories.ToArray());
        }
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            foreach (var category in predefinedCategories)
            {
                cmbCategory.Items.Add(category);
            }
        }

        private void UpdateTotal()
        {
            decimal total = expenseController.GetTotalAmount();
            lblTotal.Text = $"Tổng: {total} VNĐ";
        }
        private void BtnAddExpenses_Click(object sender, EventArgs e)
        {
            string description = txtDes.Text;
            decimal amount;
            DateTime date = dtpExpenseDate.Value;
            string category = cmbCategory.Text;

            if (decimal.TryParse(txtAmount.Text, out amount) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(category))
            {
                Expenses newExpense = new Expenses();
                newExpense.SetDescription(description);
                newExpense.SetAmount(amount);
                newExpense.SetDate(date);
                newExpense.SetCategory(category);

                expenseController.AddExpense(newExpense);
                listExpenses.Items.Add(newExpense.ToString());

                txtDes.Clear();
                txtAmount.Clear();

                UpdateTotal();
                CheckBudgetAlerts();

                if (!cmbCategory.Items.Contains(category))
                {
                    cmbCategory.Items.Add(category);
                }

                if (!txtFilterCategory.Items.Contains(category))
                {
                    txtFilterCategory.Items.Add(category);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mô tả, số tiền, và danh mục hợp lệ.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK);
            }
        }

        private void BtnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (listExpenses.SelectedItem != null)
            {
                Expenses selectedExpense = expenseController.GetExpenses()
                    .FirstOrDefault(exp => exp.ToString() == listExpenses.SelectedItem.ToString());
                if (selectedExpense != null)
                {
                    expenseController.RemoveExpense(selectedExpense);
                    listExpenses.Items.Remove(selectedExpense.ToString());

                    UpdateTotal();

                    MessageBox.Show("Chi tiêu đã được xóa.", "Xóa chi tiêu", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiêu để xóa.", "Chưa chọn chi tiêu", MessageBoxButtons.OK);
            }
        }

        private void SaveData()
        {
            expenseController.SaveData("user_data.json");
        }

        private void LoadData()
        {
            expenseController.LoadData("user_data.json");

            listExpenses.Items.Clear();
            foreach (var expense in expenseController.GetExpenses())
            {
                listExpenses.Items.Add(expense.ToString());

                if (!cmbCategory.Items.Contains(expense.GetCategory()))
                {
                    cmbCategory.Items.Add(expense.GetCategory());
                }
                // Thêm danh mục vào ComboBox txtFilterCategory nếu chưa có
                if (!txtFilterCategory.Items.Contains(expense.GetCategory()))
                {
                    txtFilterCategory.Items.Add(expense.GetCategory());
                }
            }


            UpdateTotal();
            UpdateBudgetListView(); // Cập nhật hiển thị ngân sách sau khi tải dữ liệu
        }


        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.Text;

            if (!string.IsNullOrEmpty(selectedCategory) && cmbCategory.Items.Contains(selectedCategory))
            {
                cmbCategory.Items.Remove(selectedCategory);
                txtFilterCategory.Items.Remove(selectedCategory);

                var expensesToRemove = expenseController.GetExpenses().Where(expense => expense.GetCategory() == selectedCategory).ToList();
                foreach (var expense in expensesToRemove)
                {
                    expenseController.RemoveExpense(expense);
                }

                UpdateTotal();

                MessageBox.Show($"Danh mục '{selectedCategory}' và các chi tiêu liên quan đã được xóa.", "Xóa danh mục", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục hợp lệ để xóa.", "Chưa chọn danh mục", MessageBoxButtons.OK);
            }
        }

        private void BtnSetCategoryBudget_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;
            decimal budget;
            if (decimal.TryParse(txtBudget.Text, out budget) && !string.IsNullOrWhiteSpace(category))
            {
                expenseController.SetCategoryBudget(category, budget);
                MessageBox.Show($"Ngân sách cho danh mục '{category}' đã được đặt là {budget} VNĐ.", "Ngân sách cập nhật", MessageBoxButtons.OK);
                UpdateBudgetListView();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập danh mục và ngân sách hợp lệ.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK);
            }
        }

        private void UpdateBudgetListView()
        {
            listViewBudgets.Items.Clear();
            var categoryBudgets = expenseController.GetCategoryBudgets();

            foreach (var budget in categoryBudgets)
            {
                var item = new ListViewItem(budget.Key);
                item.SubItems.Add($"{budget.Value:N0} VNĐ");
                listViewBudgets.Items.Add(item);
            }
        }


        private void FormView_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadData();
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void CheckBudgetAlerts()
        {
            var categoryBudgets = expenseController.GetCategoryBudgets();

            foreach (var category in categoryBudgets.Keys)
            {
                decimal totalAmountInCategory = expenseController.GetTotalAmountByCategory(category);
                decimal categoryBudget = expenseController.GetCategoryBudget(category);

                // Kiểm tra xem ngân sách có bị vượt không và danh mục này chưa được cảnh báo
                if (totalAmountInCategory > categoryBudget && !alertedCategories.Contains(category))
                {
                    MessageBox.Show($"Cảnh báo: Bạn đã chi tiêu vượt quá ngân sách của danh mục '{category}'!", "Cảnh báo ngân sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    alertedCategories.Add(category); // Thêm danh mục vào danh sách đã cảnh báo
                }
            }
        }

        private void ResetAlertedCategories()
        {
            alertedCategories.Clear(); // Xóa danh mục đã cảnh báo
        }

        private void BtnFilterExpenses_Click(object sender, EventArgs e)
        {
            string selectedPeriod = cmbTimePeriod.SelectedItem?.ToString();
            string selectedCategory = txtFilterCategory.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPeriod))
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian để lọc các khoản chi.");
                return;
            }

            List<Expenses> filteredExpenses = new List<Expenses>();

            DateTime selectedDate = dtpFilterDate.Value;
            decimal totalFilteredAmount = 0;

            foreach (var expense in expenseController.GetExpenses())
            {
                bool matchesCategory = string.IsNullOrEmpty(selectedCategory) || expense.GetCategory() == selectedCategory;

                switch (selectedPeriod)
                {
                    case "Ngày":
                        if (expense.GetDate().Date == selectedDate.Date && matchesCategory)
                        {
                            filteredExpenses.Add(expense);
                            totalFilteredAmount += expense.GetAmount();
                        }
                        break;
                    case "Tuần":
                        var culture = System.Globalization.CultureInfo.CurrentCulture;
                        var diff = (7 + (selectedDate.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek)) % 7;
                        var firstDayOfWeek = selectedDate.AddDays(-1 * diff).Date;
                        var lastDayOfWeek = firstDayOfWeek.AddDays(6).Date;
                        if (expense.GetDate() >= firstDayOfWeek && expense.GetDate() <= lastDayOfWeek && matchesCategory)
                        {
                            filteredExpenses.Add(expense);
                            totalFilteredAmount += expense.GetAmount();
                        }
                        break;
                    case "Tháng":
                        if (expense.GetDate().Year == selectedDate.Year && expense.GetDate().Month == selectedDate.Month && matchesCategory)
                        {
                            filteredExpenses.Add(expense);
                            totalFilteredAmount += expense.GetAmount();
                        }
                        break;
                    case "Năm":
                        if (expense.GetDate().Year == selectedDate.Year && matchesCategory)
                        {
                            filteredExpenses.Add(expense);
                            totalFilteredAmount += expense.GetAmount();
                        }
                        break;
                    case "Tất cả":
                        if (matchesCategory)
                        {
                            filteredExpenses.Add(expense);
                            totalFilteredAmount += expense.GetAmount();
                        }
                        break;
                }
            }

            listExpenses.Items.Clear();
            foreach (var exp in filteredExpenses)
            {
                listExpenses.Items.Add(exp.ToString());
            }

            lblTotal.Text = $"Tổng (lọc): {totalFilteredAmount} VNĐ";
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            string newCategory = cmbCategory.Text;
            if (!string.IsNullOrWhiteSpace(newCategory) && !cmbCategory.Items.Contains(newCategory) && !predefinedCategories.Contains(newCategory))
            {
                cmbCategory.Items.Add(newCategory);
                MessageBox.Show($"Danh mục '{newCategory}' đã được thêm.");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập danh mục hợp lệ hoặc danh mục đã có sẵn.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK);
            }
        }
        private void BtnDelCategoryBudget_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.Text;

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                expenseController.RemoveCategoryBudget(selectedCategory);
                MessageBox.Show($"Ngân sách của danh mục '{selectedCategory}' đã được xóa.", "Xóa ngân sách", MessageBoxButtons.OK);
                UpdateBudgetListView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục hợp lệ để xóa ngân sách.", "Chưa chọn danh mục", MessageBoxButtons.OK);
            }
        }

        private void listViewBudgets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFilterDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTimePeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBudget_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
