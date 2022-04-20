using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Arşiv_Fatura
{
    class Clear
    {
        public static void GroupBox(GroupBox groupBox)
        {
            foreach (Control cntrl in groupBox.Controls)
            {
                if (cntrl is DateTimePicker)
                {
                    DateTimePicker questionCntrl = cntrl as DateTimePicker;
                    questionCntrl.MaxDate = DateTime.Now.AddSeconds(10);
                    questionCntrl.Value = DateTime.Now;
                }

                if (cntrl is Label)
                {
                }

                if (cntrl is TextBox)
                {
                    TextBox questionCntrl = cntrl as TextBox;
                    questionCntrl.Clear();
                }

                if (cntrl is DataGridView)
                {
                    DataGridView questionCntrl = cntrl as DataGridView;
                    questionCntrl.Rows.Clear();
                }
                
                if (cntrl is ComboBox)
                {
                    ComboBox questionCntrl = cntrl as ComboBox;
                    questionCntrl.SelectedIndex = -1;
                }
            }
        }

    }
}
