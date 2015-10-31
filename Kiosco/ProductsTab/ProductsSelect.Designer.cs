namespace Kiosco.ProductsTab
{
    partial class ProductsSelect
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsSelect));
            this.bProductDelete = new System.Windows.Forms.Button();
            this.bProductModify = new System.Windows.Forms.Button();
            this.bProductAdd = new System.Windows.Forms.Button();
            this.bProductView = new System.Windows.Forms.Button();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lProductName = new System.Windows.Forms.Label();
            this.lProductCode = new System.Windows.Forms.Label();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.lbProducts = new Kiosco.Commons.ListBox2();
            this.SuspendLayout();
            // 
            // bProductDelete
            // 
            this.bProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProductDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProductDelete.BackgroundImage")));
            this.bProductDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProductDelete.Enabled = false;
            this.bProductDelete.Location = new System.Drawing.Point(165, 169);
            this.bProductDelete.Name = "bProductDelete";
            this.bProductDelete.Size = new System.Drawing.Size(32, 32);
            this.bProductDelete.TabIndex = 15;
            this.bProductDelete.UseVisualStyleBackColor = true;
            this.bProductDelete.Click += new System.EventHandler(this.bProductDelete_Click);
            // 
            // bProductModify
            // 
            this.bProductModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProductModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProductModify.BackgroundImage")));
            this.bProductModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProductModify.Enabled = false;
            this.bProductModify.Location = new System.Drawing.Point(165, 131);
            this.bProductModify.Name = "bProductModify";
            this.bProductModify.Size = new System.Drawing.Size(32, 32);
            this.bProductModify.TabIndex = 14;
            this.bProductModify.UseVisualStyleBackColor = true;
            this.bProductModify.Click += new System.EventHandler(this.bProductModify_Click);
            // 
            // bProductAdd
            // 
            this.bProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProductAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProductAdd.BackgroundImage")));
            this.bProductAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProductAdd.Location = new System.Drawing.Point(165, 93);
            this.bProductAdd.Name = "bProductAdd";
            this.bProductAdd.Size = new System.Drawing.Size(32, 32);
            this.bProductAdd.TabIndex = 13;
            this.bProductAdd.UseVisualStyleBackColor = true;
            this.bProductAdd.Click += new System.EventHandler(this.bProductAdd_Click);
            // 
            // bProductView
            // 
            this.bProductView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProductView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProductView.BackgroundImage")));
            this.bProductView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProductView.Enabled = false;
            this.bProductView.Location = new System.Drawing.Point(165, 55);
            this.bProductView.Name = "bProductView";
            this.bProductView.Size = new System.Drawing.Size(32, 32);
            this.bProductView.TabIndex = 12;
            this.bProductView.UseVisualStyleBackColor = true;
            this.bProductView.Click += new System.EventHandler(this.bProductView_Click);
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductName.Location = new System.Drawing.Point(62, 3);
            this.tbProductName.MaxLength = 50;
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(135, 20);
            this.tbProductName.TabIndex = 8;
            this.tbProductName.TextChanged += new System.EventHandler(this.tbProductName_TextChanged);
            // 
            // lProductName
            // 
            this.lProductName.AutoSize = true;
            this.lProductName.Location = new System.Drawing.Point(3, 6);
            this.lProductName.Name = "lProductName";
            this.lProductName.Size = new System.Drawing.Size(53, 13);
            this.lProductName.TabIndex = 7;
            this.lProductName.Text = "Producto:";
            // 
            // lProductCode
            // 
            this.lProductCode.AutoSize = true;
            this.lProductCode.Location = new System.Drawing.Point(3, 32);
            this.lProductCode.Name = "lProductCode";
            this.lProductCode.Size = new System.Drawing.Size(43, 13);
            this.lProductCode.TabIndex = 9;
            this.lProductCode.Text = "Código:";
            // 
            // tbProductCode
            // 
            this.tbProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductCode.Location = new System.Drawing.Point(62, 29);
            this.tbProductCode.MaxLength = 13;
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.Size = new System.Drawing.Size(135, 20);
            this.tbProductCode.TabIndex = 10;
            this.tbProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProductCode_KeyPress);
            // 
            // lbProducts
            // 
            this.lbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProducts.DisplayMember = "Name";
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(3, 55);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(156, 147);
            this.lbProducts.TabIndex = 11;
            // 
            // ProductsSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbProductCode);
            this.Controls.Add(this.lProductCode);
            this.Controls.Add(this.bProductDelete);
            this.Controls.Add(this.bProductModify);
            this.Controls.Add(this.bProductAdd);
            this.Controls.Add(this.bProductView);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lProductName);
            this.Name = "ProductsSelect";
            this.Size = new System.Drawing.Size(200, 207);
            this.Load += new System.EventHandler(this.ProductsSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bProductDelete;
        private System.Windows.Forms.Button bProductModify;
        private System.Windows.Forms.Button bProductAdd;
        private System.Windows.Forms.Button bProductView;
        private Kiosco.Commons.ListBox2 lbProducts;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lProductName;
        private System.Windows.Forms.Label lProductCode;
        private System.Windows.Forms.TextBox tbProductCode;
    }
}
