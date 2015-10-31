using Data;
using Data.Dtos;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace Kiosco.ProvidersTab
{
    public partial class ProvidersSelect : UserControl
    {
        public ListBox ListBox { get { return this.lbProviders; } }
        [Category("Appearance")]
        public bool OnlySearch { get; set; }

        public ProvidersSelect()
        {
            InitializeComponent();
        }

        public ProviderDB getSelectedProvider()
        {
            return this.lbProviders.SelectedItem as ProviderDB;
        }

        private void refreshSearchProviderByName()
        {
            List<ProviderDB> providers = DbValidation.Instance.searchProvidersByName(this.tbProviderName.Text);
            lbProviders.DataSource = providers;

            if (lbProviders.SelectedIndex == -1)
            {
                this.bProviderView.Enabled = false;
                this.bProviderModify.Enabled = false;
                this.bProviderDelete.Enabled = false;
            }
            else
            {
                this.bProviderView.Enabled = true;
                this.bProviderModify.Enabled = true;
                this.bProviderDelete.Enabled = true;
            }
        }

        private void tbProviderName_TextChanged(object sender, System.EventArgs e)
        {
            this.refreshSearchProviderByName();
        }

        private void bProviderView_Click(object sender, System.EventArgs e)
        {
            FormProviderActions formProvider = new FormProviderActions();
            formProvider.ShowDialog(lbProviders.SelectedItem as ProviderDB, DbActionsEnum.Show);
        }

        private void bProviderAdd_Click(object sender, System.EventArgs e)
        {
            FormProviderActions formProvider = new FormProviderActions();
            if (formProvider.ShowDialog(null, DbActionsEnum.Create) == DialogResult.OK)
            {
                DbValidation.Instance.saveProvider(formProvider.ResultProvider);
                foreach (ProviderPhoneDB phone in formProvider.Phones)
                {
                    phone.ProviderId = formProvider.ResultProvider.Id;
                    DbValidation.Instance.saveProviderPhone(phone);
                }
                this.refreshSearchProviderByName();
            }
        }
        private void bProviderModify_Click(object sender, System.EventArgs e)
        {
            FormProviderActions formProvider = new FormProviderActions();
            if (formProvider.ShowDialog(lbProviders.SelectedItem as ProviderDB, DbActionsEnum.Update) == DialogResult.OK)
            {
                DbValidation.Instance.saveProvider(formProvider.ResultProvider);
                foreach (ProviderPhoneDB phone in formProvider.Phones)
                {
                    phone.ProviderId = formProvider.ResultProvider.Id;
                    DbValidation.Instance.saveProviderPhone(phone);
                }
                foreach (ProviderPhoneDB phone in formProvider.DeletedPhones)
                {
                    DbValidation.Instance.deleteProviderPhone(phone);
                }
                this.refreshSearchProviderByName();
            }
        }

        private void bProviderDelete_Click(object sender, System.EventArgs e)
        {
            DbValidation.Instance.deleteProvider(lbProviders.SelectedItem as ProviderDB);
            this.refreshSearchProviderByName();
        }

        private void ProvidersSelect_Load(object sender, System.EventArgs e)
        {
            if (this.OnlySearch)
            {
                this.bProviderView.Visible = true;
                this.bProviderAdd.Visible = false;
                this.bProviderModify.Visible = false;
                this.bProviderDelete.Visible = false;
            }
            else
            {
                this.bProviderView.Visible = true;
                this.bProviderAdd.Visible = true;
                this.bProviderModify.Visible = true;
                this.bProviderDelete.Visible = true;
            }
        }
    }
}
