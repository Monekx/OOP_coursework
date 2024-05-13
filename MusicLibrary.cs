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
                // Если экземпляр еще не был создан, создаем его
                if (instance == null)
                {
                    instance = LoadFromJson("library.json") ?? new MusicLibrary();
                }
                return instance;
            }
        }

        // Приватный конструктор, чтобы предотвратить создание экземпляров через new
        private MusicLibrary() { }

        // Свойства и методы вашего класса MusicLibrary
        // ...

        public Track current;
        public MusicLibrary next;
        private int length;

        private MusicLibrary(Track current)
        {
            this.current = current;
            this.next = null;
            this.length = 1;
        }

        private MusicLibrary(Track current, MusicLibrary next)
        {
            this.current = current;
            this.next = next;
            this.length = 1 + next.length;
        }

        // Метод для добавления трека в конец списка
        public void AddTrack(Track track)
        {
            if (current == null)
            {
                current = track;
                length = 1;
            }
            else if (next == null)
            {
                next = new MusicLibrary(track);
                length++;
            }
            else
            {
                next.AddTrack(track);
                length++;
            }
        }

        // Метод для удаления трека из списка
        public void RemoveTrack(int id)
        {
            if (current.id == id)
            {
                current = next?.current;
                next = next?.next;
                if (current != null)
                    length--;
            }
            else
            {
                next?.RemoveTrack(id);
                if (next != null && next.current == null)
                    length--;
            }
        }

        // Метод для копирования списка
        public MusicLibrary Copy()
        {
            if (current == null)
                return new MusicLibrary();

            MusicLibrary copy = new MusicLibrary(current);
            if (next != null)
                copy.next = next.Copy();
            copy.length = length;
            return copy;
        }

        public Track GetTrackById(int id)
        {
            Track result = null;
            if (current.id == id)
            {
                result = current;
            }
            else
            {
                next?.GetTrackById(id);

            }
            return result;
        }

        // Метод для поиска трека по ключевым словам
        public List<Track> SearchTracks(string keyword)
        {
            List<Track> result = new List<Track>();

            if (current != null && (current.Name.Contains(keyword) || current.Description.Contains(keyword) || current.Author.Contains(keyword)))
            {
                result.Add(current);
            }

            if (next != null)
            {
                result.AddRange(next.SearchTracks(keyword));
            }

            return result;
        }

        public IEnumerator<Track> GetEnumerator()
        {
            return new MusicLibraryEnumerator(this);
        }

        private static MusicLibrary LoadFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<MusicLibrary>(json);
            }
            return null;
        }

        public void SaveToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(filePath, json);
        }
    }

    // Внутренний класс, который реализует IEnumerator
    public class MusicLibraryEnumerator : IEnumerator<Track>
    {
        private MusicLibrary current;
        private Track currentTrack;

        public MusicLibraryEnumerator(MusicLibrary library)
        {
            current = library;
        }

        public Track Current => currentTrack;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (current == null)
                return false;

            if (current.current != null)
            {
                currentTrack = current.current;
                current = current.next;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }



    public class Track
    {

        private static int nextID = 1;

        public int id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public bool IsAlbum { get; set; }

        public Track(string name, string description, string author, bool isalbum)
        {
            this.id = nextID++;
            this.Name = name;
            this.Author = author;
            this.Description = description;
            this.IsAlbum = isalbum;

        }
    }
}
