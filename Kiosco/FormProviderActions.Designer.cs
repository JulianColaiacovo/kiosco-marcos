namespace Kiosco
{
    partial class FormProviderActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProviderActions));
            this.lProviderId = new System.Windows.Forms.Label();
            this.lProviderName = new System.Windows.Forms.Label();
            this.lProviderAddress = new System.Windows.Forms.Label();
            this.tbProviderId = new System.Windows.Forms.TextBox();
            this.tbProviderName = new System.Windows.Forms.TextBox();
            this.tbProviderAddress = new System.Windows.Forms.TextBox();
            this.lPhones = new System.Windows.Forms.Label();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lbPhones = new System.Windows.Forms.ListBox();
            this.bPhoneShow = new System.Windows.Forms.Button();
            this.bPhoneAdd = new System.Windows.Forms.Button();
            this.bPhoneEdit = new System.Windows.Forms.Button();
            this.bPhoneDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lProviderId
            // 
            this.lProviderId.AutoSize = true;
            this.lProviderId.Location = new System.Drawing.Point(12, 15);
            this.lProviderId.Name = "lProviderId";
            this.lProviderId.Size = new System.Drawing.Size(21, 13);
            this.lProviderId.TabIndex = 0;
            this.lProviderId.Text = "ID:";
            // 
            // lProviderName
            // 
            this.lProviderName.AutoSize = true;
            this.lProviderName.Location = new System.Drawing.Point(12, 41);
            this.lProviderName.Name = "lProviderName";
            this.lProviderName.Size = new System.Drawing.Size(47, 13);
            this.lProviderName.TabIndex = 2;
            this.lProviderName.Text = "Nombre:";
            // 
            // lProviderAddress
            // 
            this.lProviderAddress.AutoSize = true;
            this.lProviderAddress.Location = new System.Drawing.Point(12, 67);
            this.lProviderAddress.Name = "lProviderAddress";
            this.lProviderAddress.Size = new System.Drawing.Size(55, 13);
            this.lProviderAddress.TabIndex = 4;
            this.lProviderAddress.Text = "Dirección:";
            // 
            // tbProviderId
            // 
            this.tbProviderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProviderId.Location = new System.Drawing.Point(73, 12);
            this.tbProviderId.MaxLength = 15;
            this.tbProviderId.Name = "tbProviderId";
            this.tbProviderId.Size = new System.Drawing.Size(117, 20);
            this.tbProviderId.TabIndex = 5;
            this.tbProviderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProviderName
            // 
            this.tbProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProviderName.Location = new System.Drawing.Point(73, 38);
            this.tbProviderName.MaxLength = 50;
            this.tbProviderName.Name = "tbProviderName";
            this.tbProviderName.Size = new System.Drawing.Size(117, 20);
            this.tbProviderName.TabIndex = 6;
            // 
            // tbProviderAddress
            // 
            this.tbProviderAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProviderAddress.Location = new System.Drawing.Point(73, 64);
            this.tbProviderAddress.MaxLength = 100;
            this.tbProviderAddress.Name = "tbProviderAddress";
            this.tbProviderAddress.Size = new System.Drawing.Size(117, 20);
            this.tbProviderAddress.TabIndex = 7;
            // 
            // lPhones
            // 
            this.lPhones.AutoSize = true;
            this.lPhones.Location = new System.Drawing.Point(12, 93);
            this.lPhones.Name = "lPhones";
            this.lPhones.Size = new System.Drawing.Size(57, 13);
            this.lPhones.TabIndex = 8;
            this.lPhones.Text = "Teléfonos:";
            // 
            // bAccept
            // 
            this.bAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAccept.Location = new System.Drawing.Point(34, 261);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 23);
            this.bAccept.TabIndex = 9;
            this.bAccept.Text = "Aceptar";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(115, 261);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // lbPhones
            // 
            this.lbPhones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPhones.DisplayMember = "Phone";
            this.lbPhones.FormattingEnabled = true;
            this.lbPhones.Location = new System.Drawing.Point(12, 109);
            this.lbPhones.Name = "lbPhones";
            this.lbPhones.Size = new System.Drawing.Size(140, 147);
            this.lbPhones.TabIndex = 11;
            this.lbPhones.SelectedIndexChanged += new System.EventHandler(this.lbPhones_SelectedIndexChanged);
            // 
            // bPhoneShow
            // 
            this.bPhoneShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPhoneShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPhoneShow.BackgroundImage")));
            this.bPhoneShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPhoneShow.Enabled = false;
            this.bPhoneShow.Location = new System.Drawing.Point(158, 109);
            this.bPhoneShow.Name = "bPhoneShow";
            this.bPhoneShow.Size = new System.Drawing.Size(32, 32);
            this.bPhoneShow.TabIndex = 12;
            this.bPhoneShow.UseVisualStyleBackColor = true;
            this.bPhoneShow.Click += new System.EventHandler(this.bPhoneShow_Click);
            // 
            // bPhoneAdd
            // 
            this.bPhoneAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPhoneAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPhoneAdd.BackgroundImage")));
            this.bPhoneAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPhoneAdd.Enabled = false;
            this.bPhoneAdd.Location = new System.Drawing.Point(158, 147);
            this.bPhoneAdd.Name = "bPhoneAdd";
            this.bPhoneAdd.Size = new System.Drawing.Size(32, 32);
            this.bPhoneAdd.TabIndex = 13;
            this.bPhoneAdd.UseVisualStyleBackColor = true;
            this.bPhoneAdd.Click += new System.EventHandler(this.bPhoneAdd_Click);
            // 
            // bPhoneEdit
            // 
            this.bPhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPhoneEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPhoneEdit.BackgroundImage")));
            this.bPhoneEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPhoneEdit.Enabled = false;
            this.bPhoneEdit.Location = new System.Drawing.Point(158, 185);
            this.bPhoneEdit.Name = "bPhoneEdit";
            this.bPhoneEdit.Size = new System.Drawing.Size(32, 32);
            this.bPhoneEdit.TabIndex = 14;
            this.bPhoneEdit.UseVisualStyleBackColor = true;
            this.bPhoneEdit.Click += new System.EventHandler(this.bPhoneEdit_Click);
            // 
            // bPhoneDelete
            // 
            this.bPhoneDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPhoneDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPhoneDelete.BackgroundImage")));
            this.bPhoneDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPhoneDelete.Enabled = false;
            this.bPhoneDelete.Location = new System.Drawing.Point(158, 223);
            this.bPhoneDelete.Name = "bPhoneDelete";
            this.bPhoneDelete.Size = new System.Drawing.Size(32, 32);
            this.bPhoneDelete.TabIndex = 15;
            this.bPhoneDelete.UseVisualStyleBackColor = true;
            this.bPhoneDelete.Click += new System.EventHandler(this.bPhoneDelete_Click);
            // 
            // FormProviderActions
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(202, 296);
            this.Controls.Add(this.bPhoneDelete);
            this.Controls.Add(this.bPhoneEdit);
            this.Controls.Add(this.bPhoneAdd);
            this.Controls.Add(this.bPhoneShow);
            this.Controls.Add(this.lbPhones);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.lPhones);
            this.Controls.Add(this.tbProviderAddress);
            this.Controls.Add(this.tbProviderName);
            this.Controls.Add(this.tbProviderId);
            this.Controls.Add(this.lProviderAddress);
            this.Controls.Add(this.lProviderName);
            this.Controls.Add(this.lProviderId);
            this.Name = "FormProviderActions";
            this.Text = "FormProviderActions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProviderId;
        private System.Windows.Forms.Label lProviderName;
        private System.Windows.Forms.Label lProviderAddress;
        private System.Windows.Forms.TextBox tbProviderId;
        private System.Windows.Forms.TextBox tbProviderName;
        private System.Windows.Forms.TextBox tbProviderAddress;
        private System.Windows.Forms.Label lPhones;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ListBox lbPhones;
        private System.Windows.Forms.Button bPhoneShow;
        private System.Windows.Forms.Button bPhoneAdd;
        private System.Windows.Forms.Button bPhoneEdit;
        private System.Windows.Forms.Button bPhoneDelete;
    }
}