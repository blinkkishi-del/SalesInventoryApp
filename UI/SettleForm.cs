namespace UI
{
    public partial class SettleForm : Form
    {

        public decimal Cash { get; private set; }

        public SettleForm(decimal total, decimal initialCash)
        {
            InitializeComponent();
         
        }


        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
