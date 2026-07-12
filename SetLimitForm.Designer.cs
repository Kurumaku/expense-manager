namespace manaherUI
{
    partial class SetLimitForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button btnCancel1;
        private Button btnSave1;
        private TextBox txtLimitValue;

        private void InitializeComponent()
        {
            btnCancel1 = new Button();
            btnSave1 = new Button();
            txtLimitValue = new TextBox();
            SuspendLayout();
            // 
            // btnCancel1
            // 
            btnCancel1.Location = new Point(114, 151);
            btnCancel1.Name = "btnCancel1";
            btnCancel1.Size = new Size(75, 23);
            btnCancel1.TabIndex = 0;
            btnCancel1.Text = "Cancel";
            btnCancel1.UseVisualStyleBackColor = true;
            btnCancel1.Click += this.btnCancel_Click;
            // 
            // btnSave1
            // 
            btnSave1.Location = new Point(12, 151);
            btnSave1.Name = "btnSave1";
            btnSave1.Size = new Size(75, 23);
            btnSave1.TabIndex = 1;
            btnSave1.Text = "Save";
            btnSave1.UseVisualStyleBackColor = true;
            btnSave1.Click += this.btnSave_Click;
            // 
            // txtLimitValue
            // 
            txtLimitValue.Location = new Point(36, 77);
            txtLimitValue.Name = "txtLimitValue";
            txtLimitValue.Size = new Size(100, 23);
            txtLimitValue.TabIndex = 2;
            // 
            // SetLimitForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(txtLimitValue);
            Controls.Add(btnSave1);
            Controls.Add(btnCancel1);
            Name = "SetLimitForm";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}