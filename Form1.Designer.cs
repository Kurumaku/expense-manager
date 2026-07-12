namespace manaherUI
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
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            dgvExpenses = new DataGridView();
            cmsDelete1 = new ContextMenuStrip(components);
            menuItemDelete = new ToolStripMenuItem();
            lblTotal = new Label();
            btnShowByCategory = new Button();
            cmbFilter = new ComboBox();
            nmrPiece = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            cmsDelete1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPiece).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(23, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(23, 105);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(88, 23);
            txtPrice.TabIndex = 1;
            txtPrice.TextChanged += textBox2_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(23, 163);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(138, 23);
            cmbCategory.TabIndex = 2;
            cmbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.ForeColor = Color.SaddleBrown;
            btnAdd.Location = new Point(23, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(62, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvExpenses
            // 
            dgvExpenses.BackgroundColor = Color.MistyRose;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.ContextMenuStrip = cmsDelete1;
            dgvExpenses.Location = new Point(23, 266);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.ScrollBars = ScrollBars.Vertical;
            dgvExpenses.Size = new Size(583, 540);
            dgvExpenses.TabIndex = 4;
            dgvExpenses.CellContentClick += dgvExpenses_CellContentClick;
            // 
            // cmsDelete1
            // 
            cmsDelete1.Items.AddRange(new ToolStripItem[] { menuItemDelete });
            cmsDelete1.Name = "contextMenuStrip1";
            cmsDelete1.Size = new Size(181, 48);
            cmsDelete1.Opening += cmsDelete1_Opening;
            // 
            // menuItemDelete
            // 
            menuItemDelete.Name = "menuItemDelete";
            menuItemDelete.Size = new Size(180, 22);
            menuItemDelete.Text = "Delete";
            menuItemDelete.Click += menuItemDelete_Click;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Location = new Point(23, 809);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 23);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total\r\n";
            lblTotal.TextAlign = ContentAlignment.BottomLeft;
            lblTotal.Click += lblTotal_Click;
            // 
            // btnShowByCategory
            // 
            btnShowByCategory.ForeColor = Color.SaddleBrown;
            btnShowByCategory.Location = new Point(375, 105);
            btnShowByCategory.Name = "btnShowByCategory";
            btnShowByCategory.Size = new Size(92, 23);
            btnShowByCategory.TabIndex = 6;
            btnShowByCategory.Text = "choose";
            btnShowByCategory.UseVisualStyleBackColor = true;
            btnShowByCategory.Click += btnShowByCategory_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(375, 76);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(167, 23);
            cmbFilter.TabIndex = 7;
            cmbFilter.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // nmrPiece
            // 
            nmrPiece.Location = new Point(23, 134);
            nmrPiece.Name = "nmrPiece";
            nmrPiece.Size = new Size(88, 23);
            nmrPiece.TabIndex = 9;
            nmrPiece.ValueChanged += nmrPiece_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(628, 859);
            Controls.Add(nmrPiece);
            Controls.Add(cmbFilter);
            Controls.Add(btnShowByCategory);
            Controls.Add(lblTotal);
            Controls.Add(dgvExpenses);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            cmsDelete1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmrPiece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private DataGridView dgvExpenses;
        private Label lblTotal;
        private Button btnShowByCategory;
        private ComboBox cmbFilter;
        private NumericUpDown nmrPiece;
        private ContextMenuStrip cmsDelete1;
        private ToolStripMenuItem menuItemDelete;
    }
}
