using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Library.Interfaces;

namespace Media_Library.Classes
{
    class VideoURL : Video, IHaveURL
    {
        public string URL
        {
            get;
        }
        public VideoURL(string author, DateTime dateOfCreation, string genre, string name, int size, TimeSpan duration, 
            Quality quality,string url) : base(author, dateOfCreation, genre, name, size, duration, quality)
        {
            URL = url;
        }

    }
}
