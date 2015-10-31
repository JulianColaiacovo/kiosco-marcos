using Data;
using Data.Dtos;
using Kiosco.PurchasesTab.Elements;
using Kiosco.PurchaseItemCart;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco.PurchasesTab
{
    public partial class PurchaseCart : UserControl
    {
        public DataGridView DataGridView { get { return this.dgvPurchaseItems; } }
        private BindingList<PurchaseItem> items;

        public PurchaseCart()
        {
            this.items = new BindingList<PurchaseItem>();
            InitializeComponent();

            this.dgvPurchaseItems.AutoGenerateColumns = false;

            this.dgvPurchaseItems.DataSource = this.items;

            this.bPurchaseItemEdit.Enabled = false;
            this.bPurchaseItemDelete.Enabled = false;
            this.bBuy.Enabled = false;
            this.bClear.Enabled = false;
        }

        private void setBehaviourItemsChanged()
        {
            if (this.dgvPurchaseItems.Rows.Count == 0)
            {
                this.bBuy.Enabled = false;
                this.bClear.Enabled = false;
            }
            else
            {
                this.bBuy.Enabled = true;
                this.bClear.Enabled = true;
            }
        }


        public void addPurchaseItem(PurchaseItem purchaseItem)
        {
            bool alreadyExist = false;
            foreach (PurchaseItem item in this.items)
            {
                if (item.Product.Id == purchaseItem.Product.Id && item.Provider.Id == purchaseItem.Provider.Id)
                {
                    alreadyExist = true;
                    item.Quantity += purchaseItem.Quantity;
                    break;
                }
            }
            if (!alreadyExist)
            {
                this.items.Add(purchaseItem);
            }
            this.dgvPurchaseItems.Refresh();
        }

        private void bPurchaseItemEdit_Click(object sender, System.EventArgs e)
        {
            QuantityUnitPriceForm form = new QuantityUnitPriceForm();
            PurchaseItem pi = this.items[this.dgvPurchaseItems.SelectedRows[0].Index];
            if (form.ShowDialog(new QuantityUnitPrice(pi.Quantity, pi.UnitPrice), DbActionsEnum.Update) == System.Windows.Forms.DialogResult.OK)
            {
                pi.UnitPrice = form.ResultData.UnitPrice;
                pi.Quantity = form.ResultData.Quantity;
                this.dgvPurchaseItems.Refresh();
            }
        }

        private void bPurchaseItemDelete_Click(object sender, System.EventArgs e)
        {
            this.items.RemoveAt(this.dgvPurchaseItems.SelectedRows[0].Index);
        }

        private void dgvPurchaseItems_SelectionChanged(object sender, System.EventArgs e)
        {
            if (this.dgvPurchaseItems.SelectedRows.Count > 0)
            {
                this.bPurchaseItemEdit.Enabled = true;
                this.bPurchaseItemDelete.Enabled = true;
            }
            else
            {
                this.bPurchaseItemEdit.Enabled = false;
                this.bPurchaseItemDelete.Enabled = false;
            }
        }

        private void dgvPurchaseItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = this.dgvPurchaseItems.Columns[e.ColumnIndex].Name;
            if (columnName == "PurchaseItemProductColumn")
            {
                e.Value = this.items[e.RowIndex].Product.Name;
            }
            else if (columnName == "PurchaseItemQuantityColumn")
            {
                e.Value = this.items[e.RowIndex].Quantity;
            }
            else if (columnName == "PurchaseItemUnitPriceColumn")
            {
                e.Value = this.items[e.RowIndex].UnitPrice;
            }
            else if (columnName == "PurchaseItemProviderColumn")
            {
                e.Value = this.items[e.RowIndex].Provider.Name;
            }
        }


        private void dgvPurchaseItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.setBehaviourItemsChanged();
        }

        private void dgvPurchaseItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.setBehaviourItemsChanged();
        }

        private void bClear_Click(object sender, System.EventArgs e)
        {
            this.items.Clear();
        }

        private void bBuy_Click(object sender, System.EventArgs e)
        {
            List<PurchaseItemDB> list = new List<PurchaseItemDB>();
            foreach (PurchaseItem item in this.items)
            {
                list.Add((PurchaseItemDB)item);
            }
            try
            {
                DbValidation.Instance.savePurchase(list, this.nudDiscount.Value, this.nudTax.Value);
                this.bClear.PerformClick();
                this.nudDiscount.Value = 0;
                this.nudTax.Value = 0;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

        }
    }
}
