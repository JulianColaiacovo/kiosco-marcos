using Data.Dtos;
using System;
using System.Windows.Forms;

namespace Kiosco
{
    public partial class FormProductActions : Form
    {
        public FormProductActions()
        {
            InitializeComponent();
        }
        private ProductDB originalProduct;
        private ProductDB resultProduct;

        private void setBehaviorFromOperation(DbActionsEnum operation)
        {
            if (operation == DbActionsEnum.Show)
            {
                this.Text = "Datos del producto";
                this.tbProductId.Text = this.originalProduct.Id.ToString();
                this.tbProductCode.Text = this.originalProduct.Code.ToString();
                this.tbProductName.Text = this.originalProduct.Name;
                this.cbProductStockable.Checked = this.originalProduct.Stockable;
                this.tbProductId.ReadOnly = true;
                this.tbProductCode.ReadOnly = true;
                this.tbProductName.ReadOnly = true;
                this.cbProductStockable.Enabled = true;
                this.bAccept.Visible = false;
                this.bCancel.Text = "Cerrar";
            }
            else if (operation == DbActionsEnum.Create)
            {
                this.tbProductId.Enabled = false;
                this.Text = "Nuevo producto";
                this.bAccept.Text = "Crear";
            }
            else if (operation == DbActionsEnum.Update)
            {
                this.Text = "Modificar producto";
                this.tbProductId.ReadOnly = true;
                this.tbProductId.Text = this.originalProduct.Id.ToString();
                this.tbProductCode.Text = this.originalProduct.Code.ToString();
                this.tbProductName.Text = this.originalProduct.Name;
                this.cbProductStockable.Checked = this.originalProduct.Stockable;
                this.bAccept.Text = "Modificar";
            }
        }

        private bool validData()
        {
            return true;
        }

        public DialogResult ShowDialog(ProductDB product, DbActionsEnum operation)
        {
            if (operation == DbActionsEnum.Create)
            {
                this.originalProduct = null;
            }
            else
            {
                this.originalProduct = product;
            }
            this.setBehaviorFromOperation(operation);
            return this.ShowDialog();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (this.validData())
            {
                if (this.originalProduct == null || this.originalProduct.Id == null)
                {
                    this.resultProduct = new ProductDB(long.Parse(this.tbProductCode.Text), this.tbProductName.Text, this.cbProductStockable.Checked);
                }
                else
                {
                    this.resultProduct = new ProductDB((int)this.originalProduct.Id, long.Parse(this.tbProductCode.Text), this.tbProductName.Text, this.cbProductStockable.Checked);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public ProductDB ResultProduct
        {
            get { return resultProduct; }
        }
    }
}
