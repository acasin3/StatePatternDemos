using System;
using System.Windows.Forms;

namespace DynamicPurchase
{
    public partial class frmEditPurchase : Form
    {
        Purchase _purchase;

        public frmEditPurchase()
        {
            InitializeComponent();
        }

        public Purchase Purchase
        {
            get
            {
                return _purchase;
            }
            set
            {
                _purchase = value;
                BindControls();
                UpdateValuesOfUnboundControls();
            }
        }
        
        private void BindControls()
        {
            txtSupplierTIN.DataBindings.Add("Text", _purchase, "SupplierTIN", false, DataSourceUpdateMode.OnValidation);
            txtSupplierName.DataBindings.Add("Text", _purchase, "SupplierName", false, DataSourceUpdateMode.OnValidation);
            txtDocNo.DataBindings.Add("Text", _purchase, "DocNo", false, DataSourceUpdateMode.OnValidation);
        }

        private void UpdateValuesOfUnboundControls()
        {
            if (_purchase.RegistrationType == "VAT")
            {
                lblVAT.Text = _purchase.VAT.ToString();
                lblPercentageTax.Text = "0";
            }
            else
            {
                lblPercentageTax.Text = _purchase.PercentageTax.ToString();
                lblVAT.Text = "0";
            }
        }

        private void txtSupplierTIN_Validated(object sender, EventArgs e)
        {
            _purchase.SupplierTIN = txtSupplierTIN.Text;
            UpdateValuesOfUnboundControls();
        }
    }
}
