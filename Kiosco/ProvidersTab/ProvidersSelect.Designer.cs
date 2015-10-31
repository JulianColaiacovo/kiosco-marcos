namespace Kiosco.ProvidersTab
{
    partial class ProvidersSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvidersSelect));
            this.lProviderName = new System.Windows.Forms.Label();
            this.tbProviderName = new System.Windows.Forms.TextBox();
            this.lbProviders = new Kiosco.Commons.ListBox2();
            this.bProviderView = new System.Windows.Forms.Button();
            this.bProviderAdd = new System.Windows.Forms.Button();
            this.bProviderModify = new System.Windows.Forms.Button();
            this.bProviderDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lProviderName
            // 
            this.lProviderName.AutoSize = true;
            this.lProviderName.Location = new System.Drawing.Point(3, 6);
            this.lProviderName.Name = "lProviderName";
            this.lProviderName.Size = new System.Drawing.Size(59, 13);
            this.lProviderName.TabIndex = 0;
            this.lProviderName.Text = "Proveedor:";
            // 
            // tbProviderName
            // 
            this.tbProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProviderName.Location = new System.Drawing.Point(68, 3);
            this.tbProviderName.MaxLength = 50;
            this.tbProviderName.Name = "tbProviderName";
            this.tbProviderName.Size = new System.Drawing.Size(129, 20);
            this.tbProviderName.TabIndex = 1;
            this.tbProviderName.TextChanged += new System.EventHandler(this.tbProviderName_TextChanged);
            // 
            // lbProviders
            // 
            this.lbProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProviders.DisplayMember = "Name";
            this.lbProviders.FormattingEnabled = true;
            this.lbProviders.Location = new System.Drawing.Point(3, 29);
            this.lbProviders.Name = "lbProviders";
            this.lbProviders.Size = new System.Drawing.Size(156, 147);
            this.lbProviders.TabIndex = 2;
            // 
            // bProviderView
            // 
            this.bProviderView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProviderView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProviderView.BackgroundImage")));
            this.bProviderView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProviderView.Enabled = false;
            this.bProviderView.Location = new System.Drawing.Point(165, 29);
            this.bProviderView.Name = "bProviderView";
            this.bProviderView.Size = new System.Drawing.Size(32, 32);
            this.bProviderView.TabIndex = 3;
            this.bProviderView.UseVisualStyleBackColor = true;
            this.bProviderView.Click += new System.EventHandler(this.bProviderView_Click);
            // 
            // bProviderAdd
            // 
            this.bProviderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProviderAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProviderAdd.BackgroundImage")));
            this.bProviderAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProviderAdd.Location = new System.Drawing.Point(165, 67);
            this.bProviderAdd.Name = "bProviderAdd";
            this.bProviderAdd.Size = new System.Drawing.Size(32, 32);
            this.bProviderAdd.TabIndex = 4;
            this.bProviderAdd.UseVisualStyleBackColor = true;
            this.bProviderAdd.Click += new System.EventHandler(this.bProviderAdd_Click);
            // 
            // bProviderModify
            // 
            this.bProviderModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProviderModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProviderModify.BackgroundImage")));
            this.bProviderModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProviderModify.Enabled = false;
            this.bProviderModify.Location = new System.Drawing.Point(165, 105);
            this.bProviderModify.Name = "bProviderModify";
            this.bProviderModify.Size = new System.Drawing.Size(32, 32);
            this.bProviderModify.TabIndex = 5;
            this.bProviderModify.UseVisualStyleBackColor = true;
            this.bProviderModify.Click += new System.EventHandler(this.bProviderModify_Click);
            // 
            // bProviderDelete
            // 
            this.bProviderDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProviderDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProviderDelete.BackgroundImage")));
            this.bProviderDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProviderDelete.Enabled = false;
            this.bProviderDelete.Location = new System.Drawing.Point(165, 143);
            this.bProviderDelete.Name = "bProviderDelete";
            this.bProviderDelete.Size = new System.Drawing.Size(32, 32);
            this.bProviderDelete.TabIndex = 6;
            this.bProviderDelete.UseVisualStyleBackColor = true;
            this.bProviderDelete.Click += new System.EventHandler(this.bProviderDelete_Click);
            // 
            // ProvidersSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bProviderDelete);
            this.Controls.Add(this.bProviderModify);
            this.Controls.Add(this.bProviderAdd);
            this.Controls.Add(this.bProviderView);
            this.Controls.Add(this.lbProviders);
            this.Controls.Add(this.tbProviderName);
            this.Controls.Add(this.lProviderName);
            this.Name = "ProvidersSelect";
            this.Size = new System.Drawing.Size(200, 180);
            this.Load += new System.EventHandler(this.ProvidersSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProviderName;
        private System.Windows.Forms.TextBox tbProviderName;
        private Kiosco.Commons.ListBox2 lbProviders;
        private System.Windows.Forms.Button bProviderView;
        private System.Windows.Forms.Button bProviderAdd;
        private System.Windows.Forms.Button bProviderModify;
        private System.Windows.Forms.Button bProviderDelete;
    }
}
