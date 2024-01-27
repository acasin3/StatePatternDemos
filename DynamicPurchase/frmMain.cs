using System;
using System.Windows.Forms;

namespace DynamicPurchase
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase a = new Purchase();

            frmEditPurchase f = new frmEditPurchase();
            f.Text = "Add Purchase";
            f.Purchase = a;
            f.Show();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase a = new Purchase();
            a.Load(1);

            frmEditPurchase f = new frmEditPurchase();
            f.Text = "Edit Purchase";
            f.Purchase = a;
            f.Show();
        }
    }
}
