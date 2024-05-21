using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
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

            checkbox_Disk_help.SetToolTip(checkBox_disk, "Пошук дисків, треки яких відповідають критерію пошуку.");
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
            TrackList.Text = "Треки в базі";
        }

        private void RefreshSongList(List<Track> list)
        {
            // Очистка списка песен
            listViewSongs.Items.Clear();

            // Получение всех песен из библиотеки и добавление их в ListView
            foreach (Track track in list)
            {
                string[] row = { track.Name, track.Author, track.Description };
                listViewSongs.Items.Add(new ListViewItem(row)).Tag = track.Id;
            }
            TrackList.Text = "Результати пошуку:";
        }

        private void RefreshDiskStorage()
        {
            diskList.Items.Clear();
            
            foreach (Disk disc in diskStorage.Disks)
            {
                string tracks = "";
                int count = 0;
                

                foreach (int id in disc.Content)
                {
                    Track track = library.GetTrackById(id);
                    if (track != null)
                    {
                        if (tracks == "") { tracks += track.Name; } else { tracks += ", " + track.Name; }
                        if (count++ == 2) { tracks += "..."; break; }
                    }
                }
                string[] row = { disc.DiskName, tracks };
                diskList.Items.Add(new ListViewItem(row)).Tag = disc.DiskId;
            }
            DisksGroup.Text = "Диски";
        }

        private void RefreshDiskStorage(List<Disk> list)
        {
            diskList.Items.Clear();

            foreach (Disk disc in list)
            {
                string tracks = "";
                int count = 0;
                foreach (int id in disc.Content)
                {
                    Track track = library.GetTrackById(id);
                    if (tracks == "") { tracks += track.Name; } else { tracks += ", " + track.Name; }
                    if (count++ == 2) { tracks += "..."; break; }

                }
                string[] row = { disc.DiskName, tracks };
                diskList.Items.Add(new ListViewItem(row)).Tag = disc.DiskId;
            }
            DisksGroup.Text = "Результати пошуку";
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

            TrackList.Text = "Результати пошуку:";
        }

        private void DiskList_ItemActivate_1(object sender, EventArgs e)
        {
            // Получаем выбранный элемент списка
            string item = diskList.SelectedItems[0].Tag.ToString();
            Disk currentDisk = diskStorage.Search(item);
            DiskContent diskContent = new DiskContent(currentDisk.DiskId);
            diskContent.ShowDialog();

            RefreshDiskStorage();
        }

        private void DiskCreate_Click_1(object sender, EventArgs e)
        {
            if (diskNameAdd.Text == "") { return; }
            Disk newdisk = new Disk(diskNameAdd.Text);
            diskStorage.AddDisk(newdisk);
            diskNameAdd.Text = "";
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

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshSongList(library);
            RefreshDiskStorage();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string text = Search_box.Text;
            List<Track> result = library.SearchTracks(text);
            ShowSearchResult(result);
        }

        private void DeleteTrack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете це зробити? Цю дію неможливо скасувати!",
                                              "Підтвердження дії",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            if (listViewSongs.SelectedItems.Count == 0) { MessageBox.Show("Ви не заповнили одне або декілька полей!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            foreach (ListViewItem item in listViewSongs.SelectedItems)
            {
                int id = (int)item.Tag;
                library.RemoveTrack(id);

                foreach (Disk disk in diskStorage.Disks)
                {
                    if ( disk.Content.Contains(id) ) { 
                        disk.RemoveFromDisk(id);
                    }
                }
            }
            
            RefreshSongList(library);
            RefreshDiskStorage();
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

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void ChooseDisk_Click(object sender, EventArgs e)
        {
            string item = diskList.SelectedItems[0].Tag.ToString();
            Disk currentDisk = diskStorage.Search(item);
            DiskContent diskContent = new DiskContent(currentDisk.DiskId);
            diskContent.ShowDialog();

            RefreshDiskStorage();
        }

        private void advSearch_search_Click(object sender, EventArgs e)
        {
            
            string keyword = advSearch_textbox.Text;
            if (keyword == "") { return; }
            if (checkBox_disk.Checked)
            {
                List<Disk> result = new List<Disk> ();
                foreach (Disk disk in diskStorage.Disks)
                {
                    foreach (int id in disk.Content) 
                    {
                        Track track = library.GetTrackById(id);
                        if (track != null && (track.Name.Contains(keyword) || track.Description.Contains(keyword) || track.Author.Contains(keyword)))
                        {
                            result.Add(disk);
                            break;
                        }
                    }
                }
                RefreshDiskStorage(result);
            } else if (checkBox_author.Checked) {
                List<Track> result = library.SearchTracksAuthor(keyword);
                RefreshSongList(result);
            } else if (checkBox_name.Checked)
            {
                List<Track> result = library.SearchTracksName(keyword);
                RefreshSongList(result);
            } else
            { 
                List<Track> result = library.SearchTracks(keyword);
                ShowSearchResult(result);
            }
        }



        private void toolMenu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolMenu_Save_Click(object sender, EventArgs e)
        {
            string lib_json = library.SaveToJson();
            string disks_json = diskStorage.SaveToJson();

            File.WriteAllText("save.json", $"{{\"Library\":{lib_json},\"Disks\":{disks_json}}}");

        }

        private void deleteDisk_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете це зробити? Цю дію неможливо скасувати!",
                                              "Підтвердження дії",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            diskStorage.RemoveDisk((int)diskList.SelectedItems[0].Tag);
            RefreshDiskStorage();
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            string programInfo = "Назва програми: Довідник меломана\n" +
                             "Версия: 1.5b\n" +
                             "Автор: Соболєв Максим Андрійович\n" +
                             "Додаткова інформація: ПЗПІ-23-2, перший курс\n" +
                             "Опис: Курсова робота";

            MessageBox.Show(programInfo, "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void advSearch_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter) { advSearch_search_Click(sender, e); e.Handled = true; e.SuppressKeyPress = true; }
            
        }

        private void diskNameAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                DiskCreate_Click_1(sender, e);
            }
        }
    }
}
