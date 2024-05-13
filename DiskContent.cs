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
            diskContentView.Columns.Add("Трек", 150);
            diskContentView.Columns.Add("Автор", 150);
            diskContentView.Columns.Add("Опис треку", 150);


        }

        public void RefreshDisk(string id)
        {
            diskContentView.Items.Clear();

            foreach (Track track in DiskStorage.Instance.Search(id))
            {
                string[] row = { track.Name, track.Author, track.Description };
                diskContentView.Items.Add(new ListViewItem(row)).Tag = track.id;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackSelection_Click(object sender, EventArgs e)
        {
            AddTracksToDisk addTracksToDisk = new AddTracksToDisk(currDiskID);
            addTracksToDisk.ShowDialog();

            Disk updatedDisk = DiskStorage.Instance.Search(currDiskID.ToString());
            MessageBox.Show(updatedDisk.ToString());
            RefreshDisk(currDiskID.ToString());
        }
    }
}
