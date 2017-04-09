using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
   public class Audio : MediaItem, IAudioItem
    {
        public int Bitrate
        {
            get;
        }

        public double Duration
        {
            get;
        }

        public Audio(string author, int dateOfCreation, string genre, string name, int size, double duration,int bitrate) : base(author, dateOfCreation, genre, name, size)
        {
            Duration = duration;
            Bitrate = bitrate;
        }
    }
}
