using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace OOP_coursework
{
    public partial class MainWindow : Form
    {
        public MusicLibrary library = MusicLibrary.Instance;
        public MainWindow()
        {

            InitializeComponent();
            listViewSongs.View = View.Details;
            listViewSongs.Columns.Add("Назва", 190);
            listViewSongs.Columns.Add("Автор", 190);
            listViewSongs.Columns.Add("Опис", 380);


            // Заполнение ListBox данными из библиотеки
            RefreshSongList(library);
        }

        private void RefreshSongList(MusicLibrary library)
        {
            // Очистка списка песен
            listViewSongs.Items.Clear();

            // Получение всех песен из библиотеки и добавление их в ListView
            foreach (Track track in library)
            {
                string[] row = { track.Name, track.Author, track.Description };
                listViewSongs.Items.Add(new ListViewItem(row)).Tag = track.id;
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
                listViewSongs.Items.Add(new ListViewItem(row)).Tag = track.id;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            // При закрытии приложения сохраняем данные в файл JSON
            library.SaveToJson("library.json");
        }

        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            AddTrackForm addTrackForm = new AddTrackForm();
            addTrackForm.ShowDialog();
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

        private void saveFile_Click(object sender, EventArgs e)
        {
            library.SaveToJson("library.json");
        }

        private void openDisks_Click(object sender, EventArgs e)
        {
            DisksList disksList = new DisksList();
            disksList.ShowDialog();
        }
    }
}
