using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace manaherUI
{
    public partial class AddEditForm : Form
    {
        public Expense Result { get; private set; } = new Expense();
        private Expense? editingItem;

        public AddEditForm(string[] categories, Expense? itemToEdit = null)
        {
            InitializeComponent();
            cmbCategory.Items.AddRange(categories);

            if (itemToEdit != null)
            {
                editingItem = itemToEdit;
                txtName.Text = itemToEdit.Name;
                txtPrice.Text = itemToEdit.Price.ToString();
                cmbCategory.SelectedItem = itemToEdit.Category;
                nmrPiece.Value = itemToEdit.Piece;
                Text = "Edit expense";
            }
            else
            {
                Text = "Add expense";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("choose category");
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("price must be a number");
                return;
            }

            Result = new Expense();
            Result.Name = txtName.Text;
            Result.Price = price;
            Result.Category = cmbCategory.SelectedItem.ToString();
            Result.Piece = (int)nmrPiece.Value;
            Result.Time = editingItem != null ? editingItem.Time : DateTime.Now;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
