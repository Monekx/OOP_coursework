using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_coursework
{
    internal class Artist
    {

        private static int NextID = 1;

        public int Id { get; set; }
        public string Name { get; set; }

        public Artist(string Name) 
        {
            this.Name = Name;
            Id = NextID++;
        }



    }
}
