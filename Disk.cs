using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_coursework
{
    public class Disk
    {
        private static int NextId = 1;

        public int DiskId { get; set; }
        public string DiskName { get; set; }
        public Track current {  get; set; }
        public Disk next { get; set; }

        public Disk(string disc, Track curr) 
        {
            DiskId = 0;
            DiskName = disc;
            current = curr;
            next = null;
        }

        public void AddToDisk(Track track)
        {
            if (current == null)
            {
                current = track;
            } 
            else if (next == null)
            {
                next = new Disk(disc: this.DiskName, curr: track);
                return;
            } 
            else
            {
                next.AddToDisk(track);
            }
            
        }

        public IEnumerator<Track> GetEnumerator()
        {
            return new DiskEnumerator(this);
        }

        public void RemoveFromDisk(int id)
        {
            if (current.id == id)
            {
                current = next?.current;
                next = next?.next;

            }
            else
            {
                next?.RemoveFromDisk(id);

            }
        }

    }

    public class DiskEnumerator : IEnumerator<Track>
    {
        private Disk current;
        private Track currentTrack;

        public DiskEnumerator(Disk disk)
        {
            current = disk;
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

}
