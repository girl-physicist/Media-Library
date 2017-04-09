using Media_Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    class Disk:MediaItem //, IAudioItem,IImageItem
    {
        //public int Bitrate
        //{
        //    get;
        //}
        //public TimeSpan Duration
        //{
        //    get;
        //}
        //public string Resolution
        //{
        //    get;
        //}
        public ICollection<IMediaItem> Items
        {
            get;
            protected set;
        }
        public Disk(string author, int dateOfCreation, string genre, string name, int size, 
            ICollection<IMediaItem> items) : base(author, dateOfCreation, genre, name, size)
        {
            //Bitrate = bitrate;
            //Duration = duration;
            //Resolution = resolution;
            Items = items;
        }
    }
}
 