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

namespace OOP_coursework
{
    public partial class Form1 : Form
    {
        public MusicLibrary library = MusicLibrary.Instance;
        public Form1()
        {

            InitializeComponent();

            // Инициализация объекта MusicLibrary
            
            library.AddTrack(new Track("X.O.", "1", "Pencil", false));
            library.AddTrack(new Track("Penis2", "2", "Pencil", false));
            library.AddTrack(new Track("Penis3", "3", "Pencil", false));
            library.AddTrack(new Track("Penis4", "4", "Pencil", false));
            library.AddTrack(new Track("Penis5", "5", "Pencil", false));
            listViewSongs.View = View.Details;
            listViewSongs.Columns.Add("Назва", 190);
            listViewSongs.Columns.Add("Автор", 190);
            listViewSongs.Columns.Add("Опис", 380);
            listViewSongs.Items.Add(new ListViewItem(new string[] { "Название трека 1", "Автор трека 1", "Описание трека 1" }));
            listViewSongs.Items.Add(new ListViewItem(new string[] { "Название трека 2", "Автор трека 2", "Описание трека 2" }));
            listViewSongs.Items.Add(new ListViewItem(new string[] { "Название трека 3", "Автор трека 3", "Описание трека 3" }));


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

        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            AddTrackForm addTrackForm = new AddTrackForm();
            addTrackForm.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshSongList(library);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string text = Search_box.Text;
            List<Track> result = library.SearchTracks(text);
            ShowSearchResult(result);
        }

        private void DeleteTrack_Click(object sender, EventArgs e)
        {
            int id = (int)listViewSongs.SelectedItems[0].Tag;
            library.RemoveTrack(id);
            RefreshSongList(library);
        }
    }
}
