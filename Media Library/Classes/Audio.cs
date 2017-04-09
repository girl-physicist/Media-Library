using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
   public class Audio : PlayableItem, IAudioItem
    {
        public int Bitrate
        {
            get;
        }
        public Audio(string author, DateTime dateOfCreation, string genre, string name, int size, TimeSpan duration,int bitrate) : base(author, dateOfCreation, genre, name, size, duration)
        {
            Bitrate = bitrate;
        }
    }
}
