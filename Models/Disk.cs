using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace OOP_coursework
{
    public class Disk
    {
        private static int NextID = 1;
        public int DiskId { get; private set; }
        public string DiskName { get; set; }
        public List<Track> Content { get; set; }

        public Disk(string disk)
        {
            DiskId = NextID++;
            DiskName = disk;
            Content = new List<Track>(1000);
        }

        public void AddToDisk(Track track)
        {
            Content.Add(track);
        }

        public void EditTrack(int id, Track replaceItem)
        {
            int index = Content.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                Content[index] = replaceItem;
            }
        }

        public void RemoveFromDisk(int id)
        {
            Content.RemoveAll(x => x.Id == id);
        }
    }


}
