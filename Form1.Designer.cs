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
            budgetBar = new BudgetProgressBar();
            btnSetBudget = new Button();
            tabControl1 = new TabControl();
            tabMain = new TabPage();
            tabExpenses = new TabPage();
            btnManageCategories = new Button();
            tabBudget = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            cmsDelete1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabExpenses.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SaddleBrown;
            btnAdd.Location = new Point(15, 25);
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
            dgvExpenses.Location = new Point(15, 86);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.ScrollBars = ScrollBars.Vertical;
            dgvExpenses.Size = new Size(467, 498);
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
            lblTotal.Location = new Point(15, 587);
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
            btnShowByCategory.Location = new Point(114, 25);
            btnShowByCategory.Name = "btnShowByCategory";
            btnShowByCategory.Size = new Size(167, 37);
            btnShowByCategory.TabIndex = 6;
            btnShowByCategory.Text = "Choose Category";
            btnShowByCategory.UseVisualStyleBackColor = true;
            btnShowByCategory.Click += btnShowByCategory_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(315, 34);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(167, 23);
            cmbFilter.TabIndex = 7;
            cmbFilter.Text = "Category";
            cmbFilter.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // budgetBar
            // 
            budgetBar.Location = new Point(488, 532);
            budgetBar.Name = "budgetBar";
            budgetBar.Size = new Size(122, 52);
            budgetBar.TabIndex = 8;
            budgetBar.Text = "budgetProgressBar1";
            // 
            // btnSetBudget
            // 
            btnSetBudget.BackColor = Color.Transparent;
            btnSetBudget.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetBudget.ForeColor = Color.SaddleBrown;
            btnSetBudget.Location = new Point(505, 480);
            btnSetBudget.Name = "btnSetBudget";
            btnSetBudget.Size = new Size(92, 46);
            btnSetBudget.TabIndex = 10;
            btnSetBudget.Text = "Set Budget";
            btnSetBudget.UseVisualStyleBackColor = false;
            btnSetBudget.Click += btnSetBudget_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMain);
            tabControl1.Controls.Add(tabExpenses);
            tabControl1.Controls.Add(tabBudget);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(624, 638);
            tabControl1.TabIndex = 11;
            // 
            // tabMain
            // 
            tabMain.Location = new Point(4, 24);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(3);
            tabMain.Size = new Size(616, 610);
            tabMain.TabIndex = 0;
            tabMain.Text = "Menu";
            tabMain.UseVisualStyleBackColor = true;
            // 
            // tabExpenses
            // 
            tabExpenses.Controls.Add(btnManageCategories);
            tabExpenses.Controls.Add(dgvExpenses);
            tabExpenses.Controls.Add(btnAdd);
            tabExpenses.Controls.Add(btnSetBudget);
            tabExpenses.Controls.Add(lblTotal);
            tabExpenses.Controls.Add(budgetBar);
            tabExpenses.Controls.Add(btnShowByCategory);
            tabExpenses.Controls.Add(cmbFilter);
            tabExpenses.Location = new Point(4, 24);
            tabExpenses.Name = "tabExpenses";
            tabExpenses.Padding = new Padding(3);
            tabExpenses.Size = new Size(616, 610);
            tabExpenses.TabIndex = 1;
            tabExpenses.Text = "Expenses";
            tabExpenses.UseVisualStyleBackColor = true;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Location = new Point(505, 25);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(92, 35);
            btnManageCategories.TabIndex = 11;
            btnManageCategories.Text = "Categories";
            btnManageCategories.UseVisualStyleBackColor = true;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // tabBudget
            // 
            tabBudget.Location = new Point(4, 24);
            tabBudget.Name = "tabBudget";
            tabBudget.Padding = new Padding(3);
            tabBudget.Size = new Size(616, 610);
            tabBudget.TabIndex = 2;
            tabBudget.Text = "Budget Planner";
            tabBudget.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(628, 801);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            cmsDelete1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabExpenses.ResumeLayout(false);
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
        private BudgetProgressBar budgetBar;
        private Button btnSetBudget;
        private TabControl tabControl1;
        private TabPage tabMain;
        private TabPage tabExpenses;
        private TabPage tabBudget;
        private Button btnManageCategories;
    }
}
