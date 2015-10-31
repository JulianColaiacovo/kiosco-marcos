using Data;
using Data.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kiosco.ProductsTab
{
    public partial class ProductsSelect : UserControl
    {
        public TextBox TextBoxCode { get { return this.tbProductCode; } }
        public ListBox ListBox { get { return this.lbProducts; } }
        [Category("Appearance")]
        public bool OnlySearch { get; set; }

        public ProductsSelect()
        {
            InitializeComponent();
        }

        public ProductDB getSelectedProduct()
        {
            return this.lbProducts.SelectedItem as ProductDB;
        }

        private void refreshSearchProductsByName()
        {
            List<ProductDB> products = DbValidation.Instance.searchProductsByName(this.tbProductName.Text);
            this.lbProducts.DataSource = products;

            if (this.lbProducts.SelectedIndex == -1)
            {
                this.bProductView.Enabled = false;
                this.bProductModify.Enabled = false;
                this.bProductDelete.Enabled = false;
            }
            else
            {
                this.bProductView.Enabled = true;
                this.bProductModify.Enabled = true;
                this.bProductDelete.Enabled = true;
            }
            this.setBehaviourListBox();
        }
        private void refreshSearchProductsByCode()
        {
            long code = String.IsNullOrEmpty(this.tbProductCode.Text) ? -1 : long.Parse(this.tbProductCode.Text);
            ProductDB product = DbValidation.Instance.searchProductByCode(code);

            if (product == null)
            {
                string old = this.lbProducts.DisplayMember;
                this.lbProducts.DataSource = null;
                this.lbProducts.DisplayMember = old;
                this.lbProducts.ClearSelected();
            }
            else
            {
                List<ProductDB> products = new List<ProductDB>();
                products.Add(product);
                this.lbProducts.DataSource = products;
                this.lbProducts.SelectedIndex = 0;
            }
            this.setBehaviourListBox();
        }

        private void setBehaviourListBox()
        {
            if (this.lbProducts.SelectedIndex == -1)
            {
                this.bProductView.Enabled = false;
                this.bProductModify.Enabled = false;
                this.bProductDelete.Enabled = false;
            }
            else
            {
                this.bProductView.Enabled = true;
                this.bProductModify.Enabled = true;
                this.bProductDelete.Enabled = true;
            }
        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {
            this.refreshSearchProductsByName();
        }

        private void bProductView_Click(object sender, EventArgs e)
        {
            FormProductActions formProduct = new FormProductActions();
            formProduct.ShowDialog(this.lbProducts.SelectedItem as ProductDB, DbActionsEnum.Show);
        }

        private void bProductAdd_Click(object sender, EventArgs e)
        {
            FormProductActions formProduct = new FormProductActions();
            if (formProduct.ShowDialog(null, DbActionsEnum.Create) == DialogResult.OK)
            {
                DbValidation.Instance.saveProduct(formProduct.ResultProduct);
                this.refreshSearchProductsByName();
            }
        }

        private void bProductModify_Click(object sender, EventArgs e)
        {
            FormProductActions formProduct = new FormProductActions();
            if (formProduct.ShowDialog(this.lbProducts.SelectedItem as ProductDB, DbActionsEnum.Update) == DialogResult.OK)
            {
                DbValidation.Instance.saveProduct(formProduct.ResultProduct);
                this.refreshSearchProductsByName();
            }
        }

        private void bProductDelete_Click(object sender, EventArgs e)
        {
            DbValidation.Instance.deleteProduct(this.lbProducts.SelectedItem as ProductDB);
            this.refreshSearchProductsByName();
        }

        private void ProductsSelect_Load(object sender, EventArgs e)
        {
            if (this.OnlySearch)
            {
                this.bProductView.Visible = true;
                this.bProductAdd.Visible = false;
                this.bProductModify.Visible = false;
                this.bProductDelete.Visible = false;
            }
            else
            {
                this.bProductView.Visible = true;
                this.bProductAdd.Visible = true;
                this.bProductModify.Visible = true;
                this.bProductDelete.Visible = true;
            }
        }

        private void tbProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar == '\r')
            {
                this.refreshSearchProductsByCode();
                this.tbProductCode.Clear();
            }
        }
    }
}
