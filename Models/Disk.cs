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
        public List<int> Content { get; set; }

        public Disk(string disk)
        {
            DiskId = NextID++;
            DiskName = disk;
            Content = new List<int>(100);
        }

        public void AddToDisk(int track_id)
        {
            Content.Add(track_id);
        }

        public void RemoveFromDisk(int id)
        {
            Content.RemoveAll(x => x == id);
        }
    }


}
