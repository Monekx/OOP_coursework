using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OOP_coursework
{
    public partial class MainWindow : Form
    {
        public MusicLibrary library = MusicLibrary.Instance;
        public DiskStorage diskStorage = DiskStorage.Instance;

        public MainWindow()
        {

            InitializeComponent();
            listViewSongs.View = View.Details;
            listViewSongs.Columns.Add("Назва", 190);
            listViewSongs.Columns.Add("Автор", 190);
            listViewSongs.Columns.Add("Опис", 380);
            diskList.Columns.Add("Назва диску", 150);
            diskList.Columns.Add("Треки диску", 150);

            // Заполнение ListBox данными из библиотеки
            RefreshSongList(library);
            RefreshDiskStorage();
        }

        private void RefreshSongList(MusicLibrary library)
        {
            // Очистка списка песен
            listViewSongs.Items.Clear();

            // Получение всех песен из библиотеки и добавление их в ListView
            foreach (Track track in library.tracks)
            {
                string[] row = { track.Name, track.Author, track.Description };
                listViewSongs.Items.Add(new ListViewItem(row)).Tag = track.Id;
            }
        }

        private void RefreshDiskStorage()
        {
            diskList.Items.Clear();
            
            foreach (Disk disc in diskStorage.Disks)
            {
                string tracks = "";
                int count = 0;
                foreach (Track track in disc.Content)
                {
                    if (tracks == "") { tracks += track.Name; } else { tracks += ", " + track.Name; }
                    if (count++ == 2) { tracks += "..."; break; }
                    
                }
                string[] row = { disc.DiskName, tracks };
                diskList.Items.Add(new ListViewItem(row)).Tag = disc.DiskId;
            }
        }

        private void ShowSearchResult(List<Track> result)
        {
            // Очистка списка песен
            listViewSongs.Items.Clear();

            // Получение всех песен из библиотеки и добавление их в ListBox
            foreach (Track track in result)
            {
                string[] row = { track.Name, track.Author, track.Description };
                listViewSongs.Items.Add(new ListViewItem(row)).Tag = track.Id;
            }
        }

        private void diskList_ItemActivate_1(object sender, EventArgs e)
        {
            // Получаем выбранный элемент списка
            string item = diskList.SelectedItems[0].Tag.ToString();
            Disk currentDisk = diskStorage.Search(item);
            DiskContent diskContent = new DiskContent(currentDisk.DiskId);
            diskContent.ShowDialog();

            RefreshDiskStorage();
        }

        private void diskCreate_Click_1(object sender, EventArgs e)
        {
            Disk newdisk = new Disk(diskNameAdd.Text);
            diskStorage.AddDisk(newdisk);

            RefreshDiskStorage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            // При закрытии приложения сохраняем данные в файл JSON
            string lib_json = library.SaveToJson();
            string disks_json = diskStorage.SaveToJson();

            File.WriteAllText("save.json", $"{{\"Library\":{lib_json},\"Disks\":{disks_json}}}");
        }

        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            AddTrackForm addTrackForm = new AddTrackForm();
            addTrackForm.ShowDialog();
            RefreshSongList(library);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshSongList(library);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string text = Search_box.Text;
            List<Track> result = library.SearchTracks(text);
            ShowSearchResult(result);
        }

        private void DeleteTrack_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems == null) { MessageBox.Show("Ви не заповнили одне або декілька полей!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } 
            int id = (int)listViewSongs.SelectedItems[0].Tag;
            library.RemoveTrack(id);
            RefreshSongList(library);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            string lib_json = library.SaveToJson();
            string disks_json = diskStorage.SaveToJson();

            File.WriteAllText("data.json", $"{{\"Library\":{lib_json},\"Address\":{disks_json}}}");

        }



        private void AdvSearch_Click(object sender, EventArgs e)
        {
            AdvSearchForm advanceSearchForm = new AdvSearchForm();
            advanceSearchForm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }


    }
}
