using Media_Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
  public  class Serial : Group
    {
        public Serial(string name, DateTime dateOfCreation) : base(name, dateOfCreation)
        {
        }

        public new void Add(IMediaItem item)
        {
            // mediaItems.Add(item);
            if (item is Video || item is Image)
            { mediaItems.Add(item); }
            else
            { Console.WriteLine("Serial can only consist of Video and Image");
                //throw new InvalidOperationException("Serial can only consist of Video and Image"); }
        }

        
    }
}
