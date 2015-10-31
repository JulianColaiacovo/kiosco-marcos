namespace Kiosco
{
    partial class FormProductActions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.lProductName = new System.Windows.Forms.Label();
            this.lProductId = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.lProductCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductStockable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductName.Location = new System.Drawing.Point(73, 38);
            this.tbProductName.MaxLength = 50;
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(120, 20);
            this.tbProductName.TabIndex = 12;
            // 
            // tbProductId
            // 
            this.tbProductId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductId.Location = new System.Drawing.Point(73, 12);
            this.tbProductId.MaxLength = 15;
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(120, 20);
            this.tbProductId.TabIndex = 11;
            this.tbProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lProductName
            // 
            this.lProductName.AutoSize = true;
            this.lProductName.Location = new System.Drawing.Point(12, 41);
            this.lProductName.Name = "lProductName";
            this.lProductName.Size = new System.Drawing.Size(47, 13);
            this.lProductName.TabIndex = 9;
            this.lProductName.Text = "Nombre:";
            // 
            // lProductId
            // 
            this.lProductId.AutoSize = true;
            this.lProductId.Location = new System.Drawing.Point(12, 15);
            this.lProductId.Name = "lProductId";
            this.lProductId.Size = new System.Drawing.Size(21, 13);
            this.lProductId.TabIndex = 7;
            this.lProductId.Text = "ID:";
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(118, 110);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bAccept
            // 
            this.bAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAccept.Location = new System.Drawing.Point(37, 110);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 23);
            this.bAccept.TabIndex = 15;
            this.bAccept.Text = "Aceptar";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // tbProductCode
            // 
            this.tbProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductCode.Location = new System.Drawing.Point(73, 64);
            this.tbProductCode.MaxLength = 50;
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.Size = new System.Drawing.Size(120, 20);
            this.tbProductCode.TabIndex = 13;
            // 
            // lProductCode
            // 
            this.lProductCode.AutoSize = true;
            this.lProductCode.Location = new System.Drawing.Point(12, 67);
            this.lProductCode.Name = "lProductCode";
            this.lProductCode.Size = new System.Drawing.Size(43, 13);
            this.lProductCode.TabIndex = 8;
            this.lProductCode.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Stock:";
            // 
            // cbProductStockable
            // 
            this.cbProductStockable.AutoSize = true;
            this.cbProductStockable.Checked = true;
            this.cbProductStockable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbProductStockable.Location = new System.Drawing.Point(73, 90);
            this.cbProductStockable.Name = "cbProductStockable";
            this.cbProductStockable.Size = new System.Drawing.Size(15, 14);
            this.cbProductStockable.TabIndex = 17;
            this.cbProductStockable.UseVisualStyleBackColor = true;
            // 
            // FormProductActions
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(205, 145);
            this.Controls.Add(this.cbProductStockable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProductCode);
            this.Controls.Add(this.lProductCode);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.lProductName);
            this.Controls.Add(this.lProductId);
            this.Name = "FormProductActions";
            this.Text = "FormProductActions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.Label lProductName;
        private System.Windows.Forms.Label lProductId;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.Label lProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbProductStockable;
    }
}