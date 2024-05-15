using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_coursework
{
    public partial class AdvSearchForm : Form
    {
        public AdvSearchForm()
        {
            InitializeComponent();

            toolTip_disk_cb.SetToolTip(checkBox_disk, "Пошук дисків, трек/треки яких відповідають критерію пошуку.");
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
