using BusinessLogic.Controller;
using Model;
using System.ComponentModel;

namespace UI
{
    public partial class StockEntry : Form
    {


        public StockEntry(string username)
        {
            InitializeComponent();

        }

        public StockEntry(string username, string productId, string supplierName) : this(username)
        {

        }

        private void StockEntry_Load(object sender, EventArgs e)
        {

        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void AddSelectedProductToList()
        {
          
        }

        private void btnAddToList_Click(object sender, EventArgs e) { }

        private void dgProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
