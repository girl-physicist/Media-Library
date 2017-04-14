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

        public TimeSpan Duration
        {
            get;
        }

        

        public Audio(string author, DateTime dateOfCreation, string genre, string name, int size, TimeSpan duration,int bitrate) : base(author, dateOfCreation, genre, name, size)
        {
            Duration = duration;
            Bitrate = bitrate;
        }
        public new Tuple<string, string, string, int, DateTime, TimeSpan, int> OpenItem()
        {
            return Tuple.Create(Name, Author, Genre, Size, DateOfCreation, Duration, Bitrate);
        }

    }
}
