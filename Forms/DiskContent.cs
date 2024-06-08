using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_coursework
{
    public partial class DiskContent : Form
    {
        private int currDiskID;
        public DiskContent(int id)
        {
            currDiskID = id;
            InitializeComponent();
            string diskName = DiskStorage.Instance.Search(id.ToString()).DiskName;
            label_disk.Text = $"Контент диску {diskName}.";
            Text = diskName;
            diskContentView.View = View.Details;
            diskContentView.Columns.Add("Назва", 190);
            diskContentView.Columns.Add("Автор", 190);
            diskContentView.Columns.Add("Опис", 380);

            RefreshDisk(currDiskID.ToString());

        }

        private void RefreshDisk(string id)
        {
            diskContentView.Items.Clear();
            MusicLibrary library = MusicLibrary.Instance;
            foreach (int id_ in DiskStorage.Instance.Search(id).Content)
            {
                Track track = library.GetTrackById(id_);
                string[] row = { track.Name, track.Author, track.Description };
                diskContentView.Items.Add(new ListViewItem(row)).Tag = track.Id;
            }

        }

        private void trackSelection_Click(object sender, EventArgs e)
        {
            AddTracksToDisk addTracksToDisk = new AddTracksToDisk(currDiskID);
            addTracksToDisk.ShowDialog();

            Disk updatedDisk = DiskStorage.Instance.Search(currDiskID.ToString());
            
            RefreshDisk(currDiskID.ToString());
        }

        private void TrackDelete_Click(object sender, EventArgs e)
        {
            if (diskContentView.SelectedItems.Count == 0) { MessageBox.Show("Ви не обрали жодного треку до видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете це зробити? Цю дію неможливо скасувати!",
                                                  "Підтвердження дії",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            DiskStorage diskStorage = DiskStorage.Instance;
            Disk disk = diskStorage.Search(currDiskID.ToString());
            
            foreach (ListViewItem item in diskContentView.SelectedItems)
            {
                int id = (int)item.Tag;
                disk.RemoveFromDisk(id);

            }
            RefreshDisk(currDiskID.ToString());
            
        }
    }
}
