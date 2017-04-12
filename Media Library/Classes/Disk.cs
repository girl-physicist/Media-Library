using Media_Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
   public class Disk:Group
    {
        public Disk(string name, DateTime dateOfCreation) : base(name, dateOfCreation)
        {
        }

        public new void Add(IMediaItem item)
        {
            if (item is Audio || item is Image)
            { mediaItems.Add(item);
                Console.WriteLine("item " + item.Name + " has been added.");
            }
            else
            {
                Console.WriteLine("item " + item.Name + " has not been added. Disk can only consist of Audio and Image");
               
                //throw new InvalidOperationException("Disk can only consist of Audio and Image");
                // обработка исключения
            }
        }
      
    }
}
 