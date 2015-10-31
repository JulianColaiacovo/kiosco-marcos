using System;
using System.Windows.Forms;

namespace Kiosco.SaleItemCart
{
    public partial class QuantityForm : Form
    {
        private decimal originalData;
        public decimal ResultData { get; set; }

        public QuantityForm()
        {
            InitializeComponent();
            this.originalData = 0;
            this.ResultData = 0;
        }
        
        private bool validateData()
        {
            return true;
        }

        public DialogResult ShowDialog(decimal data, DbActionsEnum operation)
        {
            this.originalData = data;
            if (operation != DbActionsEnum.Create)
            {
                this.nudQuantity.Value = data;
            }
            return this.ShowDialog();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (this.validateData())
            {
                this.ResultData = this.nudQuantity.Value;
            }
        }
    }
}
