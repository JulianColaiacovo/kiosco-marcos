using Data;
using Data.Dtos;
using Kiosco.SaleItemCart;
using Kiosco.SalesTab.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kiosco.SalesTab
{
    public partial class SaleCart : UserControl
    {
        public DataGridView DataGridView { get { return this.dgvSaleItems; } }
        private BindingList<SaleItem> items;

        public SaleCart()
        {
            this.items = new BindingList<SaleItem>();
            InitializeComponent();

            this.dgvSaleItems.AutoGenerateColumns = false;

            this.dgvSaleItems.DataSource = this.items;

            this.bSaleItemEdit.Enabled = false;
            this.bSaleItemDelete.Enabled = false;
            this.bSell.Enabled = false;
            this.bClear.Enabled = false;
        }

        private void setBehaviourItemsChanged()
        {
            if (this.dgvSaleItems.Rows.Count == 0)
            {
                this.bSell.Enabled = false;
                this.bClear.Enabled = false;
            }
            else
            {
                this.bSell.Enabled = true;
                this.bClear.Enabled = true;
            }
        }

        public void addSaleItem(SaleItem saleItem)
        {
            bool alreadyExist = false;
            foreach (SaleItem item in this.items)
            {
                if (item.Product.Id == saleItem.Product.Id)
                {
                    alreadyExist = true;
                    item.Quantity += saleItem.Quantity;
                    break;
                }
            }
            if (!alreadyExist)
            {
                this.items.Add(saleItem);
            }
            this.dgvSaleItems.Refresh();
        }

        private void dgvPurchaseItems_SelectionChanged(object sender, System.EventArgs e)
        {
            if (this.dgvSaleItems.SelectedRows.Count > 0)
            {
                this.bSaleItemEdit.Enabled = true;
                this.bSaleItemDelete.Enabled = true;
            }
            else
            {
                this.bSaleItemEdit.Enabled = false;
                this.bSaleItemDelete.Enabled = false;
            }
        }

        private void dgvPurchaseItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = this.dgvSaleItems.Columns[e.ColumnIndex].Name;
            if (columnName == "SaleItemProductColumn")
            {
                e.Value = this.items[e.RowIndex].Product.Name;
            }
            else if (columnName == "SaleItemQuantityColumn")
            {
                e.Value = this.items[e.RowIndex].Quantity;
            }
            else if (columnName == "SaleItemSubTotalColumn")
            {
                e.Value = this.items[e.RowIndex].Quantity * this.items[e.RowIndex].Product.Price;
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

        private void bSell_Click(object sender, System.EventArgs e)
        {
            List<SaleItemDB> list = new List<SaleItemDB>();
            foreach (SaleItem item in this.items)
            {
                list.Add((SaleItemDB)item);
            }
            try
            {
                DbValidation.Instance.saveSale(list, this.nudDiscount.Value, this.nudTax.Value);
                this.bClear.PerformClick();
                this.nudDiscount.Value = 0;
                this.nudTax.Value = 0;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

        }

        private void bSaleItemEdit_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            SaleItem pi = this.items[this.dgvSaleItems.SelectedRows[0].Index];
            if (form.ShowDialog(pi.Quantity, DbActionsEnum.Update) == System.Windows.Forms.DialogResult.OK)
            {
                pi.Quantity = form.ResultData;
                this.dgvSaleItems.Refresh();
            }
        }

        private void bSaleItemDelete_Click(object sender, EventArgs e)
        {
            this.items.RemoveAt(this.dgvSaleItems.SelectedRows[0].Index);
        }

    }
}
