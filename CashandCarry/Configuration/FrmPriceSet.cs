using CashandCarry.BL;
using CashandCarry.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Configuration
{
    public partial class FrmPriceSet : MetroForm
    {
        public FrmPriceSet()
        {
            InitializeComponent();
        }

        private void FrmPriceSet_Load(object sender, EventArgs e)
        {
            FormDisabled();
        }

        private void FormDisabled()
        {            
            txtProductName.Enabled = false;
            txtBuyerPrice.Enabled = false;
            txtSellerPrice.Enabled = false;
            rdActive.Enabled = false;
            rdNotActive.Enabled = false;
            btnSave.Enabled = false;
        }

        private void FromEnable()
        {            
            txtProductName.Enabled = true;
            txtBuyerPrice.Enabled = true;
            txtSellerPrice.Enabled = true;
            rdActive.Enabled = true;
            rdNotActive.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            FromEnable();
            LoadProduct();
        }

        private void LoadProduct()
        {
            ProductBL objPro = new ProductBL();
            List<View_tbl_Product> dt = objPro.Select();
            txtProductName.DataSource = dt;
            txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtProductName.DisplayMember = "ProductName";
            txtProductName.ValueMember = "ProductID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

       

    }
}
