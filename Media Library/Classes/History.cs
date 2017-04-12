using Media_Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    public class History : Group
    {
        public History(string name, DateTime dateOfCreation) : base(name, dateOfCreation)
        {
        }

        public new void Add(IMediaItem item)
        {
            //  mediaItems.Add(item);
            if (item is Video || item is Image || item is VideoURL || item is ImageURL)
            { mediaItems.Add(item);
             Console.WriteLine("item "+item.Name+" has been added.");
            }
            else
            {
                Console.WriteLine("item " + item.Name + " has not been added. History can only consist of Video(VideoURL) and Image(ImageURL)");
              
                //throw new InvalidOperationException("History can only consist of Video(VideoURL) and Image(ImageURL)"); }
            }


        }
    }
}
