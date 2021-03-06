﻿using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Media_Library.Classes
{
    public  class MediaItem : IMediaItem
    {
        public string Author
        {
            get;
        }

        public DateTime DateOfCreation
        {
            get;
        }
        public string Genre
        {
            get;
        }
        public string Name
        {
            get;
        }
        public int Size
        {
            get;
        }
        public  MediaItem(string author, DateTime dateOfCreation, string genre, string name, int size)
        {
            Author = author;
            DateOfCreation = dateOfCreation;
            Genre = genre;
            Name = name;
            Size = size;
        }

        public Tuple<string, string, string, int, DateTime> OpenItem()
        {
            return Tuple.Create(Name,Author, Genre, Size, DateOfCreation);
        }

      
    }
}
