using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Media_Library.Classes
{
    public abstract class MediaItem : IMediaItem
    {
        public string Author
        {
            get;
            protected set;
        }

        public DateTime DateOfCreation
        {
            get;
            protected set;
        }

        public string Genre
        {
            get;
            protected set;
        }

        public int Id
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public int Size
        {
            get;
            protected set;
        }
      
    }
}
