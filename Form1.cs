using System.IO;
using System.Linq;
namespace manaherUI
{

    public partial class Form1 : Form
    {
        List<Expense> expenses = new List<Expense>();
        string filePath = "expenses.csv";
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
            cmbCategory.Items.AddRange(categories);
            cmbFilter.Items.AddRange(categoriesToDisplay);
            LoadFromFile();
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
            dgvExpenses.DataSource = expenses;
            UpdateTotal(expenses);
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
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("choose category");
                return;
            }

            Expense item = new Expense();
            item.Name = txtName.Text;
            item.Price = decimal.Parse(txtPrice.Text);
            item.Category = cmbCategory.SelectedItem.ToString();
            item.Time = DateTime.Now;
            item.Piece = (int)nmrPiece.Value;

            expenses.Add(item);
            SaveToFile();
            RefreshTable();

            txtName.Clear();
            txtPrice.Clear();
            nmrPiece.ResetText();
        }

        private void btnShowByCategory_Click(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null)
            {
                MessageBox.Show("choose category for filter");
                return;
            }


            string filterCategory = cmbFilter.SelectedItem.ToString();
            List<Expense> filtered = new List<Expense>();
            if (filterCategory == "all")
            {
                filtered = expenses;
            }
            else
            {
                foreach (Expense ex in expenses)
                {
                    if (ex.Category == filterCategory)
                    {
                        filtered.Add(ex);
                    }

                }
            }

            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = filtered;
            UpdateTotal(filtered);
        }
        private void SaveToFile()
        {
            List<string> lines = new List<string>();
            foreach (Expense ex in expenses)
            {
                string line = ex.Name + ";" + ex.Price + ";" + ex.Category + ";" + ex.Time + ";" + ex.Piece;
                lines.Add(line);
            }
            File.WriteAllLines(filePath, lines);
        }

        private void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] fields = line.Split(';');
                    Expense loaded = new Expense();
                    loaded.Name = fields[0];
                    loaded.Price = decimal.Parse(fields[1]);
                    loaded.Category = fields[2];
                    loaded.Time = DateTime.Parse(fields[3]);
                    loaded.Piece = int.Parse(fields[4]);
                    expenses.Add(loaded);
                }
                RefreshTable();
            }
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
                    expenses.Remove(selected);
                    SaveToFile();
                    RefreshTable();
                }
            }
        }
    }
    public class Expense
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Time { get; set; }
        public int Piece { get; set; }
        public string Category { get; set; }
    }
}
