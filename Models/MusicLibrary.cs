using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Reflection;

namespace OOP_coursework
{
    public class MusicLibrary
    {
        // Приватное статическое поле для хранения единственного экземпляра MusicLibrary
        private static MusicLibrary instance;

        // Публичное статическое свойство для доступа к единственному экземпляру MusicLibrary
        public static MusicLibrary Instance
        {
            get
            {
                try
                {
                    if (instance != null)
                    {
                        return instance;
                    }
                    instance = LoadFromJson("save.json") ?? new MusicLibrary(); return instance;
                }
                catch { instance = new MusicLibrary(); }
                return instance;
            }
        }

        // Приватный конструктор, чтобы предотвратить создание экземпляров через new


        // Свойства и методы вашего класса MusicLibrary
        // ...

        public List<Track> tracks { get; set; }

        private MusicLibrary()
        {
            tracks = new List<Track>();
            
            
        }

        

        // Метод для добавления трека в конец списка
        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }

        // Метод для удаления трека из списка
        public void RemoveTrack(int id)
        {
            int index = tracks.FindIndex(x => x.Id == id);
            tracks.RemoveAt(index);
        }

        // Метод для копирования списка
        public List<Track> Copy()
        {
            return tracks;
        }

        public Track GetTrackById(int id)
        {
            return tracks.Find(x => x.Id == id);

        }

        // Метод для поиска трека по ключевым словам
        public List<Track> SearchTracks(string keyword)
        {
            List<Track> result = new List<Track>();
            foreach (Track current in tracks)
            {
                if (current != null && (current.Name.Contains(keyword) || current.Description.Contains(keyword) || current.Author.Contains(keyword)))
                {
                    result.Add(current);
                }
            }
            return result;
        }

        public List<Track> SearchTracksAuthor(string keyword)
        {
            List<Track> result = new List<Track>();
            foreach (Track current in tracks)
            {
                if (current != null && current.Author.Contains(keyword))
                {
                    result.Add(current);
                }
            }
            return result;
        }

        public List<Track> SearchTracksName(string keyword)
        {
            List<Track> result = new List<Track>();
            foreach (Track current in tracks)
            {
                if (current != null && current.Name.Contains(keyword))
                {
                    result.Add(current);
                }
            }
            return result;
        }

        private static MusicLibrary LoadFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                dynamic data = JsonConvert.DeserializeObject(json);
                MusicLibrary library = JsonConvert.DeserializeObject<MusicLibrary>(data.Library.ToString());
                return library;
            }
            return null;
        }

        public string SaveToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }

    // Внутренний класс, который реализует IEnumerator
    



    public class Track
    {

        private static int nextID = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public bool IsAlbum { get; set; }

        public Track(string name, string description, string author, bool isalbum)
        {
            this.Id = nextID++;
            this.Name = name;
            this.Author = author;
            this.Description = description;
            this.IsAlbum = isalbum;

        }
    }
}
