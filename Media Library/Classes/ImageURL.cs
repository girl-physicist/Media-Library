using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    class ImageURL : Image, IHaveURL
    {
        public string URL
        {
            get;
        }
        public ImageURL(string author, int dateOfCreation, string genre, string name, int size, string resolution,string url) : base(author, dateOfCreation, genre, name, size, resolution)
        {
            URL = url;
        }
    }
}
