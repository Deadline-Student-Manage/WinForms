// Form1.cs
using Microsoft.VisualBasic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SimpleEM
{
    public partial class Form1 : Form
    {
        // List to store expenses
        private List<Expenses> expenses = new List<Expenses>();

        public Form1()
        {
            InitializeComponent();

        }
        // Class to represent an expense
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (var expense in expenses)
            {
                total += expense.Amount;
            }
            lblTotal.Text = $"Tổng: {total} VNĐ";
        }
        public class Expenses
        {
            public string? Description { get; set; }
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
            public string Category { get; set; }  // Thêm trường danh mục

            public override string ToString()
            {
                return $"{Description} ({Category}): {Amount} VNĐ - {Date.ToShortDateString()}";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
            // Add the expense to the list
            string description = txtDes.Text;
            decimal amount;
            DateTime date = dtpExpenseDate.Value;  // Lấy ngày tháng từ dtpExpenseDate
            string category = cmbCategory.Text;

            if (decimal.TryParse(txtAmount.Text, out amount) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(category))
            {
                Expenses newExpense = new Expenses
                {
                    Description = description,
                    Amount = amount,
                    Date = date,  // Lưu ngày tháng
                    Category = category
                };

                expenses.Add(newExpense);
                listExpenses.Items.Add(newExpense);

                // Clear the textboxes
                txtDes.Clear();
                txtAmount.Clear();

                // Update total
                UpdateTotal();

                // Add the new category to the ComboBox if it doesn't already exist
                if (!cmbCategory.Items.Contains(category))
                {
                    cmbCategory.Items.Add(category);
                }

                // Add the new category to the filter ComboBox if it doesn't already exist
                if (!cmbFilterCategory.Items.Contains(category))
                {
                    cmbFilterCategory.Items.Add(category);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mô tả, số tiền, và danh mục hợp lệ.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK);
            }
        }


        private void btnFilterExpenses_Click(object sender, EventArgs e)
        {
            string selectedPeriod = cmbTimePeriod.SelectedItem?.ToString();
            string selectedCategory = cmbFilterCategory.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPeriod))
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian để lọc các khoản chi.");
                return;
            }

            List<Expenses> filteredExpenses = new List<Expenses>();

            DateTime selectedDate = dtpFilterDate.Value;  // Lấy ngày tháng từ dtpFilterDate
            decimal totalFilteredAmount = 0;

            foreach (var expense in expenses)
            {
                bool matchesCategory = string.IsNullOrEmpty(selectedCategory) || expense.Category == selectedCategory;

                switch (selectedPeriod)
                {
                    case "Ngày":
                        if (expense.Date.Date == selectedDate.Date && matchesCategory)
                        {
                            filteredExpenses.Add(expense);
                            totalFilteredAmount += expense.Amount;
                        }
                        break;
                    case "Tuần":
                        var culture = System.Globalization.CultureInfo.CurrentCulture;
                        var diff = (7 + (selectedDate.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek)) % 7;
                        var firstDayOfWeek = selectedDate.AddDays(-1 * diff).Date;
                        var lastDayOfWeek = firstDayOfWeek.AddDays(6).Date;
                        if (expense.Date >= firstDayOfWeek && expense.Date <= lastDayOfWeek && matchesCategory)
                        {
                            filteredExpenses.Add(expense);
                            totalFilteredAmount += expense.Amount;
                        }
                        break;
                    case "Tháng":
                        if (expense.Date.Year == selectedDate.Year && expense.Date.Month == selectedDate.Month && matchesCategory)
                        {
                            filteredExpenses.Add(expense);
                            totalFilteredAmount += expense.Amount;
                        }
                        break;
                }
            }

            listExpenses.Items.Clear();
            foreach (var exp in filteredExpenses)
            {
                listExpenses.Items.Add(exp);
            }

            lblTotal.Text = $"Tổng (lọc): {totalFilteredAmount} VNĐ";
        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newCategory = cmbCategory.Text;
            if (!string.IsNullOrWhiteSpace(newCategory) && !cmbCategory.Items.Contains(newCategory))
            {
                cmbCategory.Items.Add(newCategory);
                MessageBox.Show($"Danh mục '{newCategory}' đã được thêm.");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập danh mục hợp lệ.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK);
            }
        }



        private void cmbTimePeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}