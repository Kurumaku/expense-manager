using System.IO;
using System.Linq;
namespace manaherUI
{

    public partial class Form1 : Form
    {
        ExpenseManager manager = new ExpenseManager("expenses.csv");
        string[] categories = { "food", "transport", "fun", "home", "health", "other" };
        string[] categoriesToDisplay = { "all", "food", "transport", "fun", "home", "health", "other" };
        public Form1()
        {
            InitializeComponent();
            // отключаем автогенерацию колонок
            dgvExpenses.AutoGenerateColumns = false;
            dgvExpenses.Columns.Clear();

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                FillWeight = 30
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price",
                FillWeight = 15
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category",
                FillWeight = 20
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Time",
                HeaderText = "Date",
                FillWeight = 25,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy HH:mm" }
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Piece",
                HeaderText = "Piece",
                FillWeight = 10
            });

            // общий внешний вид
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToResizeRows = false;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvExpenses.ColumnHeadersHeight = 32;
            dgvExpenses.RowTemplate.Height = 28;
            dgvExpenses.Font = new Font("Segoe UI", 9.5f);
            dgvExpenses.BackgroundColor = Color.White;
            dgvExpenses.BorderStyle = BorderStyle.None;
            dgvExpenses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvExpenses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvExpenses.CellMouseDown += dgvExpenses_CellMouseDown;
            cmbFilter.Items.AddRange(categoriesToDisplay);
            RefreshTable();
        }
        private void dgvExpenses_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvExpenses.ClearSelection();
                dgvExpenses.Rows[e.RowIndex].Selected = true;
            }
        }
        private void RefreshTable()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = manager.GetAll();
            UpdateTotal(manager.GetAll());
        }
        private void UpdateTotal(List<Expense> list)
        {
            decimal total = list.Sum(ex => ex.Price);
            lblTotal.Text = "Total: " + total;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(categories);
            if (form.ShowDialog() == DialogResult.OK)
            {
                manager.Add(form.Result);
                RefreshTable();
            }
        }

        private void btnShowByCategory_Click(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null)
            {
                MessageBox.Show("choose category for filter");
                return;
            }


            string filterCategory = cmbFilter.SelectedItem.ToString();
            List<Expense> filtered = manager.Filter(filterCategory);

            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = filtered;
            UpdateTotal(filtered);
        }
        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void nmrPiece_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void cmsDelete1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                Expense selected = (Expense)dgvExpenses.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show(
                    "Удалить \"" + selected.Name + "\"?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    manager.Remove(selected);
                    RefreshTable();
                }
            }
        }
    }
}
