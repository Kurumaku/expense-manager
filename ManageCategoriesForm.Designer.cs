namespace manaherUI
{
    partial class ManageCategoriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCategories = new ListBox();
            txtNewCategory = new TextBox();
            btnAddCategory = new Button();
            button2 = new Button();
            btnClose = new Button();
            btnDeleteCategory = new Button();
            SuspendLayout();
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.Location = new Point(24, 46);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(145, 364);
            lstCategories.TabIndex = 0;
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(204, 46);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(148, 23);
            txtNewCategory.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(204, 109);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 23);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // button2
            // 
            button2.Location = new Point(204, 166);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(204, 220);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(204, 166);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(75, 23);
            btnDeleteCategory.TabIndex = 3;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // ManageCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 441);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteCategory);
            Controls.Add(button2);
            Controls.Add(btnAddCategory);
            Controls.Add(txtNewCategory);
            Controls.Add(lstCategories);
            Name = "ManageCategoriesForm";
            Text = "ManageCategoriesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCategories;
        private TextBox txtNewCategory;
        private Button btnAddCategory;
        private Button button2;
        private Button btnClose;
        private Button btnDeleteCategory;
    }
}