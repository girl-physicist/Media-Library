using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
  public  class Image : MediaItem, IImageItem
    {
        public string Resolution
        {
            get;
        }
        public Image(string author, int dateOfCreation, string genre, string name, int size, string resolution) : base(author, dateOfCreation, genre, name, size)
        {
            Resolution = resolution;
        }
    }
}
