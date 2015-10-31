namespace Kiosco.PurchasesTab
{
    partial class PurchaseCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPurchase = new System.Windows.Forms.GroupBox();
            this.bPurchaseItemDelete = new System.Windows.Forms.Button();
            this.bPurchaseItemEdit = new System.Windows.Forms.Button();
            this.dgvPurchaseItems = new System.Windows.Forms.DataGridView();
            this.PurchaseItemProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItemQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItemUnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItemProviderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBuy = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.lDiscount = new System.Windows.Forms.Label();
            this.lTax = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.gbPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPurchase
            // 
            this.gbPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPurchase.Controls.Add(this.nudTax);
            this.gbPurchase.Controls.Add(this.nudDiscount);
            this.gbPurchase.Controls.Add(this.lTax);
            this.gbPurchase.Controls.Add(this.lDiscount);
            this.gbPurchase.Controls.Add(this.bClear);
            this.gbPurchase.Controls.Add(this.bBuy);
            this.gbPurchase.Controls.Add(this.bPurchaseItemDelete);
            this.gbPurchase.Controls.Add(this.bPurchaseItemEdit);
            this.gbPurchase.Controls.Add(this.dgvPurchaseItems);
            this.gbPurchase.Location = new System.Drawing.Point(3, 3);
            this.gbPurchase.Name = "gbPurchase";
            this.gbPurchase.Size = new System.Drawing.Size(417, 280);
            this.gbPurchase.TabIndex = 3;
            this.gbPurchase.TabStop = false;
            this.gbPurchase.Text = "Compra";
            // 
            // bPurchaseItemDelete
            // 
            this.bPurchaseItemDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPurchaseItemDelete.Location = new System.Drawing.Point(379, 57);
            this.bPurchaseItemDelete.Name = "bPurchaseItemDelete";
            this.bPurchaseItemDelete.Size = new System.Drawing.Size(32, 32);
            this.bPurchaseItemDelete.TabIndex = 2;
            this.bPurchaseItemDelete.UseVisualStyleBackColor = true;
            this.bPurchaseItemDelete.Click += new System.EventHandler(this.bPurchaseItemDelete_Click);
            // 
            // bPurchaseItemEdit
            // 
            this.bPurchaseItemEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPurchaseItemEdit.Location = new System.Drawing.Point(379, 19);
            this.bPurchaseItemEdit.Name = "bPurchaseItemEdit";
            this.bPurchaseItemEdit.Size = new System.Drawing.Size(32, 32);
            this.bPurchaseItemEdit.TabIndex = 1;
            this.bPurchaseItemEdit.UseVisualStyleBackColor = true;
            this.bPurchaseItemEdit.Click += new System.EventHandler(this.bPurchaseItemEdit_Click);
            // 
            // dgvPurchaseItems
            // 
            this.dgvPurchaseItems.AllowUserToAddRows = false;
            this.dgvPurchaseItems.AllowUserToDeleteRows = false;
            this.dgvPurchaseItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchaseItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseItemProductColumn,
            this.PurchaseItemQuantityColumn,
            this.PurchaseItemUnitPriceColumn,
            this.PurchaseItemProviderColumn});
            this.dgvPurchaseItems.Location = new System.Drawing.Point(6, 19);
            this.dgvPurchaseItems.Name = "dgvPurchaseItems";
            this.dgvPurchaseItems.ReadOnly = true;
            this.dgvPurchaseItems.RowHeadersVisible = false;
            this.dgvPurchaseItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseItems.Size = new System.Drawing.Size(367, 226);
            this.dgvPurchaseItems.TabIndex = 0;
            this.dgvPurchaseItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPurchaseItems_CellFormatting);
            this.dgvPurchaseItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPurchaseItems_RowsAdded);
            this.dgvPurchaseItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPurchaseItems_RowsRemoved);
            this.dgvPurchaseItems.SelectionChanged += new System.EventHandler(this.dgvPurchaseItems_SelectionChanged);
            // 
            // PurchaseItemProductColumn
            // 
            this.PurchaseItemProductColumn.HeaderText = "Producto";
            this.PurchaseItemProductColumn.Name = "PurchaseItemProductColumn";
            this.PurchaseItemProductColumn.ReadOnly = true;
            // 
            // PurchaseItemQuantityColumn
            // 
            this.PurchaseItemQuantityColumn.FillWeight = 75F;
            this.PurchaseItemQuantityColumn.HeaderText = "Cantidad";
            this.PurchaseItemQuantityColumn.Name = "PurchaseItemQuantityColumn";
            this.PurchaseItemQuantityColumn.ReadOnly = true;
            // 
            // PurchaseItemUnitPriceColumn
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.PurchaseItemUnitPriceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PurchaseItemUnitPriceColumn.HeaderText = "Precio unitario";
            this.PurchaseItemUnitPriceColumn.Name = "PurchaseItemUnitPriceColumn";
            this.PurchaseItemUnitPriceColumn.ReadOnly = true;
            // 
            // PurchaseItemProviderColumn
            // 
            this.PurchaseItemProviderColumn.HeaderText = "Proveedor";
            this.PurchaseItemProviderColumn.Name = "PurchaseItemProviderColumn";
            this.PurchaseItemProviderColumn.ReadOnly = true;
            // 
            // bBuy
            // 
            this.bBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuy.Location = new System.Drawing.Point(255, 251);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(75, 23);
            this.bBuy.TabIndex = 5;
            this.bBuy.Text = "Comprar";
            this.bBuy.UseVisualStyleBackColor = true;
            this.bBuy.Click += new System.EventHandler(this.bBuy_Click);
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(336, 251);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 6;
            this.bClear.Text = "Limpiar lista";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // lDiscount
            // 
            this.lDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDiscount.AutoSize = true;
            this.lDiscount.Location = new System.Drawing.Point(6, 256);
            this.lDiscount.Name = "lDiscount";
            this.lDiscount.Size = new System.Drawing.Size(67, 13);
            this.lDiscount.TabIndex = 5;
            this.lDiscount.Text = "Descuentos:";
            // 
            // lTax
            // 
            this.lTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTax.AutoSize = true;
            this.lTax.Location = new System.Drawing.Point(132, 256);
            this.lTax.Name = "lTax";
            this.lTax.Size = new System.Drawing.Size(58, 13);
            this.lTax.TabIndex = 6;
            this.lTax.Text = "Impuestos:";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudDiscount.Location = new System.Drawing.Point(80, 254);
            this.nudDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(47, 20);
            this.nudDiscount.TabIndex = 3;
            // 
            // nudTax
            // 
            this.nudTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudTax.Location = new System.Drawing.Point(196, 254);
            this.nudTax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(46, 20);
            this.nudTax.TabIndex = 4;
            // 
            // PurchaseCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPurchase);
            this.MinimumSize = new System.Drawing.Size(423, 286);
            this.Name = "PurchaseCart";
            this.Size = new System.Drawing.Size(423, 286);
            this.gbPurchase.ResumeLayout(false);
            this.gbPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPurchase;
        private System.Windows.Forms.Button bPurchaseItemDelete;
        private System.Windows.Forms.Button bPurchaseItemEdit;
        private System.Windows.Forms.DataGridView dgvPurchaseItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseItemProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseItemQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseItemUnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseItemProviderColumn;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bBuy;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lTax;
        private System.Windows.Forms.Label lDiscount;
    }
}
