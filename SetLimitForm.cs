namespace manaherUI
{
    public partial class SetLimitForm : Form
    {
        public decimal LimitResult { get; private set; }

        public SetLimitForm(decimal currentLimit)
        {
            InitializeComponent();
            txtLimitValue.Text = currentLimit.ToString();
            Text = "Set Budget Limit";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtLimitValue.Text, out decimal limit))
            {
                MessageBox.Show("limit must be a number");
                return;
            }

            LimitResult = limit;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}