using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace OOP_coursework
{
    public partial class DisksList : Form
    {
        public DiskStorage diskStorage = DiskStorage.Instance;
        public DisksList()
        {
            InitializeComponent();
            AcceptButton = diskCreate;
            
            Disk temp = new Disk("Name", new Track("placeholder", "placeholder", "author", false));
            diskStorage.AddDisk(temp);

            diskList.Columns.Add("Назва диску", 150);
            diskList.Columns.Add("Треки диску", 150);
            foreach (Disk disc in diskStorage.disks) 
            {
                string[] row = { disc.DiskName, "placeholder" };
                diskList.Items.Add(new ListViewItem(row)).Tag = disc.DiskId;
            } 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void diskCreate_Click(object sender, EventArgs e)
        {
            Disk newdisk = new Disk(diskNameAdd.Text, null);
            diskNameAdd.Text = "";
            diskStorage.AddDisk(newdisk);

            RefreshDiskStorage();
        }

        public void RefreshDiskStorage()
        {
            diskList.Items.Clear();

            foreach (Disk disc in diskStorage.disks)
            {
                string[] row = { disc.DiskName, "placeholder" };
                diskList.Items.Add(new ListViewItem(row)).Tag = disc.DiskId;
            }
        }

        private void diskList_ItemActivate(object sender, EventArgs e)
        {
            // Получаем выбранный элемент списка
            string item = diskList.SelectedItems[0].Tag.ToString();
            Disk currentDisk = diskStorage.Search(item);
            DiskContent diskContent = new DiskContent(currentDisk.DiskId);
            diskContent.ShowDialog();

            ;
        }


    }
}
