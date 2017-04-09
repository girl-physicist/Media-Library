using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
   public  class PlayableItem :MediaItem, IPlayableItem
    {
        public TimeSpan Duration
        {
            get;
        }
       public PlayableItem(string author, DateTime dateOfCreation, string genre, string name, int size, TimeSpan duration) : base(author, dateOfCreation, genre, name, size)
        {
            Duration = duration;
        }
    }
}
