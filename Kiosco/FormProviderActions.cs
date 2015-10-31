using Data;
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
    public partial class FormProviderActions : Form
    {
        private DbActionsEnum operation;
        private ProviderDB originalProvider = null;
        private ProviderDB resultProvider = null;
        private BindingList<ProviderPhoneDB> phones = new BindingList<ProviderPhoneDB>();
        private List<ProviderPhoneDB> deletedPhones = new List<ProviderPhoneDB>();

        public FormProviderActions()
        {
            InitializeComponent();
        }

        private void updatePhones()
        {
            this.lbPhones.DataSource = this.phones;
            this.lbPhones.SelectedIndex = -1;
        }

        private void setBehaviorFromOperation(DbActionsEnum operation)
        {
            if (operation == DbActionsEnum.Show)
            {
                this.tbProviderId.Text = this.originalProvider.Id.ToString();
                this.tbProviderName.Text = this.originalProvider.Name;
                this.tbProviderAddress.Text = this.originalProvider.Address;

                this.bPhoneShow.Enabled = false;
                this.bPhoneAdd.Enabled = false;
                this.bPhoneEdit.Enabled = false;
                this.bPhoneDelete.Enabled = false;

                this.tbProviderId.ReadOnly = true;
                this.tbProviderName.ReadOnly = true;
                this.tbProviderAddress.ReadOnly = true;
                this.Text = String.Format("Datos del proveedor {0}", this.originalProvider.Name);
            }
            else if (operation == DbActionsEnum.Create)
            {
                this.tbProviderId.Enabled = false;

                this.bPhoneShow.Enabled = false;
                this.bPhoneAdd.Enabled = true;
                this.bPhoneEdit.Enabled = false;
                this.bPhoneDelete.Enabled = false;

                this.Text = "Nuevo proveedor";
            }
            else if (operation == DbActionsEnum.Update)
            {
                this.tbProviderId.Text = this.originalProvider.Id.ToString();
                this.tbProviderName.Text = this.originalProvider.Name;
                this.tbProviderAddress.Text = this.originalProvider.Address;

                this.bPhoneShow.Enabled = false;
                this.bPhoneAdd.Enabled = true;
                this.bPhoneEdit.Enabled = false;
                this.bPhoneDelete.Enabled = false;

                this.tbProviderId.ReadOnly = true;
                this.Text = String.Format("Modificando proveedor {0}", this.originalProvider.Name);
            }
        }

        public DialogResult ShowDialog(ProviderDB provider, DbActionsEnum operation)
        {
            this.operation = operation;
            if (operation != DbActionsEnum.Create)
            {
                this.originalProvider = provider;
                this.phones = new BindingList<ProviderPhoneDB>(DbValidation.Instance.searchProviderPhonesByProviderId((int)provider.Id));
            }
            else
            {
                this.originalProvider = null;
                this.phones = new BindingList<ProviderPhoneDB>();
            }
            this.updatePhones();
            this.setBehaviorFromOperation(operation);

            return this.ShowDialog();
        }

        private bool validData()
        {
            return true;
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (this.validData())
            {
                if (this.operation == DbActionsEnum.Create)
                {
                    this.resultProvider = new ProviderDB(this.tbProviderName.Text, this.tbProviderAddress.Text);
                }
                else if (this.operation == DbActionsEnum.Update)
                {
                    this.resultProvider = new ProviderDB((int)this.originalProvider.Id, this.tbProviderName.Text, this.tbProviderAddress.Text);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void bPhoneShow_Click(object sender, EventArgs e)
        {
            FormProviderPhoneActions form = new FormProviderPhoneActions();
            DialogResult dr = form.ShowDialog(this.lbPhones.SelectedItem as ProviderPhoneDB, DbActionsEnum.Show);
        }

        private void bPhoneAdd_Click(object sender, EventArgs e)
        {
            FormProviderPhoneActions form = new FormProviderPhoneActions();
            DialogResult dr = form.ShowDialog(null, DbActionsEnum.Create);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.phones.Add(form.ResultPhone);
                this.updatePhones();
            }
        }
        private void bPhoneEdit_Click(object sender, EventArgs e)
        {
            FormProviderPhoneActions form = new FormProviderPhoneActions();
            DialogResult dr = form.ShowDialog(this.lbPhones.SelectedItem as ProviderPhoneDB, DbActionsEnum.Update);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.phones[this.lbPhones.SelectedIndex] = form.ResultPhone;
                this.updatePhones();
            }
        }

        private void bPhoneDelete_Click(object sender, EventArgs e)
        {
            ProviderPhoneDB phone = this.phones[lbPhones.SelectedIndex];
            if (!phone.IsNew())
            {
                this.deletedPhones.Add(phone);
            }
            this.phones.RemoveAt(lbPhones.SelectedIndex);
        }
        public ProviderDB ResultProvider
        {
            get { return resultProvider; }
        }
        public List<ProviderPhoneDB> Phones
        {
            get { return phones.ToList<ProviderPhoneDB>(); }
        }
        public List<ProviderPhoneDB> DeletedPhones
        {
            get { return deletedPhones; }
        }

        private void lbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.operation == DbActionsEnum.Show)
            {
                this.bPhoneShow.Enabled = true;
                this.bPhoneAdd.Enabled = false;
                this.bPhoneEdit.Enabled = false;
                this.bPhoneDelete.Enabled = false;
            }
            else if (this.lbPhones.SelectedIndex != -1)
            {
                this.bPhoneShow.Enabled = true;
                this.bPhoneAdd.Enabled = true;
                this.bPhoneEdit.Enabled = true;
                this.bPhoneDelete.Enabled = true;
            }
            else
            {
                this.bPhoneShow.Enabled = false;
                this.bPhoneAdd.Enabled = true;
                this.bPhoneEdit.Enabled = false;
                this.bPhoneDelete.Enabled = false;
            }
        }
    }
}
