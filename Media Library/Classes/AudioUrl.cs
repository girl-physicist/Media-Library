using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    class AudioUrl : Audio, IHaveURL
    {
        public string URL
        {
            get;
        }
        public AudioUrl(string author, int dateOfCreation, string genre, string name, int size, 
            double duration, int bitrate,string url) : base(author, dateOfCreation, genre, name, size, duration, bitrate)
        {
            URL = url;
        }

    }
}
