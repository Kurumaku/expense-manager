namespace manaherUI
{
    partial class AddEditForm
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
            txtName = new TextBox();
            txtPrice = new TextBox();
            nmrPiece = new NumericUpDown();
            cmbCategory = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrPiece).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AccessibleName = "txtName";
            txtName.Location = new Point(33, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 23);
            txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.AccessibleName = "txtPrice";
            txtPrice.Location = new Point(33, 73);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(88, 23);
            txtPrice.TabIndex = 1;
            txtPrice.TextChanged += textBox2_TextChanged;
            // 
            // nmrPiece
            // 
            nmrPiece.AccessibleName = "nmrPiece";
            nmrPiece.Location = new Point(33, 113);
            nmrPiece.Name = "nmrPiece";
            nmrPiece.Size = new Size(88, 23);
            nmrPiece.TabIndex = 9;
            // 
            // cmbCategory
            // 
            cmbCategory.AccessibleName = "cmbCategory";
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(33, 155);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(138, 23);
            cmbCategory.TabIndex = 2;
            // 
            // button1
            // 
            button1.AccessibleName = "btnSave";
            button1.Location = new Point(33, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "btnCancel";
            button2.Location = new Point(140, 215);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancel_Click;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 258);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtName);
            Controls.Add(nmrPiece);
            Controls.Add(txtPrice);
            Controls.Add(cmbCategory);
            Name = "AddEditForm";
            Text = "AddEditForm";
            ((System.ComponentModel.ISupportInitialize)nmrPiece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPrice;
        private NumericUpDown nmrPiece;
        private ComboBox cmbCategory;
        private Button button1;
        private Button button2;
    }
}