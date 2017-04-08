using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    class Image : MediaItem, IImageItem
    {
        public string resolution
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
