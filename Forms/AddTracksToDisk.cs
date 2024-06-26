﻿using System;
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
    public partial class AddTracksToDisk : Form
    {
        private int recDiskID;
        public AddTracksToDisk(int ID)
        {
            this.recDiskID = ID;
            Text = "Додати трек до диску";
            InitializeComponent();
            addTrackToDisk_View.Columns.Add("Трек", 150);
            addTrackToDisk_View.Columns.Add("Автор", 150);
            addTrackToDisk_View.Columns.Add("Опис треку", 150);
            GetTracks(MusicLibrary.Instance);
        }

        private void AddTrackToForm_DECLINE_Click(object sender, EventArgs e)
        {

        }

        private void GetTracks(MusicLibrary library) 
        {

            foreach (Track track in library.tracks)
            {
                string[] row = { track.Name, track.Author, track.Description };
                addTrackToDisk_View.Items.Add(new ListViewItem(row)).Tag = track.Id;
            }

        }



        private void addTrackToDisk_OK_Click(object sender, EventArgs e)
        {
            DiskStorage diskStorage = DiskStorage.Instance;
            Disk recievedDisk = diskStorage.Search(recDiskID.ToString());
            
            foreach (ListViewItem selectedItem in addTrackToDisk_View.SelectedItems)
            {
                // Получаем идентификатор трека из свойства Tag элемента
                int trackId = (int)selectedItem.Tag;

                // Находим трек в библиотеке по идентификатору
                Track selectedTrack = MusicLibrary.Instance.GetTrackById(trackId);

                Disk disk = diskStorage.Search(recDiskID.ToString());

                if (disk.Content.Contains(trackId) != true) 
                {
                    diskStorage.UpdateDisk(recDiskID, selectedTrack);
                } else
                {
                    MessageBox.Show($"Трек {selectedTrack.Name} вже знаходиться у диску", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Добавляем трек в объект recDisk

                
            }
            // Закрываем форму после добавления треков
            Close();
        }
    }
}
