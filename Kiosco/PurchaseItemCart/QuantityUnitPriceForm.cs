using System;
using System.Windows.Forms;

namespace Kiosco.PurchaseItemCart
{
    public partial class QuantityUnitPriceForm : Form
    {
        private QuantityUnitPrice originalData;
        public QuantityUnitPrice ResultData { get; set; }

        public QuantityUnitPriceForm()
        {
            this.originalData = null;
            this.ResultData = null;
            InitializeComponent();
        }

        private bool validateData()
        {
            return true;
        }

        public DialogResult ShowDialog(QuantityUnitPrice data, DbActionsEnum operation)
        {
            this.originalData = data;
            if (operation != DbActionsEnum.Create)
            {
                this.nudQuantity.Value = data.Quantity;
                this.nudUnitPrice.Value = data.UnitPrice;
            }
            return this.ShowDialog();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (this.validateData())
            {
                this.ResultData = new QuantityUnitPrice(this.nudQuantity.Value, this.nudUnitPrice.Value);
            }
        }
    }
}
