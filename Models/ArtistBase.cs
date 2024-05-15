using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP_coursework
{
    internal class ArtistBase
    {
        private static ArtistBase instance;

        public static ArtistBase Instance
        {
            get
            {
                if (instance == null)
                    instance = new ArtistBase();
                return instance;
            }
        }

        private ArtistBase() { }


        public Artist current;
        public ArtistBase next;
        public int length;

        private ArtistBase(Artist current)
        {
            this.current = current;
            this.next = null;
            this.length = 1;
        }

        private ArtistBase(Artist current, ArtistBase next)
        {
            this.current = current;
            this.next = next;
            this.length = 1;
        }

        public void AddArtist(Artist artist)
        {
            if (current == null)
            {
                current = artist;
                length = 1;
            }
            else if (next == null)
            {
                next = new ArtistBase(artist);
                length++;
            }
            else
            {
                next.AddArtist(artist);
                length++;
            }
        }

        public void RemoveArtist(int id)
        {
            if (current.Id == id)
            {
                current = next?.current;
                next = next?.next;
                if (current != null)
                    length--;
            }
            else
            {
                next?.RemoveArtist(id);
                if (next != null && next.current == null)
                    length--;
            }
        }

    }
}
