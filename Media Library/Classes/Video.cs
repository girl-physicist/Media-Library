using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
   public class Video : MediaItem, IVideoItem
    {
        public Quality Quality
        {
            get;
        }

        public double Duration
        {
            get;
        }

        public Video(string author, int dateOfCreation, string genre, string name, int size, double duration, Quality quality) : base(author, dateOfCreation, genre, name, size)
        {
            Quality = quality;
            Duration = duration;
        }
    }
}
