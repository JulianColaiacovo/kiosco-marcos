using Data.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco
{
    public partial class FormProviderPhoneActions : Form
    {
        private ProviderPhoneDB originalPhone;
        private ProviderPhoneDB resultPhone;

        public FormProviderPhoneActions()
        {
            InitializeComponent();
        }
        private void setBehaviorFromOperation(DbActionsEnum operation)
        {
            if (operation == DbActionsEnum.Show)
            {
                this.Text = "Datos del teléfono";
                this.tbPhone.Text = this.originalPhone.Phone;
                this.tbDescription.Text = this.originalPhone.Description;
                this.tbPhone.ReadOnly = true;
                this.tbDescription.ReadOnly = true;
                this.bAccept.Visible = false;
                this.bCancel.Text = "Cerrar";
            }
            else if (operation == DbActionsEnum.Create)
            {
                this.Text = "Nuevo teléfono";
                this.bAccept.Text = "Crear";
            }
            else if (operation == DbActionsEnum.Update)
            {
                this.Text = "Modificar teléfono";
                this.tbPhone.Text = this.originalPhone.Phone;
                this.tbDescription.Text = this.originalPhone.Description;
                this.bAccept.Text = "Modificar";
            }
        }

        private bool validData()
        {
            return true;
        }

        public DialogResult ShowDialog(ProviderPhoneDB providerPhone, DbActionsEnum operation)
        {
            if (operation == DbActionsEnum.Create)
            {
                this.originalPhone = null;
            }
            else
            {
                this.originalPhone = providerPhone;
            }
            this.setBehaviorFromOperation(operation);
            return this.ShowDialog();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (this.validData())
            {
                if (this.originalPhone == null || this.originalPhone.Id == null)
                {
                    this.resultPhone = new ProviderPhoneDB(this.tbPhone.Text, this.tbDescription.Text);
                }
                else
                {
                    this.resultPhone = new ProviderPhoneDB((int)this.originalPhone.Id, this.originalPhone.ProviderId, this.tbPhone.Text, this.tbDescription.Text);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public ProviderPhoneDB ResultPhone
        {
            get { return resultPhone; }
        }
    }
}
