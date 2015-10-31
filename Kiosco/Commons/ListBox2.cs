using System;
using System.Windows.Forms;

namespace Kiosco.Commons
{
    public class ListBox2 : ListBox
    {
        public override int SelectedIndex
        {
            get
            {
                return base.SelectedIndex;
            }
            set
            {
                base.SelectedIndex = value;
                if (value == -1)
                {
                    this.OnSelectedIndexChanged(new EventArgs());
                }
            }
        }
    }
}
