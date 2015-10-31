namespace Kiosco
{
    partial class Form_inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inicio));
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpProviders = new System.Windows.Forms.TabPage();
            this.psProvidersTab = new Kiosco.ProvidersTab.ProvidersSelect();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.psProductsTab = new Kiosco.ProductsTab.ProductsSelect();
            this.tpPurchases = new System.Windows.Forms.TabPage();
            this.bPurchaseItemAdd = new System.Windows.Forms.Button();
            this.purchaseCart = new Kiosco.PurchasesTab.PurchaseCart();
            this.prodsPurchaseTab = new Kiosco.ProductsTab.ProductsSelect();
            this.psPurchasesTab = new Kiosco.ProvidersTab.ProvidersSelect();
            this.tpSales = new System.Windows.Forms.TabPage();
            this.bSellItemAdd = new System.Windows.Forms.Button();
            this.prodsSellTab = new Kiosco.ProductsTab.ProductsSelect();
            this.saleCart = new Kiosco.SalesTab.SaleCart();
            this.tcMenu.SuspendLayout();
            this.tpProviders.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.tpPurchases.SuspendLayout();
            this.tpSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMenu.Controls.Add(this.tpProviders);
            this.tcMenu.Controls.Add(this.tpProducts);
            this.tcMenu.Controls.Add(this.tpPurchases);
            this.tcMenu.Controls.Add(this.tpSales);
            this.tcMenu.Location = new System.Drawing.Point(12, 12);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(919, 338);
            this.tcMenu.TabIndex = 0;
            // 
            // tpProviders
            // 
            this.tpProviders.Controls.Add(this.psProvidersTab);
            this.tpProviders.Location = new System.Drawing.Point(4, 22);
            this.tpProviders.Name = "tpProviders";
            this.tpProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tpProviders.Size = new System.Drawing.Size(911, 312);
            this.tpProviders.TabIndex = 0;
            this.tpProviders.Text = "Proveedores";
            this.tpProviders.UseVisualStyleBackColor = true;
            // 
            // psProvidersTab
            // 
            this.psProvidersTab.Location = new System.Drawing.Point(6, 6);
            this.psProvidersTab.Name = "psProvidersTab";
            this.psProvidersTab.OnlySearch = false;
            this.psProvidersTab.Size = new System.Drawing.Size(200, 220);
            this.psProvidersTab.TabIndex = 0;
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.psProductsTab);
            this.tpProducts.Location = new System.Drawing.Point(4, 22);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducts.Size = new System.Drawing.Size(911, 312);
            this.tpProducts.TabIndex = 1;
            this.tpProducts.Text = "Productos";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // psProductsTab
            // 
            this.psProductsTab.Location = new System.Drawing.Point(6, 6);
            this.psProductsTab.Name = "psProductsTab";
            this.psProductsTab.OnlySearch = false;
            this.psProductsTab.Size = new System.Drawing.Size(200, 220);
            this.psProductsTab.TabIndex = 0;
            // 
            // tpPurchases
            // 
            this.tpPurchases.Controls.Add(this.bPurchaseItemAdd);
            this.tpPurchases.Controls.Add(this.purchaseCart);
            this.tpPurchases.Controls.Add(this.prodsPurchaseTab);
            this.tpPurchases.Controls.Add(this.psPurchasesTab);
            this.tpPurchases.Location = new System.Drawing.Point(4, 22);
            this.tpPurchases.Name = "tpPurchases";
            this.tpPurchases.Size = new System.Drawing.Size(911, 312);
            this.tpPurchases.TabIndex = 2;
            this.tpPurchases.Text = "Compras";
            this.tpPurchases.UseVisualStyleBackColor = true;
            // 
            // bPurchaseItemAdd
            // 
            this.bPurchaseItemAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bPurchaseItemAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPurchaseItemAdd.BackgroundImage")));
            this.bPurchaseItemAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPurchaseItemAdd.Location = new System.Drawing.Point(415, 134);
            this.bPurchaseItemAdd.Name = "bPurchaseItemAdd";
            this.bPurchaseItemAdd.Size = new System.Drawing.Size(35, 35);
            this.bPurchaseItemAdd.TabIndex = 3;
            this.bPurchaseItemAdd.UseVisualStyleBackColor = true;
            this.bPurchaseItemAdd.Click += new System.EventHandler(this.bPurchaseItemAdd_Click);
            // 
            // purchaseCart
            // 
            this.purchaseCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseCart.Location = new System.Drawing.Point(456, 3);
            this.purchaseCart.MinimumSize = new System.Drawing.Size(423, 286);
            this.purchaseCart.Name = "purchaseCart";
            this.purchaseCart.Size = new System.Drawing.Size(452, 306);
            this.purchaseCart.TabIndex = 2;
            // 
            // prodsPurchaseTab
            // 
            this.prodsPurchaseTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prodsPurchaseTab.Location = new System.Drawing.Point(209, 3);
            this.prodsPurchaseTab.Name = "prodsPurchaseTab";
            this.prodsPurchaseTab.OnlySearch = true;
            this.prodsPurchaseTab.Size = new System.Drawing.Size(200, 306);
            this.prodsPurchaseTab.TabIndex = 1;
            // 
            // psPurchasesTab
            // 
            this.psPurchasesTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.psPurchasesTab.Location = new System.Drawing.Point(3, 3);
            this.psPurchasesTab.Name = "psPurchasesTab";
            this.psPurchasesTab.OnlySearch = true;
            this.psPurchasesTab.Size = new System.Drawing.Size(200, 306);
            this.psPurchasesTab.TabIndex = 0;
            // 
            // tpSales
            // 
            this.tpSales.Controls.Add(this.bSellItemAdd);
            this.tpSales.Controls.Add(this.prodsSellTab);
            this.tpSales.Controls.Add(this.saleCart);
            this.tpSales.Location = new System.Drawing.Point(4, 22);
            this.tpSales.Name = "tpSales";
            this.tpSales.Size = new System.Drawing.Size(911, 312);
            this.tpSales.TabIndex = 3;
            this.tpSales.Text = "Ventas";
            this.tpSales.UseVisualStyleBackColor = true;
            // 
            // bSellItemAdd
            // 
            this.bSellItemAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bSellItemAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSellItemAdd.BackgroundImage")));
            this.bSellItemAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSellItemAdd.Enabled = false;
            this.bSellItemAdd.Location = new System.Drawing.Point(209, 134);
            this.bSellItemAdd.Name = "bSellItemAdd";
            this.bSellItemAdd.Size = new System.Drawing.Size(35, 35);
            this.bSellItemAdd.TabIndex = 5;
            this.bSellItemAdd.UseVisualStyleBackColor = true;
            this.bSellItemAdd.Click += new System.EventHandler(this.bSellItemAdd_Click);
            // 
            // prodsSellTab
            // 
            this.prodsSellTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prodsSellTab.Location = new System.Drawing.Point(3, 3);
            this.prodsSellTab.Name = "prodsSellTab";
            this.prodsSellTab.OnlySearch = true;
            this.prodsSellTab.Size = new System.Drawing.Size(200, 306);
            this.prodsSellTab.TabIndex = 4;
            // 
            // saleCart
            // 
            this.saleCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saleCart.Location = new System.Drawing.Point(250, 3);
            this.saleCart.Name = "saleCart";
            this.saleCart.Size = new System.Drawing.Size(658, 306);
            this.saleCart.TabIndex = 0;
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 362);
            this.Controls.Add(this.tcMenu);
            this.KeyPreview = true;
            this.Name = "Form_inicio";
            this.Text = "Form1";
            this.tcMenu.ResumeLayout(false);
            this.tpProviders.ResumeLayout(false);
            this.tpProducts.ResumeLayout(false);
            this.tpPurchases.ResumeLayout(false);
            this.tpSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpProviders;
        private System.Windows.Forms.TabPage tpProducts;
        private ProductsTab.ProductsSelect psProductsTab;
        private System.Windows.Forms.TabPage tpPurchases;
        private System.Windows.Forms.TabPage tpSales;
        private ProvidersTab.ProvidersSelect psProvidersTab;
        private ProvidersTab.ProvidersSelect psPurchasesTab;
        private ProductsTab.ProductsSelect prodsPurchaseTab;
        private PurchasesTab.PurchaseCart purchaseCart;
        private System.Windows.Forms.Button bPurchaseItemAdd;
        private SalesTab.SaleCart saleCart;
        private System.Windows.Forms.Button bSellItemAdd;
        private ProductsTab.ProductsSelect prodsSellTab;
    }
}

