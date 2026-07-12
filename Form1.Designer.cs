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
            btnAdd = new Button();
            dgvExpenses = new DataGridView();
            cmsDelete1 = new ContextMenuStrip(components);
            menuItemDelete = new ToolStripMenuItem();
            lblTotal = new Label();
            btnShowByCategory = new Button();
            cmbFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            cmsDelete1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SaddleBrown;
            btnAdd.Location = new Point(12, 174);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 37);
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
            dgvExpenses.Location = new Point(12, 217);
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
            cmsDelete1.Size = new Size(108, 26);
            cmsDelete1.Opening += cmsDelete1_Opening;
            // 
            // menuItemDelete
            // 
            menuItemDelete.Name = "menuItemDelete";
            menuItemDelete.Size = new Size(107, 22);
            menuItemDelete.Text = "Delete";
            menuItemDelete.Click += menuItemDelete_Click;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Location = new Point(12, 760);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 23);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total\r\n";
            lblTotal.TextAlign = ContentAlignment.BottomLeft;
            lblTotal.Click += lblTotal_Click;
            // 
            // btnShowByCategory
            // 
            btnShowByCategory.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            btnShowByCategory.ForeColor = Color.SaddleBrown;
            btnShowByCategory.Location = new Point(428, 12);
            btnShowByCategory.Name = "btnShowByCategory";
            btnShowByCategory.Size = new Size(167, 26);
            btnShowByCategory.TabIndex = 6;
            btnShowByCategory.Text = "Choose Category";
            btnShowByCategory.UseVisualStyleBackColor = true;
            btnShowByCategory.Click += btnShowByCategory_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(428, 44);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(167, 23);
            cmbFilter.TabIndex = 7;
            cmbFilter.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(628, 801);
            Controls.Add(cmbFilter);
            Controls.Add(btnShowByCategory);
            Controls.Add(lblTotal);
            Controls.Add(dgvExpenses);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            cmsDelete1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private DataGridView dgvExpenses;
        private Label lblTotal;
        private Button btnShowByCategory;
        private ComboBox cmbFilter;
        private ContextMenuStrip cmsDelete1;
        private ToolStripMenuItem menuItemDelete;
    }
}
