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
    public partial class AddTrackForm : Form
    {
        public AddTrackForm()
        {
            InitializeComponent();
        }

        private void AddTrackForm_Load(object sender, EventArgs e)
        {

        }

        private void AddTrackPopButt_Click(object sender, EventArgs e)
        {

            if (NameBox.Text == "" || DescriptionBox.Text == "" || AuthorBox.Text == "") 
            {
                MessageBox.Show("Ви не заповнили одне або декілька полей!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            MusicLibrary library = MusicLibrary.Instance;
            Track track = new Track(NameBox.Text, DescriptionBox.Text, AuthorBox.Text, false);
            library.AddTrack(track);
            
            this.Close();
            
        }
    }
}
