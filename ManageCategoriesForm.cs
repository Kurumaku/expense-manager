using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace manaherUI
{
    public partial class ManageCategoriesForm : Form
    {
        private CategoryManager categoryManager;
        private List<Expense> allExpenses;

        public ManageCategoriesForm(CategoryManager categoryManager, List<Expense> allExpenses)
        {
            InitializeComponent();
            this.categoryManager = categoryManager;
            this.allExpenses = allExpenses;
            RefreshList();
        }

        private void RefreshList()
        {
            lstCategories.Items.Clear();
            foreach (string cat in categoryManager.GetAll())
            {
                lstCategories.Items.Add(cat);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtNewCategory.Text.Trim() == "")
            {
                MessageBox.Show("enter category name");
                return;
            }

            categoryManager.Add(txtNewCategory.Text.Trim());
            txtNewCategory.Clear();
            RefreshList();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem == null)
            {
                MessageBox.Show("select category to delete");
                return;
            }

            string selected = lstCategories.SelectedItem.ToString();
            bool removed = categoryManager.Remove(selected, allExpenses);

            if (!removed)
            {
                MessageBox.Show("cannot delete: category is used by existing expenses");
            }
            else
            {
                RefreshList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}