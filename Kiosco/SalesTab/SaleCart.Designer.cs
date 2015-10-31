namespace Kiosco.SalesTab
{
    partial class SaleCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbSale = new System.Windows.Forms.GroupBox();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.lTax = new System.Windows.Forms.Label();
            this.lDiscount = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.bSell = new System.Windows.Forms.Button();
            this.bSaleItemDelete = new System.Windows.Forms.Button();
            this.bSaleItemEdit = new System.Windows.Forms.Button();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.SaleItemProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleItemQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleItemSubTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSale
            // 
            this.gbSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSale.Controls.Add(this.nudTax);
            this.gbSale.Controls.Add(this.nudDiscount);
            this.gbSale.Controls.Add(this.lTax);
            this.gbSale.Controls.Add(this.lDiscount);
            this.gbSale.Controls.Add(this.bClear);
            this.gbSale.Controls.Add(this.bSell);
            this.gbSale.Controls.Add(this.bSaleItemDelete);
            this.gbSale.Controls.Add(this.bSaleItemEdit);
            this.gbSale.Controls.Add(this.dgvSaleItems);
            this.gbSale.Location = new System.Drawing.Point(3, 3);
            this.gbSale.Name = "gbSale";
            this.gbSale.Size = new System.Drawing.Size(501, 256);
            this.gbSale.TabIndex = 4;
            this.gbSale.TabStop = false;
            this.gbSale.Text = "Venta";
            // 
            // nudTax
            // 
            this.nudTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudTax.Location = new System.Drawing.Point(196, 230);
            this.nudTax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(46, 20);
            this.nudTax.TabIndex = 4;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudDiscount.Location = new System.Drawing.Point(80, 230);
            this.nudDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(47, 20);
            this.nudDiscount.TabIndex = 3;
            // 
            // lTax
            // 
            this.lTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTax.AutoSize = true;
            this.lTax.Location = new System.Drawing.Point(132, 232);
            this.lTax.Name = "lTax";
            this.lTax.Size = new System.Drawing.Size(58, 13);
            this.lTax.TabIndex = 6;
            this.lTax.Text = "Impuestos:";
            // 
            // lDiscount
            // 
            this.lDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDiscount.AutoSize = true;
            this.lDiscount.Location = new System.Drawing.Point(6, 232);
            this.lDiscount.Name = "lDiscount";
            this.lDiscount.Size = new System.Drawing.Size(67, 13);
            this.lDiscount.TabIndex = 5;
            this.lDiscount.Text = "Descuentos:";
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(420, 227);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 6;
            this.bClear.Text = "Limpiar lista";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSell
            // 
            this.bSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSell.Location = new System.Drawing.Point(339, 227);
            this.bSell.Name = "bSell";
            this.bSell.Size = new System.Drawing.Size(75, 23);
            this.bSell.TabIndex = 5;
            this.bSell.Text = "Vender";
            this.bSell.UseVisualStyleBackColor = true;
            this.bSell.Click += new System.EventHandler(this.bSell_Click);
            // 
            // bSaleItemDelete
            // 
            this.bSaleItemDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaleItemDelete.Location = new System.Drawing.Point(463, 57);
            this.bSaleItemDelete.Name = "bSaleItemDelete";
            this.bSaleItemDelete.Size = new System.Drawing.Size(32, 32);
            this.bSaleItemDelete.TabIndex = 2;
            this.bSaleItemDelete.UseVisualStyleBackColor = true;
            this.bSaleItemDelete.Click += new System.EventHandler(this.bSaleItemDelete_Click);
            // 
            // bSaleItemEdit
            // 
            this.bSaleItemEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaleItemEdit.Location = new System.Drawing.Point(463, 19);
            this.bSaleItemEdit.Name = "bSaleItemEdit";
            this.bSaleItemEdit.Size = new System.Drawing.Size(32, 32);
            this.bSaleItemEdit.TabIndex = 1;
            this.bSaleItemEdit.UseVisualStyleBackColor = true;
            this.bSaleItemEdit.Click += new System.EventHandler(this.bSaleItemEdit_Click);
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.AllowUserToAddRows = false;
            this.dgvSaleItems.AllowUserToDeleteRows = false;
            this.dgvSaleItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSaleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleItemProductColumn,
            this.SaleItemQuantityColumn,
            this.SaleItemSubTotalColumn});
            this.dgvSaleItems.Location = new System.Drawing.Point(6, 19);
            this.dgvSaleItems.Name = "dgvSaleItems";
            this.dgvSaleItems.ReadOnly = true;
            this.dgvSaleItems.RowHeadersVisible = false;
            this.dgvSaleItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleItems.Size = new System.Drawing.Size(451, 202);
            this.dgvSaleItems.TabIndex = 0;
            this.dgvSaleItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPurchaseItems_CellFormatting);
            this.dgvSaleItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPurchaseItems_RowsAdded);
            this.dgvSaleItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPurchaseItems_RowsRemoved);
            this.dgvSaleItems.SelectionChanged += new System.EventHandler(this.dgvPurchaseItems_SelectionChanged);
            // 
            // SaleItemProductColumn
            // 
            this.SaleItemProductColumn.HeaderText = "Producto";
            this.SaleItemProductColumn.Name = "SaleItemProductColumn";
            this.SaleItemProductColumn.ReadOnly = true;
            // 
            // SaleItemQuantityColumn
            // 
            this.SaleItemQuantityColumn.FillWeight = 75F;
            this.SaleItemQuantityColumn.HeaderText = "Cantidad";
            this.SaleItemQuantityColumn.Name = "SaleItemQuantityColumn";
            this.SaleItemQuantityColumn.ReadOnly = true;
            // 
            // SaleItemSubTotalColumn
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.SaleItemSubTotalColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.SaleItemSubTotalColumn.HeaderText = "Sub-total";
            this.SaleItemSubTotalColumn.Name = "SaleItemSubTotalColumn";
            this.SaleItemSubTotalColumn.ReadOnly = true;
            // 
            // SaleCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSale);
            this.Name = "SaleCart";
            this.Size = new System.Drawing.Size(507, 262);
            this.gbSale.ResumeLayout(false);
            this.gbSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSale;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lTax;
        private System.Windows.Forms.Label lDiscount;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSell;
        private System.Windows.Forms.Button bSaleItemDelete;
        private System.Windows.Forms.Button bSaleItemEdit;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleItemProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleItemQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleItemSubTotalColumn;

    }
}
