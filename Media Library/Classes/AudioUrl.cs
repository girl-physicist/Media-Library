using Media_Library.Classes;
using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    class AudioUrl : IAudioItem, IHaveURL
    {
        public string URL
        {
            get;
        }

        public int Bitrate
        {
            get;
            
        }

        public TimeSpan Duration
        {
            get;
            
        }

        public string Name
        {
            get;
            
        }

        public string Author
        {
            get;
           
        }

        public string Genre
        {
            get;
            
        }

        public int Size
        {
            get;
            
        }

        public DateTime DateOfCreation
        {
            get;
           
        }

        public AudioUrl(string author, DateTime dateOfCreation, string genre, string name, int size, 
            TimeSpan duration, int bitrate,string url) 
        {
            URL = url;
        }

        public Tuple<string, string, string, int, DateTime> OpenItem()
        {
            throw new NotImplementedException();
        }
    }
}
