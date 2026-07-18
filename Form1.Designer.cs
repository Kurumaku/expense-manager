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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            btnQuickAdd = new Button();
            lstRecentExpenses = new ListBox();
            lstTopCategories = new ListBox();
            mainBudgetBar = new BudgetProgressBar();
            lblMainTotal = new Label();
            tabExpenses = new TabPage();
            btnManageCategories = new Button();
            tabBudget = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            cmsDelete1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabMain.SuspendLayout();
            tabExpenses.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.BackColor = Color.FromArgb(124, 156, 245);
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAdd.ForeColor = Color.White;
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvExpenses
            // 
            resources.ApplyResources(dgvExpenses, "dgvExpenses");
            dgvExpenses.BackgroundColor = Color.FromArgb(42, 42, 60);
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.ContextMenuStrip = cmsDelete1;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.CellContentClick += dgvExpenses_CellContentClick;
            // 
            // cmsDelete1
            // 
            resources.ApplyResources(cmsDelete1, "cmsDelete1");
            cmsDelete1.Items.AddRange(new ToolStripItem[] { menuItemDelete });
            cmsDelete1.Name = "contextMenuStrip1";
            cmsDelete1.Opening += cmsDelete1_Opening;
            // 
            // menuItemDelete
            // 
            resources.ApplyResources(menuItemDelete, "menuItemDelete");
            menuItemDelete.Name = "menuItemDelete";
            menuItemDelete.Click += menuItemDelete_Click;
            // 
            // lblTotal
            // 
            resources.ApplyResources(lblTotal, "lblTotal");
            lblTotal.BackColor = Color.Transparent;
            lblTotal.ForeColor = Color.White;
            lblTotal.Name = "lblTotal";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnShowByCategory
            // 
            resources.ApplyResources(btnShowByCategory, "btnShowByCategory");
            btnShowByCategory.BackColor = Color.FromArgb(124, 156, 245);
            btnShowByCategory.ForeColor = Color.White;
            btnShowByCategory.Name = "btnShowByCategory";
            btnShowByCategory.UseVisualStyleBackColor = false;
            btnShowByCategory.Click += btnShowByCategory_Click;
            // 
            // cmbFilter
            // 
            resources.ApplyResources(cmbFilter, "cmbFilter");
            cmbFilter.BackColor = Color.FromArgb(124, 156, 245);
            cmbFilter.ForeColor = Color.White;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Name = "cmbFilter";
            cmbFilter.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // budgetBar
            // 
            resources.ApplyResources(budgetBar, "budgetBar");
            budgetBar.BackColor = Color.FromArgb(42, 42, 60);
            budgetBar.Name = "budgetBar";
            budgetBar.Click += budgetBar_Click;
            // 
            // btnSetBudget
            // 
            resources.ApplyResources(btnSetBudget, "btnSetBudget");
            btnSetBudget.BackColor = Color.FromArgb(124, 156, 245);
            btnSetBudget.ForeColor = Color.White;
            btnSetBudget.Name = "btnSetBudget";
            btnSetBudget.UseVisualStyleBackColor = false;
            btnSetBudget.Click += btnSetBudget_Click;
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabMain);
            tabControl1.Controls.Add(tabExpenses);
            tabControl1.Controls.Add(tabBudget);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabMain
            // 
            resources.ApplyResources(tabMain, "tabMain");
            tabMain.BackColor = Color.FromArgb(24, 24, 37);
            tabMain.Controls.Add(btnQuickAdd);
            tabMain.Controls.Add(lstRecentExpenses);
            tabMain.Controls.Add(lstTopCategories);
            tabMain.Controls.Add(mainBudgetBar);
            tabMain.Controls.Add(lblMainTotal);
            tabMain.Name = "tabMain";
            // 
            // btnQuickAdd
            // 
            resources.ApplyResources(btnQuickAdd, "btnQuickAdd");
            btnQuickAdd.BackColor = Color.FromArgb(124, 156, 245);
            btnQuickAdd.Name = "btnQuickAdd";
            btnQuickAdd.UseVisualStyleBackColor = false;
            btnQuickAdd.Click += btnQuickAdd_Click;
            // 
            // lstRecentExpenses
            // 
            resources.ApplyResources(lstRecentExpenses, "lstRecentExpenses");
            lstRecentExpenses.BackColor = Color.FromArgb(42, 42, 60);
            lstRecentExpenses.ForeColor = Color.White;
            lstRecentExpenses.FormattingEnabled = true;
            lstRecentExpenses.Name = "lstRecentExpenses";
            // 
            // lstTopCategories
            // 
            resources.ApplyResources(lstTopCategories, "lstTopCategories");
            lstTopCategories.BackColor = Color.FromArgb(42, 42, 60);
            lstTopCategories.ForeColor = Color.White;
            lstTopCategories.FormattingEnabled = true;
            lstTopCategories.Name = "lstTopCategories";
            // 
            // mainBudgetBar
            // 
            resources.ApplyResources(mainBudgetBar, "mainBudgetBar");
            mainBudgetBar.Name = "mainBudgetBar";
            // 
            // lblMainTotal
            // 
            resources.ApplyResources(lblMainTotal, "lblMainTotal");
            lblMainTotal.ForeColor = Color.White;
            lblMainTotal.Name = "lblMainTotal";
            lblMainTotal.Click += lblMainTotal_Click;
            // 
            // tabExpenses
            // 
            resources.ApplyResources(tabExpenses, "tabExpenses");
            tabExpenses.BackColor = Color.FromArgb(24, 24, 37);
            tabExpenses.Controls.Add(btnManageCategories);
            tabExpenses.Controls.Add(dgvExpenses);
            tabExpenses.Controls.Add(btnAdd);
            tabExpenses.Controls.Add(btnSetBudget);
            tabExpenses.Controls.Add(lblTotal);
            tabExpenses.Controls.Add(budgetBar);
            tabExpenses.Controls.Add(btnShowByCategory);
            tabExpenses.Controls.Add(cmbFilter);
            tabExpenses.Name = "tabExpenses";
            // 
            // btnManageCategories
            // 
            resources.ApplyResources(btnManageCategories, "btnManageCategories");
            btnManageCategories.BackColor = Color.FromArgb(124, 156, 245);
            btnManageCategories.ForeColor = Color.White;
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.UseVisualStyleBackColor = false;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // tabBudget
            // 
            resources.ApplyResources(tabBudget, "tabBudget");
            tabBudget.BackColor = Color.FromArgb(24, 24, 37);
            tabBudget.Name = "tabBudget";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            Controls.Add(tabControl1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            cmsDelete1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabMain.PerformLayout();
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
        private Label lblMainTotal;
        private Button btnQuickAdd;
        private ListBox lstRecentExpenses;
        private ListBox lstTopCategories;
        private BudgetProgressBar mainBudgetBar;
    }
}
