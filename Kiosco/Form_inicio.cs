using Kiosco.PurchaseItemCart;
using Kiosco.PurchasesTab.Elements;
using Kiosco.SalesTab.Elements;
using Kiosco.SaleItemCart;
using System;
using System.Windows.Forms;

namespace Kiosco
{
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();

            this.bPurchaseItemAdd.Enabled = false;
            this.purchaseCart.Enabled = false;
            this.psPurchasesTab.ListBox.SelectedValueChanged += ListBoxProviders_SelectedValueChanged;
            this.prodsPurchaseTab.ListBox.SelectedValueChanged += ListBoxProducts_SelectedValueChanged;
            this.purchaseCart.DataGridView.RowsAdded += DataGridView_RowsAdded;
            this.purchaseCart.DataGridView.RowsRemoved += DataGridView_RowsRemoved;
            this.prodsPurchaseTab.TextBoxCode.KeyPress += TextBoxCode_KeyPress;

            this.bSellItemAdd.Enabled = false;
            this.saleCart.Enabled = false;
            this.prodsSellTab.ListBox.SelectedValueChanged += ListBoxProductsSale_SelectedValueChanged;
            this.saleCart.DataGridView.RowsAdded += DataGridViewSale_RowsAdded;
            this.saleCart.DataGridView.RowsRemoved += DataGridViewSale_RowsRemoved;
            this.prodsSellTab.TextBoxCode.KeyPress += TextBoxCodeSale_KeyPress;
        }

        private void TextBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.prodsPurchaseTab.TextBoxCode.Focused && this.prodsPurchaseTab.getSelectedProduct() != null)
            {
                this.bPurchaseItemAdd.PerformClick();
            }
        }
        private void TextBoxCodeSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.prodsSellTab.TextBoxCode.Focused && this.prodsSellTab.getSelectedProduct() != null)
            {
                this.bSellItemAdd.PerformClick();
            }
        }

        private void ListBoxProviders_SelectedValueChanged(object sender, EventArgs e)
        {
            this.setBehaviourProvidersProducts();
        }
        private void ListBoxProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            this.setBehaviourProvidersProducts();
        }

        private void ListBoxProductsSale_SelectedValueChanged(object sender, EventArgs e)
        {
            this.setBehaviourProductsSale();
        }

        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.setBehaviourRowsCart();
        }
        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.setBehaviourRowsCart();
        }

        private void DataGridViewSale_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.setBehaviourRowsCart();
        }
        private void DataGridViewSale_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.setBehaviourRowsCart();
        }

        private void setBehaviourRowsCart()
        {
            this.psPurchasesTab.Enabled = this.purchaseCart.DataGridView.Rows.Count == 0;
        }
        private void setBehaviourProvidersProducts()
        {
            if (this.prodsPurchaseTab.ListBox.SelectedIndex != -1 && this.psPurchasesTab.ListBox.SelectedIndex != -1)
            {
                this.bPurchaseItemAdd.Enabled = true;
                this.purchaseCart.Enabled = true;
            }
            else
            {
                this.bPurchaseItemAdd.Enabled = false;
                this.purchaseCart.Enabled = false;
            }
        }
        private void setBehaviourProductsSale()
        {
            if (this.prodsSellTab.ListBox.SelectedIndex != -1)
            {
                this.bSellItemAdd.Enabled = true;
                this.saleCart.Enabled = true;
            }
            else
            {
                this.bSellItemAdd.Enabled = false;
                this.saleCart.Enabled = false;
            }
        }

        private void bPurchaseItemAdd_Click(object sender, EventArgs e)
        {
            QuantityUnitPriceForm form = new QuantityUnitPriceForm();
            if (form.ShowDialog(null, DbActionsEnum.Create) == System.Windows.Forms.DialogResult.OK)
            {
                PurchaseItem pi = new PurchaseItem(form.ResultData.Quantity, form.ResultData.UnitPrice, this.prodsPurchaseTab.getSelectedProduct(), this.psPurchasesTab.getSelectedProvider());
                this.purchaseCart.addPurchaseItem(pi);
            }
        }

        private void bSellItemAdd_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            if (form.ShowDialog(1, DbActionsEnum.Create) == System.Windows.Forms.DialogResult.OK)
            {
                SaleItem si = new SaleItem(form.ResultData, this.prodsSellTab.getSelectedProduct());
                this.saleCart.addSaleItem(si);
            }
        }
    }
}
